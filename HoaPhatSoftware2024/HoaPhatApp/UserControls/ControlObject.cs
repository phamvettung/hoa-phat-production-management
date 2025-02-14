using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoaPhatApp.UserControls
{
    public partial class ControlObject : ArtanPanel
    {
        public PictureBox Pic { get; set; }
        public System.Windows.Forms.Label LbTittle { get; set; }
        public System.Windows.Forms.Label LbMainVal {  get; set; }
        public System.Windows.Forms.Label LbForeignVal1 { get; set; }
        public System.Windows.Forms.Label LbForeignVal2 { get; set; }

        public Panel panMainVal { get; set; }
        public ControlObject()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            //This
            this.Size = new System.Drawing.Size(350, 150);
            //this.BackColor = Color.White;
            this.GradientTopColor = Color.White;
            this.GradientBottomColor = Color.White;
            this.Margin = new System.Windows.Forms.Padding(10);
            this.BorderStyle = BorderStyle.None;



            //Image
            Pic = new PictureBox();
            Pic.Image = Properties.Resources.Intech_logo;
            Pic.Location = new System.Drawing.Point(10, 5);
            Pic.BackColor = Color.Transparent;
            Pic.Size = new System.Drawing.Size(40, 40);
            Pic.SizeMode = PictureBoxSizeMode.CenterImage;
            this.Controls.Add(Pic);

            //lbTittle
            LbTittle = new System.Windows.Forms.Label();
            LbTittle.AutoSize = true;
            LbTittle.BackColor = Color.Transparent;
            LbTittle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            LbTittle.Location = new Point(60, 10);
            LbTittle.Size = new Size(60, 30);
            LbTittle.Text = "Tittle";
            this.Controls.Add(LbTittle);

            panMainVal = new Panel();
            panMainVal.Size = new Size(340, 90);
            panMainVal.Location = new Point(5, 35);
            panMainVal.SendToBack();
            this.Controls.Add(panMainVal);

            //lbMainVal
            LbMainVal = new System.Windows.Forms.Label();
            LbMainVal.AutoSize = false;
            LbMainVal.Dock = DockStyle.Fill;
            LbMainVal.TextAlign = ContentAlignment.MiddleCenter;
            LbMainVal.BackColor = Color.Transparent;
            LbMainVal.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            LbMainVal.Location = new Point(5, 30);
            LbMainVal.Size = new Size(80, 40);
            LbMainVal.Text = "MAIN VALUE";
            panMainVal.Controls.Add(LbMainVal);

            //lbForeignVal1
            LbForeignVal1 = new System.Windows.Forms.Label();
            LbForeignVal1.AutoSize = true;
            LbForeignVal1.BackColor = Color.Transparent;
            LbForeignVal1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LbForeignVal1.Location = new Point(5, 115);
            LbForeignVal1.Size = new Size(50, 25);
            LbForeignVal1.Text = "Foreign:";
            LbForeignVal1.BringToFront();
            this.Controls.Add(LbForeignVal1);

            //lbForeignVal2
            LbForeignVal2 = new System.Windows.Forms.Label();
            LbForeignVal2.AutoSize = true;
            LbForeignVal2.BackColor = Color.Transparent;
            LbForeignVal2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            LbForeignVal2.Location = new Point(200, 115);
            LbForeignVal2.Size = new Size(35, 25);
            LbForeignVal2.Text = "Empty";
            LbForeignVal2.BringToFront();
            this.Controls.Add(LbForeignVal2);

        }
    }
}
