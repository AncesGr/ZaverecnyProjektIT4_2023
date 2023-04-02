namespace Zaverecny_projekt_Greplova
{
    partial class AdminContractAdd
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
            this.btnAdmContractAddOK = new System.Windows.Forms.Button();
            this.txtAdmContractAddDescription = new System.Windows.Forms.RichTextBox();
            this.lblAdmContractAddDescription = new System.Windows.Forms.Label();
            this.txtAdmContractAddName = new System.Windows.Forms.TextBox();
            this.lblAdmContractAddName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdmContractAddOK
            // 
            this.btnAdmContractAddOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdmContractAddOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdmContractAddOK.Location = new System.Drawing.Point(244, 190);
            this.btnAdmContractAddOK.Name = "btnAdmContractAddOK";
            this.btnAdmContractAddOK.Size = new System.Drawing.Size(94, 42);
            this.btnAdmContractAddOK.TabIndex = 15;
            this.btnAdmContractAddOK.Text = "OK";
            this.btnAdmContractAddOK.UseVisualStyleBackColor = false;
            this.btnAdmContractAddOK.Click += new System.EventHandler(this.btnAdmContractAddOK_Click);
            // 
            // txtAdmContractAddDescription
            // 
            this.txtAdmContractAddDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAdmContractAddDescription.Location = new System.Drawing.Point(27, 116);
            this.txtAdmContractAddDescription.Name = "txtAdmContractAddDescription";
            this.txtAdmContractAddDescription.Size = new System.Drawing.Size(311, 54);
            this.txtAdmContractAddDescription.TabIndex = 14;
            this.txtAdmContractAddDescription.Text = "";
            // 
            // lblAdmContractAddDescription
            // 
            this.lblAdmContractAddDescription.AutoSize = true;
            this.lblAdmContractAddDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdmContractAddDescription.Location = new System.Drawing.Point(24, 86);
            this.lblAdmContractAddDescription.Name = "lblAdmContractAddDescription";
            this.lblAdmContractAddDescription.Size = new System.Drawing.Size(185, 25);
            this.lblAdmContractAddDescription.TabIndex = 13;
            this.lblAdmContractAddDescription.Text = "Contract description";
            // 
            // txtAdmContractAddName
            // 
            this.txtAdmContractAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAdmContractAddName.Location = new System.Drawing.Point(27, 47);
            this.txtAdmContractAddName.Name = "txtAdmContractAddName";
            this.txtAdmContractAddName.Size = new System.Drawing.Size(311, 30);
            this.txtAdmContractAddName.TabIndex = 12;
            // 
            // lblAdmContractAddName
            // 
            this.lblAdmContractAddName.AutoSize = true;
            this.lblAdmContractAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdmContractAddName.Location = new System.Drawing.Point(24, 18);
            this.lblAdmContractAddName.Name = "lblAdmContractAddName";
            this.lblAdmContractAddName.Size = new System.Drawing.Size(143, 25);
            this.lblAdmContractAddName.TabIndex = 11;
            this.lblAdmContractAddName.Text = "Contract Name";
            // 
            // AdminContractAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 261);
            this.Controls.Add(this.btnAdmContractAddOK);
            this.Controls.Add(this.txtAdmContractAddDescription);
            this.Controls.Add(this.lblAdmContractAddDescription);
            this.Controls.Add(this.txtAdmContractAddName);
            this.Controls.Add(this.lblAdmContractAddName);
            this.Name = "AdminContractAdd";
            this.Text = "Contract Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdmContractAddOK;
        private System.Windows.Forms.RichTextBox txtAdmContractAddDescription;
        private System.Windows.Forms.Label lblAdmContractAddDescription;
        private System.Windows.Forms.TextBox txtAdmContractAddName;
        private System.Windows.Forms.Label lblAdmContractAddName;
    }
}