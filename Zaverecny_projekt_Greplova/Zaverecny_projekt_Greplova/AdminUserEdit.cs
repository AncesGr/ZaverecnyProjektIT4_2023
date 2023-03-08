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
        public AdminUserEdit()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        private void AdminUserEdit_Load(object sender, EventArgs e)
        {
            var listUsers = sqlRepository.GetUsers();
            foreach(var user in listUsers) 
            {
                Employee employee = sqlRepository.GetEmployee(user.IdEmployee);
                lwAdmUserEdit.Items.Add(new ListViewItem(new string[] { employee.FirstName + " " + employee.LastName, user.Name }));
            }
        }
    }
}
