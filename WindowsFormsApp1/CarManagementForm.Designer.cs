namespace WindowsFormsApp1
{
    partial class CarManagementForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.modelLabel = new System.Windows.Forms.Label();
            this.mileageLabel = new System.Windows.Forms.Label();
            this.colorLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.mileageTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.submitAndPublishBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(337, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Car Specifications";
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Location = new System.Drawing.Point(342, 147);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(71, 25);
            this.modelLabel.TabIndex = 1;
            this.modelLabel.Text = "Model";
            // 
            // mileageLabel
            // 
            this.mileageLabel.AutoSize = true;
            this.mileageLabel.Location = new System.Drawing.Point(697, 147);
            this.mileageLabel.Name = "mileageLabel";
            this.mileageLabel.Size = new System.Drawing.Size(88, 25);
            this.mileageLabel.TabIndex = 2;
            this.mileageLabel.Text = "Mileage";
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Location = new System.Drawing.Point(342, 304);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(63, 25);
            this.colorLabel.TabIndex = 3;
            this.colorLabel.Text = "Color";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(697, 303);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(61, 25);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(342, 465);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(58, 25);
            this.yearLabel.TabIndex = 5;
            this.yearLabel.Text = "Year";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Location = new System.Drawing.Point(347, 206);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(234, 31);
            this.modelTextBox.TabIndex = 6;
            // 
            // mileageTextBox
            // 
            this.mileageTextBox.Location = new System.Drawing.Point(702, 206);
            this.mileageTextBox.Name = "mileageTextBox";
            this.mileageTextBox.Size = new System.Drawing.Size(234, 31);
            this.mileageTextBox.TabIndex = 7;
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(347, 371);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(234, 31);
            this.colorTextBox.TabIndex = 8;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(702, 371);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(234, 31);
            this.priceTextBox.TabIndex = 9;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(347, 525);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(234, 31);
            this.yearTextBox.TabIndex = 10;
            // 
            // submitAndPublishBtn
            // 
            this.submitAndPublishBtn.Location = new System.Drawing.Point(423, 637);
            this.submitAndPublishBtn.Name = "submitAndPublishBtn";
            this.submitAndPublishBtn.Size = new System.Drawing.Size(428, 109);
            this.submitAndPublishBtn.TabIndex = 11;
            this.submitAndPublishBtn.Text = "Register Car and Notify Users";
            this.submitAndPublishBtn.UseVisualStyleBackColor = true;
            this.submitAndPublishBtn.Click += new System.EventHandler(this.submitAndPublishBtn_Click);
            // 
            // CarManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1548, 896);
            this.Controls.Add(this.submitAndPublishBtn);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.mileageTextBox);
            this.Controls.Add(this.modelTextBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.mileageLabel);
            this.Controls.Add(this.modelLabel);
            this.Controls.Add(this.label1);
            this.Name = "CarManagementForm";
            this.Text = "CarManagementForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.Label mileageLabel;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.TextBox mileageTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Button submitAndPublishBtn;
    }
}