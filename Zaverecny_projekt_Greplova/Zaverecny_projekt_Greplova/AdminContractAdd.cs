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
    public partial class AdminContractAdd : Form
    {
        SqlRepository sqlRepository;
        public AdminContractForm AdminContractForm { get; set; }
        public AdminContractAdd(AdminContractForm adminContractForm)
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
            AdminContractForm = new AdminContractForm();
        }

        private void btnAdmContractAddOK_Click(object sender, EventArgs e)
        {
             if (txtAdmContractAddDescription.Text != "" && txtAdmContractAddName.Text != "")
            {
                sqlRepository.AddContract(txtAdmContractAddName.Text, txtAdmContractAddDescription.Text);
                AdminContractForm.LoadData();
                MessageBox.Show("Contract is added");
                Close();
            }
            else
            {
                MessageBox.Show("Not all fields are filled in");
            }
        }
    }
}
