namespace Zaverecny_projekt_Greplova
{
    partial class AdminWorkTypeAdd
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
            this.btnAdmWorkTypeAddOK = new System.Windows.Forms.Button();
            this.txtAdmWorkTypeAddDescription = new System.Windows.Forms.RichTextBox();
            this.lblAdmWorkTypeAddDescription = new System.Windows.Forms.Label();
            this.txtAdmWorkTypeAddName = new System.Windows.Forms.TextBox();
            this.lblAdmWorkTypeAddName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdmWorkTypeAddOK
            // 
            this.btnAdmWorkTypeAddOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAdmWorkTypeAddOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdmWorkTypeAddOK.Location = new System.Drawing.Point(245, 202);
            this.btnAdmWorkTypeAddOK.Name = "btnAdmWorkTypeAddOK";
            this.btnAdmWorkTypeAddOK.Size = new System.Drawing.Size(94, 42);
            this.btnAdmWorkTypeAddOK.TabIndex = 20;
            this.btnAdmWorkTypeAddOK.Text = "OK";
            this.btnAdmWorkTypeAddOK.UseVisualStyleBackColor = false;
            this.btnAdmWorkTypeAddOK.Click += new System.EventHandler(this.btnAdmWorkTypeAddOK_Click);
            // 
            // txtAdmWorkTypeAddDescription
            // 
            this.txtAdmWorkTypeAddDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAdmWorkTypeAddDescription.Location = new System.Drawing.Point(28, 128);
            this.txtAdmWorkTypeAddDescription.Name = "txtAdmWorkTypeAddDescription";
            this.txtAdmWorkTypeAddDescription.Size = new System.Drawing.Size(311, 54);
            this.txtAdmWorkTypeAddDescription.TabIndex = 19;
            this.txtAdmWorkTypeAddDescription.Text = "";
            // 
            // lblAdmWorkTypeAddDescription
            // 
            this.lblAdmWorkTypeAddDescription.AutoSize = true;
            this.lblAdmWorkTypeAddDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdmWorkTypeAddDescription.Location = new System.Drawing.Point(25, 98);
            this.lblAdmWorkTypeAddDescription.Name = "lblAdmWorkTypeAddDescription";
            this.lblAdmWorkTypeAddDescription.Size = new System.Drawing.Size(203, 25);
            this.lblAdmWorkTypeAddDescription.TabIndex = 18;
            this.lblAdmWorkTypeAddDescription.Text = "WorkType description";
            // 
            // txtAdmWorkTypeAddName
            // 
            this.txtAdmWorkTypeAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtAdmWorkTypeAddName.Location = new System.Drawing.Point(28, 59);
            this.txtAdmWorkTypeAddName.Name = "txtAdmWorkTypeAddName";
            this.txtAdmWorkTypeAddName.Size = new System.Drawing.Size(311, 30);
            this.txtAdmWorkTypeAddName.TabIndex = 17;
            // 
            // lblAdmWorkTypeAddName
            // 
            this.lblAdmWorkTypeAddName.AutoSize = true;
            this.lblAdmWorkTypeAddName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblAdmWorkTypeAddName.Location = new System.Drawing.Point(25, 30);
            this.lblAdmWorkTypeAddName.Name = "lblAdmWorkTypeAddName";
            this.lblAdmWorkTypeAddName.Size = new System.Drawing.Size(161, 25);
            this.lblAdmWorkTypeAddName.TabIndex = 16;
            this.lblAdmWorkTypeAddName.Text = "WorkType Name";
            // 
            // AdminWorkTypeAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 283);
            this.Controls.Add(this.btnAdmWorkTypeAddOK);
            this.Controls.Add(this.txtAdmWorkTypeAddDescription);
            this.Controls.Add(this.lblAdmWorkTypeAddDescription);
            this.Controls.Add(this.txtAdmWorkTypeAddName);
            this.Controls.Add(this.lblAdmWorkTypeAddName);
            this.Name = "AdminWorkTypeAdd";
            this.Text = "WorkType Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdmWorkTypeAddOK;
        private System.Windows.Forms.RichTextBox txtAdmWorkTypeAddDescription;
        private System.Windows.Forms.Label lblAdmWorkTypeAddDescription;
        private System.Windows.Forms.TextBox txtAdmWorkTypeAddName;
        private System.Windows.Forms.Label lblAdmWorkTypeAddName;
    }
}