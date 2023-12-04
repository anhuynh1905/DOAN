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
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseRoom1DataSet)).BeginInit();
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
    }
}