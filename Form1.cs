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




namespace Student_Management_System
{
    public partial class Form1 : Form
    {
        MySql.Data.MySqlClient.MySqlConnection sqlConnection;


        MySql.Data.MySqlClient.MySqlDataAdapter departmentDataAdapter;
        DataSet departmentDataSet;

        MySql.Data.MySqlClient.MySqlDataAdapter professorDataAdapter;
        DataSet professorDataSet;

        MySql.Data.MySqlClient.MySqlDataAdapter studentDataAdapter;
        DataSet studentDataSet;



        public Form1()
        {
            InitializeComponent();


            string myConnectionString;

            myConnectionString = "server=127.0.0.1;" + "uid=CSharp;" + "database=studentDb;" + "pwd=i am c#";

            try
            {
                sqlConnection = new MySql.Data.MySqlClient.MySqlConnection();
                sqlConnection.ConnectionString = myConnectionString;
                sqlConnection.Open();
                sqlConnection.StateChange += HandleSqlStatusChange;
                connectToServerBtn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
            }
        }

        private void connectToServer_Click(object sender, EventArgs e)
        {
            string myConnectionString;

            myConnectionString = "server=127.0.0.1;" + "uid=CSharp;" + "database=studentDb;" + "pwd=i am c#";

            try
            {
                sqlConnection = new MySql.Data.MySqlClient.MySqlConnection();
                sqlConnection.ConnectionString = myConnectionString;
                sqlConnection.Open();
                sqlConnection.StateChange += HandleSqlStatusChange;
                connectToServerBtn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sqlConnection.StateChange -= HandleSqlStatusChange;
            if (sqlConnection != null)
            {
                sqlConnection.Close();
            }
        }


        private void HandleSqlStatusChange(object connection, StateChangeEventArgs args)
        {
            if (sqlConnection.State.ToString() == "Closed") // tested
            {
                MessageBox.Show("SQL connection is lost!!!\r\n Please reconnect again.");
                connectToServerBtn.Enabled = true;
            }
        }


        private void create_btn_Click(object sender, EventArgs e)
        {
            if (name_txt.Text != "" && phoneNumber_txt.Text != "" && email_txt.Text != "")
            {
                try
                {
                    string myInsertQuery = "INSERT INTO department  VALUES (" + depId_updwn.Value.ToString() + ", '" + name_txt.Text + "', '" + phoneNumber_txt.Text + "', '" + email_txt.Text + "');";
                    MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                    myCommand.Connection = sqlConnection;
                    myCommand.ExecuteNonQuery();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Some items are not filled!");
            }

            updateTable_btn.Enabled = false;
        }

        private void update_btn_Click(object sender, EventArgs e)
        {
            if (name_txt.Text != "" && phoneNumber_txt.Text != "" && email_txt.Text != "")
            {
                try
                {
                    string myInsertQuery = "UPDATE department " +
                                           "SET " + "name = '" + name_txt.Text + "', phoneNumber = '" + phoneNumber_txt.Text + "', email = '" + email_txt.Text + "' " +
                                           "WHERE depId = " + depId_updwn.Value.ToString() + ";";
                    MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                    myCommand.Connection = sqlConnection;
                    if (myCommand.ExecuteNonQuery() == -1)
                    {
                        MessageBox.Show("Department ID does not exist!");
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Some items are not filled!");
            }

            updateTable_btn.Enabled = false;
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string myInsertQuery = "DELETE FROM department " +
                                        "WHERE depId = " + depId_updwn.Value.ToString() + ";";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                if (myCommand.ExecuteNonQuery() == -1)
                {
                    MessageBox.Show("Department ID does not exist!");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            updateTable_btn.Enabled = false;
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlQuery = "SELECT* FROM department";
                departmentDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(departmentDataAdapter);
                departmentDataSet = new DataSet();
                departmentDataAdapter.Fill(departmentDataSet, "department");
                department_GridView.DataSource = departmentDataSet;
                department_GridView.DataMember = "department";
                updateTable_btn.Enabled = true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void updateTable_btn_Click(object sender, EventArgs e)
        {
            try
            {
                departmentDataAdapter.Update(departmentDataSet, "department");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void profCreate_btn_Click(object sender, EventArgs e)
        {
            if (profName_txt.Text != "" && profPhoneNumber_txt.Text != "" && profEmail_txt.Text != "")
            {
                try
                {
                    string myInsertQuery = "INSERT INTO professor  VALUES (" + profId_updwn.Value.ToString() + ", '" + profName_txt.Text + "', '" + profBirthdate_date.Value.Date.ToString("yyyy-MM-dd") + "', '" + profPhoneNumber_txt.Text + "', '" + profEmail_txt.Text + "');";
                    MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                    myCommand.Connection = sqlConnection;
                    myCommand.ExecuteNonQuery();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Some items are not filled!");
            }

            profUpdateTable_btn.Enabled = false;
        }

        private void profUpdate_btn_Click(object sender, EventArgs e)
        {
            if (profName_txt.Text != "" && profPhoneNumber_txt.Text != "" && profEmail_txt.Text != "")
            {
                try
                {
                    string myInsertQuery = "UPDATE professor " +
                                           "SET " + "name = '" + profName_txt.Text + "', birthdate = '" + profBirthdate_date.Value.Date.ToString("yyyy-MM-dd") + "', phoneNumber = '" + profPhoneNumber_txt.Text + "', email = '" + profEmail_txt.Text + "' " +
                                           "WHERE profId = " + profId_updwn.Value.ToString() + ";";
                    MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                    myCommand.Connection = sqlConnection;
                    if (myCommand.ExecuteNonQuery() == -1)
                    {
                        MessageBox.Show("Professor ID does not exist!");
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Some items are not filled!");
            }

            profUpdateTable_btn.Enabled = false;
        }

        private void profDelete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string myInsertQuery = "DELETE FROM professor " +
                                        "WHERE profId = " + profId_updwn.Value.ToString() + ";";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                if (myCommand.ExecuteNonQuery() == -1)
                {
                    MessageBox.Show("Professor ID does not exist!");
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            profUpdateTable_btn.Enabled = false;
        }

        private void profRefreshTable_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlQuery = "SELECT* FROM professor";
                professorDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(professorDataAdapter);
                professorDataSet = new DataSet();
                professorDataAdapter.Fill(professorDataSet, "professor");
                professor_GridView.DataSource = professorDataSet;
                professor_GridView.DataMember = "professor";
                profUpdateTable_btn.Enabled = true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void profUpdateTable_btn_Click(object sender, EventArgs e)
        {
            try
            {
                professorDataAdapter.Update(professorDataSet, "professor");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void studentCreate_btn_Click(object sender, EventArgs e)
        {
            if (studentName_txt.Text != "" && studentPhoneNumber_txt.Text != "" && studentEmail_txt.Text != "")
            {
                try
                {
                    string myInsertQuery = "INSERT INTO student  VALUES (" + studentUin_updwn.Value.ToString() + ", '" + studentName_txt.Text + "', '" + studentBirthdate_date.Value.Date.ToString("yyyy-MM-dd") + "', '" + studentPhoneNumber_txt.Text + "', '" + studentEmail_txt.Text + "', '" + studentDepId_updwn.Value.ToString() + "');";
                    MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                    myCommand.Connection = sqlConnection;
                    myCommand.ExecuteNonQuery();
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Some items are not filled!");
            }

            studentUpdateTable_btn.Enabled = false;
        }

        private void studentUpdate_btn_Click(object sender, EventArgs e)
        {
            if (studentName_txt.Text != "" && studentPhoneNumber_txt.Text != "" && studentEmail_txt.Text != "")
            {
                try
                {
                    string myInsertQuery = "UPDATE student " +
                                           "SET " + "name = '" + studentName_txt.Text + "', birthdate = '" + studentBirthdate_date.Value.Date.ToString("yyyy-MM-dd") + "', phoneNumber = '" + studentPhoneNumber_txt.Text + "', email = '" + studentEmail_txt.Text + "', depId = " + studentDepId_updwn.Value.ToString() + " " +
                                           "WHERE uin = " + studentUin_updwn.Value.ToString() + ";";
                    MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                    myCommand.Connection = sqlConnection;
                    if (myCommand.ExecuteNonQuery() == -1)
                    {
                        MessageBox.Show("Student UIN does not exist!");
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Some items are not filled!");
            }

            studentUpdateTable_btn.Enabled = false;
        }

        private void studentDelete_btn_Click(object sender, EventArgs e)
        {

        }

        private void studentRefreshTable_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlQuery = "SELECT* FROM student";
                studentDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(studentDataAdapter);
                studentDataSet = new DataSet();
                studentDataAdapter.Fill(studentDataSet, "student");
                student_GridView.DataSource = studentDataSet;
                student_GridView.DataMember = "student";
                studentUpdateTable_btn.Enabled = true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void studentUpdateTable_btn_Click(object sender, EventArgs e)
        {
            try
            {
                studentDataAdapter.Update(studentDataSet, "student");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void studentLookUp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                MySql.Data.MySqlClient.MySqlDataAdapter studentDepIdDataAdapter;
                DataSet studentDepIdDataSet;

                string sqlQuery = "SELECT depId, name FROM department";
                studentDepIdDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(studentDepIdDataAdapter);
                studentDepIdDataSet = new DataSet();
                studentDepIdDataAdapter.Fill(studentDepIdDataSet, "department");
                studentDepId_GridView.DataSource = studentDepIdDataSet;
                studentDepId_GridView.DataMember = "department";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
