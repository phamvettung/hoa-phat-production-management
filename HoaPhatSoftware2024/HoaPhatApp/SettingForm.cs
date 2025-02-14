using DBRepositories.Entities;
using DBServices;
using HoaPhatApp.Classes;
using HoaPhatApp.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static HoaPhatApp.SettingForm;

namespace HoaPhatApp
{
    public partial class SettingForm : Form
    {
        public SettingForm()
        {
            InitializeComponent();
            RegisterEvents();
            DisplayDataGridView(dgvModel, SystemColors.ControlLight);
            DisplayDataGridView(dgvOperator, SystemColors.ControlLight);
        }

        #region EVENTS
        private void RegisterEvents()
        {
            Load += SettingForm_Load;

            dgvModel.CellClick += DgvModel_CellClick;
            dgvModel.CellDoubleClick += DgvModel_CellDoubleClick;
            dgvOperator.CellDoubleClick += DgvOperator_CellDoubleClick;
            dgvOperator.CellEndEdit += DgvOperator_CellEndEdit;

            btnWriteTimeToPLC.Click += BtnWriteTimeToPLC_Click;
            btnExportOpera.Click += BtnExportOpera_Click;
            btnExportModel.Click += BtnExportModel_Click;
            btnOpen.Click += BtnOpen_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnOk.Click += BtnOk_Click;
            btnActiveCamera.Click += BtnActiveCamera_Click;
            AuthenForm.ActiveCamera += AuthenForm_ActiveCamera;

            cboBCR.SelectedValueChanged += CboBCR_SelectedValueChanged;
        }

        private void CboBCR_SelectedValueChanged(object? sender, EventArgs e)
        {
            if(cboBCR.SelectedItem.ToString() == "HIK")
            {
                HomeForm.plc.WriteCodeReader(0);
            }
            else if(cboBCR.SelectedItem.ToString() == "OTP")
            {
                HomeForm.plc.WriteCodeReader(1);
            }
        }

        private void AuthenForm_ActiveCamera(EnumProcessingData status)
        {
            if(status == EnumProcessingData.ACTIVE)
            {
                btnActiveCamera.BackColor = Color.Lime;
                btnActiveCamera.ForeColor = Color.Red;
                btnActiveCamera.Text = "Tắt Camera";
            }
            else
            {
                btnActiveCamera.BackColor = Color.LightGray;
                btnActiveCamera.ForeColor = Color.Red;
                btnActiveCamera.Text = "Bật Camera";
            }
        }

        private void BtnActiveCamera_Click(object? sender, EventArgs e)
        {
            AuthenForm authenForm = new AuthenForm();
            if(btnActiveCamera.BackColor == Color.Lime)
                authenForm.CameraStatus = EnumProcessingData.INACTIVE;
            else if (btnActiveCamera.BackColor == Color.LightGray)
                authenForm.CameraStatus = EnumProcessingData.ACTIVE;
            authenForm.ShowDialog();
        }

        private void BtnOk_Click(object? sender, EventArgs e)
        {
            string startTime = dateStart.Value.ToString("HH:mm:ss");
            string endTime = dateEnd.Value.ToString("HH:mm:ss");
            Properties.Settings.Default.StartProductionTime = DateTime.Parse(startTime);
            Properties.Settings.Default.EndProductionTime = DateTime.Parse(endTime);
            Properties.Settings.Default.Save();
            OnUpdateProductionTime();
            MessageBox.Show("Đã lưu cài đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            string modelCode = string.Empty;
            try
            {
                for (int i = 0; i < dgvOperator.Rows.Count; i++)
                {
                    Operator opera = new Operator();
                    opera.ModelCode = dgvOperator.Rows[i].Cells["modelCodeOpera"].Value.ToString();
                    if(modelCode == string.Empty)
                        modelCode = opera.ModelCode;
                    opera.NumOperator = (byte)dgvOperator.Rows[i].Cells["numOperatorOpera"].Value;
                    opera.OperatorName = dgvOperator.Rows[i].Cells["operatorNameOpera"].Value.ToString();
                    opera.ExcutionTime = (TimeSpan)dgvOperator.Rows[i].Cells["excutionTime"].Value;
                    opera.IsIgnore = (bool)dgvOperator.Rows[i].Cells["isIgnore"].Value;

                    //Update to database
                    ServiceExtension.GetInstance().UpdateOperator(opera);
                }
                MessageBox.Show("Đã cập nhật lại dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Reload to operator table
                dgvOperator.DataSource = ServiceExtension.GetInstance().GetOperatorByModel(modelCode);
                btnUpdate.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvOperator_CellEndEdit(object? sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Visible = true;
        }

        private void DgvOperator_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex != 3 &&  e.ColumnIndex != 4 && e.ColumnIndex != 5) // do not allow user click on column operatorNameOpera, excutionTime, isIgnore
            {
                Operator opera = new Operator();
                opera.ModelCode = dgvOperator.Rows[e.RowIndex].Cells["modelCodeOpera"].Value.ToString();
                opera.NumOperator = (byte)dgvOperator.Rows[e.RowIndex].Cells["numOperatorOpera"].Value;
                opera.OperatorName = dgvOperator.Rows[e.RowIndex].Cells["operatorNameOpera"].Value.ToString();
                opera.ExcutionTime = (TimeSpan)dgvOperator.Rows[e.RowIndex].Cells["excutionTime"].Value;
                opera.IsIgnore = (bool)dgvOperator.Rows[e.RowIndex].Cells["isIgnore"].Value;

                OperatorForm operatorForm = new OperatorForm();
                operatorForm.Operator = opera;
                operatorForm.ShowDialog();

                //Load dataagain
                dgvOperator.DataSource = ServiceExtension.GetInstance().GetOperatorByModel(opera.ModelCode);
            }
        }

        private void DgvModel_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Model model = new Model();
                model.ModelCode = dgvModel.Rows[e.RowIndex].Cells["modelCodeModel"].Value.ToString();
                model.ModelName = dgvModel.Rows[e.RowIndex].Cells["modelNameModel"].Value.ToString();
                model.GrossWeight = (float)dgvModel.Rows[e.RowIndex].Cells["grossWeight"].Value;
                model.ToLerance = (int)dgvModel.Rows[e.RowIndex].Cells["toLerance"].Value;

                ModelForm modelForm = new ModelForm();
                modelForm.Model = model;
                modelForm.ShowDialog();
                //Load data 2 the table again
                dgvModel.DataSource = ServiceExtension.GetInstance().GetModelTable();
                dgvOperator.DataSource = ServiceExtension.GetInstance().GetOperatorByModel(model.ModelCode);
            }
            catch
            {

            }
        }

        private void BtnWriteTimeToPLC_Click(object? sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Bạn muốn ghi thời gian và trạng thái các công đoạn trong bảng hiện tại xuống PLC?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(dr == DialogResult.Yes)
            {
                try
                {
                    short[] timeArr = new short[dgvOperator.Rows.Count];
                    List<Operator> operatorList = new List<Operator>();
                    for (int i = 0; i < dgvOperator.Rows.Count; i++)
                    {
                        TimeSpan time = (TimeSpan)dgvOperator.Rows[i].Cells["excutionTime"].Value;
                        bool isIgnore = (bool)dgvOperator.Rows[i].Cells["isIgnore"].Value;
                        Operator op = new Operator();
                        op.ExcutionTime = time;
                        op.IsIgnore = isIgnore;
                        operatorList.Add(op);
                    }
                    HomeForm.plc.WriteTimeAndIgnore(operatorList);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }           
        }

        private void BtnOpen_Click(object? sender, EventArgs e)
        {
            ModelForm modelForm = new ModelForm();
            modelForm.ShowDialog();
            dgvModel.DataSource = ServiceExtension.GetInstance().GetModelTable();
        }

        private void BtnExportModel_Click(object? sender, EventArgs e)
        {
            Excel.GetInstance().SaveFile(dgvModel);
        }

        private void BtnExportOpera_Click(object? sender, EventArgs e)
        {
            Excel.GetInstance().SaveFile(dgvOperator);
        }

        private void DgvModel_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string modelCode = dgvModel.Rows[e.RowIndex].Cells["modelCodeModel"].Value.ToString();
                dgvOperator.DataSource = ServiceExtension.GetInstance().GetOperatorByModel(modelCode);
            }
            catch
            {

            }
        }

        private void SettingForm_Load(object? sender, EventArgs e)
        {
            dgvModel.DataSource = ServiceExtension.GetInstance().GetModelTable();

            //Hiển thị thời gian sản xuất từ app config
            dateStart.Value = Properties.Settings.Default.StartProductionTime;
            dateEnd.Value = Properties.Settings.Default.EndProductionTime;
        }

        #endregion

        #region METHODS
        private void DisplayDataGridView(DataGridView dgv, Color color)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.BorderStyle = BorderStyle.Fixed3D;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = color;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
        }
        #endregion


        public delegate void UpdateProductionTime();
        public static event UpdateProductionTime OnUpdateProductionTime;
    }
}
