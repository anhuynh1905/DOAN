namespace DOAN
{
    partial class Receptionist_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receptionist_Form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btCheckout = new Guna.UI2.WinForms.Guna2Button();
            this.btCheckin = new Guna.UI2.WinForms.Guna2Button();
            this.lbNoticeRecep = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btExitRecep = new Guna.UI2.WinForms.Guna2Button();
            this.checkIn1 = new DOAN._controllManager.CheckIn();
            this.checkOut1 = new DOAN._controllManager.CheckOut();
            this.Info = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Info);
            this.panel1.Controls.Add(this.btCheckout);
            this.panel1.Controls.Add(this.btCheckin);
            this.panel1.Controls.Add(this.lbNoticeRecep);
            this.panel1.Location = new System.Drawing.Point(59, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(759, 64);
            this.panel1.TabIndex = 2;
            // 
            // btCheckout
            // 
            this.btCheckout.BorderRadius = 15;
            this.btCheckout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCheckout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCheckout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCheckout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCheckout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btCheckout.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckout.ForeColor = System.Drawing.Color.Black;
            this.btCheckout.Location = new System.Drawing.Point(484, 12);
            this.btCheckout.Margin = new System.Windows.Forms.Padding(2);
            this.btCheckout.Name = "btCheckout";
            this.btCheckout.Size = new System.Drawing.Size(119, 37);
            this.btCheckout.TabIndex = 2;
            this.btCheckout.Text = "CheckOut";
            this.btCheckout.Click += new System.EventHandler(this.btCheckout_Click);
            // 
            // btCheckin
            // 
            this.btCheckin.BorderRadius = 15;
            this.btCheckin.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btCheckin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btCheckin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btCheckin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btCheckin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btCheckin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btCheckin.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckin.ForeColor = System.Drawing.Color.Black;
            this.btCheckin.Location = new System.Drawing.Point(351, 12);
            this.btCheckin.Margin = new System.Windows.Forms.Padding(2);
            this.btCheckin.Name = "btCheckin";
            this.btCheckin.Size = new System.Drawing.Size(111, 37);
            this.btCheckin.TabIndex = 1;
            this.btCheckin.Text = "CheckIn";
            this.btCheckin.Click += new System.EventHandler(this.btCheckin_Click);
            // 
            // lbNoticeRecep
            // 
            this.lbNoticeRecep.AutoSize = true;
            this.lbNoticeRecep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbNoticeRecep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNoticeRecep.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNoticeRecep.Location = new System.Drawing.Point(21, 11);
            this.lbNoticeRecep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNoticeRecep.Name = "lbNoticeRecep";
            this.lbNoticeRecep.Size = new System.Drawing.Size(313, 39);
            this.lbNoticeRecep.TabIndex = 0;
            this.lbNoticeRecep.Text = "Receptionist Functions";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // btExitRecep
            // 
            this.btExitRecep.BorderRadius = 18;
            this.btExitRecep.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btExitRecep.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btExitRecep.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btExitRecep.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btExitRecep.FillColor = System.Drawing.Color.Silver;
            this.btExitRecep.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btExitRecep.ForeColor = System.Drawing.Color.White;
            this.btExitRecep.Image = ((System.Drawing.Image)(resources.GetObject("btExitRecep.Image")));
            this.btExitRecep.ImageSize = new System.Drawing.Size(30, 30);
            this.btExitRecep.Location = new System.Drawing.Point(9, 10);
            this.btExitRecep.Margin = new System.Windows.Forms.Padding(2);
            this.btExitRecep.Name = "btExitRecep";
            this.btExitRecep.Size = new System.Drawing.Size(30, 32);
            this.btExitRecep.TabIndex = 1;
            this.btExitRecep.Click += new System.EventHandler(this.btExitRecep_Click);
            // 
            // checkIn1
            // 
            this.checkIn1.BackColor = System.Drawing.Color.LightGray;
            this.checkIn1.Location = new System.Drawing.Point(9, 97);
            this.checkIn1.Margin = new System.Windows.Forms.Padding(2);
            this.checkIn1.Name = "checkIn1";
            this.checkIn1.Size = new System.Drawing.Size(961, 470);
            this.checkIn1.TabIndex = 4;
            // 
            // checkOut1
            // 
            this.checkOut1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkOut1.Location = new System.Drawing.Point(9, 97);
            this.checkOut1.Margin = new System.Windows.Forms.Padding(2);
            this.checkOut1.Name = "checkOut1";
            this.checkOut1.Size = new System.Drawing.Size(962, 486);
            this.checkOut1.TabIndex = 3;
            // 
            // Info
            // 
            this.Info.BorderRadius = 15;
            this.Info.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Info.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Info.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Info.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Info.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Info.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info.ForeColor = System.Drawing.Color.Black;
            this.Info.Location = new System.Drawing.Point(619, 13);
            this.Info.Margin = new System.Windows.Forms.Padding(2);
            this.Info.Name = "Info";
            this.Info.Size = new System.Drawing.Size(119, 37);
            this.Info.TabIndex = 3;
            this.Info.Text = "Info";
            this.Info.Click += new System.EventHandler(this.Info_Click);
            // 
            // Receptionist_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(982, 578);
            this.Controls.Add(this.checkIn1);
            this.Controls.Add(this.checkOut1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btExitRecep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Receptionist_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receptionist_Form";
            this.Load += new System.EventHandler(this.Receptionist_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btExitRecep;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btCheckout;
        private Guna.UI2.WinForms.Guna2Button btCheckin;
        private System.Windows.Forms.Label lbNoticeRecep;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private _controllManager.CheckOut checkOut1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private _controllManager.CheckIn checkIn1;
        private Guna.UI2.WinForms.Guna2Button Info;
    }
}