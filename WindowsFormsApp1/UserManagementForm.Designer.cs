namespace WindowsFormsApp1
{
    partial class UserManagementForm
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
            this.addUserBtn = new System.Windows.Forms.RadioButton();
            this.delUserBtn = new System.Windows.Forms.RadioButton();
            this.actionSelectLabel = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.phoneNoLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.userInfoLabel = new System.Windows.Forms.Label();
            this.emailErrorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addUserBtn
            // 
            this.addUserBtn.AutoSize = true;
            this.addUserBtn.Location = new System.Drawing.Point(182, 222);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(132, 29);
            this.addUserBtn.TabIndex = 0;
            this.addUserBtn.TabStop = true;
            this.addUserBtn.Text = "Add User";
            this.addUserBtn.UseVisualStyleBackColor = true;
            // 
            // delUserBtn
            // 
            this.delUserBtn.AutoSize = true;
            this.delUserBtn.Location = new System.Drawing.Point(182, 328);
            this.delUserBtn.Name = "delUserBtn";
            this.delUserBtn.Size = new System.Drawing.Size(156, 29);
            this.delUserBtn.TabIndex = 1;
            this.delUserBtn.TabStop = true;
            this.delUserBtn.Text = "Delete User";
            this.delUserBtn.UseVisualStyleBackColor = true;
            // 
            // actionSelectLabel
            // 
            this.actionSelectLabel.AutoSize = true;
            this.actionSelectLabel.Location = new System.Drawing.Point(177, 129);
            this.actionSelectLabel.Name = "actionSelectLabel";
            this.actionSelectLabel.Size = new System.Drawing.Size(174, 25);
            this.actionSelectLabel.TabIndex = 2;
            this.actionSelectLabel.Text = "Select an Action:";
            // 
            // submitBtn
            // 
            this.submitBtn.Location = new System.Drawing.Point(486, 673);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(297, 116);
            this.submitBtn.TabIndex = 3;
            this.submitBtn.Text = "Submit";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(636, 129);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(116, 25);
            this.firstNameLabel.TabIndex = 4;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(636, 268);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(115, 25);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Last Name";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(636, 410);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(65, 25);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email";
            // 
            // phoneNoLabel
            // 
            this.phoneNoLabel.AutoSize = true;
            this.phoneNoLabel.Location = new System.Drawing.Point(636, 529);
            this.phoneNoLabel.Name = "phoneNoLabel";
            this.phoneNoLabel.Size = new System.Drawing.Size(155, 25);
            this.phoneNoLabel.TabIndex = 7;
            this.phoneNoLabel.Text = "Phone Number";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(641, 196);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(321, 31);
            this.firstNameTextBox.TabIndex = 8;
            // 
            // phoneNoTextBox
            // 
            this.phoneNoTextBox.Location = new System.Drawing.Point(641, 593);
            this.phoneNoTextBox.Name = "phoneNoTextBox";
            this.phoneNoTextBox.Size = new System.Drawing.Size(321, 31);
            this.phoneNoTextBox.TabIndex = 9;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(641, 455);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(321, 31);
            this.emailTextBox.TabIndex = 10;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(641, 328);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(321, 31);
            this.lastNameTextBox.TabIndex = 11;
            // 
            // userInfoLabel
            // 
            this.userInfoLabel.AutoSize = true;
            this.userInfoLabel.Location = new System.Drawing.Point(636, 58);
            this.userInfoLabel.Name = "userInfoLabel";
            this.userInfoLabel.Size = new System.Drawing.Size(169, 25);
            this.userInfoLabel.TabIndex = 12;
            this.userInfoLabel.Text = "User Information";
            // 
            // emailErrorLabel
            // 
            this.emailErrorLabel.AutoSize = true;
            this.emailErrorLabel.Location = new System.Drawing.Point(1034, 455);
            this.emailErrorLabel.Name = "emailErrorLabel";
            this.emailErrorLabel.Size = new System.Drawing.Size(0, 25);
            this.emailErrorLabel.TabIndex = 13;
            this.emailErrorLabel.Visible = false;
            // 
            // UserManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1553, 836);
            this.Controls.Add(this.emailErrorLabel);
            this.Controls.Add(this.userInfoLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.phoneNoTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.phoneNoLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.submitBtn);
            this.Controls.Add(this.actionSelectLabel);
            this.Controls.Add(this.delUserBtn);
            this.Controls.Add(this.addUserBtn);
            this.Name = "UserManagementForm";
            this.Text = "UserManagementForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton addUserBtn;
        private System.Windows.Forms.RadioButton delUserBtn;
        private System.Windows.Forms.Label actionSelectLabel;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label phoneNoLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox phoneNoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label userInfoLabel;
        private System.Windows.Forms.Label emailErrorLabel;
    }
}