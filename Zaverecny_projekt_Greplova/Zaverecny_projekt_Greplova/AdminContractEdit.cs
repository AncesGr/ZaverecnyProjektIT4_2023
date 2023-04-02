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
    public partial class AdminContractEdit : Form
    {
        SqlRepository sqlRepository;
        public AdminContractForm Parent { get; set; }
        public int IdContract { get; set; }
        public AdminContractEdit(int idContract, AdminContractForm parent)
        {
            InitializeComponent();
            IdContract = idContract;
            sqlRepository = new SqlRepository();
            Parent = parent;
        }

        private void AdminContractEdit_Load(object sender, EventArgs e)
        {
            var contract = sqlRepository.GetContract(IdContract);
            if (contract != null)
            {
                txtAdmContractEditDescription.Text = contract.Description;
                txtAdmContractEditName.Text = contract.Customer;
            }
        }

        private void btnAdmContractEditOK_Click(object sender, EventArgs e)
        {
            if (txtAdmContractEditDescription.Text != "" && txtAdmContractEditName.Text != "")
            {
                sqlRepository.UpdateContract(IdContract, txtAdmContractEditName.Text, txtAdmContractEditDescription.Text);
                Parent.LoadData();
                Close();
            }
            else
            {
                MessageBox.Show("You havent selected any record");
            }
        }
    }
}
