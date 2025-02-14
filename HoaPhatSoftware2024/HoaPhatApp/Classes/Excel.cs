using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoaPhatApp.Classes
{
    public class Excel
    {
        private static Excel instance;
        private SaveFileDialog saveFileDialog;
        private Excel()
        {
            saveFileDialog = new SaveFileDialog();
        }
        public static Excel GetInstance()
        {
            if (instance == null)
                instance = new Excel();
            return instance;    
        }

        public void SaveFile(DataGridView dgv)
        {
            try
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (dgv != null)
                        ToExcel(dgv, saveFileDialog.FileName);
                    else
                        MessageBox.Show("The table is empty");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToExcel(DataGridView dgv, string fileName)
        {
            Microsoft.Office.Interop.Excel.Application excel;
            Microsoft.Office.Interop.Excel.Workbook workbook;
            Microsoft.Office.Interop.Excel.Worksheet worksheet;
            try
            {
                excel = new Microsoft.Office.Interop.Excel.Application();
                excel.Visible = false;
                excel.DisplayAlerts = false;

                workbook = excel.Workbooks.Add(Type.Missing);
                worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets["Sheet1"];

                worksheet.Name = "Sheet1";

                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    worksheet.Cells[1, i + 1] = dgv.Columns[i].HeaderText;
                }

                for (int i = 0; i < dgv.RowCount; i++)
                {
                    for (int j = 0; j < dgv.ColumnCount; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                    }
                }

                workbook.SaveAs(fileName);

                workbook.Close();
                excel.Quit();
                MessageBox.Show("Đã kết xuất dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                workbook = null;
                worksheet = null;
            }
        }
    }
}
