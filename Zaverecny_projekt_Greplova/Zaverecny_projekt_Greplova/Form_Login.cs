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
    public partial class Form_Login : Form
    {
        SqlRepository sqlRepository;
        public Form_Login()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtNameL.Text != " " && txtPasswordL.Text != " ")
            {
                User user = sqlRepository.GetUser(txtNameL.Text);
                if (user != null)
                {
                    if (user.VerifyPassword(txtPasswordL.Text))
                    {
                        MainForm mainForm = new MainForm(user);
                        mainForm.Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Tento uživatel neexistuje!");
                }
            }
            else
            {
                MessageBox.Show("Nevyplnil jste heslo nebo uživatelské jméno!");
            }
        }
        

        /*private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtNameL.Text != "" && txtPasswordL.Text != " ")
            {
                sqlRepository.Register(txtNameL.Text, txtPasswordL.Text);
            }
            else
            {
                MessageBox.Show("Nevyplnil jste uživatelké jméno či heslo");
            }
        }*/
    }
}
