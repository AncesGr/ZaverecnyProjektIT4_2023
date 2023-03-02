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
    public partial class MainForm : Form
    {
        public User User { get; set; }
        public MainForm( User user)
        {
            InitializeComponent();
            User = user;
            lblUser.Text = User.Name;
        }
    }
}
