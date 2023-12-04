namespace DOAN._controllManager
{
    partial class RoomManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lbIDRoom = new System.Windows.Forms.Label();
            this.lbTypeRoom = new System.Windows.Forms.Label();
            this.txtIDRoom = new Guna.UI2.WinForms.Guna2TextBox();
            this.cbTypeRoom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbTypeBed = new System.Windows.Forms.Label();
            this.cbTypeBed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lbPriceRoom = new System.Windows.Forms.Label();
            this.txtPriceRoom = new Guna.UI2.WinForms.Guna2TextBox();
            this.btRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.btAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dataRoomManage = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataRoomManage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(204, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Room Manage";
            // 
            // lbIDRoom
            // 
            this.lbIDRoom.AutoSize = true;
            this.lbIDRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbIDRoom.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIDRoom.Location = new System.Drawing.Point(708, 52);
            this.lbIDRoom.Name = "lbIDRoom";
            this.lbIDRoom.Size = new System.Drawing.Size(80, 24);
            this.lbIDRoom.TabIndex = 2;
            this.lbIDRoom.Text = "ID Room";
            // 
            // lbTypeRoom
            // 
            this.lbTypeRoom.AutoSize = true;
            this.lbTypeRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbTypeRoom.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeRoom.Location = new System.Drawing.Point(708, 139);
            this.lbTypeRoom.Name = "lbTypeRoom";
            this.lbTypeRoom.Size = new System.Drawing.Size(99, 24);
            this.lbTypeRoom.TabIndex = 3;
            this.lbTypeRoom.Text = "Type Room";
            // 
            // txtIDRoom
            // 
            this.txtIDRoom.BorderRadius = 15;
            this.txtIDRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDRoom.DefaultText = "";
            this.txtIDRoom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIDRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIDRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDRoom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIDRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDRoom.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtIDRoom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIDRoom.Location = new System.Drawing.Point(712, 81);
            this.txtIDRoom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIDRoom.Name = "txtIDRoom";
            this.txtIDRoom.PasswordChar = '\0';
            this.txtIDRoom.PlaceholderText = "";
            this.txtIDRoom.SelectedText = "";
            this.txtIDRoom.Size = new System.Drawing.Size(260, 37);
            this.txtIDRoom.TabIndex = 4;
            // 
            // cbTypeRoom
            // 
            this.cbTypeRoom.BackColor = System.Drawing.Color.Transparent;
            this.cbTypeRoom.BorderRadius = 15;
            this.cbTypeRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTypeRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeRoom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTypeRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTypeRoom.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.cbTypeRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTypeRoom.ItemHeight = 30;
            this.cbTypeRoom.Items.AddRange(new object[] {
            "Hotel",
            "Villa"});
            this.cbTypeRoom.Location = new System.Drawing.Point(712, 166);
            this.cbTypeRoom.Name = "cbTypeRoom";
            this.cbTypeRoom.Size = new System.Drawing.Size(260, 36);
            this.cbTypeRoom.StartIndex = 0;
            this.cbTypeRoom.TabIndex = 5;
            // 
            // lbTypeBed
            // 
            this.lbTypeBed.AutoSize = true;
            this.lbTypeBed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbTypeBed.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTypeBed.Location = new System.Drawing.Point(708, 225);
            this.lbTypeBed.Name = "lbTypeBed";
            this.lbTypeBed.Size = new System.Drawing.Size(86, 24);
            this.lbTypeBed.TabIndex = 3;
            this.lbTypeBed.Text = "Type Bed";
            // 
            // cbTypeBed
            // 
            this.cbTypeBed.BackColor = System.Drawing.Color.Transparent;
            this.cbTypeBed.BorderRadius = 15;
            this.cbTypeBed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTypeBed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeBed.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTypeBed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTypeBed.Font = new System.Drawing.Font("Times New Roman", 10.2F);
            this.cbTypeBed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTypeBed.ItemHeight = 30;
            this.cbTypeBed.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Family"});
            this.cbTypeBed.Location = new System.Drawing.Point(712, 252);
            this.cbTypeBed.Name = "cbTypeBed";
            this.cbTypeBed.Size = new System.Drawing.Size(260, 36);
            this.cbTypeBed.StartIndex = 0;
            this.cbTypeBed.TabIndex = 5;
            // 
            // lbPriceRoom
            // 
            this.lbPriceRoom.AutoSize = true;
            this.lbPriceRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbPriceRoom.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriceRoom.Location = new System.Drawing.Point(708, 304);
            this.lbPriceRoom.Name = "lbPriceRoom";
            this.lbPriceRoom.Size = new System.Drawing.Size(50, 24);
            this.lbPriceRoom.TabIndex = 2;
            this.lbPriceRoom.Text = "Price";
            // 
            // txtPriceRoom
            // 
            this.txtPriceRoom.BorderRadius = 15;
            this.txtPriceRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPriceRoom.DefaultText = "";
            this.txtPriceRoom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPriceRoom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPriceRoom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceRoom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceRoom.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtPriceRoom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceRoom.Location = new System.Drawing.Point(712, 332);
            this.txtPriceRoom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPriceRoom.Name = "txtPriceRoom";
            this.txtPriceRoom.PasswordChar = '\0';
            this.txtPriceRoom.PlaceholderText = "";
            this.txtPriceRoom.SelectedText = "";
            this.txtPriceRoom.Size = new System.Drawing.Size(260, 37);
            this.txtPriceRoom.TabIndex = 4;
            // 
            // btRemove
            // 
            this.btRemove.BorderRadius = 18;
            this.btRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btRemove.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btRemove.ForeColor = System.Drawing.Color.Black;
            this.btRemove.Location = new System.Drawing.Point(782, 388);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(103, 45);
            this.btRemove.TabIndex = 6;
            this.btRemove.Text = "Remove";
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BorderRadius = 18;
            this.btUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btUpdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btUpdate.ForeColor = System.Drawing.Color.Black;
            this.btUpdate.Location = new System.Drawing.Point(652, 388);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(101, 45);
            this.btUpdate.TabIndex = 7;
            this.btUpdate.Text = "Update";
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btAdd
            // 
            this.btAdd.BorderRadius = 18;
            this.btAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btAdd.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btAdd.ForeColor = System.Drawing.Color.Black;
            this.btAdd.Location = new System.Drawing.Point(920, 388);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(100, 45);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "Add";
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // dataRoomManage
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataRoomManage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataRoomManage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataRoomManage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataRoomManage.ColumnHeadersHeight = 4;
            this.dataRoomManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataRoomManage.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataRoomManage.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataRoomManage.Location = new System.Drawing.Point(25, 81);
            this.dataRoomManage.Name = "dataRoomManage";
            this.dataRoomManage.RowHeadersVisible = false;
            this.dataRoomManage.RowHeadersWidth = 51;
            this.dataRoomManage.RowTemplate.Height = 24;
            this.dataRoomManage.Size = new System.Drawing.Size(619, 304);
            this.dataRoomManage.TabIndex = 8;
            this.dataRoomManage.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataRoomManage.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataRoomManage.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataRoomManage.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataRoomManage.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataRoomManage.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataRoomManage.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataRoomManage.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataRoomManage.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataRoomManage.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataRoomManage.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataRoomManage.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataRoomManage.ThemeStyle.HeaderStyle.Height = 4;
            this.dataRoomManage.ThemeStyle.ReadOnly = false;
            this.dataRoomManage.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataRoomManage.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataRoomManage.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dataRoomManage.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataRoomManage.ThemeStyle.RowsStyle.Height = 24;
            this.dataRoomManage.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataRoomManage.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // RoomManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.dataRoomManage);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.cbTypeBed);
            this.Controls.Add(this.cbTypeRoom);
            this.Controls.Add(this.lbTypeBed);
            this.Controls.Add(this.txtPriceRoom);
            this.Controls.Add(this.txtIDRoom);
            this.Controls.Add(this.lbPriceRoom);
            this.Controls.Add(this.lbTypeRoom);
            this.Controls.Add(this.lbIDRoom);
            this.Controls.Add(this.label1);
            this.Name = "RoomManager";
            this.Size = new System.Drawing.Size(1043, 436);
            this.Load += new System.EventHandler(this.RoomManager_Load);
            this.Enter += new System.EventHandler(this.RoomManager_Enter);
            this.Leave += new System.EventHandler(this.RoomManager_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dataRoomManage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbIDRoom;
        private System.Windows.Forms.Label lbTypeRoom;
        private Guna.UI2.WinForms.Guna2TextBox txtIDRoom;
        private Guna.UI2.WinForms.Guna2ComboBox cbTypeRoom;
        private System.Windows.Forms.Label lbTypeBed;
        private Guna.UI2.WinForms.Guna2ComboBox cbTypeBed;
        private System.Windows.Forms.Label lbPriceRoom;
        private Guna.UI2.WinForms.Guna2TextBox txtPriceRoom;
        private Guna.UI2.WinForms.Guna2Button btRemove;
        private Guna.UI2.WinForms.Guna2Button btUpdate;
        private Guna.UI2.WinForms.Guna2Button btAdd;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DataGridView dataRoomManage;
    }
}
