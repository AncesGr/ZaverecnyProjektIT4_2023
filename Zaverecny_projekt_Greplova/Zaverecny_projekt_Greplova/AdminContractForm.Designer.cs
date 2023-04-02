namespace Zaverecny_projekt_Greplova
{
    partial class AdminContractForm
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
            this.lvAdmContractForm = new System.Windows.Forms.ListView();
            this.chContractName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chContractDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDeleteContract = new System.Windows.Forms.Button();
            this.btnAddContract = new System.Windows.Forms.Button();
            this.btnEditContract = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvAdmContractForm
            // 
            this.lvAdmContractForm.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chContractName,
            this.chContractDescription,
            this.chId});
            this.lvAdmContractForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.lvAdmContractForm.FullRowSelect = true;
            this.lvAdmContractForm.GridLines = true;
            this.lvAdmContractForm.HideSelection = false;
            this.lvAdmContractForm.Location = new System.Drawing.Point(0, 0);
            this.lvAdmContractForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvAdmContractForm.Name = "lvAdmContractForm";
            this.lvAdmContractForm.Size = new System.Drawing.Size(605, 450);
            this.lvAdmContractForm.TabIndex = 6;
            this.lvAdmContractForm.UseCompatibleStateImageBehavior = false;
            this.lvAdmContractForm.View = System.Windows.Forms.View.Details;
            // 
            // chContractName
            // 
            this.chContractName.DisplayIndex = 1;
            this.chContractName.Text = "Contract Name";
            this.chContractName.Width = 120;
            // 
            // chContractDescription
            // 
            this.chContractDescription.DisplayIndex = 2;
            this.chContractDescription.Text = "Contract Description";
            this.chContractDescription.Width = 300;
            // 
            // chId
            // 
            this.chId.DisplayIndex = 0;
            this.chId.Text = "Id";
            this.chId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.chId.Width = 95;
            // 
            // btnDeleteContract
            // 
            this.btnDeleteContract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDeleteContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDeleteContract.Location = new System.Drawing.Point(625, 124);
            this.btnDeleteContract.Name = "btnDeleteContract";
            this.btnDeleteContract.Size = new System.Drawing.Size(89, 36);
            this.btnDeleteContract.TabIndex = 11;
            this.btnDeleteContract.Text = "Delete";
            this.btnDeleteContract.UseVisualStyleBackColor = false;
            this.btnDeleteContract.Click += new System.EventHandler(this.btnDeleteContract_Click);
            // 
            // btnAddContract
            // 
            this.btnAddContract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAddContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAddContract.Location = new System.Drawing.Point(625, 68);
            this.btnAddContract.Name = "btnAddContract";
            this.btnAddContract.Size = new System.Drawing.Size(89, 36);
            this.btnAddContract.TabIndex = 10;
            this.btnAddContract.Text = "Add";
            this.btnAddContract.UseVisualStyleBackColor = false;
            this.btnAddContract.Click += new System.EventHandler(this.btnAddContract_Click);
            // 
            // btnEditContract
            // 
            this.btnEditContract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEditContract.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnEditContract.Location = new System.Drawing.Point(625, 12);
            this.btnEditContract.Name = "btnEditContract";
            this.btnEditContract.Size = new System.Drawing.Size(89, 36);
            this.btnEditContract.TabIndex = 9;
            this.btnEditContract.Text = "Edit";
            this.btnEditContract.UseVisualStyleBackColor = false;
            this.btnEditContract.Click += new System.EventHandler(this.btnEditContract_Click);
            // 
            // AdminContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.btnDeleteContract);
            this.Controls.Add(this.btnAddContract);
            this.Controls.Add(this.btnEditContract);
            this.Controls.Add(this.lvAdmContractForm);
            this.Name = "AdminContractForm";
            this.Text = "Contract";
            this.Load += new System.EventHandler(this.AdminContractForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvAdmContractForm;
        private System.Windows.Forms.ColumnHeader chContractName;
        private System.Windows.Forms.ColumnHeader chContractDescription;
        private System.Windows.Forms.ColumnHeader chId;
        private System.Windows.Forms.Button btnDeleteContract;
        private System.Windows.Forms.Button btnAddContract;
        private System.Windows.Forms.Button btnEditContract;
    }
}