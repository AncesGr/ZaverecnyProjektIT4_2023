﻿namespace Zaverecny_projekt_Greplova
{
    partial class PasswordChangeForm
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
            this.txtPasswordChangeName = new System.Windows.Forms.TextBox();
            this.txtCurrentPassword = new System.Windows.Forms.TextBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblPasswordChangeName = new System.Windows.Forms.Label();
            this.lblCurrentPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.btnSubmitNewPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPasswordChangeName
            // 
            this.txtPasswordChangeName.Location = new System.Drawing.Point(50, 65);
            this.txtPasswordChangeName.Name = "txtPasswordChangeName";
            this.txtPasswordChangeName.Size = new System.Drawing.Size(100, 22);
            this.txtPasswordChangeName.TabIndex = 0;
            // 
            // txtCurrentPassword
            // 
            this.txtCurrentPassword.Location = new System.Drawing.Point(50, 175);
            this.txtCurrentPassword.Name = "txtCurrentPassword";
            this.txtCurrentPassword.Size = new System.Drawing.Size(100, 22);
            this.txtCurrentPassword.TabIndex = 1;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(50, 276);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(100, 22);
            this.txtNewPassword.TabIndex = 2;
            // 
            // lblPasswordChangeName
            // 
            this.lblPasswordChangeName.AutoSize = true;
            this.lblPasswordChangeName.Location = new System.Drawing.Point(69, 34);
            this.lblPasswordChangeName.Name = "lblPasswordChangeName";
            this.lblPasswordChangeName.Size = new System.Drawing.Size(70, 16);
            this.lblPasswordChangeName.TabIndex = 3;
            this.lblPasswordChangeName.Text = "Username";
            // 
            // lblCurrentPassword
            // 
            this.lblCurrentPassword.AutoSize = true;
            this.lblCurrentPassword.Location = new System.Drawing.Point(54, 138);
            this.lblCurrentPassword.Name = "lblCurrentPassword";
            this.lblCurrentPassword.Size = new System.Drawing.Size(111, 16);
            this.lblCurrentPassword.TabIndex = 4;
            this.lblCurrentPassword.Text = "Current password";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(54, 234);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(96, 16);
            this.lblNewPassword.TabIndex = 5;
            this.lblNewPassword.Text = "New password";
            // 
            // btnSubmitNewPassword
            // 
            this.btnSubmitNewPassword.Location = new System.Drawing.Point(57, 342);
            this.btnSubmitNewPassword.Name = "btnSubmitNewPassword";
            this.btnSubmitNewPassword.Size = new System.Drawing.Size(75, 23);
            this.btnSubmitNewPassword.TabIndex = 6;
            this.btnSubmitNewPassword.Text = "OK";
            this.btnSubmitNewPassword.UseVisualStyleBackColor = true;
            this.btnSubmitNewPassword.Click += new System.EventHandler(this.btnSubmitNewPassword_Click);
            // 
            // PasswordChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 450);
            this.Controls.Add(this.btnSubmitNewPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblCurrentPassword);
            this.Controls.Add(this.lblPasswordChangeName);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.txtCurrentPassword);
            this.Controls.Add(this.txtPasswordChangeName);
            this.Name = "PasswordChangeForm";
            this.Text = "PasswordChangeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPasswordChangeName;
        private System.Windows.Forms.TextBox txtCurrentPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblPasswordChangeName;
        private System.Windows.Forms.Label lblCurrentPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.Button btnSubmitNewPassword;
    }
}