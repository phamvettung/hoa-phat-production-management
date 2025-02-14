using DBRepositories.Entities;
using DBServices;
using HoaPhatApp.Devices;
using HoaPhatApp.UserControls;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Abstractions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoaPhatApp
{
    public partial class HomeForm : Form
    {
        //************ CONTROL OBJECTS ***************//
        ControlObject modelControl;
        ControlObject timeControl;
        ControlObject barcodeControl;
        ControlObject loadControl;

        ProgressBarEx progressBar;

        //************ INSTANCES ***************//
        ProductionOrderService productionOrderService = ProductionOrderService.GetInstance();
        ServiceExtension serviceExtension = ServiceExtension.GetInstance();
        ModelService modelService = ModelService.GetInstance();
        ModelDataService modelDataService = ModelDataService.GetInstance();
        OperatorService operatorService = OperatorService.GetInstance();
        ErrorDataService errorDataService = ErrorDataService.GetInstance();
        HandleDataReceived handleDataReceived = HandleDataReceived.GetInstance();
        DataReaderService dataReaderService = DataReaderService.GetInstance();

        //************ FIELDS ***************//
        public static string CurrentModelCode { get; set; } = string.Empty;
        private int totalExpectedOutput = 0;
        int LineType = Properties.Settings.Default.LineType;

        //************ PLC ***************//
        public static PLC plc;
        private int iNumberOfData = Properties.Settings.Default.NumOfOpeartor;
        public List<OperatorControl> operatorControls;
        //timer
        System.Windows.Forms.Timer tmrDisplayData;
        System.Windows.Forms.Timer tmrDisplayErr;
        //the arrays to read data
        private int iNumOfData = Properties.Settings.Default.NumOfOpeartor;
        private int[] FinishData;
        private int[] ExceedingData;
        private int[] ImmediateData;
        private int[] ErrBitData;
        private int totalOutput;
        private int totalCurrrentModel;
        private int productOnConveyor;
        private int completeReading;
        //Enums
        /// <summary>
        /// Để biết xem luồng đã hoàn thành đọc dữ liệu hay chưa (hoặc PLC đã được kết nối với PC chưa). sau đó mới bắt đầu xử lý dữ liệu đọc
        /// </summary>
        public EnumPlcThread PlcReadDataFinish { get; private set; }


        //************ TOTAL PRODUCTION TIME ***************//
        private DateTime startProductionTime;
        private DateTime endProductionTime;
        System.Windows.Forms.Timer tmrDisplayProductionTime;

        //************ CAMERA ***************//
        private int ActualOutputCount = 0;

        //************ ESCALE ***************//
        public EScale eScale;


        public HomeForm()
        {
            InitializeComponent();
            InitializeControlObject();
            RegisterEvents();
            RegisterTimers();
            DisplayDataGridView(dgvProductionOrder, Color.FromArgb(1, 179, 191)); //Color.FromArgb(1, 208, 166)

            // ==========   PLC
            plc = new PLC();
            operatorControls = new List<OperatorControl>();
            //the variables to read data
            FinishData = new int[iNumOfData];
            ExceedingData = new int[iNumOfData];
            ImmediateData = new int[iNumOfData];
            ErrBitData = new int[iNumOfData];
            //Enums
            PlcReadDataFinish = EnumPlcThread.DISNABLE;

            //Escale
            if (LineType == 1)
            {
                eScale = new EScale();
            }
        }



        #region >> Forms
        private void RegisterTimers()
        {
            tmrDisplayData = new System.Windows.Forms.Timer();
            tmrDisplayData.Tick += TmrDisplayData_Tick;
            tmrDisplayData.Interval = 800;
            tmrDisplayData.Stop();

            tmrDisplayErr = new System.Windows.Forms.Timer();
            tmrDisplayErr.Tick += TmrDisplayErr_Tick;
            tmrDisplayErr.Interval = 100;
            tmrDisplayErr.Stop();

            tmrDisplayProductionTime = new System.Windows.Forms.Timer();
            tmrDisplayProductionTime.Tick += TmrDisplayProductionTime_Tick;
            tmrDisplayProductionTime.Interval = 1000;
            tmrDisplayProductionTime.Stop();
        }

        private void RegisterEvents()
        {
            //FORMS
            Load += HomeForm_Load;
            FormClosing += HomeForm_FormClosing;
            FormClosed += HomeForm_FormClosed;
            btnNextModel.Click += BtnNextModel_Click;
            btnCreateNewOrder.Click += BtnCreateNewOrder_Click;

            //Handle Data received from Devices
            PLC.OnDisplayData += PLC_OnDisplayData;

            if (LineType == 1)
            {
                MainForm.OnDisplayResultCamera += MainForm_OnDisplayResultCamera;
                EScale.OnDisplayResultEscale += EScale_OnDisplayResultEscale;
                HandleDataReceived.OnDisplayCounterAndResult += HandleDataReceied_OnDisplayCounterAndResult;
                HandleDataReceived.OnDisplayResult += HandleDataReceived_OnDisplayResult;
            }
            SettingForm.OnUpdateProductionTime += SettingForm_OnUpdateProductionTime;

        }

        private void HomeForm_FormClosed(object? sender, FormClosedEventArgs e)
        {

        }

        private void HomeForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            UpdateProductionOrder("Đang thực hiện");
            //PLC
            plc.Stop(); // stop thread
            plc.Close(); // close connection

            if (LineType == 1)
            {
                //Stop xử lý dữ liệu trả về từ Camera và Cân
                handleDataReceived.Stop();
                //Escale
                eScale.Close();
            }
        }

        private void HomeForm_Load(object? sender, EventArgs e)
        {
            try
            {
                Thread thLoading = new Thread(() =>
                {
                    using (LoadingForm connForm = new LoadingForm(plc.Open, "Đang kết nối đến PLC."))
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            connForm.ShowDialog(this);
                        });
                    }

                    using (LoadingForm connForm = new LoadingForm(LoadProductionOrder, "Đang tải dữ liệu."))
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            connForm.ShowDialog(this);
                        });
                    }
                });
                thLoading.IsBackground = true;
                thLoading.Start();

                if (this.LineType == 1)
                {
                    eScale.Open();
                }

                //Total production time
                startProductionTime = Properties.Settings.Default.StartProductionTime;
                endProductionTime = Properties.Settings.Default.EndProductionTime;
                timeControl.LbForeignVal2.Text = endProductionTime.ToString("HH:mm:ss");

                //Load count model
                if (LineType == 1) // get the OK quantity from the database 
                {
                    txtActualOutput.Text = serviceExtension.CountDataReader(DateTime.Now, DateTime.Now, "Đạt").ToString();
                    txtCurrentModelOutput.Text = serviceExtension.CountDataReaderByModel(DateTime.Now, DateTime.Now, "Đạt", CurrentModelCode).ToString();
                }
                else if (LineType == 2) // get the quantity from the app config, regardless OK or NG 
                {
                    txtActualOutput.Text = Properties.Settings.Default.CountTotal.ToString();
                    txtCurrentModelOutput.Text = Properties.Settings.Default.CountByModel.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Start all timer
                tmrDisplayData.Start();
                //tmrDisplayErr.Start();
                tmrDisplayProductionTime.Start();
            }
        }

        private void BtnCreateNewOrder_Click(object? sender, EventArgs e)
        {
            CreateNewOrder();
        }

        private void CreateNewOrder()
        {
            //Save the current ProductionOrder to the ModelData then delete ProductionOrder in the database
            List<ProductionOrder> lst = productionOrderService.GetAll();
            foreach (ProductionOrder item in lst)
            {
                ModelDatum modelData = new ModelDatum();
                modelData.ModelCode = item.ModelCode;
                modelData.Date = item.Date;
                modelData.ExpectedOutput = item.ExpectedOutput;
                modelData.ActualOutput = item.ActualOutput;
                //Save to ModelData
                modelDataService.Create(modelData);
                //Delete id from ProductionOrder
                productionOrderService.Delete(item.Id);
            }

            ProductionOrderForm productionOrder = new ProductionOrderForm();
            productionOrder.ShowDialog();

            Thread thLoading = new Thread(() =>
            {
                using (LoadingForm connForm = new LoadingForm(LoadProductionOrder, "Đang tải dữ liệu."))
                {
                    Invoke((MethodInvoker)delegate
                    {
                        connForm.ShowDialog(this);
                    });
                }
            });
            thLoading.IsBackground = true;
            thLoading.Start();
        }

        /// <summary>
        /// Create the new operator control by the current model code
        /// </summary>
        /// <param name="currentModelCode">the current model code</param>
        private void InitializeOperatorControl(string currentModelCode, int readyOption = 1, bool[] arrLockBit = null)
        {
            List<Operator> lst = OperatorService.GetInstance().GetByModelCode(currentModelCode);

            switch (readyOption)
            {
                case 0:
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (arrLockBit[i] == true)
                        {
                            lst[i].IsIgnore = true;
                        }
                        else
                        {
                            lst[i].IsIgnore = false;
                        }

                    }
                    break;
                case 1:
                    break;
                default:
                    break;
            }

            flowLayoutPanel2.Controls.Clear();
            operatorControls.Clear();
            foreach (Operator op in lst)
            {
                OperatorControl opControl = new OperatorControl();
                opControl.Operator = op;
                flowLayoutPanel2.Controls.Add(opControl);

                operatorControls.Add(opControl);
            }
        }

        private void InitializeControlObject()
        {

            modelControl = new ControlObject();
            modelControl.Pic.Image = Properties.Resources.product_30;
            modelControl.Pic.BackColor = Color.Orange;
            modelControl.LbTittle.Text = "HOÀN THÀNH (%)";
            modelControl.LbMainVal.Text = "-1";
            modelControl.LbMainVal.Visible = true;
            modelControl.LbMainVal.AutoSize = true;
            modelControl.LbMainVal.Dock = DockStyle.None;
            modelControl.LbMainVal.Location = new Point(170, 5);
            modelControl.LbMainVal.Font = new Font("Segeo UI", 65F, FontStyle.Regular, GraphicsUnit.Point);
            modelControl.LbMainVal.Size = new Size(100, 65);
            modelControl.LbForeignVal1.Text = "Model tiếp theo:";
            modelControl.LbForeignVal1.BringToFront();
            modelControl.LbForeignVal1.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            modelControl.LbForeignVal2.Text = "";
            modelControl.LbForeignVal2.BringToFront();
            modelControl.panMainVal.Location = new Point(5, 23);
            modelControl.LbForeignVal2.Location = new Point(170, 110);

            progressBar = new ProgressBarEx();
            progressBar.Width = 200;
            progressBar.Height = 35;
            progressBar.Location = new Point(5, 50);
            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.BackColor = SystemColors.ControlLight;
            progressBar.ForeColor = Color.SlateBlue;
            progressBar.Maximum = 100;
            progressBar.Minimum = 0;
            progressBar.Value = 95;
            progressBar.Visible = true;
            modelControl.panMainVal.Controls.Add(progressBar);


            flowLayoutPanel1.Controls.Add(modelControl);

            timeControl = new ControlObject();
            timeControl.Pic.Image = Properties.Resources.time_30;
            timeControl.Pic.BackColor = Color.MediumSlateBlue;
            timeControl.LbTittle.Text = "THỜI GIAN SẢN XUẤT";
            timeControl.LbMainVal.Text = "00:00:00";
            timeControl.LbMainVal.Font = new Font("Arial", 45F, FontStyle.Regular, GraphicsUnit.Point);
            timeControl.LbForeignVal1.Text = "Dự kiến hoàn thành:";
            timeControl.LbForeignVal1.BringToFront();
            timeControl.LbForeignVal1.Font = new Font("Arial", 15F, FontStyle.Regular, GraphicsUnit.Point);
            timeControl.LbForeignVal2.Text = "00:00:00";
            timeControl.LbForeignVal2.Location = new Point(200, 110);
            timeControl.LbForeignVal2.BringToFront();
            flowLayoutPanel1.Controls.Add(timeControl);

            if (LineType == 1)
            {
                barcodeControl = new ControlObject();
                barcodeControl.Pic.Image = Properties.Resources.barcode_30;
                barcodeControl.Pic.BackColor = Color.Green;
                barcodeControl.LbTittle.Text = "SERIAL";
                barcodeControl.LbMainVal.Text = "";
                barcodeControl.LbMainVal.Visible = true;
                barcodeControl.LbForeignVal1.Text = "Kết quả:";
                barcodeControl.LbForeignVal1.BringToFront();
                barcodeControl.LbForeignVal2.Text = "";
                barcodeControl.LbForeignVal2.BringToFront();
                barcodeControl.LbForeignVal2.Location = new Point(100, 115);
                flowLayoutPanel1.Controls.Add(barcodeControl);

                loadControl = new ControlObject();
                loadControl.Pic.Image = Properties.Resources.weight_30;
                loadControl.Pic.BackColor = Color.Red;
                loadControl.LbTittle.Text = "KHỐI LƯỢNG (kg)";
                loadControl.LbMainVal.Text = "0.0";
                loadControl.LbMainVal.Font = new Font("Arial", 45F, FontStyle.Regular, GraphicsUnit.Point);
                loadControl.LbForeignVal1.Text = "Kết quả:";
                loadControl.LbForeignVal1.BringToFront();
                loadControl.LbForeignVal2.Text = "";
                loadControl.LbForeignVal2.BringToFront();
                loadControl.LbForeignVal2.Location = new Point(100, 115);
                flowLayoutPanel1.Controls.Add(loadControl);
            }
        }

        private void DisplayDataGridView(DataGridView dgv, Color color)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.BorderStyle = BorderStyle.Fixed3D;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = color;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 16, FontStyle.Regular);
        }

        #endregion

        #region >> Processing Next model

        public DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
                TypeDescriptor.GetProperties(typeof(T));

            DataTable table = new DataTable();

            table.Columns.Add("stt", typeof(int));
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);

            int i = 1;
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row["stt"] = i.ToString();
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                table.Rows.Add(row);
                i++;
            }
            return table;
        }


        /// <summary>
        /// Load ProductionOrder table to dgvProductionOrder
        /// </summary>
        private void LoadProductionOrder()
        {
            try
            {
                List<ProductionOrder> lst = productionOrderService.GetAll();
                DataTable table = ConvertToDataTable(lst);
                if (lst.Count > 0)
                {
                    dgvProductionOrder.Invoke((MethodInvoker)delegate
                    {
                        dgvProductionOrder.DataSource = table;
                    });

                    totalExpectedOutput = serviceExtension.GetTotalExpectedOutput();
                    txtExpectOutput.Invoke((MethodInvoker)delegate
                    {
                        txtExpectOutput.Text = totalExpectedOutput.ToString();
                    });
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Next model then loaded ProductionOrder
                Invoke((MethodInvoker)delegate
                {
                    NextModel();
                });
            }
        }

        //The current model index
        int currentModelIndex = 0;
        private void BtnNextModel_Click(object? sender, EventArgs e)
        {
            UpdateProductionOrder("Hoàn thành");

            using (LoadingForm connForm = new LoadingForm(LoadProductionOrder, "Đang tải dữ liệu."))
            {
                Invoke((MethodInvoker)delegate
                {
                    connForm.ShowDialog(this);
                });
            }
        }

        /// <summary>
        /// Hàm dùng để update số lượng thực tế vào bảng Kế hoạch sản xuất trước khi chuyển sang model khác hoặc đóng chương trình.
        /// </summary>
        /// <param name="status">trạng thái của model khi update. "Hoàn thành" khi nhấn chuyển model. "Đang thực hiện" người dùng đóng chương trình do quên hoặc vẫn muốn tiếp tục lệnh sản xuất cũ</param>
        private void UpdateProductionOrder(string status)
        {
            if (dgvProductionOrder.Rows.Count < 1) return; // nếu bảng kế hoạch trống thì return
            try
            {
                //update on ProductionOrder table in Database
                ProductionOrder productOrder = new ProductionOrder();
                productOrder.Id = int.Parse(dgvProductionOrder.Rows[currentModelIndex].Cells["idOrder"].Value.ToString());
                productOrder.Date = (DateTime)dgvProductionOrder.Rows[currentModelIndex].Cells["dateOrder"].Value;
                productOrder.ModelCode = dgvProductionOrder.Rows[currentModelIndex].Cells["modelCodeOrder"].Value.ToString();
                productOrder.ExpectedOutput = short.Parse(dgvProductionOrder.Rows[currentModelIndex].Cells["expectedOutputOrder"].Value.ToString());
                productOrder.ActualOutput = short.Parse(txtCurrentModelOutput.Text);
                productOrder.Status = status;
                productionOrderService.Update(productOrder);
                if (status == "Đang thực hiện") //Thông báo chỉ xuất hiện khi status là "Đang thực hiện"
                {
                    string message = string.Format("Đã lưu lại Sản lượng của model hiện tại:\n-Model: {0}\n-Sản lượng thực tế: {1}\n-Trạng thái: {2}", productOrder.ModelCode, productOrder.ActualOutput, status);
                    MessageBox.Show(message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                if (iNumberOfData == 2)//Chuyền phụ
                {
                    if (plc.ResetCurrentModel() == false)
                    {
                        MessageBox.Show("Không thể kết nối tới PLC.");
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void NextModel()
        {
            //Stop the thread read data from PLC
            //Khi chuyển model sẽ khởi tạo lại các operator control. Vì vậy nên dừng luồng đọc dữ liệu từ PLC.
            plc.Stop();

            int modelIndex = -1;

            try
            {
                //Change color according to modelIndex
                for (int i = 0; i < dgvProductionOrder.Rows.Count; i++)
                {
                    DataGridViewRow row = dgvProductionOrder.Rows[i];
                    //Quét dòng trong datagridview nếu đang ở trạng thái chờ thì lấy được modelIndex dòng đó
                    if (row.Cells["statusOrder"].Value.ToString() == "Chờ" || row.Cells["statusOrder"].Value.ToString() == "Đang thực hiện")
                    {
                        modelIndex = row.Index;
                        //Đổi màu đối tượng DataGridViewRow lấy từ DataGridview nên DataGridview bản chất là không bị đổi màu
                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 128);
                        row.Cells["statusOrder"].Value = "Đang thực hiện";
                        //Khi lấy được modelIndex đầu tiên thì break
                        break;
                    }
                }
                //That mean there are no model waiting
                if (modelIndex == -1)
                {
                    CurrentModelCode = string.Empty;//current model
                    lbCurrentModel.Text = "...";
                    DialogResult dr1 = MessageBox.Show("Lệnh sản xuất đã hoàn thành. Bạn muốn tạo Lệnh sản xuất mới. Chọn YES để đồng ý.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (dr1 == DialogResult.Yes)
                    {
                        CreateNewOrder();
                    }
                    return;
                }

                /* ===> Có được modelIndex => lấy đc currentModelCode => lấy thời gian và trạng thái bỏ qua => ghi xuống plc => hiển thị lên modelControl */
                //Show the current model on modelControl
                CurrentModelCode = dgvProductionOrder.Rows[modelIndex].Cells["modelCodeOrder"].Value.ToString();//current model
                lbCurrentModel.Text = CurrentModelCode;
                currentModelIndex = modelIndex;

                //Get time and ignore setting from database
                List<Operator> lst = operatorService.GetByModelCode(CurrentModelCode);

                //Kiểm tra người dùng đã cài đặt thời gian hay chưa
                int countExcTimeZero = 0;
                foreach (Operator op in lst)
                {
                    if (op.ExcutionTime <= TimeSpan.FromSeconds(30))
                    {
                        countExcTimeZero++;
                    }
                }
                if (countExcTimeZero == iNumOfData)
                {
                    MessageBox.Show("Bạn chưa đặt thời gian cho các công đoạn hoặc thời gian cài đặt nhỏ hơn 30s. Vui lòng tới phần Thiết lập để cài đặt, sau đó quay lại màn hình chính và Tạo Lệnh sản xuất mới.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    int id = int.Parse(dgvProductionOrder.Rows[modelIndex].Cells["idOrder"].Value.ToString());
                    productionOrderService.Delete(id); //delete production id current.
                    return;
                }
                else if (countExcTimeZero > 0 && countExcTimeZero < iNumOfData)
                {
                    DialogResult dr3 = MessageBox.Show("Có " + countExcTimeZero + " công đoạn chưa đặt thời gian. Bạn vẫn muốn tiếp tục sản xuất?", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (dr3 == DialogResult.No)
                    {
                        int id = int.Parse(dgvProductionOrder.Rows[modelIndex].Cells["idOrder"].Value.ToString());
                        productionOrderService.Delete(id);
                        return;
                    }
                }


                string message = "Bạn có muốn cài đặt thời gian và bỏ qua của các công đoạn từ phần mềm?\n- Chọn YES để đồng ý.\n- Chọn NO để cài đặt trên HMI.";
                DialogResult dr2 = MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dr2 == DialogResult.Yes)
                {
                    //Write down to PLC
                    plc.WriteTimeAndIgnore(lst);

                    InitializeOperatorControl(lbCurrentModel.Text.ToUpper().Trim());
                }
                else if (dr2 == DialogResult.No)
                {
                    //Write down to PLC
                    plc.WriteTimeAndIgnore(lst, 0);

                    bool[] arrLockStationData = new bool[iNumberOfData];
                    //plc.ReadLockStation(ref arrLockStationData);
                    InitializeOperatorControl(lbCurrentModel.Text.ToUpper().Trim(), 0, arrLockStationData);
                }


                // Show the next model on modelControl
                if (dgvProductionOrder.Rows.Count > modelIndex + 1)
                {
                    modelControl.LbForeignVal2.Text = dgvProductionOrder.Rows[modelIndex + 1].Cells["modelCodeOrder"].Value.ToString(); // next model
                }
                else
                {
                    modelControl.LbForeignVal2.Text = "Trống";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Start again the thread read data from PLC
                plc.Start();
            }

        }
        #endregion

        #region >> Processing Data Received From
        /// <summary>
        /// Sự kiện nhận dữ liệu từ PLC
        /// </summary>
        /// <param name="finish"></param>
        /// <param name="exceeding"></param>
        /// <param name="immediate"></param>
        /// <param name="errBitData"></param>
        private void PLC_OnDisplayData(int[] finish, int[] exceeding, int[] immediate, int[] errBitData, int totalOutput, int totalCurrrentModel, int productOnConveyor, int completeReading)
        {
            this.FinishData = finish;
            this.ExceedingData = exceeding;
            this.ImmediateData = immediate; // giá trị thời gian tức thời
            this.ErrBitData = errBitData;
            this.totalOutput = totalOutput;
            this.totalCurrrentModel = totalCurrrentModel;
            this.productOnConveyor = productOnConveyor;
            this.completeReading = completeReading;
            if (PlcReadDataFinish != EnumPlcThread.ENABLE)
                PlcReadDataFinish = EnumPlcThread.ENABLE; //Hoàn thành việc đọc dữ liệu, kiểm tra tín hiệu Enable 1 lần duy nhất, để biết là PLC đã được kết nối.
                                                          //Nếu chưa kết nối thì đoạn chương trình trong TmrDisplayData_Tick báo lỗi
        }

        int flagProductOnConveyor = 0; double complet_rate = 0; int actual_output_temp = 0, expected_output_temp = 1;// biến tạm để parce txt to in để tính tỷ lệ hoàn thành cho 2 loại chuyền
        private void TmrDisplayData_Tick(object? sender, EventArgs e)
        {
            if (PlcReadDataFinish == EnumPlcThread.ENABLE)
            {
                if (LineType == 1)
                {
                    if (productOnConveyor == 1 && flagProductOnConveyor == 0)
                    {

                        //Bắt đầu xử lý luồng dữ liệu từ Camera và Cân
                        handleDataReceived.Start();

                        int countTimeout = 0;
                        while (countTimeout < 70)
                        {
                            countTimeout++;
                            Thread.Sleep(10);
                        }
                        plc.WriteReadyTrigger();
                        eScale.SendData();

                        flagProductOnConveyor = 1;
                    }
                    else if (productOnConveyor == 0)
                    {
                        flagProductOnConveyor = 0;
                    }
                }
                else if (LineType == 2)
                {
                    //reading output
                    txtActualOutput.Text = this.totalOutput.ToString();
                    txtCurrentModelOutput.Text = this.totalCurrrentModel.ToString();
                }

                //tính tỷ lệ hoàn thành dựa vào textbox
                int.TryParse(txtActualOutput.Text, out actual_output_temp);
                int.TryParse(txtExpectOutput.Text, out expected_output_temp);
                complet_rate = (actual_output_temp * 100) / expected_output_temp;
                modelControl.LbMainVal.Text = complet_rate.ToString();
                progressBar.Value = (int)complet_rate;

                //Show state of all operator
                if (operatorControls.Count < iNumOfData) return;
                Invoke((MethodInvoker)delegate
                {
                    try
                    {
                        for (int i = 0; i < this.operatorControls.Count; i++)
                        {
                            if (operatorControls[i].Operator.IsIgnore) continue;

                            if (this.FinishData[i] == 1)
                                operatorControls[i].Finish = true;
                            else
                                operatorControls[i].Finish = false;

                            if (this.ExceedingData[i] == 1)
                                operatorControls[i].Exceeding = true;
                            else
                                operatorControls[i].Exceeding = false;

                            operatorControls[i].ImmediateTime = ImmediateData[i];
                        }

                    }
                    catch (System.IndexOutOfRangeException ex)
                    {
                        tmrDisplayData.Stop();
                        MessageBox.Show(ex.Message);
                    }
                });
            }

        }

        private void TmrDisplayErr_Tick(object? sender, EventArgs e)
        {
            //if (PlcReadDataFinish == EnumPlcThread.ENABLE)
            //{
            //    for (int i = 0; i < this.ErrBitData.Length; i++)
            //    {
            //        int indexErr = int.Parse(Properties.Settings.Default.ErrEventNewsletter[i]);
            //        if (ErrBitData[i] == 1 && indexErr == 0)
            //        {
            //            Properties.Settings.Default.ErrEventNewsletter[i] = "1";
            //            Properties.Settings.Default.Save();

            //            ErrorDatum errData = new ErrorDatum();
            //            errData.BitError = string.Format("M9{0:00}", i);
            //            errData.Ngay = DateTime.Now;
            //            errorDataService.Create(errData);
            //        }
            //        if (ErrBitData[i] == 1 && indexErr == 1)
            //        {
            //            //nope
            //        }
            //        if (ErrBitData[i] == 0 && indexErr == 1)
            //        {
            //            Properties.Settings.Default.ErrEventNewsletter[i] = "0";
            //            Properties.Settings.Default.Save();
            //        }
            //        if (ErrBitData[i] == 0 && indexErr == 0)
            //        {
            //            //nope
            //        }
            //    }
            //}
        }

        #endregion

        #region >> Display total production time

        private void TmrDisplayProductionTime_Tick(object? sender, EventArgs e)
        {
            DisplayTotalProductionTime();
        }
        private void SettingForm_OnUpdateProductionTime()
        {
            this.startProductionTime = Properties.Settings.Default.StartProductionTime;
            this.endProductionTime = Properties.Settings.Default.EndProductionTime;
            timeControl.Invoke(new Action(() =>
            {
                timeControl.LbForeignVal2.Text = this.endProductionTime.ToString();
            }));
        }

        private void DisplayTotalProductionTime()
        {
            if (DateTime.Now < startProductionTime)
            {
                timeControl.LbMainVal.Text = "00:00:00";
                timeControl.BackColor = Color.Yellow;
                return;
            }
            if (DateTime.Now > endProductionTime)
            {
                timeControl.LbMainVal.Text = "00:00:00";
                timeControl.BackColor = Color.Orange;
                return;
            }

            TimeSpan totalTimeSpan = DateTime.Now - startProductionTime;
            DateTime totalTime = DateTime.Parse(totalTimeSpan.ToString());
            timeControl.LbMainVal.Text = totalTime.ToString("HH:mm:ss");
            timeControl.BackColor = Color.LightGreen;
        }

        #endregion

        #region >> TCP
        private void MainForm_OnDisplayResultCamera(string result)
        {
            barcodeControl.Invoke(new Action(() =>
            {
                barcodeControl.BackColor = Color.White;
                //barcodeControl.GradientTopColor = Color.White;
                //barcodeControl.GradientBottomColor = Color.White;
                barcodeControl.LbForeignVal2.Text = "Trống";
                //Thread.Sleep(100);

                barcodeControl.LbMainVal.Text = result;
                if (result == "NoRead")
                {
                    barcodeControl.BackColor = Color.Orange;
                    //barcodeControl.GradientTopColor = Color.Orange;
                    //barcodeControl.GradientBottomColor = Color.Orange;
                    barcodeControl.LbForeignVal2.Text = "NG";
                }
                else
                {
                    barcodeControl.BackColor = Color.LightGreen;
                    //barcodeControl.GradientTopColor = Color.LightGreen;
                    //barcodeControl.GradientBottomColor = Color.LightGreen;
                    barcodeControl.LbForeignVal2.Text = "OK";
                }
            }));

        }
        #endregion

        #region >> ESCALE
        private void EScale_OnDisplayResultEscale(string result)
        {
            try
            {
                loadControl.Invoke(new Action(() =>
                {
                    loadControl.LbForeignVal2.Text = "Trống";
                    loadControl.BackColor = Color.White;
                    //loadControl.GradientTopColor = Color.White;
                    //loadControl.GradientBottomColor = Color.White;
                }));
                //Thread.Sleep(100);

                float grossWeight = float.Parse(result);
                int res = modelService.GetResultEscale(CurrentModelCode, grossWeight);
                if (res == 0)
                {
                    loadControl.Invoke(new Action(() =>
                    {
                        loadControl.LbForeignVal2.Text = "OK";
                        loadControl.BackColor = Color.LightGreen;
                        //loadControl.GradientTopColor = Color.LightGreen;
                        //loadControl.GradientBottomColor = Color.LightGreen;
                    }));
                }
                else if (res == 1)
                {
                    loadControl.Invoke(new Action(() =>
                    {
                        loadControl.LbForeignVal2.Text = "NG";
                        loadControl.BackColor = Color.Orange;
                        //loadControl.GradientTopColor = Color.Orange;
                        //loadControl.GradientBottomColor = Color.Orange;
                    }));
                }
                else if (res == -1)
                {
                    MessageBox.Show("Không xác định được Model hiện tại trong khi cân trả về giá trị. Kế hoạch sản xuất đã hoàn thành, hãy tạo Kế hoạch sản xuất mới.");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            loadControl.Invoke(new Action(() =>
            {
                loadControl.LbMainVal.Text = result;
            }));
        }
        #endregion

        #region >> Processing Display Counter And Result

        Color currentColor = Color.Gray;
        private void HandleDataReceied_OnDisplayCounterAndResult(DataReader dataSaved, EnumProcessingData result)
        {

            handleDataReceived.Stop();
            try
            {
                Invoke((MethodInvoker)delegate
                {
                    txtActualOutput.Text = serviceExtension.CountDataReader(DateTime.Now, DateTime.Now, "Đạt").ToString();
                    txtCurrentModelOutput.Text = serviceExtension.CountDataReaderByModel(DateTime.Now, DateTime.Now, "Đạt", CurrentModelCode).ToString();

                    if (result == EnumProcessingData.OK)
                    {
                        plc.WriteResult(1, 0);

                        if (currentColor != Color.Blue && currentColor != Color.Green) currentColor = Color.Blue;
                        if (currentColor == Color.Blue)
                            currentColor = Color.Green;
                        else if (currentColor == Color.Green)
                            currentColor = Color.Blue;
                    }
                    else if (result == EnumProcessingData.NG)
                    {
                        plc.WriteResult(99, 0);
                        currentColor = Color.Red;
                    }
                    dataSaved.UserName = MainForm.accoutLogin.UserName;
                    dataSaved.OperatorName = MainForm.operatorName;
                    dataReaderService.Create(dataSaved);
                    lbMessageToSave.ForeColor = currentColor;
                    lbMessageToSave.Text = string.Format("Thời gian: {0}--- Model: {1}--- Barcode: {2}--- Khối lượng: {3} (kg)--- Kết quả: {4}.", dataSaved.Date, dataSaved.ModelCode, dataSaved.Barcode, dataSaved.GrossWeight, result.ToString());
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }
        }

        private void HandleDataReceived_OnDisplayResult(int option, EnumProcessingData result)
        {
            Invoke((MethodInvoker)delegate
            {
                if (result == EnumProcessingData.OK)
                {
                    plc.WriteResult(1, option);
                }
                else
                {
                    plc.WriteResult(99, option);
                }
            });
        }

        #endregion

    }
}
