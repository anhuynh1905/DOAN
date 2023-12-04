using System.Windows.Forms;

namespace DOAN
{
    partial class Guest_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Guest_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.BookBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseRoom1DataSet = new DOAN.DatabaseRoom1DataSet();
            this.roomsTableAdapter = new DOAN.DatabaseRoom1DataSetTableAdapters.roomsTableAdapter();
            this.CheckOut = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGribView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.roomsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseRoom1DataSet1 = new DOAN.DatabaseRoom1DataSet1();
            this.roomsTableAdapter1 = new DOAN.DatabaseRoom1DataSet1TableAdapters.roomsTableAdapter();
            this.fNameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lNameBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.RoomBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.CheckIn = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.booked = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseRoom1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGribView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseRoom1DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.Location = new System.Drawing.Point(12, 12);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(35, 21);
            this.guna2ImageButton1.TabIndex = 0;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(366, 6);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(300, 27);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Hotel Room Booking Menu";
            // 
            // BookBtn
            // 
            this.BookBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BookBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BookBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BookBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BookBtn.FillColor = System.Drawing.Color.DarkGoldenrod;
            this.BookBtn.Font = new System.Drawing.Font("Modern No. 20", 12F);
            this.BookBtn.ForeColor = System.Drawing.Color.White;
            this.BookBtn.Location = new System.Drawing.Point(871, 88);
            this.BookBtn.Name = "BookBtn";
            this.BookBtn.Size = new System.Drawing.Size(65, 36);
            this.BookBtn.TabIndex = 4;
            this.BookBtn.Text = "Book";
            this.BookBtn.Click += new System.EventHandler(this.Book_Click);
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(636, 133);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(68, 20);
            this.guna2HtmlLabel2.TabIndex = 6;
            this.guna2HtmlLabel2.Text = "Check in";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(636, 62);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(75, 20);
            this.guna2HtmlLabel3.TabIndex = 7;
            this.guna2HtmlLabel3.Text = "Check out";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "rooms";
            this.roomsBindingSource.DataSource = this.databaseRoom1DataSet;
            // 
            // databaseRoom1DataSet
            // 
            this.databaseRoom1DataSet.DataSetName = "DatabaseRoom1DataSet";
            this.databaseRoom1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // CheckOut
            // 
            this.CheckOut.Checked = true;
            this.CheckOut.CustomFormat = "dd/MM/yyyy";
            this.CheckOut.FillColor = System.Drawing.Color.White;
            this.CheckOut.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.CheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CheckOut.Location = new System.Drawing.Point(636, 88);
            this.CheckOut.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.CheckOut.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Size = new System.Drawing.Size(203, 36);
            this.CheckOut.TabIndex = 10;
            this.CheckOut.Value = new System.DateTime(2023, 12, 4, 14, 0, 24, 409);
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // bedDataGridViewTextBoxColumn
            // 
            this.bedDataGridViewTextBoxColumn.DataPropertyName = "bed";
            this.bedDataGridViewTextBoxColumn.HeaderText = "bed";
            this.bedDataGridViewTextBoxColumn.Name = "bedDataGridViewTextBoxColumn";
            // 
            // roomTypeDataGridViewTextBoxColumn
            // 
            this.roomTypeDataGridViewTextBoxColumn.DataPropertyName = "roomType";
            this.roomTypeDataGridViewTextBoxColumn.HeaderText = "roomType";
            this.roomTypeDataGridViewTextBoxColumn.Name = "roomTypeDataGridViewTextBoxColumn";
            // 
            // roomNoDataGridViewTextBoxColumn
            // 
            this.roomNoDataGridViewTextBoxColumn.DataPropertyName = "roomNo";
            this.roomNoDataGridViewTextBoxColumn.HeaderText = "roomNo";
            this.roomNoDataGridViewTextBoxColumn.Name = "roomNoDataGridViewTextBoxColumn";
            // 
            // DataGribView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGribView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGribView.AutoGenerateColumns = false;
            this.DataGribView.BackgroundColor = System.Drawing.Color.AliceBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Modern No. 20", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGribView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGribView.ColumnHeadersHeight = 16;
            this.DataGribView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGribView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNoDataGridViewTextBoxColumn,
            this.roomTypeDataGridViewTextBoxColumn,
            this.bedDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.booked});
            this.DataGribView.DataSource = this.roomsBindingSource1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGribView.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGribView.GridColor = System.Drawing.Color.White;
            this.DataGribView.Location = new System.Drawing.Point(12, 66);
            this.DataGribView.Name = "DataGribView";
            this.DataGribView.RowHeadersVisible = false;
            this.DataGribView.Size = new System.Drawing.Size(564, 476);
            this.DataGribView.TabIndex = 9;
            this.DataGribView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGribView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGribView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGribView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGribView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGribView.ThemeStyle.BackColor = System.Drawing.Color.AliceBlue;
            this.DataGribView.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.DataGribView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.DataGribView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGribView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Modern No. 20", 8.25F);
            this.DataGribView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGribView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGribView.ThemeStyle.HeaderStyle.Height = 16;
            this.DataGribView.ThemeStyle.ReadOnly = false;
            this.DataGribView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGribView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGribView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.DataGribView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGribView.ThemeStyle.RowsStyle.Height = 22;
            this.DataGribView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGribView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // roomsBindingSource1
            // 
            this.roomsBindingSource1.DataMember = "rooms";
            this.roomsBindingSource1.DataSource = this.databaseRoom1DataSet1;
            // 
            // databaseRoom1DataSet1
            // 
            this.databaseRoom1DataSet1.DataSetName = "DatabaseRoom1DataSet1";
            this.databaseRoom1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsTableAdapter1
            // 
            this.roomsTableAdapter1.ClearBeforeFill = true;
            // 
            // fNameBox
            // 
            this.fNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fNameBox.DefaultText = "";
            this.fNameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fNameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fNameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fNameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fNameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fNameBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.fNameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.fNameBox.Location = new System.Drawing.Point(636, 236);
            this.fNameBox.Name = "fNameBox";
            this.fNameBox.PasswordChar = '\0';
            this.fNameBox.PlaceholderText = "";
            this.fNameBox.SelectedText = "";
            this.fNameBox.Size = new System.Drawing.Size(203, 32);
            this.fNameBox.TabIndex = 11;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(636, 210);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(86, 20);
            this.guna2HtmlLabel4.TabIndex = 12;
            this.guna2HtmlLabel4.Text = "First Name";
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(636, 279);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(82, 20);
            this.guna2HtmlLabel5.TabIndex = 14;
            this.guna2HtmlLabel5.Text = "Last Name";
            // 
            // lNameBox
            // 
            this.lNameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lNameBox.DefaultText = "";
            this.lNameBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lNameBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lNameBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lNameBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lNameBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lNameBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lNameBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lNameBox.Location = new System.Drawing.Point(636, 305);
            this.lNameBox.Name = "lNameBox";
            this.lNameBox.PasswordChar = '\0';
            this.lNameBox.PlaceholderText = "";
            this.lNameBox.SelectedText = "";
            this.lNameBox.Size = new System.Drawing.Size(203, 32);
            this.lNameBox.TabIndex = 13;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold);
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(636, 349);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(44, 20);
            this.guna2HtmlLabel6.TabIndex = 16;
            this.guna2HtmlLabel6.Text = "Room ";
            // 
            // RoomBox
            // 
            this.RoomBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RoomBox.DefaultText = "";
            this.RoomBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RoomBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RoomBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RoomBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RoomBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RoomBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomBox.Location = new System.Drawing.Point(636, 375);
            this.RoomBox.Name = "RoomBox";
            this.RoomBox.PasswordChar = '\0';
            this.RoomBox.PlaceholderText = "";
            this.RoomBox.SelectedText = "";
            this.RoomBox.Size = new System.Drawing.Size(203, 32);
            this.RoomBox.TabIndex = 15;
            // 
            // CheckIn
            // 
            this.CheckIn.Checked = true;
            this.CheckIn.CustomFormat = "dd/MM/yyyy";
            this.CheckIn.FillColor = System.Drawing.Color.White;
            this.CheckIn.Font = new System.Drawing.Font("Modern No. 20", 10F);
            this.CheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.CheckIn.Location = new System.Drawing.Point(636, 159);
            this.CheckIn.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.CheckIn.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.CheckIn.Name = "CheckIn";
            this.CheckIn.Size = new System.Drawing.Size(203, 36);
            this.CheckIn.TabIndex = 17;
            this.CheckIn.Value = new System.DateTime(2023, 12, 4, 14, 0, 24, 409);
            // 
            // booked
            // 
            this.booked.DataPropertyName = "booked";
            this.booked.HeaderText = "booked";
            this.booked.Name = "booked";
            // 
            // Guest_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(948, 655);
            this.Controls.Add(this.CheckIn);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.RoomBox);
            this.Controls.Add(this.guna2HtmlLabel5);
            this.Controls.Add(this.lNameBox);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.fNameBox);
            this.Controls.Add(this.CheckOut);
            this.Controls.Add(this.DataGribView);
            this.Controls.Add(this.guna2HtmlLabel3);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.BookBtn);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.guna2ImageButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Guest_Form";
            this.Text = "Guest_Form";
            this.Load += new System.EventHandler(this.Guest_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseRoom1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGribView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseRoom1DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button BookBtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private DatabaseRoom1DataSet databaseRoom1DataSet;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private DatabaseRoom1DataSetTableAdapters.roomsTableAdapter roomsTableAdapter;
        private Guna.UI2.WinForms.Guna2DateTimePicker CheckOut;
        private Guna.UI2.WinForms.Guna2DataGridView DataGribView;
        private DataGridViewTextBoxColumn roomNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bedDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DatabaseRoom1DataSet1 databaseRoom1DataSet1;
        private BindingSource roomsBindingSource1;
        private DatabaseRoom1DataSet1TableAdapters.roomsTableAdapter roomsTableAdapter1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2TextBox fNameBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2TextBox lNameBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2TextBox RoomBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker CheckIn;
        private DataGridViewTextBoxColumn booked;
    }
}