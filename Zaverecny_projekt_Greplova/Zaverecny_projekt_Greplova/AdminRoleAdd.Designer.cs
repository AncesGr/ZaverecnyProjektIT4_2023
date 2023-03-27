namespace Zaverecny_projekt_Greplova
{
    partial class AdminRoleAdd
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
            this.btnAdmRoleAddOK = new System.Windows.Forms.Button();
            this.txtAdmRoleAddName = new System.Windows.Forms.TextBox();
            this.lblAdmRoleAddName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdmRoleAddOK
            // 
            this.btnAdmRoleAddOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdmRoleAddOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdmRoleAddOK.Location = new System.Drawing.Point(160, 112);
            this.btnAdmRoleAddOK.Name = "btnAdmRoleAddOK";
            this.btnAdmRoleAddOK.Size = new System.Drawing.Size(89, 36);
            this.btnAdmRoleAddOK.TabIndex = 10;
            this.btnAdmRoleAddOK.Text = "OK";
            this.btnAdmRoleAddOK.UseVisualStyleBackColor = false;
            this.btnAdmRoleAddOK.Click += new System.EventHandler(this.btnAdmRoleAddOK_Click);
            // 
            // txtAdmRoleAddName
            // 
            this.txtAdmRoleAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAdmRoleAddName.Location = new System.Drawing.Point(12, 54);
            this.txtAdmRoleAddName.Name = "txtAdmRoleAddName";
            this.txtAdmRoleAddName.Size = new System.Drawing.Size(237, 30);
            this.txtAdmRoleAddName.TabIndex = 9;
            // 
            // lblAdmRoleAddName
            // 
            this.lblAdmRoleAddName.AutoSize = true;
            this.lblAdmRoleAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdmRoleAddName.Location = new System.Drawing.Point(12, 25);
            this.lblAdmRoleAddName.Name = "lblAdmRoleAddName";
            this.lblAdmRoleAddName.Size = new System.Drawing.Size(105, 25);
            this.lblAdmRoleAddName.TabIndex = 8;
            this.lblAdmRoleAddName.Text = "Role name";
            // 
            // AdminRoleAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 172);
            this.Controls.Add(this.btnAdmRoleAddOK);
            this.Controls.Add(this.txtAdmRoleAddName);
            this.Controls.Add(this.lblAdmRoleAddName);
            this.MinimumSize = new System.Drawing.Size(296, 219);
            this.Name = "AdminRoleAdd";
            this.Text = "Role Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdmRoleAddOK;
        private System.Windows.Forms.TextBox txtAdmRoleAddName;
        private System.Windows.Forms.Label lblAdmRoleAddName;
    }
}