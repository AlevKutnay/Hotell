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
    public partial class RentRoomMenu : Form
    {
        public RentRoomMenu()
        {
            InitializeComponent();
        }

        private void rentBtn_Click(object sender, EventArgs e)
        {
            bool roomStatus = false;
            RentStatus status = RentStatus.Failed;
            Rent newRent = new Rent();

            foreach (var user in DbContext.UserList.ToList())
            {               
                if (user.openClose)
                {
                    if (user.Id == userIdNud.Value)
                    {
                        foreach (var customer in DbContext.CustomerList.ToList())
                        {

                            if (customer.Id == customerIdNud.Value)
                            {
                                if (customer.Age >= 18)
                                {
                                    foreach (var rooms in DbContext.RoomList.ToList())
                                    {
                                        if (rooms.Name == roomtypeComBox.Text)
                                        {
                                            if (rooms.IsStatus)
                                            {
                                                if (rooms.StockRoom > 0)
                                                {
                                                    int day = Convert.ToInt32(numericDayNud.Value);
                                                    if (customer.Balance >= day * rooms.Price)
                                                    {

                                                        customer.Balance -= (day * rooms.Price);

                                                        newRent.TotalPrice = (Convert.ToDouble(day) * rooms.Price);
                                                        DbContext.RentList.Add(newRent);

                                                        rooms.StockRoom -= 1;
                                                        if (rooms.StockRoom == 0)
                                                            rooms.IsStatus = false;

                                                        status = RentStatus.Success;

                                                        MessageBox.Show("Room Rental Successful");
                                                        roomStatus = true;

                                                        Rent rent = new Rent()
                                                        {
                                                            Id = newRent.Id,
                                                            UserId = newRent.UserId,
                                                            RoomId = newRent.RoomId
                                                        };

                                                        DbContext.RentList.Add(rent);
                                                        RentLb.Items.Clear();
                                                        RentLb.Items.Add(user.Name + " " + user.Surname);
                                                        RentLb.Items.Add(customer.Name + " " + customer.Surname + " " + "Balance: " + customer.Balance);
                                                        RentLb.Items.Add(rooms.Name + " Stock "+ " : " + rooms.StockRoom);
                                                        RentLb.Items.Add("Total Price : " + " " + newRent.TotalPrice.ToString());


                                                    }
                                                    else
                                                    {
                                                        status = RentStatus.InsufficientBalance;
                                                        MessageBox.Show("Insufficient Balance");
                                                        return;
                                                    }
                                                    

                                                }
                                                else
                                                {
                                                    MessageBox.Show(rooms.Name + " " + "Not Found ");
                                                    return;
                                                }

                                            }
                                            else
                                            {
                                                status = RentStatus.RoomBeenRented;
                                                MessageBox.Show("Room Been Rented");
                                                return;
                                            }

                                            break;
                                        }


                                    }
                                    if (!roomStatus)
                                    {
                                        status = RentStatus.RoomNotFound;
                                        MessageBox.Show("Room Not Found");
                                        return;
                                    }


                                }
                                else
                                {
                                    status = RentStatus.AgeLimit;
                                    MessageBox.Show("Age Limit");
                                    return;
                                }
                                break;
                            }                          
                        }
                        if (!roomStatus)
                        {

                            status = RentStatus.CustomerNotFound;
                            MessageBox.Show("Customer Not Found");
                            return;
                        }
                    }
                   
                }               
            }
            if (!roomStatus)
            {
                status = RentStatus.UserNotFound;
                MessageBox.Show("User Not Found");
                return;
            }            
        }
        private void RentRoomMenu_Load(object sender, EventArgs e)
        {
            roomtypeComBox.Items.Add("Single Rooms");
            roomtypeComBox.Items.Add("Double Rooms");
            roomtypeComBox.Items.Add("Triple Rooms");
        }
        private void backBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
