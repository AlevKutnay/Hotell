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
    public partial class UserMenu : Form
    {
        
        User user = new User();
        UserProccess userProcess = new UserProccess();
        public UserMenu()
        {
            InitializeComponent();
        }

        private void adduserBtn_Click(object sender, EventArgs e)
        {
            User user = new User();

            if (!String.IsNullOrWhiteSpace(unameTxt.Text) && !String.IsNullOrWhiteSpace(usurnameTxt.Text)&& !String.IsNullOrWhiteSpace(uemailTxt.Text) && !String.IsNullOrWhiteSpace(uusernameTxt.Text) && !String.IsNullOrWhiteSpace(upasswordTxt.Text) )
            {
                user.Id = Convert.ToInt32(userIdNud.Text);
                user.Name = unameTxt.Text;
                user.Surname = usurnameTxt.Text;
                user.email = uemailTxt.Text;
                user.UserName = uusernameTxt.Text;
                user.Password = upasswordTxt.Text;


                if (userProcess.Add(user))
                {
                    MessageBox.Show("User Add Successful");
                    
                    
                    unameTxt.Clear();
                    usurnameTxt.Clear();
                    uemailTxt.Clear();
                    uusernameTxt.Clear();
                    upasswordTxt.Clear();
                    
                    unameTxt.Focus();
                    //userList();
                }
                else
                {
                    MessageBox.Show("User Add Failed");
                }
            }
            else
            {
                MessageBox.Show("Değerler Boş geçilemez");
            }
        }
        public void userList()
        {
            UserLb.Items.Clear();

            foreach (var user in userProcess.List().ToList())
            {
                UserLb.Items.Add(user.Id + "  " + user.Name + " " + user.Surname);
               
            }
            
        }

       

        private void getuserBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(getuserIdNud.Value);
            User user = userProcess.Detail(id);

            if (user != null)
            {
                getuserIdLbl.Text = user.Id.ToString();
                getusernameLbl.Text = user.Name;
                getusersurnameLbl.Text = user.Surname;
                getuserusernameLbl.Text = user.UserName;
                getuseremailLbl.Text = user.email;
                getuserpasswordLbl.Text = user.Password;


                MessageBox.Show("User Found Successful");
            }
            else 
            {
                MessageBox.Show("Not Found User");
            }
        }

        private void deleteuserBtn_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(deleteuserIdNud.Value);
            if (userProcess.Delete(id))
            {
                MessageBox.Show("User Delete Successful");
                userList();
            }
            else
            {
                MessageBox.Show("Not Found User");
            }
        }

        private void listuserBtn_Click(object sender, EventArgs e)
        {
            userList();
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
