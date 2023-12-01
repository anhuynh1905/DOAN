namespace DOAN
{
    partial class Manager_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager_Form));
            this.btExitManager = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btView = new Guna.UI2.WinForms.Guna2Button();
            this.btManage = new Guna.UI2.WinForms.Guna2Button();
            this.lbNotice = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.roomManager1 = new DOAN._controllManager.RoomManager();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btExitManager
            // 
            this.btExitManager.BorderRadius = 18;
            this.btExitManager.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btExitManager.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btExitManager.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btExitManager.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btExitManager.FillColor = System.Drawing.Color.Silver;
            this.btExitManager.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btExitManager.ForeColor = System.Drawing.Color.White;
            this.btExitManager.Image = ((System.Drawing.Image)(resources.GetObject("btExitManager.Image")));
            this.btExitManager.ImageSize = new System.Drawing.Size(30, 30);
            this.btExitManager.Location = new System.Drawing.Point(12, 12);
            this.btExitManager.Name = "btExitManager";
            this.btExitManager.Size = new System.Drawing.Size(40, 40);
            this.btExitManager.TabIndex = 0;
            this.btExitManager.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btView);
            this.panel1.Controls.Add(this.btManage);
            this.panel1.Controls.Add(this.lbNotice);
            this.panel1.Location = new System.Drawing.Point(100, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 76);
            this.panel1.TabIndex = 1;
            // 
            // btView
            // 
            this.btView.BorderRadius = 15;
            this.btView.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btView.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btView.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btView.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btView.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btView.ForeColor = System.Drawing.Color.Black;
            this.btView.Location = new System.Drawing.Point(713, 15);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(196, 45);
            this.btView.TabIndex = 2;
            this.btView.Text = "View Reports";
            
            // 
            // btManage
            // 
            this.btManage.BorderRadius = 15;
            this.btManage.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btManage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btManage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btManage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btManage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btManage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btManage.Font = new System.Drawing.Font("Century", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btManage.ForeColor = System.Drawing.Color.Black;
            this.btManage.Location = new System.Drawing.Point(474, 15);
            this.btManage.Name = "btManage";
            this.btManage.Size = new System.Drawing.Size(215, 45);
            this.btManage.TabIndex = 1;
            this.btManage.Text = "Room Manage";
            this.btManage.Click += new System.EventHandler(this.btManage_Click);
            // 
            // lbNotice
            // 
            this.lbNotice.AutoSize = true;
            this.lbNotice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbNotice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbNotice.Font = new System.Drawing.Font("Corbel", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNotice.Location = new System.Drawing.Point(13, 15);
            this.lbNotice.Name = "lbNotice";
            this.lbNotice.Size = new System.Drawing.Size(414, 47);
            this.lbNotice.TabIndex = 0;
            this.lbNotice.Text = "Managerment Functions";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.roomManager1);
            this.panel2.Location = new System.Drawing.Point(9, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1043, 447);
            this.panel2.TabIndex = 2;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // roomManager1
            // 
            this.roomManager1.BackColor = System.Drawing.Color.Silver;
            this.roomManager1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.roomManager1.Location = new System.Drawing.Point(-1, -1);
            this.roomManager1.Name = "roomManager1";
            this.roomManager1.Size = new System.Drawing.Size(1043, 447);
            this.roomManager1.TabIndex = 0;
            // 
            // Manager_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1070, 553);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btExitManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manager_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager_Form";
            this.Load += new System.EventHandler(this.Manager_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btExitManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbNotice;
        private Guna.UI2.WinForms.Guna2Button btView;
        private Guna.UI2.WinForms.Guna2Button btManage;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private _controllManager.RoomManager roomManager1;
    }
}