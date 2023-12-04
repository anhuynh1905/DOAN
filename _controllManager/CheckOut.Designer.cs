namespace DOAN._controllManager
{
    partial class CheckOut
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbCheckout = new System.Windows.Forms.Label();
            this.lbSearch = new System.Windows.Forms.Label();
            this.txtEnter = new Guna.UI2.WinForms.Guna2TextBox();
            this.dataCheckOut = new Guna.UI2.WinForms.Guna2DataGridView();
            this.lbNameGuest = new System.Windows.Forms.Label();
            this.txtNameGuest = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbRoomGuest = new System.Windows.Forms.Label();
            this.txtRoomGuest = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTimeCOut = new System.Windows.Forms.Label();
            this.timeCheckOut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btConfirmCOut = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataCheckOut)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCheckout
            // 
            this.lbCheckout.AutoSize = true;
            this.lbCheckout.Font = new System.Drawing.Font("Century", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCheckout.Location = new System.Drawing.Point(394, 0);
            this.lbCheckout.Name = "lbCheckout";
            this.lbCheckout.Size = new System.Drawing.Size(201, 40);
            this.lbCheckout.TabIndex = 0;
            this.lbCheckout.Text = "Check_Out";
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSearch.Location = new System.Drawing.Point(0, 43);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(122, 20);
            this.lbSearch.TabIndex = 1;
            this.lbSearch.Text = "Search Name";
            // 
            // txtEnter
            // 
            this.txtEnter.BorderColor = System.Drawing.Color.Silver;
            this.txtEnter.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEnter.DefaultText = "";
            this.txtEnter.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEnter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEnter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnter.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEnter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEnter.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtEnter.ForeColor = System.Drawing.Color.Black;
            this.txtEnter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEnter.Location = new System.Drawing.Point(4, 68);
            this.txtEnter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.PasswordChar = '\0';
            this.txtEnter.PlaceholderText = "Enter Fullname";
            this.txtEnter.SelectedText = "";
            this.txtEnter.Size = new System.Drawing.Size(186, 47);
            this.txtEnter.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtEnter.TabIndex = 2;
            this.txtEnter.TextChanged += new System.EventHandler(this.txtEnter_TextChanged);
            // 
            // dataCheckOut
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dataCheckOut.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataCheckOut.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataCheckOut.ColumnHeadersHeight = 4;
            this.dataCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataCheckOut.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataCheckOut.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataCheckOut.Location = new System.Drawing.Point(4, 124);
            this.dataCheckOut.Name = "dataCheckOut";
            this.dataCheckOut.RowHeadersVisible = false;
            this.dataCheckOut.RowHeadersWidth = 51;
            this.dataCheckOut.RowTemplate.Height = 24;
            this.dataCheckOut.Size = new System.Drawing.Size(1022, 294);
            this.dataCheckOut.TabIndex = 3;
            this.dataCheckOut.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataCheckOut.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataCheckOut.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataCheckOut.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataCheckOut.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataCheckOut.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataCheckOut.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataCheckOut.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataCheckOut.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataCheckOut.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataCheckOut.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataCheckOut.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataCheckOut.ThemeStyle.HeaderStyle.Height = 4;
            this.dataCheckOut.ThemeStyle.ReadOnly = false;
            this.dataCheckOut.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataCheckOut.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataCheckOut.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataCheckOut.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataCheckOut.ThemeStyle.RowsStyle.Height = 24;
            this.dataCheckOut.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataCheckOut.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataCheckOut.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataCheckOut_CellContentClick);
            // 
            // lbNameGuest
            // 
            this.lbNameGuest.AutoSize = true;
            this.lbNameGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbNameGuest.Location = new System.Drawing.Point(238, 43);
            this.lbNameGuest.Name = "lbNameGuest";
            this.lbNameGuest.Size = new System.Drawing.Size(57, 20);
            this.lbNameGuest.TabIndex = 1;
            this.lbNameGuest.Text = "Name";
            // 
            // txtNameGuest
            // 
            this.txtNameGuest.BorderColor = System.Drawing.Color.Silver;
            this.txtNameGuest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNameGuest.DefaultText = "";
            this.txtNameGuest.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNameGuest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNameGuest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameGuest.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNameGuest.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameGuest.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtNameGuest.ForeColor = System.Drawing.Color.Black;
            this.txtNameGuest.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNameGuest.Location = new System.Drawing.Point(242, 68);
            this.txtNameGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNameGuest.Name = "txtNameGuest";
            this.txtNameGuest.PasswordChar = '\0';
            this.txtNameGuest.PlaceholderText = "Fullname";
            this.txtNameGuest.ReadOnly = true;
            this.txtNameGuest.SelectedText = "";
            this.txtNameGuest.Size = new System.Drawing.Size(131, 46);
            this.txtNameGuest.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtNameGuest.TabIndex = 2;
            // 
            // lbRoomGuest
            // 
            this.lbRoomGuest.AutoSize = true;
            this.lbRoomGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbRoomGuest.Location = new System.Drawing.Point(409, 43);
            this.lbRoomGuest.Name = "lbRoomGuest";
            this.lbRoomGuest.Size = new System.Drawing.Size(57, 20);
            this.lbRoomGuest.TabIndex = 1;
            this.lbRoomGuest.Text = "Room";
            this.lbRoomGuest.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtRoomGuest
            // 
            this.txtRoomGuest.BorderColor = System.Drawing.Color.Silver;
            this.txtRoomGuest.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomGuest.DefaultText = "";
            this.txtRoomGuest.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRoomGuest.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRoomGuest.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomGuest.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRoomGuest.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomGuest.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtRoomGuest.ForeColor = System.Drawing.Color.Black;
            this.txtRoomGuest.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRoomGuest.Location = new System.Drawing.Point(413, 66);
            this.txtRoomGuest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoomGuest.Name = "txtRoomGuest";
            this.txtRoomGuest.PasswordChar = '\0';
            this.txtRoomGuest.PlaceholderText = "RoomID";
            this.txtRoomGuest.ReadOnly = true;
            this.txtRoomGuest.SelectedText = "";
            this.txtRoomGuest.Size = new System.Drawing.Size(154, 48);
            this.txtRoomGuest.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtRoomGuest.TabIndex = 2;
            // 
            // lbTimeCOut
            // 
            this.lbTimeCOut.AutoSize = true;
            this.lbTimeCOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.lbTimeCOut.Location = new System.Drawing.Point(604, 43);
            this.lbTimeCOut.Name = "lbTimeCOut";
            this.lbTimeCOut.Size = new System.Drawing.Size(148, 20);
            this.lbTimeCOut.TabIndex = 4;
            this.lbTimeCOut.Text = "Time Check_Out";
            // 
            // timeCheckOut
            // 
            this.timeCheckOut.Checked = true;
            this.timeCheckOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.timeCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.timeCheckOut.Location = new System.Drawing.Point(604, 66);
            this.timeCheckOut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.timeCheckOut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.timeCheckOut.Name = "timeCheckOut";
            this.timeCheckOut.Size = new System.Drawing.Size(170, 47);
            this.timeCheckOut.TabIndex = 5;
            this.timeCheckOut.Value = new System.DateTime(2023, 12, 2, 9, 22, 50, 394);
            // 
            // btConfirmCOut
            // 
            this.btConfirmCOut.BorderRadius = 15;
            this.btConfirmCOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btConfirmCOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btConfirmCOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btConfirmCOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btConfirmCOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btConfirmCOut.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfirmCOut.ForeColor = System.Drawing.Color.Black;
            this.btConfirmCOut.Location = new System.Drawing.Point(818, 66);
            this.btConfirmCOut.Name = "btConfirmCOut";
            this.btConfirmCOut.Size = new System.Drawing.Size(162, 45);
            this.btConfirmCOut.TabIndex = 6;
            this.btConfirmCOut.Text = "Check_Out";
            this.btConfirmCOut.Click += new System.EventHandler(this.btConfirmCOut_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // CheckOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.Controls.Add(this.btConfirmCOut);
            this.Controls.Add(this.timeCheckOut);
            this.Controls.Add(this.lbTimeCOut);
            this.Controls.Add(this.dataCheckOut);
            this.Controls.Add(this.txtRoomGuest);
            this.Controls.Add(this.lbRoomGuest);
            this.Controls.Add(this.txtNameGuest);
            this.Controls.Add(this.lbNameGuest);
            this.Controls.Add(this.txtEnter);
            this.Controls.Add(this.lbSearch);
            this.Controls.Add(this.lbCheckout);
            this.Name = "CheckOut";
            this.Size = new System.Drawing.Size(1043, 436);
            this.Load += new System.EventHandler(this.CheckOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCheckOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCheckout;
        private System.Windows.Forms.Label lbSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtEnter;
        private Guna.UI2.WinForms.Guna2DataGridView dataCheckOut;
        private System.Windows.Forms.Label lbNameGuest;
        private Guna.UI2.WinForms.Guna2TextBox txtNameGuest;
        private System.Windows.Forms.Label lbRoomGuest;
        private Guna.UI2.WinForms.Guna2TextBox txtRoomGuest;
        private System.Windows.Forms.Label lbTimeCOut;
        private Guna.UI2.WinForms.Guna2DateTimePicker timeCheckOut;
        private Guna.UI2.WinForms.Guna2Button btConfirmCOut;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
