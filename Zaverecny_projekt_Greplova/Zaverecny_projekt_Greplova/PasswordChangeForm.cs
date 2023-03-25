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
    public partial class PasswordChangeForm : Form
    {
        SqlRepository sqlRepository;
        public PasswordChangeForm()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        private void btnSubmitNewPassword_Click(object sender, EventArgs e)
        {
            if (txtCurrentPassword.Text != "" && txtNewPassword.Text != "" && txtPasswordChangeName.Text != "")
            {
                var user = sqlRepository.GetUser(txtPasswordChangeName.Text);
                if (user != null)
                {
                    if(user.VerifyPassword(txtCurrentPassword.Text))
                    {
                        user.ChangePassword(txtNewPassword.Text);
                        sqlRepository.ChangeUserPassword(user.Id, user.PasswordHash, user.PasswordSalt);
                        this.Close();
                        MessageBox.Show("Password changed successfully");
                    }
                    else
                    {
                        MessageBox.Show("Password doesnt exist!");
                    }
                }
            }
            else
            {
                MessageBox.Show("This user doesnt exist");
            }
                
        }
    }
}
