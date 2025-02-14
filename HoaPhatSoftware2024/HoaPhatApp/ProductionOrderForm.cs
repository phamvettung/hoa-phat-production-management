using DBRepositories.Entities;
using DBServices;
using System;
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
    public partial class ProductionOrderForm : Form
    {
        ServiceExtension serviceExtension = ServiceExtension.GetInstance(); 
        ProductionOrderService productionOrderService = ProductionOrderService.GetInstance();
        int LineType = Properties.Settings.Default.LineType;
        public ProductionOrderForm()
        {
            InitializeComponent();

            RegisterEvents();

            DisplayDataGridView(dgvModel, Color.LightCyan);
            DisplayDataGridView(dgvOperator, Color.LightCyan);
            DisplayDataGridView(dgvProductionOrder, Color.LightCyan);
        }

        private void RegisterEvents()
        {
            Load += ProductionOrderForm_Load;

            btnAddToList.Click += BtnAddToList_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnCancel.Click += BtnCancel_Click;
            btnStartProduction.Click += BtnStartProduction_Click;

            dgvModel.CellClick += DgvModel_CellClick;
            dgvOperator.CellDoubleClick += DgvOperator_CellDoubleClick;
            dgvOperator.CellEndEdit += DgvOperator_CellEndEdit;
            dgvProductionOrder.CellContentClick += DgvProductionOrder_CellContentClick;
        }


        private void BtnStartProduction_Click(object? sender, EventArgs e)
        {
            if(this.flagBtnUpdateEnable == true)
            {
                MessageBox.Show("Bạn chưa cập nhật lại Model.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnUpdate.BackColor = Color.Yellow;
                btnUpdate.ForeColor = Color.Red;
                return;
            }    

            if (dgvProductionOrder.Rows.Count > 1)
            {
                if (MessageBox.Show("Hãy chắc chắn rằng các thông tin cài đặt là chính xác.\r\nChọn Yes để bắt đầu sản xuất.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < dgvProductionOrder.Rows.Count - 1; i++)
                    {
                        ProductionOrder order = new ProductionOrder();
                        order.Date = DateTime.Parse(dgvProductionOrder.Rows[i].Cells["dateOrder"].Value.ToString());
                        order.ModelCode = dgvProductionOrder.Rows[i].Cells["modelCodeOrder"].Value.ToString();
                        order.ExpectedOutput = short.Parse(dgvProductionOrder.Rows[i].Cells["expectedOutput"].Value.ToString());
                        order.ActualOutput = 0;
                        order.Status = "Chờ";
                        ProductionOrderService.GetInstance().Create(order);
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Danh sách đang trống, bạn vẫn muốn bắt đầu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            this.Close();
        }

        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            if (dgvProductionOrder.Rows.Count > 1)
            {
                if (MessageBox.Show("Bạn muốn xóa toàn bộ model đã thêm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgvProductionOrder.Rows.Clear();
                }
            }

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
                    if (modelCode == string.Empty)
                        modelCode = opera.ModelCode;
                    opera.NumOperator = (byte)dgvOperator.Rows[i].Cells["numOperatorOpera"].Value;
                    opera.OperatorName = dgvOperator.Rows[i].Cells["operatorNameOpera"].Value.ToString();
                    opera.ExcutionTime = (TimeSpan)dgvOperator.Rows[i].Cells["excutionTime"].Value;
                    opera.IsIgnore = (bool)dgvOperator.Rows[i].Cells["isIgnore"].Value;

                    //Update to database
                    ServiceExtension.GetInstance().UpdateOperator(opera);
                }
                MessageBox.Show("Đã cập nhật lại thông tin cài đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Reload to operator table
                dgvOperator.DataSource = ServiceExtension.GetInstance().GetOperatorByModel(modelCode);
                btnUpdate.Visible = false;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            flagBtnUpdateEnable = false;
            btnUpdate.Visible = false;
        }

        bool flagBtnUpdateEnable = false;
        private void DgvOperator_CellEndEdit(object? sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Visible = true;
            flagBtnUpdateEnable = true;
        }

        private void DgvOperator_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 3 && e.ColumnIndex != 4 && e.ColumnIndex != 5) // do not allow user click on column operatorNameOpera, excutionTime, isIgnore
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

        private void ProductionOrderForm_Load(object? sender, EventArgs e)
        {
            try
            {
                dgvModel.DataSource = serviceExtension.GetModelTable();
                //Reset TotalOutput and CurrentModel to PLC
                if (LineType == 2)// chuyền phụ
                {
                    HomeForm.plc.ResetTotalOutput();
                    HomeForm.plc.ResetCurrentModel();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void DgvModel_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string modelCode = dgvModel.Rows[e.RowIndex].Cells["modelCodeModel"].Value.ToString();
                txtModelCode.Text = modelCode;
                txtModelName.Text = dgvModel.Rows[e.RowIndex].Cells["modelNameModel"].Value.ToString();
                dgvOperator.DataSource = ServiceExtension.GetInstance().GetOperatorByModel(modelCode);
                lbWarning.Visible = true;
                lbMessage.Text = "Hãy kiểm tra kỹ các thông tin cài đặt của từng công đoạn. Bạn có thể cập nhật lại tương tự như ở phần Thiết lập.";
            }
            catch
            {

            }
        }

        private void BtnAddToList_Click(object? sender, EventArgs e)
        {
            if (txtModelCode.Text == string.Empty && txtModelName.Text == string.Empty)
            {
                MessageBox.Show("Vui lòng chọn model cần thêm vào lệnh sản xuất, bằng cách click vào một dòng trong danh sách.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numQuantity.Value == 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Check if had the model in table? if existed already then increase quantity, do not add a new row
            for(int i = 0; i < dgvProductionOrder.Rows.Count - 1; i++)
            {
                string modelCode = dgvProductionOrder.Rows[i].Cells["modelCodeOrder"].Value.ToString();
                if (modelCode == txtModelCode.Text)
                {
                    DialogResult dr = MessageBox.Show("Model " + modelCode + " đã có trong danh sách. Hệ thống sẽ cộng thêm số lượng vào model đã có.\r\nChọn Yes để đồng ý.", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(dr == DialogResult.Yes)
                    {
                        int expectedOutput = int.Parse(dgvProductionOrder.Rows[i].Cells["expectedOutput"].Value.ToString());
                        expectedOutput += (int)numQuantity.Value;
                        dgvProductionOrder.Rows[i].Cells["expectedOutput"].Value = expectedOutput;
                    }
                    return;
                }
            }

            DataGridViewRow row = (DataGridViewRow)dgvProductionOrder.Rows[0].Clone();
            row.Cells[0].Value = DateTime.Now;
            row.Cells[1].Value = txtModelCode.Text;
            row.Cells[2].Value = numQuantity.Value;
            Button btnAction = new Button();
            row.Cells[3].Value = "Xóa";
            dgvProductionOrder.Rows.Add(row);
        }

        //Event delete a row in table
        private void DgvProductionOrder_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (dgvProductionOrder.Columns[e.ColumnIndex].Name == "action")
            {
                if (MessageBox.Show("Bạn muốn xóa dòng này ra khỏi danh sách?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    dgvProductionOrder.Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void DisplayDataGridView(DataGridView dgv, Color color)
        {
            dgv.EnableHeadersVisualStyles = false;
            dgv.BorderStyle = BorderStyle.Fixed3D;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = color;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Regular);
        }
    }
}
