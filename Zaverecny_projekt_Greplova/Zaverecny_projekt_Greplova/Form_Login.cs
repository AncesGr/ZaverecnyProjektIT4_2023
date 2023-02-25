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
            sqlRepository = new SqlRepository(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog='C:\USERS\ANNA GREPLOVÁ\SOURCE\REPOS\ZAVERECNYPROJEKTIT4_2023\DB_ZAVERECNY_PROJEKT.MDF';Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtNameL.Text  != " " && txtPasswordL.Text != " ")
            {
               sqlRepository.Login(txtNameL.Text, txtPasswordL.Text);
            }
        }
    }
}
