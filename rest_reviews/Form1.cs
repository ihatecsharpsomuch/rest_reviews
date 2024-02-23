using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace rest_reviews
{
    /// <summary>
    /// Fix login button(done) and add "leave a review"
    /// </summary>
    /// 
    public partial class Form1 : Form
    {
        bool LoggedIn;
        public Form1() {
            InitializeComponent();
        }

        public void logging_in() {
            if (LoggedIn == false)
            {   
                login_button.Text = "Login";
                publish_button.Enabled = false;
                restid_cho.Enabled = false;
                rev_text.Enabled = false;
                rest_info.Enabled = false;
                checkedListBox1.Enabled = false;
                rest_cho.Enabled = false;
                stars_cho.Enabled = false;
                date_cho.Enabled = false;
                username_input.Enabled = true;
                password_input.Enabled = true;
                LoggedIn = false;
                label3.Text = "You are not logged in";
                rest_info.MaximumSize = new Size(300, 0);
                rest_info.AutoSize = true;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (login_button.Text == "Login"){
                string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"\\\\esher.ac.uk\\home\\students\\2023\\233542\\Visual Studio 2022\\projects\\rest_reviews\\database_files\\reviews.mdf\";Integrated Security=True;Connect Timeout=30";
                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();
                SqlCommand command = new SqlCommand("SELECT * FROM Users WHERE UserName=@user AND UserPassword=@pass", sqlConnection);
                SqlParameter paramUser = new SqlParameter();
                paramUser.ParameterName = "@user";
                paramUser.Value = username_input.Text;
                SqlParameter paramPass = new SqlParameter();
                paramPass.ParameterName = "@pass";
                paramPass.Value = password_input.Text;
                command.Parameters.Add(paramUser);
                command.Parameters.Add(paramPass);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    string Username = username_input.Text;
                    if (reader.Read())
                    {
                        LoggedIn = true;
                        login_button.Text = "Logout";
                        username_input.Enabled = false;
                        password_input.Enabled = false;
                        publish_button.Enabled = true;
                        restid_cho.Enabled = true;
                        rev_text.Enabled = true;
                        rest_info.Enabled = true;
                        checkedListBox1.Enabled = true;
                        rest_cho.Enabled = true;
                        stars_cho.Enabled = true;
                        date_cho.Enabled = true;
                        label3.Text = "Welcome " + Username;
                    }
                    else
                    {
                        LoggedIn = false;
                        Username = null;
                        label3.Text = "Incorrect username or password!";
                        username_input.Text = "";
                        password_input.Text = "";
                    }
                    sqlConnection.Close();
                }
            } else { 
                LoggedIn = false;
                logging_in();
            }
        }

        

        private void get_tags(){
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"\\\\esher.ac.uk\\home\\students\\2023\\233542\\Visual Studio 2022\\projects\\rest_reviews\\database_files\\reviews.mdf\";Integrated Security=True;Connect Timeout=30";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("SELECT Tag FROM Tags ORDER BY Tag", sqlConnection);
            using (SqlDataReader reader = command.ExecuteReader()){
                while (reader.Read()){
                    checkedListBox1.Items.Add(reader["Tag"], false);
                }
            }
            sqlConnection.Close();
        }

        //kogda zhidko kakaesh
        private void Form1_Load(object sender, EventArgs e){
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"\\\\esher.ac.uk\\home\\students\\2023\\233542\\Visual Studio 2022\\projects\\rest_reviews\\database_files\\reviews.mdf\";Integrated Security=True;Connect Timeout=30";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            get_tags();
            LoggedIn = false;
            logging_in();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void rest_info_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }
        private void textBox2_TextChanged(object sender, EventArgs e) {

        }
        private void star_ch_Click(object sender, EventArgs e)
        {

        }
        private void publish_button_Click(object sender, EventArgs e) {
            string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"\\\\esher.ac.uk\\home\\students\\2023\\233542\\Visual Studio 2022\\projects\\rest_reviews\\database_files\\reviews.mdf\";Integrated Security=True;Connect Timeout=30";
            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            SqlParameter paramUser = new SqlParameter();
            paramUser.ParameterName = "@user";
            paramUser.Value = username_input.Text;
            SqlParameter paramRestID = new SqlParameter();
            paramRestID.ParameterName = "@restid";
            
            //fix
            paramRestID.Value = restid_cho.Text.Substring(restid_cho.Text.Length - 3);
            //
            SqlParameter paramRevDate = new SqlParameter();
            paramRevDate.ParameterName = "@date";
            paramRevDate.Value = date_cho.Text;
            SqlParameter paramStar = new SqlParameter();
            paramStar.ParameterName = "@star";
            paramStar.Value = stars_cho.Text;
            SqlParameter paramText = new SqlParameter();
            paramText.ParameterName = "@text";
            paramText.Value = rev_text.Text;
            SqlCommand command = new SqlCommand("insert into Reviews(UserName, RestaurantID, ReviewDate, ReviewStarRating, ReviewText) values('@user', '@restid', '@date', '@star', '@text')", sqlConnection);
        }

        private void rev_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void rest_cho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void restName_TextChanged(object sender, EventArgs e)
        {

        }

        private void restid_cho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void date_cho_ValueChanged(object sender, EventArgs e){

        }

        private void stars_cho_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
