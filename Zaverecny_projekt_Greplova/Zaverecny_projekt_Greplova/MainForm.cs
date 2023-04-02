using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaverecny_projekt_Greplova
{
    public partial class MainForm : Form
    {
        public User User { get; set; }
        public Form FormLogin { get; set; } 
        public MainForm( User user, Form form)
        {
            InitializeComponent();
            User = user;
            FormLogin = form;
            
        }

        private void btnAdmUser_Click(object sender, EventArgs e)
        {
            AdminUserForm adminUserEdit = new AdminUserForm();
            adminUserEdit.ShowDialog();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormLogin.Close();
        }

        private void btnAdmRole_Click(object sender, EventArgs e)
        {
            AdminRolesForm adminRolesForm = new AdminRolesForm();
            adminRolesForm.ShowDialog();
        }

        private void btnAdmEmployee_Click(object sender, EventArgs e)
        {
            AdminEmployeeForm adminEmployeeForm = new AdminEmployeeForm();
            adminEmployeeForm.ShowDialog();
        }

        private void btnAdmContract_Click(object sender, EventArgs e)
        {
            AdminContractForm adminContractForm = new AdminContractForm();
            adminContractForm.ShowDialog();
        }

        private void btnAdmWorkType_Click(object sender, EventArgs e)
        {
            AdminWorkTypeForm adminWorkTypeForm = new AdminWorkTypeForm();
            adminWorkTypeForm.ShowDialog();
        }
    }
}
