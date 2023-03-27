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
    public partial class AdminRoleEdit : Form
    {
        SqlRepository sqlRepository;
        public int IdRole { get; set; }
        public AdminRolesForm AdminRolesForm { get; set; }
        public AdminRoleEdit(int idRole, AdminRolesForm adminRolesForm)
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
            IdRole = idRole;
            AdminRolesForm = adminRolesForm;    
        }

        private void AdminRoleEdit_Load(object sender, EventArgs e)
        {

        }

        private void btnAdmRoleEditOK_Click(object sender, EventArgs e)
        {
            if (txtAdmRoleEditName.Text != "")
            {
                sqlRepository.UpdateRole(IdRole, txtAdmRoleEditName.Text);
                AdminRolesForm.LoadData();
                Close();
            }
            else
            {
                MessageBox.Show("You didnt enter a new role name!");
            }
        }
    }
}
