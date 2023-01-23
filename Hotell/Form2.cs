using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotell
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void customerBtn_Click(object sender, EventArgs e)
        {
            CustomerMenu customermenu = new CustomerMenu();
            this.Hide();
            customermenu.ShowDialog();
            this.Show();
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            DbContext db = new DbContext();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            UserMenu usermenu = new UserMenu();
            this.Hide();
            usermenu.ShowDialog();
            this.Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
