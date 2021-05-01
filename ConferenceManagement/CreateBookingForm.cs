// Programmer: Pao-Hua Chien
// Date: April 10, 2021
// Description: This form is for booking a conference room
//              It displays the conference room information and its availability according to date and time selected

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace ConferenceManagement
{
    public partial class CreateBookingForm : Form
    {
        //Create a DateTime variable
        DateTime today;

        //Create a SqlConnection
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\egber\source\repos\ConferenceManagement\ConferenceManagement\ConferenceDB.mdf;Integrated Security=True;Connect Timeout=30");

        //Create a method to display table in the DataGridView
        public void populate()
        {
            conn.Open();
            string query = "SELECT * FROM RoomTable";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            RoomDataGridView.DataSource = dataTable;
            conn.Close();
        }

        //Create a method to update the room availability according to the date and time
        public void updateRoomAvailable()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string roomStateNo = "No";
            string query = "UPDATE RoomTable SET Available = '"+roomStateNo+ "' WHERE RoomId IN (SELECT RoomNumber From BookingTable WHERE BookingDate = '" + BookingDateTimePicker.Value.ToString("yyyy-MM-dd") + "' AND BookingTime = '" + TimeComboBox.SelectedValue.ToString() + "');";
            SqlCommand command = new SqlCommand(query, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }

        //Update the room availability back to Yes
        public void updateRoomAvailableYes()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            string roomStateYes = "Yes";
            string roomStateNo = "No";
            string query = "UPDATE RoomTable SET Available = '" + roomStateYes + "' WHERE Available = '" + roomStateNo + "';";
            SqlCommand command = new SqlCommand(query, conn);
            command.ExecuteNonQuery();
            conn.Close();
        }


        //Fill time data from TimeTable to TimeComboBox dropdown list
        public void fillTimeComboBox()
        {
            conn.Open();
            string query = "SELECT TimePeriod FROM TimeTable";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader dataReader = command.ExecuteReader();
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("TimePeriod", typeof(string));
            dataTable.Load(dataReader);
            TimeComboBox.ValueMember = "TimePeriod";
            TimeComboBox.DataSource = dataTable;
            conn.Close();
        }

        //Create a method to find which checkbox is checked
        public int findCheckedCheckbox()
        {
            int roomNumber = 0;
            if (Room201CheckBox.Checked)
            {
                roomNumber = 201;
            }
            else if (Room202CheckBox.Checked)
            {
                roomNumber = 202;
            }
            else if (Room203CheckBox.Checked)
            {
                roomNumber = 203;
            }
            else if (Room204CheckBox.Checked)
            {
                roomNumber = 204;
            }
            else if (Room205CheckBox.Checked)
            {
                roomNumber = 205;
            }
            else if (Room206CheckBox.Checked)
            {
                roomNumber = 206;
            }

            return roomNumber;
        }

        //Create a method to enable checkboxes according to Room Avaliable
        public void roomCheckboxEnable()
        {
            //Enable all the checkboxes first
            Room201CheckBox.Enabled = true;
            Room202CheckBox.Enabled = true;
            Room203CheckBox.Enabled = true;
            Room204CheckBox.Enabled = true;
            Room205CheckBox.Enabled = true;
            Room206CheckBox.Enabled = true;

            // storing RoomID that is unavailable from RoomTable in datatable
            conn.Open();
            string roomState = "No";
            string query = "SELECT RoomId FROM RoomTable WHERE Available = '"+roomState+"'";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            // disabling room number checkbox if not available in RoomTable
            foreach (DataRow row in dataTable.Rows)
            {
                string roomNumber = row["RoomId"].ToString();

                switch (roomNumber)
                {
                    case "201":
                        Room201CheckBox.Enabled = false;
                        break;
                    case "202":
                        Room202CheckBox.Enabled = false;
                        break;
                    case "203":
                        Room203CheckBox.Enabled = false;
                        break;
                    case "204":
                        Room204CheckBox.Enabled = false;
                        break;
                    case "205":
                        Room205CheckBox.Enabled = false;
                        break;
                    case "206":
                        Room206CheckBox.Enabled = false;
                        break;
                }

            }

            conn.Close();
           
        }

        public CreateBookingForm()
        {
            InitializeComponent();
        }

        private void CreateBookingForm_Load(object sender, EventArgs e)
        {
            //Display the global variables of MainForm
            NameLabel.Text = MainForm.nameText;
            CompanyLabel.Text = MainForm.companyNameText;
            EmailLabel.Text = MainForm.emailText;

            //store current date to today variable
            today = BookingDateTimePicker.Value;

            //display table
            populate();

            //Fill the TimeComboBox
            fillTimeComboBox();
        }

        private void BookingDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //Compare the input booking date and today
            int booking = DateTime.Compare(BookingDateTimePicker.Value, today);

            // making sure user selects correct date for booking
            if (booking < 0)
            {
                MessageBox.Show("Wrong Date For Booking. Please Select Again.");
            }
            else
            {
                //Set the room availability to "Yes"
                updateRoomAvailableYes();
                //Check whether the selected time is booked in the booking record
                updateRoomAvailable();
                //Display updated table on the DataGridView
                populate();
                //Enable the checkboxes that is available based on the date and time selected
                roomCheckboxEnable();
            }
        }

        //create the booking by clicking the CreateButton
        private void CreateButton_Click(object sender, EventArgs e)
        {
            int roomNumber = findCheckedCheckbox();

            //if checkbox is not checked, throw a message to users
            if (roomNumber == 0)
            {
                MessageBox.Show("Please select a conference room.");
            }
            else 
            {
                conn.Open();
                string query = "INSERT INTO BookingTable(RoomNumber, BookingDate, BookingTime, Name, CompanyName, Email) VALUES('"+roomNumber+"', '"+BookingDateTimePicker.Value.ToString("yyyy-MM-dd") +"', '"+TimeComboBox.SelectedValue.ToString()+"', '"+NameLabel.Text+"', '"+CompanyLabel.Text+"', '"+EmailLabel.Text+"')";
                SqlCommand command1 = new SqlCommand(query, conn);
                command1.ExecuteNonQuery();
                MessageBox.Show("The booking is made successfully.");
                conn.Close();

                // inserting user id into Booking table if user is signed in
                if(MainForm.userName != "")
                    {
                    conn.Open();
                    string userIDInsert = "UPDATE BookingTable SET BookingTable.UserID = UserTable.UserID FROM BookingTable, UserTable WHERE BookingTable.Name = UserTable.Name AND UserTable.UserName = '" + MainForm.userName + "' AND UserTable.Email = BookingTable.Email";
                    SqlCommand command2 = new SqlCommand(userIDInsert, conn);
                    command2.ExecuteNonQuery();
                    conn.Close();
                }

                //uncheck all the checkboxes after click the create button
                foreach (CheckBox box in RoomGroupBox.Controls.OfType<CheckBox>())
                {
                    if (box.Checked)
                    {
                        box.Checked = false;
                    }
                }

                //update the available state of rooms after create a booking
                //Check whether the selected time is booked in the booking record
                updateRoomAvailable();
                populate();
                //if the room is booked, enable the checkbox
                roomCheckboxEnable();
            }
            
        }

        // bring user to alterbookingform
        private void ViewBookingButton_Click(object sender, EventArgs e)
        {
            AlterBookingForm alterbookingForm = new AlterBookingForm();
            alterbookingForm.Show();
            this.Close();
        }

        private void TimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set the room availability to "Yes"
            updateRoomAvailableYes();
            //Check whether the selected time is booked in the booking record
            updateRoomAvailable();
            populate();
            roomCheckboxEnable();
        }


        //Only one checkbox can be checked at a time
        private void Room201CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                foreach (CheckBox box in RoomGroupBox.Controls.OfType<CheckBox>())
                {
                    if (box != (sender as CheckBox))
                    {
                        box.Checked = false;
                    }
                }
            }
        }

        private void Room202CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                foreach (CheckBox box in RoomGroupBox.Controls.OfType<CheckBox>())
                {
                    if (box != (sender as CheckBox))
                    {
                        box.Checked = false;
                    }
                }
            }
        }

        private void Room203CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                foreach (CheckBox box in RoomGroupBox.Controls.OfType<CheckBox>())
                {
                    if (box != (sender as CheckBox))
                    {
                        box.Checked = false;
                    }
                }
            }
        }

        private void Room204CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                foreach (CheckBox box in RoomGroupBox.Controls.OfType<CheckBox>())
                {
                    if (box != (sender as CheckBox))
                    {
                        box.Checked = false;
                    }
                }
            }
        }

        private void Room205CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                foreach (CheckBox box in RoomGroupBox.Controls.OfType<CheckBox>())
                {
                    if (box != (sender as CheckBox))
                    {
                        box.Checked = false;
                    }
                }
            }
        }

        private void Room206CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                foreach (CheckBox box in RoomGroupBox.Controls.OfType<CheckBox>())
                {
                    if (box != (sender as CheckBox))
                    {
                        box.Checked = false;
                    }
                }
            }
        }

        // exiting program if button is pressed
        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        //reseting global variable to "" and bringing user back to main form
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            MainForm.userName = "";
            MainForm.password = "";
            MainForm.nameText = "";
            MainForm.emailText = "";
            MainForm.companyNameText = "";

            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Close();

            /*foreach(Form form in Application.OpenForms)
            {
                if(form is MainForm)
                {
                    form.Show();
                    break;
                }
            }*/
        }

        
    }
}
