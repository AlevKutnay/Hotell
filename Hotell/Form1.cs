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
    public partial class Form1 : Form
    {
        User user = new User();

        bool status = false;
        Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            User user = new User()
            {
                Id = 1,
                Name = "Alev",
                Surname = "Kutnay",
                email = "alevkutnay",
                UserName = "alev",
                Password = "123",
                IsStatus = true,

            };
            DbContext.UserList.Add(user);

            Room room = new Room()
            {
                Id = 1,
                Name = "Single Rooms",
                StockRoom = 10,
                Price = 100,
                IsStatus = true,

            };
            DbContext.RoomList.Add(room);
            Room room1 = new Room()
            {  /*RoomNo = 100,*/
                Id = 2,
                Name = "Double Rooms",
                //NumberofCust=1,
                StockRoom = 10,
                Price = 150,
                IsStatus = true,



            };
            DbContext.RoomList.Add(room1);
            Room room2 = new Room()
            {
                Id = 3,
                Name = "Triple Rooms",
                StockRoom = 10,
                Price = 200,
                IsStatus = true,
            };
            DbContext.RoomList.Add(room2);
            
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(usernameTxt.Text) && !String.IsNullOrWhiteSpace(passwordTxt.Text) )
            {
                
                foreach (var _user in DbContext.UserList.ToList())
                {
                    if (_user.UserName == usernameTxt.Text && _user.Password == passwordTxt.Text )
                    {
                        status = true;
                        

                        _user.openClose = true;

                        user = _user;
                        usernameTxt.Clear();
                        passwordTxt.Clear();
                       

                    }
                }

                if (status)
                {
                    
                    Form2 form2 = new Form2();
                    
                    form2.label1.Text = ("Welcome" + " " + user.Name + " " + user.Surname + " " + ". Please Select The Process You Want To Do:");
                    this.Hide();
                    
                    form2.ShowDialog();
                    this.Show();


                    status = false;
                }
                else
                {
                   
                        MessageBox.Show("Username Or Password Is Wrong");       //Kullanıcı adı veya şifre hatalı              
                        usernameTxt.Clear();
                        passwordTxt.Clear();
      
                }
            }
            else
            {
                MessageBox.Show("Values Can't Be Empty");
            }
              
        }

        
    }

}

