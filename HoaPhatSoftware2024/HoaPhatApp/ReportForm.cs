using HoaPhatApp.Classes;
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

namespace HoaPhatApp
{
    public partial class ReportForm : Form
    {
        public DataTable dtReceiver { get; set; }
        public EnumFlag flagModelData { get; set; }
        public EnumFlag flagOperatorData { get; set; }
        public EnumFlag flagDataReader { get; set; }
        public EnumFlag flagBarcodeQuantity { get; set; }

        private static ReportForm instance;

        private ReportForm()
        {
            InitializeComponent();
            InitializeForm();
            RegisterEvents();

            flagModelData = EnumFlag.INACTIVE;
            flagOperatorData = EnumFlag.INACTIVE;
            flagDataReader = EnumFlag.INACTIVE;
            flagBarcodeQuantity = EnumFlag.INACTIVE;
        }

        public static ReportForm GetInstance()
        {
            if (instance == null)
                instance = new ReportForm();
            return instance;
        }

        private void InitializeForm()
        {
            reportViewer1.Dock = DockStyle.Fill;
            panel1.Controls.Add(reportViewer1);
            dtReceiver = new DataTable();
        }

        private void RegisterEvents()
        {
            Load += ReportForm_Load;
            //Register load event from the History form
            HistoryForm.LoadReport += ReportForm_LoadReport;
        }

        private void ReportForm_Load(object? sender, EventArgs e)
        {
            
        }

        private void ReportForm_LoadReport()
        {
            if(flagModelData == EnumFlag.ACTIVE)
            {
                this.reportViewer1.LocalReport.ReportPath = "ReportDefinitions\\ModelDataReport.rdlc";
                var reportDataSource = new ReportDataSource("ModelDataDsrc", dtReceiver);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
            else if (flagOperatorData == EnumFlag.ACTIVE)
            {
                this.reportViewer1.LocalReport.ReportPath = "ReportDefinitions\\OperatorDataReport.rdlc";
                var reportDataSource = new ReportDataSource("OperatorDataDsrc", dtReceiver);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
            else if (flagDataReader == EnumFlag.ACTIVE)
            {
                this.reportViewer1.LocalReport.ReportPath = "ReportDefinitions\\DataReaderReport.rdlc";
                var reportDataSource = new ReportDataSource("DataReaderDsrc", dtReceiver);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
            else if (flagBarcodeQuantity == EnumFlag.ACTIVE)
            {
                this.reportViewer1.LocalReport.ReportPath = "ReportDefinitions\\BarcodeQuantityReport.rdlc";
                var reportDataSource = new ReportDataSource("BarcodeQuantityDsrc", dtReceiver);
                this.reportViewer1.LocalReport.DataSources.Clear();
                this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
