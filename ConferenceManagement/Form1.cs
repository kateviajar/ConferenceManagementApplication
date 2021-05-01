// Programmer: Nathan Larocque
// Date: April 20th
// Description: This form is for Entering information needed for creating a booking the user can enter their information with out an account or create an account with needed information or login to account which has needed information stored in database

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConferenceManagement
{
    public partial class MainForm : Form
    {
        // connection to database
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\egber\source\repos\ConferenceManagement\ConferenceManagement\ConferenceDB.mdf;Integrated Security=True;Connect Timeout=30");

        //Create global variables of user info
        public static string nameText = "";
        public static string companyNameText = "";
        public static string emailText = "";
        public static string userName = "";
        public static string password = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            //store textboxes text to global variables
            nameText = FirstNameTextBox.Text + " " + LastNameTextBox.Text;
            companyNameText = CompanyNameTextBox.Text;
            emailText = EmailTextBox.Text;

            //if user enter FirstName and Email
            if (FirstNameTextBox.Text != "" && EmailTextBox.Text != "")
            {
                //Jump to CreateBookingForm
                CreateBookingForm createBookingForm = new CreateBookingForm();
                createBookingForm.Show();
                this.Hide();
            
            }
        }

        // moves user to alter booking page
        private void ViewButton_Click(object sender, EventArgs e)
        {
            AlterBookingForm alterBookingForm = new AlterBookingForm();
            alterBookingForm.Show();
            this.Hide();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateAccountButton_Click(object sender, EventArgs e)
        {
            //opening connection to database if not already open
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            //store textboxes text to global variables
            nameText = CreateFirstNameTextBox.Text + " " + CreateLastNameTextBox.Text;
            companyNameText = CreateCompanyTextBox.Text;
            emailText = CreateEmailTextBox.Text;
            userName = CreateUserNameTextBox.Text;
            if (CreatePasswordTextBox.Text == ConfirmPasswordTextBox.Text)
            {
                password = CreatePasswordTextBox.Text;
                if (CreateFirstNameTextBox.Text != "" && CreateLastNameTextBox.Text != "" && CreateEmailTextBox.Text != "" && CreateUserNameTextBox.Text != "" && password != "")
                {

                    try
                    {
                        string query = "INSERT INTO UserTable (Name, CompanyName, Email, UserName, Password) VALUES ('" + CreateFirstNameTextBox.Text + " " + CreateLastNameTextBox.Text + "', '" + CreateCompanyTextBox.Text + "', '" + CreateEmailTextBox.Text + "', '" + userName + "', '" + password + "')";
                        SqlCommand command = new SqlCommand(query, conn);
                        command.ExecuteNonQuery();

                        //Jump to AlterBookingForm
                        AlterBookingForm alterBookingForm = new AlterBookingForm();
                        alterBookingForm.Show();
                        this.Hide();
                    }
                    catch (SqlException)
                    {
                        MessageTextBox.Text = "User name invlad or used already";
                    }
                }
            } else
            {
                MessageTextBox.Text = "Password does not match password confirm please try again";
            }

            conn.Close();
        }

        // grabs all of users information and displays it on the alter booking form
        private void LoginButton_Click(object sender, EventArgs e)
        {

            //opening connection to database if not already open
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }

            // variables for comaring user to database
            string compareUserName = "";
            string comparePassword = "";
            
            // grabing user information and storing it a DataTable
            string getUserName = "SELECT UserName, Password, Name, Email, CompanyName FROM UserTable WHERE UserName = '" + UserNameTextBox.Text + "'";
            SqlCommand command1 = new SqlCommand(getUserName, conn);
            SqlDataAdapter adapter1 = new SqlDataAdapter(command1);
            DataTable dataTable1 = new DataTable();
            dataTable1.Columns.Add("UserName", typeof(string));
            dataTable1.Columns.Add("Password", typeof(string));
            dataTable1.Columns.Add("Name", typeof(string));
            dataTable1.Columns.Add("Email", typeof(string));
            dataTable1.Columns.Add("CompanyName", typeof(string));
            adapter1.Fill(dataTable1);

            //storing user information in variables
            try
            {
                compareUserName = Convert.ToString(dataTable1.Rows[0][0]);
                comparePassword = Convert.ToString(dataTable1.Rows[0][1]);
            }
            catch (IndexOutOfRangeException)
            {
                MessageTextBox.Text = "User name or password do not match records please try again";
            }

            // checking if login information matches data table
            if (UserNameTextBox.Text == compareUserName && PasswordTextBox.Text == comparePassword)
            {

                // storing user information in global variables 
                userName = Convert.ToString(dataTable1.Rows[0][0]);
                password = Convert.ToString(dataTable1.Rows[0][1]);
                nameText = Convert.ToString(dataTable1.Rows[0][2]);
                emailText = Convert.ToString(dataTable1.Rows[0][3]);
                companyNameText = Convert.ToString(dataTable1.Rows[0][4]);

                //Jump to AlterBookingForm
                AlterBookingForm alterBookingForm = new AlterBookingForm();
                alterBookingForm.Show();

                // hiding form incase user wants to logout
                this.Hide();

                conn.Close();
            }
            // if information does match records in database
            else
            {
                MessageTextBox.Text = "User name or password do not match records please try again";
            }
        }

        // closing program if ExitButton is pressed
        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        //Protect the password
        private void PasswordTextBox_Enter(object sender, EventArgs e)
        {
            PasswordTextBox.UseSystemPasswordChar = true;
        }

        private void CreatePasswordTextBox_Enter(object sender, EventArgs e)
        {
            CreatePasswordTextBox.UseSystemPasswordChar = true;
        }

        private void ConfirmPasswordTextBox_Enter(object sender, EventArgs e)
        {
            ConfirmPasswordTextBox.UseSystemPasswordChar = true;
        }
    }
}
