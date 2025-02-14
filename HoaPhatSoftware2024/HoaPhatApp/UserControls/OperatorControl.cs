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

namespace HoaPhatApp.UserControls
{
    public partial class OperatorControl : ArtanPanel
    {
        // Controls
        public System.Windows.Forms.Label lbStatus { get; set; }
        public System.Windows.Forms.Label LbOperaName { get; set; }
        public System.Windows.Forms.Label LbStartTime1 { get; set; }
        public System.Windows.Forms.Label LbStartTime2 { get; set; }
        public System.Windows.Forms.Label LbEndTime1 { get; set; }
        public System.Windows.Forms.Label LbEndTime2 { get; set; }

        System.Windows.Forms.Timer tmrRefresh;

        //DB Context
        OperationDataService opDataService = OperationDataService.GetInstance();

        //Fields
        public Operator Operator { get; set; }
        public bool Finish { get; set; } = false;
        public bool Exceeding { get; set; } = false;
        public int ImmediateTime { get; set; } = 0;


        public OperatorControl()
        {
            InitializeComponent();
            Operator = new Operator();
            RegisterEvents();
            RegisterTimers();
        }

        private void RegisterEvents()
        {
            this.Paint += OperatorControl_Paint;// as Load
            this.Click += OperatorControl_Click;
            lbStatus.Click += ShowDetailForm_Click;
            LbOperaName.Click += ShowDetailForm_Click;
            LbStartTime1.Click += ShowDetailForm_Click;
            LbStartTime2.Click += ShowDetailForm_Click;
            LbEndTime1.Click += ShowDetailForm_Click;
            LbEndTime2.Click += ShowDetailForm_Click;
        }

        private void ShowDetailForm_Click(object? sender, EventArgs e)
        {
            OperatorDetailForm opDetailForm = new OperatorDetailForm();
            opDetailForm.Operator = this.Operator;
            opDetailForm.CurrentStatus = lbStatus.Text;
            opDetailForm.StartTime = LbStartTime2.Text;
            opDetailForm.EndTime = LbEndTime2.Text;
            opDetailForm.ShowDialog();
        }

        private void RegisterTimers()
        {
            tmrRefresh = new System.Windows.Forms.Timer();
            tmrRefresh.Tick += TmrRefresh_Tick;
            tmrRefresh.Interval = 100;
        }


        bool completedFlag = false;
        private void TmrRefresh_Tick(object? sender, EventArgs e)
        {
            if (Exceeding)
            {
                this.BackColor = Color.Red;
                //this.GradientTopColor = Color.Red;
                //this.GradientBottomColor = Color.Red;
                LbOperaName.ForeColor = Color.White;
                lbStatus.Text = "Quá thời gian cho phép";
            }
            else
            {
                if (Finish)
                {
                    if(completedFlag == false)
                    {
                        TimeSpan endTime = TimeSpan.Parse(DateTime.Now.ToString("HH:mm:ss"));
                        TimeSpan startTime = endTime - TimeSpan.FromSeconds(ImmediateTime);

                        //Insert to OperatorData in Database
                        OperationDatum opData = new OperationDatum();
                        opData.NumOperator = Operator.NumOperator;
                        opData.ModelCode = Operator.ModelCode;
                        opData.Date = DateTime.Now;
                        opData.StartTime = startTime;
                        opData.EndTime = endTime;
                        opDataService.Create(opData);

                        this.BackColor = Color.Green;
                        //this.GradientTopColor = Color.Green;
                        //this.GradientBottomColor = Color.Green;
                        lbStatus.Text = "Hoàn thành";
                        LbOperaName.ForeColor = Color.White;
                        LbStartTime2.Text = startTime.ToString();
                        LbEndTime2.Text = endTime.ToString();
                        completedFlag = true;
                    }
                }
                else
                {
                    if (completedFlag == true)
                    {
                        this.BackColor = Color.FromArgb(255, 192, 128);
                        //this.GradientTopColor = Color.FromArgb(255, 192, 128);
                        //this.GradientBottomColor = Color.FromArgb(255, 192, 128);
                        LbOperaName.ForeColor = Color.White;
                        lbStatus.Text = "Đang thực hiện";
                        completedFlag = false;
                    }
                }
            }

        }

        private void OperatorControl_Click(object? sender, EventArgs e)
        {
            OperatorDetailForm opDetailForm = new OperatorDetailForm();
            opDetailForm.Operator = this.Operator;
            opDetailForm.CurrentStatus = lbStatus.Text;
            opDetailForm.StartTime = LbStartTime2.Text;
            opDetailForm.EndTime = LbEndTime2.Text;
            opDetailForm.ShowDialog();
        }

        private void OperatorControl_Paint(object? sender, PaintEventArgs e)
        {
            LoadControl();
        }

        private void LoadControl()
        {
            this.LbOperaName.Text = Operator.NumOperator.ToString();
            if (Operator.IsIgnore == true)
            {
                this.BackColor = Color.Gray;
                //this.GradientTopColor = Color.Gray;
                //this.GradientBottomColor = Color.Gray;
                this.lbStatus.Text = "Bỏ qua";
                tmrRefresh.Stop();
            }
            else
            {
                tmrRefresh.Start();
            }
        }

        private void InitializeComponent()
        {
            //This
            this.Size = new System.Drawing.Size(160, 160);
            this.BackColor = Color.White;
            //this.GradientTopColor = Color.White;
            //this.GradientBottomColor = Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.BorderStyle = BorderStyle.None;

            //lbStatus
            lbStatus = new System.Windows.Forms.Label();
            lbStatus.AutoSize = true;
            lbStatus.BackColor = Color.Transparent;
            lbStatus.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbStatus.Location = new Point(5, 5);
            lbStatus.Size = new Size(10, 10);
            lbStatus.Text = "Trạng thái";
            lbStatus.Visible = false;
            this.Controls.Add(lbStatus);

            //LbOperaName
            LbOperaName = new System.Windows.Forms.Label();
            LbOperaName.Font = new Font("Arial", 75F, FontStyle.Regular, GraphicsUnit.Point);
            LbOperaName.Text = "0";
            LbOperaName.ForeColor = Color.Black;
            LbOperaName.AutoSize = false;
            LbOperaName.BackColor = Color.Transparent;
            LbOperaName.TextAlign = ContentAlignment.MiddleCenter;
            LbOperaName.Dock = DockStyle.Fill;
            this.Controls.Add(LbOperaName);

            //LbStartTime1
            LbStartTime1 = new System.Windows.Forms.Label();
            LbStartTime1.AutoSize = true;
            LbStartTime1.BackColor = Color.Transparent;
            LbStartTime1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LbStartTime1.Location = new Point(5, 100);
            LbStartTime1.Size = new Size(10, 15);
            LbStartTime1.Text = "Bắt đầu:";
            LbStartTime1.Visible = false;
            this.Controls.Add(LbStartTime1);

            //LbStartTime2
            LbStartTime2 = new System.Windows.Forms.Label();
            LbStartTime2.AutoSize = true;
            LbStartTime2.BackColor = Color.Transparent;
            LbStartTime2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LbStartTime2.Location = new Point(65, 100);
            LbStartTime2.Size = new Size(10, 15);
            LbStartTime2.Text = DateTime.MinValue.ToString("HH:mm:ss"); // 00:00:00
            LbStartTime2.Visible = false;
            this.Controls.Add(LbStartTime2);

            //LbEndTime1
            LbEndTime1 = new System.Windows.Forms.Label();
            LbEndTime1.AutoSize = true;
            LbEndTime1.BackColor = Color.Transparent;
            LbEndTime1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LbEndTime1.Location = new Point(5, 120);
            LbEndTime1.Size = new Size(10, 15);
            LbEndTime1.Text = "Kết thúc:";
            LbEndTime1.Visible = false;
            this.Controls.Add(LbEndTime1);

            //LbStartTime2
            LbEndTime2 = new System.Windows.Forms.Label();
            LbEndTime2.AutoSize = true;
            LbEndTime2.BackColor = Color.Transparent;
            LbEndTime2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LbEndTime2.Location = new Point(65, 120);
            LbEndTime2.Size = new Size(10, 15);
            LbEndTime2.Text = DateTime.MinValue.ToString("HH:mm:ss"); // 00:00:00
            LbEndTime2.Visible = false;
            this.Controls.Add(LbEndTime2);
        }
    }
}
