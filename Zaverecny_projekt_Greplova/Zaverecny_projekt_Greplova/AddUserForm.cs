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
    public partial class AddUserForm : Form
    {
        SqlRepository sqlRepository;
        public AddUserForm()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        private void AddUserForm_Load(object sender, EventArgs e)
        {
            var employee = sqlRepository.GetEmployees();
            var role = sqlRepository.GetRoles();
        }
    }
}
