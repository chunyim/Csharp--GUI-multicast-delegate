namespace WindowsFormsApp1
{
    partial class Form1
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
            this.userManagementBtn = new System.Windows.Forms.Button();
            this.carManagementBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userManagementBtn
            // 
            this.userManagementBtn.Location = new System.Drawing.Point(256, 358);
            this.userManagementBtn.Name = "userManagementBtn";
            this.userManagementBtn.Size = new System.Drawing.Size(439, 188);
            this.userManagementBtn.TabIndex = 0;
            this.userManagementBtn.Text = "User Management";
            this.userManagementBtn.UseVisualStyleBackColor = true;
            this.userManagementBtn.Click += new System.EventHandler(this.userManagementBtn_Click);
            // 
            // carManagementBtn
            // 
            this.carManagementBtn.Location = new System.Drawing.Point(888, 358);
            this.carManagementBtn.Name = "carManagementBtn";
            this.carManagementBtn.Size = new System.Drawing.Size(424, 188);
            this.carManagementBtn.TabIndex = 1;
            this.carManagementBtn.Text = "Car Management";
            this.carManagementBtn.UseVisualStyleBackColor = true;
            this.carManagementBtn.Click += new System.EventHandler(this.carManagementBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 954);
            this.Controls.Add(this.carManagementBtn);
            this.Controls.Add(this.userManagementBtn);
            this.Name = "Form1";
            this.Text = "ABC Car Dealer Co. --- Registration System";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userManagementBtn;
        private System.Windows.Forms.Button carManagementBtn;
    }
}

