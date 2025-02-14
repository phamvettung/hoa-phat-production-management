using DBRepositories;
using DBRepositories.Entities;
using DBServices;
using HoaPhatApp.Classes;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace HoaPhatApp
{
    public partial class HistoryForm : Form
    {
        //table flags
        private EnumFlag flagOperationData = EnumFlag.INACTIVE;
        private EnumFlag flagModelData = EnumFlag.INACTIVE;
        private EnumFlag flagDataReader = EnumFlag.INACTIVE;
        private EnumFlag flagBarcodeQuantity = EnumFlag.INACTIVE;

        int LineType = Properties.Settings.Default.LineType;

        //Data table
        private DataTable dtModelData = new DataTable();
        private DataTable dtOperationData =  new DataTable();
        private DataTable dtDataReader = new DataTable();
        private DataTable dtBarcodeQuantity = new DataTable();

        public HistoryForm()
        {
            InitializeComponent();
            RegisterEvents();

            DisplayDataGridView(dgvModel, SystemColors.ControlLight);
            DisplayDataGridView(dgvOperator, SystemColors.ControlLight);
            DisplayDataGridView(dgvDataReader, SystemColors.ControlLight);
            DisplayDataGridView(dgvBarcodeQuantity, SystemColors.ControlLight);
        }

        private void RegisterEvents()
        {
            Load += HistoryForm_Load;

            btnModel.Click += BtnModel_Click;
            btnOperator.Click += BtnOperator_Click;
            btnDataReader.Click += BtnDataReader_Click;
            btnBarcodeQuantity.Click += BtnBarcodeQuantity_Click;

            btnExport.Click += BtnExport_Click;
            btnReport.Click += BtnReport_Click;

            dateStart.ValueChanged += DateStart_ValueChanged;
            dateEnd.ValueChanged += DateEnd_ValueChanged;

        }

        private void HistoryForm_Load(object? sender, EventArgs e)
        {
            if(LineType == 1)
            {
                btnDataReader.Enabled = true;
                btnBarcodeQuantity.Enabled = true;
            }
            else if(LineType == 2)
            {
                btnDataReader.Enabled = false;
                btnBarcodeQuantity.Enabled = false;
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


        private void DateEnd_ValueChanged(object? sender, EventArgs e)
        {
            if(flagOperationData == EnumFlag.ACTIVE)
            {
                dtOperationData = ServiceExtension.GetInstance().GetOperationData(dateStart.Value, dateEnd.Value);
                dgvOperator.DataSource = dtOperationData;
            }
            if(flagModelData == EnumFlag.ACTIVE)
            {
                dtModelData = ServiceExtension.GetInstance().GetModelData(dateStart.Value, dateEnd.Value);
                dgvModel.DataSource = dtModelData;
            }
            if(flagDataReader == EnumFlag.ACTIVE)
            {
                dtDataReader = ServiceExtension.GetInstance().GetDataReader(dateStart.Value, dateEnd.Value);
                dgvDataReader.DataSource = dtDataReader;
            }
            if(flagBarcodeQuantity == EnumFlag.ACTIVE)
            {
                dtBarcodeQuantity = ServiceExtension.GetInstance().GetBarcodeQuantity(dateStart.Value, dateEnd.Value);
                dgvBarcodeQuantity.DataSource = dtBarcodeQuantity;
            }
        }

        private void DateStart_ValueChanged(object? sender, EventArgs e)
        {
            if (flagOperationData == EnumFlag.ACTIVE)
            {
                dtOperationData = ServiceExtension.GetInstance().GetOperationData(dateStart.Value, dateEnd.Value);
                dgvOperator.DataSource = dtOperationData;
            }
            if (flagModelData == EnumFlag.ACTIVE)
            {
                dtModelData = ServiceExtension.GetInstance().GetModelData(dateStart.Value, dateEnd.Value);
                dgvModel.DataSource = dtModelData;
            }
            if (flagDataReader == EnumFlag.ACTIVE)
            {
                dtDataReader = ServiceExtension.GetInstance().GetDataReader(dateStart.Value, dateEnd.Value);
                dgvDataReader.DataSource = dtDataReader;
            }
            if (flagBarcodeQuantity == EnumFlag.ACTIVE)
            {
                dtBarcodeQuantity = ServiceExtension.GetInstance().GetBarcodeQuantity(dateStart.Value, dateEnd.Value);
                dgvBarcodeQuantity.DataSource = dtBarcodeQuantity;
            }
        }

        private void BtnReport_Click(object? sender, EventArgs e)
        {
            if (flagOperationData == EnumFlag.ACTIVE)
            {
                DataTable dt = (DataTable)dgvOperator.DataSource;
                ReportForm.GetInstance().dtReceiver = dt;
                // Tell to the form report to know what is the table need to load  
                ReportForm.GetInstance().flagModelData = EnumFlag.INACTIVE;
                ReportForm.GetInstance().flagOperatorData = EnumFlag.ACTIVE;
                ReportForm.GetInstance().flagDataReader = EnumFlag.INACTIVE;
                ReportForm.GetInstance().flagBarcodeQuantity = EnumFlag.INACTIVE;
            }
            if (flagModelData == EnumFlag.ACTIVE)
            {
                DataTable dt = (DataTable)dgvModel.DataSource;
                ReportForm.GetInstance().dtReceiver = dt;
                // Tell to the form report to know what is the table need to load  
                ReportForm.GetInstance().flagModelData = EnumFlag.ACTIVE;
                ReportForm.GetInstance().flagOperatorData = EnumFlag.INACTIVE;
                ReportForm.GetInstance().flagDataReader = EnumFlag.INACTIVE;
                ReportForm.GetInstance().flagBarcodeQuantity = EnumFlag.INACTIVE;
            }
            if (flagDataReader == EnumFlag.ACTIVE)
            {
                DataTable dt = (DataTable)dgvDataReader.DataSource;
                ReportForm.GetInstance().dtReceiver = dt;
                // Tell to the form report to know what is the table need to load  
                ReportForm.GetInstance().flagModelData = EnumFlag.INACTIVE;
                ReportForm.GetInstance().flagOperatorData = EnumFlag.INACTIVE;
                ReportForm.GetInstance().flagDataReader = EnumFlag.ACTIVE;
                ReportForm.GetInstance().flagBarcodeQuantity = EnumFlag.INACTIVE;
            }
            if (flagBarcodeQuantity == EnumFlag.ACTIVE)
            {
                DataTable dt = (DataTable)dgvBarcodeQuantity.DataSource;
                ReportForm.GetInstance().dtReceiver = dt;
                // Tell to the form report to know what is the table need to load  
                ReportForm.GetInstance().flagModelData = EnumFlag.INACTIVE;
                ReportForm.GetInstance().flagOperatorData = EnumFlag.INACTIVE;
                ReportForm.GetInstance().flagDataReader = EnumFlag.INACTIVE;
                ReportForm.GetInstance().flagBarcodeQuantity = EnumFlag.ACTIVE;
            }
            LoadReport();
            FormOpened(ReportForm.GetInstance());
        }

        private void BtnExport_Click(object? sender, EventArgs e)
        {
            if (flagOperationData == EnumFlag.ACTIVE)
            {
                Excel.GetInstance().SaveFile(dgvOperator);
            }
            if (flagModelData == EnumFlag.ACTIVE)
            {
                Excel.GetInstance().SaveFile(dgvModel);
            }
            if (flagDataReader == EnumFlag.ACTIVE)
            {
                Excel.GetInstance().SaveFile(dgvDataReader);
            }
            if (flagBarcodeQuantity == EnumFlag.ACTIVE)
            {
                Excel.GetInstance().SaveFile(dgvBarcodeQuantity);
            }
        }
        private void BtnBarcodeQuantity_Click(object? sender, EventArgs e)
        {
            btnModel.BackColor = Color.Transparent;
            btnOperator.BackColor = Color.Transparent;
            btnDataReader.BackColor = Color.Transparent;
            btnBarcodeQuantity.BackColor = Color.LightSkyBlue;
            lbTableName.Text = "Bảng thống kê số lượng mã SERIAL";

            dgvModel.Visible = false;
            dgvOperator.Visible = false;
            dgvDataReader.Visible = false;
            dgvBarcodeQuantity.Visible = true;

            this.flagOperationData = EnumFlag.INACTIVE;
            this.flagModelData = EnumFlag.INACTIVE;
            this.flagDataReader = EnumFlag.INACTIVE;
            this.flagBarcodeQuantity = EnumFlag.ACTIVE;

            dtBarcodeQuantity = ServiceExtension.GetInstance().GetBarcodeQuantity(dateStart.Value, dateEnd.Value);
            dgvBarcodeQuantity.DataSource = dtBarcodeQuantity;

            dgvModel.Dock = DockStyle.None;
            dgvOperator.Dock = DockStyle.None;
            dgvDataReader.Dock = DockStyle.None;
            dgvBarcodeQuantity.Dock = DockStyle.Fill;
        }

        private void BtnDataReader_Click(object? sender, EventArgs e)
        {
            btnModel.BackColor = Color.Transparent;
            btnOperator.BackColor = Color.Transparent;
            btnDataReader.BackColor = Color.LightSkyBlue;
            btnBarcodeQuantity.BackColor = Color.Transparent;

            lbTableName.Text = "Bảng thống kê dữ liệu Cân và mã Serial";

            dgvModel.Visible = false;
            dgvOperator.Visible = false;
            dgvDataReader.Visible = true;
            dgvBarcodeQuantity.Visible = false;

            this.flagOperationData = EnumFlag.INACTIVE;
            this.flagModelData = EnumFlag.INACTIVE;
            this.flagDataReader = EnumFlag.ACTIVE;
            this.flagBarcodeQuantity = EnumFlag.INACTIVE;

            dtDataReader = ServiceExtension.GetInstance().GetDataReader(dateStart.Value, dateEnd.Value);
            dgvDataReader.DataSource = dtDataReader;

            dgvModel.Dock = DockStyle.None;
            dgvOperator.Dock = DockStyle.None;
            dgvDataReader.Dock = DockStyle.Fill;
            dgvBarcodeQuantity.Dock = DockStyle.None;
        }

        private void BtnOperator_Click(object? sender, EventArgs e)
        {
            btnModel.BackColor = Color.Transparent;
            btnOperator.BackColor = Color.LightSkyBlue;
            btnDataReader.BackColor = Color.Transparent;
            btnBarcodeQuantity.BackColor = Color.Transparent;

            lbTableName.Text = "Bảng thống kê theo Công đoạn sản xuất";

            dgvModel.Visible = false;
            dgvOperator.Visible = true;
            dgvDataReader.Visible = false;
            dgvBarcodeQuantity.Visible = false;

            this.flagOperationData = EnumFlag.ACTIVE;
            this.flagModelData = EnumFlag.INACTIVE;
            this.flagDataReader = EnumFlag.INACTIVE;
            this.flagBarcodeQuantity = EnumFlag.INACTIVE;

            dtOperationData = ServiceExtension.GetInstance().GetOperationData(dateStart.Value, dateEnd.Value);
            dgvOperator.DataSource = dtOperationData;

            dgvModel.Dock = DockStyle.None;
            dgvOperator.Dock = DockStyle.Fill;
            dgvDataReader.Dock = DockStyle.None;
            dgvBarcodeQuantity.Dock = DockStyle.None;
        }

        private void BtnModel_Click(object? sender, EventArgs e)
        {
            btnModel.BackColor = Color.LightSkyBlue;
            btnOperator.BackColor = Color.Transparent;
            btnDataReader.BackColor = Color.Transparent;
            btnBarcodeQuantity.BackColor = Color.Transparent;

            lbTableName.Text = "Bảng thống kê theo Sản lượng";

            dgvModel.Visible = true;
            dgvOperator.Visible = false;
            dgvDataReader.Visible = false;
            dgvBarcodeQuantity.Visible = false;

            this.flagOperationData = EnumFlag.INACTIVE;
            this.flagModelData = EnumFlag.ACTIVE;
            this.flagDataReader = EnumFlag.INACTIVE;
            this.flagBarcodeQuantity = EnumFlag.INACTIVE;

            dtModelData = ServiceExtension.GetInstance().GetModelData(dateStart.Value, dateEnd.Value);
            dgvModel.DataSource = dtModelData;

            dgvModel.Dock = DockStyle.Fill;
            dgvOperator.Dock = DockStyle.None;
            dgvDataReader.Dock = DockStyle.None;
            dgvBarcodeQuantity.Dock = DockStyle.None;
        }

        /// <summary>
        /// Event open form report to the main form
        /// </summary>
        public static event OpenFormFunc FormOpened;
        public delegate void OpenFormFunc(Form frm);

        /// <summary>
        /// Event load report to the report form
        /// </summary>
        public static event LoadReportFunc LoadReport;
        public delegate void LoadReportFunc();

    }
}
