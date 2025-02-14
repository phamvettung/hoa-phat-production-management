using DBRepositories.Entities;
using DBServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoaPhatApp
{
    public partial class ModelForm : Form
    {
        public Model Model { get; set; }
        public ModelForm()
        {
            InitializeComponent();
            RegisterEvents();
        }

        private void RegisterEvents()
        {
            Load += ModelForm_Load;
            btnAdd.Click += BtnAdd_Click;
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Model modelNew = new Model();
            modelNew.ModelCode = txtModelCode.Text.Trim().ToUpper();

            try
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa model " + modelNew.ModelCode, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    ModelService.GetInstance().Delete(modelNew.ModelCode);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnUpdate_Click(object? sender, EventArgs e)
        {
            Model modelNew = new Model();
            modelNew.ModelCode = txtModelCode.Text.Trim().ToUpper();
            modelNew.ModelName = txtModelName.Text.Trim();
            modelNew.GrossWeight = (float)numGrossWeight.Value;
            modelNew.ToLerance = (int)numToLerance.Value;

            try
            {
                ModelService.GetInstance().Update(modelNew);
                MessageBox.Show("Đã cập nhập lại model " + modelNew.ModelCode, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAdd_Click(object? sender, EventArgs e)
        {
            Model modelNew = new Model();
            modelNew.ModelCode = txtModelCode.Text.Trim().ToUpper();
            modelNew.ModelName = txtModelName.Text.Trim();
            modelNew.GrossWeight = (float)numGrossWeight.Value;
            modelNew.ToLerance = (int)numToLerance.Value;

            try
            {
                //Create a new model
                ModelService.GetInstance().Create(modelNew);
                //Then Create the new operator of that model
                for (int i = 1; i <= Properties.Settings.Default.NumOfOpeartor; i++)
                {
                    Operator opera = new Operator();
                    opera.ModelCode = modelNew.ModelCode;
                    opera.NumOperator = (byte)i;
                    opera.OperatorName = "Chưa cập nhật"; // default
                    opera.ExcutionTime = new TimeSpan(0, 0, 0); //default: 00:00:00
                    opera.IsIgnore = false; // default
                    ServiceExtension.GetInstance().CreateOperator(opera);
                }
                MessageBox.Show("Đã thêm mới model " + modelNew.ModelCode, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ModelForm_Load(object? sender, EventArgs e)
        {
            if (Model != null)
            {
                lbModelName.Text = Model.ModelCode;
                txtModelCode.Text = Model.ModelCode;
                txtModelName.Text = Model.ModelName;
                numGrossWeight.Value = (decimal)Model.GrossWeight;
                numToLerance.Value = Model.ToLerance;
            }
        }
    }
}
