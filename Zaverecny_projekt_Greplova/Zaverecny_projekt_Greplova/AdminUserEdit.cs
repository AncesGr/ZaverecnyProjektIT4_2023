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
    public partial class AdminUserEdit : Form
    {
        SqlRepository sqlRepository;
        public int IdUser { get; set; }
        public AdminUserForm Parent { get; set; }
        public AdminUserEdit(int idUser, AdminUserForm parent)
        {
            InitializeComponent();
            IdUser = idUser;
            sqlRepository = new SqlRepository();
            Parent = parent;
        }

        private void AdminUserEdit_Load(object sender, EventArgs e)
        {
            var user = sqlRepository.GetUser(IdUser);
            txtAdmEditName.Text = user.Name;
            var role = sqlRepository.GetRole(user.Role);
            cmbEditRole.Text = role.Name;
            var roles = sqlRepository.GetRoles();
            foreach(var R in roles)
            {
                cmbEditRole.Items.Add(R.Name);
            }
        }

        private void btnAdmEditOK_Click(object sender, EventArgs e)
        {
            if(txtAdmEditName.Text != "" && cmbEditRole.Text !="")
            {
                var role=sqlRepository.GetRole(cmbEditRole.Text);
                sqlRepository.UpdateUser(txtAdmEditName.Text, role.Id, IdUser);
                Parent.LoadData();
                this.Close();
            }
            else
            {
                MessageBox.Show("Nejsou vyplněna všechna políčka!");
            }
        }

        private void btnAdmEditPassword_Click(object sender, EventArgs e)
        {
            var user = sqlRepository.GetUser(IdUser);
            user.ResetPassword();
            sqlRepository.ResetUserPassword(IdUser, user.PasswordHash, user.PasswordSalt);
            Parent.LoadData();  
            this.Close();   
        }
    }
}
