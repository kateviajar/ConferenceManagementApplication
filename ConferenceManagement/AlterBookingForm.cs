// Programmer: Pao-Hua Chien
// Date: April 11, 2021
// Description: This form is for searching, editing and deleting the booking

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

namespace ConferenceManagement
{
    public partial class AlterBookingForm : Form
    {
        //Create a SqlConnection
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\egber\source\repos\ConferenceManagement\ConferenceManagement\ConferenceDB.mdf;Integrated Security=True;Connect Timeout=30");

        //Create a method to display table in the DataGridView
        public void populate()
        {
            conn.Open();
            
            // when user is logged in will pull up bookings based on their account
            if (MainForm.userName != "")
            {
                string query = "SELECT * FROM BookingTable WHERE UserID = (SELECT UserID FROM UserTable WHERE UserName = '" + MainForm.userName + "')";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                BookingInfoDataGridView.DataSource = dataTable;
            }

            // When not logged in will pull up booking by name, email, and company name
            if (MainForm.userName == "")
            {
                string query = "SELECT * FROM BookingTable WHERE Name = '" + MainForm.nameText + "' AND email = '" + MainForm.emailText + "'";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                BookingInfoDataGridView.DataSource = dataTable;
            }
            conn.Close();
        }

        public AlterBookingForm()
        {
            InitializeComponent();
        }

        //when user want to enter the textbox, the placeholder will be cleared
        private void NameSearchTextBox_Enter(object sender, EventArgs e)
        {
            if (NameSearchTextBox.Text == "By Name")
            {
                NameSearchTextBox.Text = "";
                NameSearchTextBox.ForeColor = Color.Black;
            }
        }

        //When user doesn't enter any in the textbox and leave, the placeholder will be shown on the textbox
        private void NameSearchTextBox_Leave(object sender, EventArgs e)
        {
            if (NameSearchTextBox.Text == "")
            {
                NameSearchTextBox.Text = "By Name";
                NameSearchTextBox.ForeColor = Color.Silver;
            }
        }

        //when user want to enter the textbox, the placeholder will be cleared
        private void EmailSearchTextBox_Enter(object sender, EventArgs e)
        {
            if (EmailSearchTextBox.Text == "By Email")
            {
                EmailSearchTextBox.Text = "";
                EmailSearchTextBox.ForeColor = Color.Black;
            }
        }

        //When user doesn't enter any in the textbox and leave, the placeholder will be shown on the textbox
        private void EmailSearchTextBox_Leave(object sender, EventArgs e)
        {
            if (EmailSearchTextBox.Text == "")
            {
                EmailSearchTextBox.Text = "By Email";
                EmailSearchTextBox.ForeColor = Color.Silver;
            }
        }

        private void AlterBookingForm_Load(object sender, EventArgs e)
        {
            //show the BookingTable on the DataGridView
            populate();
        }

        // searching for bookings by name and email and storing them in BookingInfoDataGridView
        private void SearchButton_Click(object sender, EventArgs e)
        {
            conn.Open();
            string query = "SELECT * FROM BookingTable WHERE Name LIKE '%"+NameSearchTextBox.Text+"%' OR Email = '"+EmailSearchTextBox.Text+"'";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            BookingInfoDataGridView.DataSource = dataTable;
            conn.Close();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            //Clear the textboxes and put placeholders back
            NameSearchTextBox.Text = "By Name"; 
            EmailSearchTextBox.Text = "By Email";

            //Display all the BookingTable
            populate();
        }

        //Display the data on textboxes when click the row on the DataGridView
        private void BookingInfoDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow dataGridViewRow = BookingInfoDataGridView.Rows[e.RowIndex];
                BookingIDEditLabel.Text = dataGridViewRow.Cells[0].Value.ToString();
                NameTextBox.Text = dataGridViewRow.Cells[4].Value.ToString();
                CompanyTextBox.Text = dataGridViewRow.Cells[5].Value.ToString();
                EmailTextBox.Text = dataGridViewRow.Cells[6].Value.ToString();
            }
        }

        //Create a method to get the name based on the booking ID that user want to update
        public string findNameBasedOnBookingIdEditLabel()
        {
            conn.Open();
            string query = "SELECT Name FROM BookingTable WHERE BookingId = '" + Convert.ToInt32(BookingIDEditLabel.Text) + "'";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            string name = dataTable.Rows[0][0].ToString();
            conn.Close();

            return name;
        }

        // updating booking if user enters correct variables
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            //if user's name is the same as the name of the booking they want to edit
            if (findNameBasedOnBookingIdEditLabel() == MainForm.nameText)
            {
                //if name or email is empty, the update cannot be executed
                if (String.IsNullOrEmpty(NameTextBox.Text) || String.IsNullOrEmpty(EmailTextBox.Text))
                {
                    MessageBox.Show("Name and Email can not be empty! Please enter again.");
                }
                else
                {
                    conn.Open();
                    string query = "UPDATE BookingTable SET Name = '" + NameTextBox.Text + "', CompanyName = '" + CompanyTextBox.Text + "', Email = '" + EmailTextBox.Text + "' WHERE BookingId = '" + Convert.ToInt32(BookingIDEditLabel.Text) + "';";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.ExecuteNonQuery();
                    MessageBox.Show("The booking information is updated successfully!");
                    conn.Close();
                    populate();
                }
            }
            else
            {
                MessageBox.Show("It is not allowable to edit other perople's booking.");
            }
        }

        //Create a method to get the name based on the input booking ID that user want to delete
        public string findNameBasedOnBookingID()
        {
            conn.Open();
            string query = "SELECT Name FROM BookingTable WHERE BookingId = '" + Convert.ToInt32(BookingIdTextBox.Text) + "'";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            string name = dataTable.Rows[0][0].ToString();
            conn.Close();

            return name;
        }

        // deletes booking if user wants
        private void CancelButton_Click(object sender, EventArgs e)
        {
            //if user logged in or user has input the name in MainForm for booking, the delete function can be executed
            if (MainForm.nameText != "" || MainForm.userName != "")
            {
                //if the name of booking is the same as the useName or the name input in the beginning
                if (findNameBasedOnBookingID() == MainForm.nameText)
                {
                    //if verify checkbox is checked, then execute deleting process
                    if (VerifyCheckBox.Checked)
                    {
                        conn.Open();
                        string query = "DELETE FROM BookingTable WHERE BookingId = '" + Convert.ToInt32(BookingIdTextBox.Text) + "' AND Name IN ('" + MainForm.userName + "', '" + MainForm.nameText + "')";
                        SqlCommand command = new SqlCommand(query, conn);
                        command.ExecuteNonQuery();
                        MessageBox.Show("The booking is canceled!");
                        conn.Close();
                        populate();
                    }
                    else
                    {
                        MessageBox.Show("If you want to cancel the booking, please check the box.");
                    }
                }
                else
                {
                    MessageBox.Show("It is not allowable to delete other people's booking.");
                }
            }
            else
            {
                MessageBox.Show("If you want to cancel the booking, please log in or enter your name in the main page.");
            }
        }

        // brings user to createBookingForm
        private void CreateButton_Click(object sender, EventArgs e)
        {
            CreateBookingForm createBookingForm = new CreateBookingForm();
            createBookingForm.Show();
            this.Close();
        }

        // Exits program
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

           /* foreach (Form form in Application.OpenForms)
            {
                if (form is MainForm)
                {
                    form.Show();
                    break;
                }
            }*/
        }
    }
}
