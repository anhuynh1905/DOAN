namespace DOAN
{
    partial class Form2
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
            this.btKH = new System.Windows.Forms.Button();
            this.btNVKS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btKH
            // 
            this.btKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btKH.Location = new System.Drawing.Point(236, 58);
            this.btKH.Margin = new System.Windows.Forms.Padding(2);
            this.btKH.Name = "btKH";
            this.btKH.Size = new System.Drawing.Size(134, 64);
            this.btKH.TabIndex = 4;
            this.btKH.Text = "Khách hàng";
            this.btKH.UseVisualStyleBackColor = true;
            // 
            // btNVKS
            // 
            this.btNVKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btNVKS.Location = new System.Drawing.Point(14, 58);
            this.btNVKS.Margin = new System.Windows.Forms.Padding(2);
            this.btNVKS.Name = "btNVKS";
            this.btNVKS.Size = new System.Drawing.Size(144, 64);
            this.btNVKS.TabIndex = 3;
            this.btNVKS.Text = "Nhân viên KS";
            this.btNVKS.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mời bạn chọn chức năng";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 148);
            this.Controls.Add(this.btKH);
            this.Controls.Add(this.btNVKS);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btKH;
        private System.Windows.Forms.Button btNVKS;
        private System.Windows.Forms.Label label1;
    }
}