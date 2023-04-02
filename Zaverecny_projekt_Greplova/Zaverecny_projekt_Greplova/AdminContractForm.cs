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
    public partial class AdminContractForm : Form
    {
        SqlRepository sqlRepository;
        public AdminContractForm()
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
        }

        public void LoadData()
        {
            lvAdmContractForm.Items.Clear();
            var contracts = sqlRepository.GetContracts();
            foreach (var contract in contracts)
            {
                lvAdmContractForm.Items.Add(new ListViewItem(new string[] { contract.Customer, contract.Description, contract.Id.ToString() }));
            }
        }

        private void AdminContractForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnEditContract_Click(object sender, EventArgs e)
        {
            if (lvAdmContractForm.SelectedItems.Count > 0)
            {
                AdminContractEdit adminContractEdit = new AdminContractEdit(Convert.ToInt32(lvAdmContractForm.SelectedItems[0].SubItems[2].Text),this);
                adminContractEdit.ShowDialog();
            }
            else
            {
                MessageBox.Show("You havent selected any record");
            }
        }

        private void btnAddContract_Click(object sender, EventArgs e)
        {
            AdminContractAdd adminContractAdd = new AdminContractAdd(this);
            adminContractAdd.ShowDialog();
        }

        private void btnDeleteContract_Click(object sender, EventArgs e)
        {
            if (lvAdmContractForm.SelectedItems.Count > 0)
            {
                sqlRepository.DeleteContract(Convert.ToInt32(lvAdmContractForm.SelectedItems[0].SubItems[2].Text));
                LoadData();
                MessageBox.Show("Contract is deleted");
            }
            else
            {
                MessageBox.Show("Nevybral jste žádnou zakázku!");
            }
        }
    }
}
