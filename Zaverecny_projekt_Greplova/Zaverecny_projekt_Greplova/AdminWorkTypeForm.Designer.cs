namespace Zaverecny_projekt_Greplova
{
    partial class AdminWorkTypeForm
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
            this.lvAdmWorkTypeForm = new System.Windows.Forms.ListView();
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteWorkType = new System.Windows.Forms.Button();
            this.btnAddWorkType = new System.Windows.Forms.Button();
            this.btnEditWorkType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvAdmWorkTypeForm
            // 
            this.lvAdmWorkTypeForm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chName,
            this.chId,
            this.chDescription});
            this.lvAdmWorkTypeForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvAdmWorkTypeForm.FullRowSelect = true;
            this.lvAdmWorkTypeForm.GridLines = true;
            this.lvAdmWorkTypeForm.HideSelection = false;
            this.lvAdmWorkTypeForm.Location = new System.Drawing.Point(0, 0);
            this.lvAdmWorkTypeForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvAdmWorkTypeForm.Name = "lvAdmWorkTypeForm";
            this.lvAdmWorkTypeForm.Size = new System.Drawing.Size(318, 323);
            this.lvAdmWorkTypeForm.TabIndex = 8;
            this.lvAdmWorkTypeForm.UseCompatibleStateImageBehavior = false;
            this.lvAdmWorkTypeForm.View = System.Windows.Forms.View.Details;
            // 
            // chName
            // 
            this.chName.DisplayIndex = 1;
            this.chName.Text = "Name";
            this.chName.Width = 115;
            // 
            // chId
            // 
            this.chId.DisplayIndex = 0;
            this.chId.Text = "Id";
            this.chId.Width = 40;
            // 
            // chDescription
            // 
            this.chDescription.Text = "Description";
            this.chDescription.Width = 120;
            // 
            // btnDeleteWorkType
            // 
            this.btnDeleteWorkType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteWorkType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteWorkType.Location = new System.Drawing.Point(337, 124);
            this.btnDeleteWorkType.Name = "btnDeleteWorkType";
            this.btnDeleteWorkType.Size = new System.Drawing.Size(89, 36);
            this.btnDeleteWorkType.TabIndex = 11;
            this.btnDeleteWorkType.Text = "Delete";
            this.btnDeleteWorkType.UseVisualStyleBackColor = false;
            this.btnDeleteWorkType.Click += new System.EventHandler(this.btnDeleteWorkType_Click);
            // 
            // btnAddWorkType
            // 
            this.btnAddWorkType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddWorkType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddWorkType.Location = new System.Drawing.Point(337, 68);
            this.btnAddWorkType.Name = "btnAddWorkType";
            this.btnAddWorkType.Size = new System.Drawing.Size(89, 36);
            this.btnAddWorkType.TabIndex = 10;
            this.btnAddWorkType.Text = "Add";
            this.btnAddWorkType.UseVisualStyleBackColor = false;
            this.btnAddWorkType.Click += new System.EventHandler(this.btnAddWorkType_Click);
            // 
            // btnEditWorkType
            // 
            this.btnEditWorkType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEditWorkType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditWorkType.Location = new System.Drawing.Point(337, 12);
            this.btnEditWorkType.Name = "btnEditWorkType";
            this.btnEditWorkType.Size = new System.Drawing.Size(89, 36);
            this.btnEditWorkType.TabIndex = 9;
            this.btnEditWorkType.Text = "Edit";
            this.btnEditWorkType.UseVisualStyleBackColor = false;
            this.btnEditWorkType.Click += new System.EventHandler(this.btnEditWorkType_Click);
            // 
            // AdminWorkTypeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 323);
            this.Controls.Add(this.btnDeleteWorkType);
            this.Controls.Add(this.btnAddWorkType);
            this.Controls.Add(this.btnEditWorkType);
            this.Controls.Add(this.lvAdmWorkTypeForm);
            this.MinimumSize = new System.Drawing.Size(469, 370);
            this.Name = "AdminWorkTypeForm";
            this.Text = "Admin Work Type";
            this.Load += new System.EventHandler(this.AdminWorkTypeForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView lvAdmWorkTypeForm;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.ColumnHeader chDescription;
        private System.Windows.Forms.Button btnDeleteWorkType;
        private System.Windows.Forms.Button btnAddWorkType;
        private System.Windows.Forms.Button btnEditWorkType;
    }
}