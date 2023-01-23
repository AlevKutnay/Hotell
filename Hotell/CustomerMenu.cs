using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotell
{
    public partial class CustomerMenu : Form
    {
       
        int customerId = 0;
        Customer customer = new Customer();
        CustomerProccess customerProcess = new CustomerProccess();
        public CustomerMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            if (!String.IsNullOrWhiteSpace(nameTxt.Text) && !String.IsNullOrWhiteSpace(surnameTxt.Text) && !String.IsNullOrWhiteSpace(ageTxt.Text) && !String.IsNullOrWhiteSpace(ganderTxt.Text) && balanceNud.Value > 0)
            {
                customer.Id = Convert.ToInt32(addcustomerIdNud.Text);
                customer.Name = nameTxt.Text;
                customer.Surname = surnameTxt.Text;
                customer.Age = Convert.ToInt32(ageTxt.Text);
                customer.Gander=ganderTxt.Text;
                customer.Balance = Convert.ToDouble(balanceNud.Value);

                if (customerProcess.Add(customer))
                {
                    MessageBox.Show("Customer Add Successful");
                    customerId++;
                    addcustomerIdNud.Text = customerId.ToString();
                    nameTxt.Clear();
                    surnameTxt.Clear();
                    ageTxt.Clear();
                    ganderTxt.Clear();
                    balanceNud.Value = 0;
                    nameTxt.Focus();
                    //customerList();
                }
                else
                {
                    MessageBox.Show("Customer Add Failed");
                }
            }
            else
            {
                MessageBox.Show("Values Can't Be Empty");
            }
        }
        public void customerList()
        {
            CustomerLb.Items.Clear();

            foreach (var customer in customerProcess.List().ToList())
            {
                CustomerLb.Items.Add(customer.Id + "  " + customer.Name + " " + customer.Surname);
            }
        }

        private void deletecustomerBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(deletecustomerIdNud.Value);
            if (customerProcess.Delete(id))
            {
                MessageBox.Show("Customer Delete Successful");
                customerList();
            }
            else
            {
                MessageBox.Show("Not Found Customer");
            }
        }

        private void getcustomerBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(getcustomerIdNud.Value);
            Customer customer = customerProcess.Detail(id);

            if (customer != null)
            {
                getcustomerIdLbl.Text = customer.Id.ToString();
                getcustomernameLbl.Text = customer.Name;
                getcustomersurnameLbl.Text = customer.Surname;
                getcustomerageLbl.Text = customer.Age.ToString();
                getcustomerganderLbl.Text = customer.Gander;
                getcustomerbalanceLbl.Text = customer.Balance + " TL";

                MessageBox.Show("Customer Found Successful");
            }
            else
            {
                MessageBox.Show("Not Found Customer");
            }
        }

        private void listcustomerBtn_Click(object sender, EventArgs e)
        {
            customerList();
        }

        private void CustomerMenu_Load(object sender, EventArgs e)
        {

        }

        private void rentroomBtn_Click(object sender, EventArgs e)
        {
            RentRoomMenu rentroommenu = new RentRoomMenu();
            this.Hide();
            rentroommenu.ShowDialog();
            this.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
    
}
