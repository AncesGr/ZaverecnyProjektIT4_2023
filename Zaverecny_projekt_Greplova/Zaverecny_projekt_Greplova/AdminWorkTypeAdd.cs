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
    public partial class AdminWorkTypeAdd : Form
    {
        SqlRepository sqlRepository;
        public AdminWorkTypeForm AdminWorkTypeForm { get; set; }
        public AdminWorkTypeAdd( AdminWorkTypeForm adminWorkTypeForm)
        {
            InitializeComponent();
            sqlRepository = new SqlRepository();
            AdminWorkTypeForm = adminWorkTypeForm;
        }

        private void btnAdmWorkTypeAddOK_Click(object sender, EventArgs e)
        {
            if (txtAdmWorkTypeAddDescription.Text != "" && txtAdmWorkTypeAddName.Text != "")
            {
                sqlRepository.AddWorkType(txtAdmWorkTypeAddName.Text, txtAdmWorkTypeAddDescription.Text);
                AdminWorkTypeForm.LoadData();
                Close();
            }
        }
    }
}
