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
    public partial class OperatorForm : Form
    {
        public Operator Operator { get; set; }
        public OperatorForm()
        {
            InitializeComponent();
            RegistorEvents();
        }

        private void RegistorEvents()
        {
            Load += OperatorForm_Load;
            btnOk.Click += BtnOk_Click;
        }

        private void BtnOk_Click(object? sender, EventArgs e)
        {
            try
            {
                Operator newOperator = new Operator();
                newOperator.ModelCode = Operator.ModelCode;
                newOperator.NumOperator = Operator.NumOperator;
                newOperator.OperatorName = txtOperatorName.Text.Trim();
                newOperator.ExcutionTime = TimeSpan.Parse(txtExcutionTime.Text.Trim());
                newOperator.IsIgnore = cboIgnore.Checked;
                ServiceExtension.GetInstance().UpdateOperator(newOperator);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OperatorForm_Load(object? sender, EventArgs e)
        {
            if(Operator != null)
            {
                lbModelName.Text = Operator.ModelCode;
                lbNumOperator.Text = Operator.NumOperator.ToString();
                txtOperatorName.Text = Operator.OperatorName;
                txtExcutionTime.Text = Operator.ExcutionTime.ToString("hh':'mm':'ss");
                cboIgnore.Checked = Operator.IsIgnore;
            }
        }
    }
}
