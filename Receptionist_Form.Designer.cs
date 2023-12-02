﻿namespace DOAN
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
            this.checkOut1 = new DOAN._controllManager.CheckOut();
            this.btExitRecep = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.checkIn1 = new DOAN._controllManager.CheckIn();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btCheckout);
            this.panel1.Controls.Add(this.btCheckin);
            this.panel1.Controls.Add(this.lbNoticeRecep);
            this.panel1.Location = new System.Drawing.Point(79, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(839, 78);
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
            this.btCheckout.Location = new System.Drawing.Point(646, 15);
            this.btCheckout.Name = "btCheckout";
            this.btCheckout.Size = new System.Drawing.Size(159, 45);
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
            this.btCheckin.Location = new System.Drawing.Point(468, 15);
            this.btCheckin.Name = "btCheckin";
            this.btCheckin.Size = new System.Drawing.Size(148, 45);
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
            this.lbNoticeRecep.Location = new System.Drawing.Point(28, 13);
            this.lbNoticeRecep.Name = "lbNoticeRecep";
            this.lbNoticeRecep.Size = new System.Drawing.Size(385, 47);
            this.lbNoticeRecep.TabIndex = 0;
            this.lbNoticeRecep.Text = "Receptionist Functions";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // checkOut1
            // 
            this.checkOut1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.checkOut1.Location = new System.Drawing.Point(12, 119);
            this.checkOut1.Name = "checkOut1";
            this.checkOut1.Size = new System.Drawing.Size(1043, 436);
            this.checkOut1.TabIndex = 3;
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
            this.btExitRecep.Location = new System.Drawing.Point(12, 12);
            this.btExitRecep.Name = "btExitRecep";
            this.btExitRecep.Size = new System.Drawing.Size(40, 40);
            this.btExitRecep.TabIndex = 1;
            this.btExitRecep.Click += new System.EventHandler(this.btExitRecep_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 30;
            this.guna2Elipse2.TargetControl = this;
            // 
            // checkIn1
            // 
            this.checkIn1.BackColor = System.Drawing.Color.LightGray;
            this.checkIn1.Location = new System.Drawing.Point(13, 119);
            this.checkIn1.Name = "checkIn1";
            this.checkIn1.Size = new System.Drawing.Size(1043, 436);
            this.checkIn1.TabIndex = 4;
            // 
            // Receptionist_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1068, 567);
            this.Controls.Add(this.checkIn1);
            this.Controls.Add(this.checkOut1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btExitRecep);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
    }
}