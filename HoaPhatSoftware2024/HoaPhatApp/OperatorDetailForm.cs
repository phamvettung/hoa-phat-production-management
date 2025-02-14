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
    public partial class OperatorDetailForm : Form
    {
        public Operator Operator { get; set; }
        public string CurrentStatus { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }

        OperationDataService opDataService = OperationDataService.GetInstance();

        public OperatorDetailForm()
        {
            InitializeComponent();
            RegisterEvents();
            DisplayDataGridView(dgvOperatorData, Color.LightCyan);

        }

        private void RegisterEvents()
        {
            Load += OperatorDetailForm_Load;
        }

        private void OperatorDetailForm_Load(object? sender, EventArgs e)
        {
            txtModelCode.Text = Operator.ModelCode;
            txtOperatorName.Text = Operator.OperatorName;
            txtNumOperator.Text = Operator.NumOperator.ToString();
            txtExcutionTime.Text = Operator.ExcutionTime.ToString();
            txtStatus.Text = CurrentStatus;
            txtStartTime.Text = StartTime;
            txtEndTime.Text = EndTime;

            List<OperationDatum> opData = opDataService.GetByDateAndNumOperator(DateTime.Now.Date, DateTime.Now.Date.AddDays(1), Operator.NumOperator);
            dgvOperatorData.DataSource = opData;
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
