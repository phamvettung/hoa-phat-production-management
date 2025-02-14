using DBRepositories.Entities;
using DBServices;
using HoaPhatApp.Classes;
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
    public partial class ErrorForm : Form
    {
        ErrorService errorService = ErrorService.GetInstance();
        ServiceExtension extension = ServiceExtension.GetInstance();
        Excel excel = Excel.GetInstance();

        public ErrorForm()
        {
            InitializeComponent();
            DisplayDataGridView(dgvError, Color.LightCyan);
            DisplayDataGridView(dgvErrorData, Color.LightCyan);
            RegisterEvents();
        }

        private void RegisterEvents()
        {
            Load += ErrorForm_Load;
            btnExport.Click += BtnExport_Click;
            dgvError.CellValueChanged += DgvError_CellValueChanged;
            dgvErrorData.CellClick += DgvErrorData_CellClick;
            dateStart.ValueChanged += DateStart_ValueChanged;
            dateEnd.ValueChanged += DateEnd_ValueChanged;
        }

        private void DgvErrorData_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtSolution.Text = dgvErrorData.Rows[e.RowIndex].Cells["solutionErrData"].Value.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void BtnExport_Click(object? sender, EventArgs e)
        {
            excel.SaveFile(dgvErrorData);
        }

        private void DateEnd_ValueChanged(object? sender, EventArgs e)
        {
            RefreshDgvErrorData();
        }

        private void DateStart_ValueChanged(object? sender, EventArgs e)
        {
            RefreshDgvErrorData();
        }

        private void ErrorForm_Load(object? sender, EventArgs e)
        {
            RefreshDgvError();
            RefreshDgvErrorData();
        }

        private void DgvError_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvError.CurrentRow;
                if (row != null)
                {
                    if (row.Cells["errorName"].Value == string.Empty && row.Cells["solution"].Value == string.Empty)
                    {
                        Error err = new Error();
                        err.BitError = row.Cells["bitError"].Value.ToString();
                        err.ErrorName = string.Empty;
                        err.Solution = string.Empty;
                        errorService.Create(err);
                    }
                    else
                    {
                        Error err = new Error();
                        err.BitError = row.Cells["bitError"].Value.ToString();
                        err.ErrorName = row.Cells["errorName"].Value.ToString();
                        err.Solution = row.Cells["solution"].Value.ToString();
                        errorService.Update(err);
                    }

                    RefreshDgvError();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
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

        private void RefreshDgvError()
        {
            List<Error> lst = errorService.GetAll();
            Error err = new Error();
            err.BitError = string.Empty;
            err.ErrorName = string.Empty;
            err.Solution = string.Empty;
            lst.Add(err);
            dgvError.DataSource = lst;
        }

        private void RefreshDgvErrorData()
        {
            dgvErrorData.DataSource = extension.GetErrorDataByDate(dateStart.Value, dateEnd.Value);
        }
    }
}
