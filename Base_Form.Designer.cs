namespace DOAN
{
    partial class Base_Form
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
            this.btKH.Location = new System.Drawing.Point(315, 81);
            this.btKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btKH.Name = "btKH";
            this.btKH.Size = new System.Drawing.Size(142, 58);
            this.btKH.TabIndex = 4;
            this.btKH.Text = "Guest";
            this.btKH.UseVisualStyleBackColor = true;
            this.btKH.Click += new System.EventHandler(this.btKH_Click);
            // 
            // btNVKS
            // 
            this.btNVKS.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btNVKS.Location = new System.Drawing.Point(41, 81);
            this.btNVKS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btNVKS.Name = "btNVKS";
            this.btNVKS.Size = new System.Drawing.Size(170, 58);
            this.btNVKS.TabIndex = 3;
            this.btNVKS.Text = "Hotel Staff";
            this.btNVKS.UseVisualStyleBackColor = true;
            this.btNVKS.Click += new System.EventHandler(this.btNVKS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(34, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "Please select a function";
            // 
            // Base_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 182);
            this.Controls.Add(this.btKH);
            this.Controls.Add(this.btNVKS);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Base_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btKH;
        private System.Windows.Forms.Button btNVKS;
        private System.Windows.Forms.Label label1;
    }
}