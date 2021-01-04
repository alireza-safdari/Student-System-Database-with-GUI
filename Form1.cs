using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using Excel = Microsoft.Office.Interop.Excel;



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

        MySql.Data.MySqlClient.MySqlDataAdapter courseDataAdapter;
        DataSet courseDataSet;

        MySql.Data.MySqlClient.MySqlDataAdapter classDataAdapter;
        DataSet classDataSet;

        MySql.Data.MySqlClient.MySqlDataAdapter clubDataAdapter;
        DataSet clubDataSet;

        MySql.Data.MySqlClient.MySqlDataAdapter teachDataAdapter;
        DataSet teachDataSet;

        MySql.Data.MySqlClient.MySqlDataAdapter takenDataAdapter;
        DataSet takenDataSet;

        MySql.Data.MySqlClient.MySqlDataAdapter memberDataAdapter;
        DataSet memberDataSet;

        MySql.Data.MySqlClient.MySqlDataAdapter presidentDataAdapter;
        DataSet presidentDataSet;

        Random rnd = new Random();



        public Form1()
        {
            InitializeComponent();

            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            groupBox4.Enabled = false;
            groupBox5.Enabled = false;
            groupBox6.Enabled = false;
            groupBox7.Enabled = false;
            groupBox8.Enabled = false;
            groupBox9.Enabled = false;
            groupBox10.Enabled = false;
            groupBox11.Enabled = false;
            groupBox12.Enabled = false;
            groupBox13.Enabled = false;
            groupBox14.Enabled = false;
            groupBox15.Enabled = false;
            groupBox16.Enabled = false;
            groupBox17.Enabled = false;
            groupBox18.Enabled = false;
            groupBox19.Enabled = false;
            groupBox20.Enabled = false;
            groupBox22.Enabled = false;
            groupBox23.Enabled = false;
            groupBox26.Enabled = false;
            groupBox27.Enabled = false;
            groupBox28.Enabled = false;
            groupBox29.Enabled = false;
            groupBox30.Enabled = false;
            groupBox31.Enabled = false;
        }

        private void connectToServer_Click(object sender, EventArgs e)
        {
            string myConnectionString;
            // myConnectionString = "server=127.0.0.1;" + "uid=CSharp;" + "database=studentDb;" + "pwd=i am c#";
            myConnectionString = "server="+ serverIp_txt.Text + ";" + "uid=" + username_txt.Text + ";" + "database=" + databaseName_txt.Text + ";" + "pwd=" + password_txt.Text;

            try
            {
                sqlConnection = new MySql.Data.MySqlClient.MySqlConnection();
                sqlConnection.ConnectionString = myConnectionString;
                sqlConnection.Open();
                sqlConnection.StateChange += HandleSqlStatusChange;
                connectToServerBtn.Enabled = false;
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox4.Enabled = true;
                groupBox5.Enabled = true;
                groupBox6.Enabled = true;
                groupBox7.Enabled = true;
                groupBox8.Enabled = true;
                groupBox9.Enabled = true;
                groupBox10.Enabled = true;
                groupBox11.Enabled = true;
                groupBox12.Enabled = true;
                groupBox13.Enabled = true;
                groupBox14.Enabled = true;
                groupBox15.Enabled = true;
                groupBox16.Enabled = true;
                groupBox17.Enabled = true;
                groupBox18.Enabled = true;
                groupBox19.Enabled = true;
                groupBox20.Enabled = true;
                groupBox22.Enabled = true;
                groupBox23.Enabled = true;
                groupBox26.Enabled = true;
                groupBox27.Enabled = true;
                groupBox28.Enabled = true;
                groupBox29.Enabled = true;
                groupBox30.Enabled = true;
                groupBox31.Enabled = true;

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
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                groupBox5.Enabled = false;
                groupBox6.Enabled = false;
                groupBox7.Enabled = false;
                groupBox8.Enabled = false;
                groupBox9.Enabled = false;
                groupBox10.Enabled = false;
                groupBox11.Enabled = false;
                groupBox12.Enabled = false;
                groupBox13.Enabled = false;
                groupBox14.Enabled = false;
                groupBox15.Enabled = false;
                groupBox16.Enabled = false;
                groupBox17.Enabled = false;
                groupBox18.Enabled = false;
                groupBox19.Enabled = false;
                groupBox20.Enabled = false;
                groupBox22.Enabled = false;
                groupBox23.Enabled = false;
                groupBox26.Enabled = false;
                groupBox27.Enabled = false;
                groupBox28.Enabled = false;
                groupBox29.Enabled = false;
                groupBox30.Enabled = false;
                groupBox31.Enabled = false;

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
                    updateTable_btn.Enabled = false;
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
                    if (myCommand.ExecuteNonQuery() < 1)
                    {
                        MessageBox.Show("Department ID does not exist!");
                    }
                    updateTable_btn.Enabled = false;
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
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string myInsertQuery = "DELETE FROM department " +
                                        "WHERE depId = " + depId_updwn.Value.ToString() + ";";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                if (myCommand.ExecuteNonQuery() < 1)
                {
                    MessageBox.Show("Department ID does not exist!");
                }
                updateTable_btn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    profUpdateTable_btn.Enabled = false;
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
                    if (myCommand.ExecuteNonQuery() < 1)
                    {
                        MessageBox.Show("Professor ID does not exist!");
                    }
                    profUpdateTable_btn.Enabled = false;
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
        }

        private void profDelete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string myInsertQuery = "DELETE FROM professor " +
                                        "WHERE profId = " + profId_updwn.Value.ToString() + ";";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                if (myCommand.ExecuteNonQuery() < 1)
                {
                    MessageBox.Show("Professor ID does not exist!");
                }
                profUpdateTable_btn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                    studentUpdateTable_btn.Enabled = false;
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
                    if (myCommand.ExecuteNonQuery() < 1)
                    {
                        MessageBox.Show("Student UIN does not exist!");
                    }
                    studentUpdateTable_btn.Enabled = false;
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
        }

        private void studentDelete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string myInsertQuery = "DELETE FROM student " +
                                        "WHERE uin = " + studentUin_updwn.Value.ToString() + ";";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                if (myCommand.ExecuteNonQuery() < 1)
                {
                    MessageBox.Show("Student UIN does not exist!");
                }
                studentUpdateTable_btn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void courseCreate_btn_Click(object sender, EventArgs e)
        {
            if (courseCode_txt.Text != "" && courseName_txt.Text != "")
            {
                try
                {
                    string myInsertQuery = "INSERT INTO course  VALUES ('" + courseCode_txt.Text + "', '" + courseName_txt.Text + "', " + courseCredit_updwn.Value.ToString() + ", " + courseDepId_updwn.Value.ToString() + ");";
                    MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                    myCommand.Connection = sqlConnection;
                    myCommand.ExecuteNonQuery();
                    courseUpdateTable_btn.Enabled = false;
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
        }

        private void courseUpdate_btn_Click(object sender, EventArgs e)
        {
            if (courseCode_txt.Text != "" && courseName_txt.Text != "")
            {
                try
                {
                    string myInsertQuery = "UPDATE course " +
                                           "SET " + "name = '" + courseName_txt.Text + "', credit = " + courseCredit_updwn.Value.ToString() + ", depId = " + courseDepId_updwn.Value.ToString() + " " +
                                           "WHERE courseCode = '" + courseCode_txt.Text + "';";
                    MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                    myCommand.Connection = sqlConnection;
                    if (myCommand.ExecuteNonQuery() < 1)
                    {
                        MessageBox.Show("Course Code does not exist!");
                    }
                    courseUpdateTable_btn.Enabled = false;
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
        }

        private void courseDelete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string myInsertQuery = "DELETE FROM course " +
                                        "WHERE courseCode = '" + courseCode_txt.Text + "';";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                if (myCommand.ExecuteNonQuery() < 1)
                {
                    MessageBox.Show("Course Code does not exist!");
                }
                courseUpdateTable_btn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void courseRefreshTable_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlQuery = "SELECT* FROM course";
                courseDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(courseDataAdapter);
                courseDataSet = new DataSet();
                courseDataAdapter.Fill(courseDataSet, "course");
                course_GridView.DataSource = courseDataSet;
                course_GridView.DataMember = "course";
                courseUpdateTable_btn.Enabled = true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void courseUpdateTable_btn_Click(object sender, EventArgs e)
        {
            try
            {
                courseDataAdapter.Update(courseDataSet, "course");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void courseDepIdLookUp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                MySql.Data.MySqlClient.MySqlDataAdapter courseDepIdDataAdapter;
                DataSet courseDepIdDataSet;

                string sqlQuery = "SELECT depId, name FROM department";
                courseDepIdDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(courseDepIdDataAdapter);
                courseDepIdDataSet = new DataSet();
                courseDepIdDataAdapter.Fill(courseDepIdDataSet, "department");
                courseDepId_GridView.DataSource = courseDepIdDataSet;
                courseDepId_GridView.DataMember = "department";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void classCreate_btn_Click(object sender, EventArgs e)
        {
            if (classCourseCode_txt.Text != "")
            {
                try
                {
                    string myInsertQuery = "INSERT INTO class  VALUES (" + classId_updwn.Value.ToString() + ", " + classYear_updwn.Value.ToString() + ", " + classSemester_updwn.Value.ToString() + ", '" + classCourseCode_txt.Text + "');";
                    MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                    myCommand.Connection = sqlConnection;
                    myCommand.ExecuteNonQuery();
                    classUpdateTable_btn.Enabled = false;
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
        }

        private void classUpdate_btn_Click(object sender, EventArgs e)
        {
            if (classCourseCode_txt.Text != "")
            {
                try
                {
                    string myInsertQuery = "UPDATE class " +
                                           "SET " + "year = " + classYear_updwn.Value.ToString() + ", semester = " + classSemester_updwn.Value.ToString() + ", courseCode = '" + classCourseCode_txt.Text + "' " +
                                           "WHERE classId = " + classId_updwn.Value.ToString() + ";";
                    MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                    myCommand.Connection = sqlConnection;
                    if (myCommand.ExecuteNonQuery() < 1)
                    {
                        MessageBox.Show("Class ID does not exist!");
                    }
                    classUpdateTable_btn.Enabled = false;
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
        }

        private void classDelete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string myInsertQuery = "DELETE FROM class " +
                                        "WHERE classId = " + classId_updwn.Value.ToString() + ";";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                if (myCommand.ExecuteNonQuery() < 1)
                {
                    MessageBox.Show("Class ID does not exist!");
                }
                classUpdateTable_btn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void classRefreshTable_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlQuery = "SELECT* FROM class";
                classDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(classDataAdapter);
                classDataSet = new DataSet();
                classDataAdapter.Fill(classDataSet, "class");
                class_GridView.DataSource = classDataSet;
                class_GridView.DataMember = "class";
                classUpdateTable_btn.Enabled = true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void classUpdateTable_btn_Click(object sender, EventArgs e)
        {
            try
            {
                classDataAdapter.Update(classDataSet, "class");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void classCourseCodeLookUp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                MySql.Data.MySqlClient.MySqlDataAdapter classDepIdDataAdapter;
                DataSet classDepIdDataSet;

                string sqlQuery = "SELECT courseCode, name FROM course";
                classDepIdDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(classDepIdDataAdapter);
                classDepIdDataSet = new DataSet();
                classDepIdDataAdapter.Fill(classDepIdDataSet, "course");
                classCourseCode_GridView.DataSource = classDepIdDataSet;
                classCourseCode_GridView.DataMember = "course";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clubCreate_btn_Click(object sender, EventArgs e)
        {
            if (clubName_txt.Text != "" && clubEmail_txt.Text != "")
            {
                try
                {
                    string myInsertQuery = "INSERT INTO club  VALUES (" + clubId_updwn.Value.ToString() + ", '" + clubName_txt.Text + "', '" + clubEmail_txt.Text + "');";
                    MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                    myCommand.Connection = sqlConnection;
                    myCommand.ExecuteNonQuery();
                    clubUpdateTable_btn.Enabled = false;
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
        }

        private void clubUpdate_btn_Click(object sender, EventArgs e)
        {
            if (clubName_txt.Text != "" && clubEmail_txt.Text != "")
            {
                try
                {
                    string myInsertQuery = "UPDATE club " +
                                           "SET " + "name = '" + clubName_txt.Text + "', email = '" + clubEmail_txt.Text + "' " +
                                           "WHERE clubId = " + clubId_updwn.Value.ToString() + ";";
                    MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                    myCommand.Connection = sqlConnection;
                    if (myCommand.ExecuteNonQuery() < 1)
                    {
                        MessageBox.Show("Club ID does not exist!");
                    }
                    clubUpdateTable_btn.Enabled = false;
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
        }

        private void clubDelete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string myInsertQuery = "DELETE FROM club " +
                                        "WHERE clubId = " + clubId_updwn.Value.ToString() + ";";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                if (myCommand.ExecuteNonQuery() < 1)
                {
                    MessageBox.Show("Club ID does not exist!");
                }
                clubUpdateTable_btn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clubRefreshTable_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlQuery = "SELECT* FROM club";
                clubDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(clubDataAdapter);
                clubDataSet = new DataSet();
                clubDataAdapter.Fill(clubDataSet, "club");
                club_GridView.DataSource = clubDataSet;
                club_GridView.DataMember = "club";
                clubUpdateTable_btn.Enabled = true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clubUpdateTable_btn_Click(object sender, EventArgs e)
        {
            try
            {
                clubDataAdapter.Update(clubDataSet, "club");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void teachCreate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string myInsertQuery = "INSERT INTO teach  VALUES (" + teachProfId_updwn.Value.ToString() + ", " + teachClassId_updwn.Value.ToString() + ");";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                myCommand.ExecuteNonQuery();
                teachUpdateTable_btn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void teachDelete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string myInsertQuery = "DELETE FROM teach " +
                                        "WHERE profId = " + teachProfId_updwn.Value.ToString() + " AND classId = " + teachClassId_updwn.Value.ToString() +"; ";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                if (myCommand.ExecuteNonQuery() < 1)
                {
                    MessageBox.Show("Record does not exist!");
                }
                teachUpdateTable_btn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void teachRefreshTable_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlQuery = "SELECT* FROM teach";
                teachDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(teachDataAdapter);
                teachDataSet = new DataSet();
                teachDataAdapter.Fill(teachDataSet, "teach");
                teach_GridView.DataSource = teachDataSet;
                teach_GridView.DataMember = "teach";
                teachUpdateTable_btn.Enabled = true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void teachUpdateTable_btn_Click(object sender, EventArgs e)
        {
            try
            {
                teachDataAdapter.Update(teachDataSet, "teach");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void teachProfIdLookUp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                MySql.Data.MySqlClient.MySqlDataAdapter teachProfIdDataAdapter;
                DataSet teachProfIdDataSet;

                string sqlQuery = "SELECT profId, name FROM professor";
                teachProfIdDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(teachProfIdDataAdapter);
                teachProfIdDataSet = new DataSet();
                teachProfIdDataAdapter.Fill(teachProfIdDataSet, "professor");
                teachProfId_GridView.DataSource = teachProfIdDataSet;
                teachProfId_GridView.DataMember = "professor";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void teachClassIdLookUp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                MySql.Data.MySqlClient.MySqlDataAdapter teachClassIdDataAdapter;
                DataSet teachClassIdDataSet;

                string sqlQuery = "SELECT * FROM class";
                teachClassIdDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(teachClassIdDataAdapter);
                teachClassIdDataSet = new DataSet();
                teachClassIdDataAdapter.Fill(teachClassIdDataSet, "class");
                teachClassId_GridView.DataSource = teachClassIdDataSet;
                teachClassId_GridView.DataMember = "class";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void teakenCreate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string myInsertQuery = "INSERT INTO taken  VALUES (" + takenUin_updwn.Value.ToString() + ", " + takenClassId_updwn.Value.ToString() + ", " + takenGrade_updwn.Value.ToString() + ");";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                myCommand.ExecuteNonQuery();
                takenUpdateTable_btn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void teakenUpdate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string myInsertQuery = "UPDATE taken " +
                                        "SET " + "grade = " + takenGrade_updwn.Value.ToString() + " " +
                                        "WHERE uin = " + takenUin_updwn.Value.ToString() + " AND classId = " + takenClassId_updwn.Value.ToString() + ";";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                if (myCommand.ExecuteNonQuery() < 1)
                {
                    MessageBox.Show("Record does not exist for this student and this class!");
                }
                takenUpdateTable_btn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void teakenDelete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string myInsertQuery = "DELETE FROM taken " +
                                        "WHERE uin = " + takenUin_updwn.Value.ToString() + " AND classId = " + takenClassId_updwn.Value.ToString() + "; ";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                if (myCommand.ExecuteNonQuery() < 1)
                {
                    MessageBox.Show("Record does not exist!");
                }
                takenUpdateTable_btn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void takenRefreshTable_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlQuery = "SELECT* FROM taken";
                takenDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(takenDataAdapter);
                takenDataSet = new DataSet();
                takenDataAdapter.Fill(takenDataSet, "taken");
                taken_GridView.DataSource = takenDataSet;
                taken_GridView.DataMember = "taken";
                takenUpdateTable_btn.Enabled = true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void takenUpdateTable_btn_Click(object sender, EventArgs e)
        {
            try
            {
                takenDataAdapter.Update(takenDataSet, "taken");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void takenUinLookUp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                MySql.Data.MySqlClient.MySqlDataAdapter takenUinDataAdapter;
                DataSet takenUinDataSet;

                string sqlQuery = "SELECT uin, name FROM student";
                takenUinDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(takenUinDataAdapter);
                takenUinDataSet = new DataSet();
                takenUinDataAdapter.Fill(takenUinDataSet, "student");
                takenUin_GridView.DataSource = takenUinDataSet;
                takenUin_GridView.DataMember = "student";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void takenClassIdLookUp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                MySql.Data.MySqlClient.MySqlDataAdapter takenClassIdDataAdapter;
                DataSet takenClassIdDataSet;

                string sqlQuery = "SELECT * FROM class";
                takenClassIdDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(takenClassIdDataAdapter);
                takenClassIdDataSet = new DataSet();
                takenClassIdDataAdapter.Fill(takenClassIdDataSet, "class");
                takenClassId_GridView.DataSource = takenClassIdDataSet;
                takenClassId_GridView.DataMember = "class";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void memberCreate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string myInsertQuery = "INSERT INTO member  VALUES (" + memberUin_updwn.Value.ToString() + ", " + memberClubId_updwn.Value.ToString() + ");";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                myCommand.ExecuteNonQuery();
                memberUpdateTable_btn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void memberDelete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string myInsertQuery = "DELETE FROM member " +
                                       "WHERE uin = " + memberUin_updwn.Value.ToString() + " AND clubId = " + memberClubId_updwn.Value.ToString() + "; ";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                if (myCommand.ExecuteNonQuery() < 1)
                {
                    MessageBox.Show("Record does not exist!");
                }
                memberUpdateTable_btn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void memberRefreshTable_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlQuery = "SELECT* FROM member";
                memberDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(memberDataAdapter);
                memberDataSet = new DataSet();
                memberDataAdapter.Fill(memberDataSet, "member");
                member_GridView.DataSource = memberDataSet;
                member_GridView.DataMember = "member";
                memberUpdateTable_btn.Enabled = true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void memberUpdateTable_btn_Click(object sender, EventArgs e)
        {
            try
            {
                memberDataAdapter.Update(memberDataSet, "member");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void memberUinLookUp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                MySql.Data.MySqlClient.MySqlDataAdapter memberUinDataAdapter;
                DataSet memberUinDataSet;

                string sqlQuery = "SELECT uin, name FROM student";
                memberUinDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(memberUinDataAdapter);
                memberUinDataSet = new DataSet();
                memberUinDataAdapter.Fill(memberUinDataSet, "student");
                memberUin_GridView.DataSource = memberUinDataSet;
                memberUin_GridView.DataMember = "student";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void memberClubIdLookUp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                MySql.Data.MySqlClient.MySqlDataAdapter memberClubIdDataAdapter;
                DataSet memberClubIdDataSet;

                string sqlQuery = "SELECT clubId, name FROM club";
                memberClubIdDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(memberClubIdDataAdapter);
                memberClubIdDataSet = new DataSet();
                memberClubIdDataAdapter.Fill(memberClubIdDataSet, "club");
                memberClubId_GridView.DataSource = memberClubIdDataSet;
                memberClubId_GridView.DataMember = "club";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void presidentCreate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string myInsertQuery = "INSERT INTO president  VALUES (" + presidentUin_updwn.Value.ToString() + ", " + presidentClubId_updwn.Value.ToString() + ");";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                myCommand.ExecuteNonQuery();
                presidentUpdateTable_btn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void presidentDelete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string myInsertQuery = "DELETE FROM president " +
                                       "WHERE uin = " + presidentUin_updwn.Value.ToString() + " AND clubId = " + presidentClubId_updwn.Value.ToString() + "; ";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                if (myCommand.ExecuteNonQuery() < 1)
                {
                    MessageBox.Show("Record does not exist!");
                }
                presidentUpdateTable_btn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void presidentRefreshTable_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlQuery = "SELECT* FROM president";
                presidentDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(presidentDataAdapter);
                presidentDataSet = new DataSet();
                presidentDataAdapter.Fill(presidentDataSet, "president");
                president_GridView.DataSource = presidentDataSet;
                president_GridView.DataMember = "president";
                presidentUpdateTable_btn.Enabled = true;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void presidentUpdateTable_btn_Click(object sender, EventArgs e)
        {
            try
            {
                presidentDataAdapter.Update(presidentDataSet, "president");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void presidentUinLookUp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                MySql.Data.MySqlClient.MySqlDataAdapter presidentUinDataAdapter;
                DataSet presidentUinDataSet;

                string sqlQuery = "SELECT uin, name FROM student";
                presidentUinDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(presidentUinDataAdapter);
                presidentUinDataSet = new DataSet();
                presidentUinDataAdapter.Fill(presidentUinDataSet, "student");
                presidentUin_GridView.DataSource = presidentUinDataSet;
                presidentUin_GridView.DataMember = "student";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void presidentClubIdLookUp_btn_Click(object sender, EventArgs e)
        {
            try
            {
                MySql.Data.MySqlClient.MySqlDataAdapter residentClubIdDataAdapter;
                DataSet presidentClubIdDataSet;

                string sqlQuery = "SELECT clubId, name FROM club";
                residentClubIdDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(residentClubIdDataAdapter);
                presidentClubIdDataSet = new DataSet();
                residentClubIdDataAdapter.Fill(presidentClubIdDataSet, "club");
                presidentClubId_GridView.DataSource = presidentClubIdDataSet;
                presidentClubId_GridView.DataMember = "club";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void generateData_btn_Click(object sender, EventArgs e)
        {
            var outPutDirectory = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase);
            MessageBox.Show("Make sure the Excel file provided for data generation is located at: " + outPutDirectory);

            var excelPath = System.IO.Path.Combine(outPutDirectory, "StudentDatabaseSample.xlsx");

            //Create COM Objects. Create a COM object for everything that is referenced
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(excelPath);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;



            decimal nDepartment = nDepartment_updwn.Value;
            decimal nProf = nProfessor_updwn.Value;
            decimal nStudent = nStudent_updwn.Value;
            decimal nCourse = nCourse_updwn.Value;
            decimal nClass = nClasses_updwn.Value;
            decimal avgNStudentPerClass = avgNStudentPerClass_updwn.Value;
            decimal nClubs = nClub_updwn.Value;
            decimal avgNStudentsPerClub = avgNStudentPerClass_updwn.Value;



            decimal depIdMin = 100;
            decimal depIdMax = depIdMin + nDepartment - 1;
            for (decimal i = 0; i < nDepartment; i++)
            {
                dataGenerateStatus_lbl.Text = "Generating " + i + "/" + nDepartment + " entries for \"department\" table...";

                decimal depId = depIdMin + i;
                string name = xlRange.Cells[i + 2, 3].Value2.ToString();
                string phoneNumber = getAPhoneNumber();
                string email = getEmail(name);
                try
                {
                    string myInsertQuery = "INSERT INTO department  VALUES (" + depId + ", '" + name + "', '" + phoneNumber + "', '" + email + "');";
                    MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                    myCommand.Connection = sqlConnection;
                    myCommand.ExecuteNonQuery();
                    updateTable_btn.Enabled = false;
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    // MessageBox.Show(ex.Message + "\n" + "Happened at" + name + "where i = " + i.ToString());
                    i--;
                }
            }



            decimal profIdMin = 1000;
            decimal profIdMax = profIdMin + nProf - 1;
            for (decimal i = 0; i < nProf; i++)
            {
                dataGenerateStatus_lbl.Text = "Generating " + i + "/" + nProf + " entries for \"professor\" table...";

                decimal profId = profIdMin + i;

                decimal randFirstNameRowN = rnd.Next(2, 502);
                decimal randFamilyNameRowN = rnd.Next(2, 502);

                string name = xlRange.Cells[randFirstNameRowN, 1].Value2.ToString() + " " + xlRange.Cells[randFamilyNameRowN, 1].Value2.ToString();
                string birhdate = rnd.Next(1950, 1996).ToString() + "-" + rnd.Next(1, 13).ToString("00") + "-" + rnd.Next(1, 29).ToString("00"); // take note 1996, 13 and 29 are not included
                string phoneNumber = getAPhoneNumber();
                string email = getEmail(name);
                try
                {
                    string myInsertQuery = "INSERT INTO professor  VALUES (" + profId + ", '" + name + "', '" + birhdate + "', '" + phoneNumber + "', '" + email + "');";
                    MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                    myCommand.Connection = sqlConnection;
                    myCommand.ExecuteNonQuery();
                    profUpdateTable_btn.Enabled = false;
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    i--;
                }
            }



            decimal uinMin = 10000;
            decimal uinMax = uinMin + nStudent - 1;
            for (decimal i = 0; i < nStudent; i++)
            {
                dataGenerateStatus_lbl.Text = "Generating " + i + "/" + nStudent + " entries for \"student\" table...";

                decimal uin = uinMin + i;

                decimal randFirstNameRowN = rnd.Next(2, 502);
                decimal randFamilyNameRowN = rnd.Next(2, 502);

                string name = xlRange.Cells[randFirstNameRowN, 1].Value2.ToString() + " " + xlRange.Cells[randFamilyNameRowN, 1].Value2.ToString();
                string birhdate = rnd.Next(1990, 2002).ToString() + "-" + rnd.Next(1, 13).ToString("00") + "-" + rnd.Next(1, 29).ToString("00"); // take note 1996, 13 and 29 are not included
                string phoneNumber = getAPhoneNumber();
                string email = getEmail(name);
                string depId = rnd.Next(Convert.ToInt32(depIdMin), Convert.ToInt32(depIdMax + 1)).ToString();
                try
                {
                    string myInsertQuery = "INSERT INTO student  VALUES (" + uin + ", '" + name + "', '" + birhdate + "', '" + phoneNumber + "', '" + email + "', " + depId + ");";
                    MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                    myCommand.Connection = sqlConnection;
                    myCommand.ExecuteNonQuery();
                    studentUpdateTable_btn.Enabled = false;
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    i--;
                }
            }



            decimal courseMin = 0;
            decimal courseMax = courseMin + nCourse - 1;
            string[] courseCodes = new String[Convert.ToInt32(nCourse)];
            for (decimal i = 0; i < nCourse; i++)
            {
                dataGenerateStatus_lbl.Text = "Generating " + i + "/" + nCourse + " entries for \"course\" table...";

                string courseCode = getACourseCode();
                decimal randCourseNameRowN = rnd.Next(2, 1698);
                string name = xlRange.Cells[randCourseNameRowN, 4].Value2.ToString();
                string credit = rnd.Next(1, 6).ToString();
                string depId = rnd.Next(Convert.ToInt32(depIdMin), Convert.ToInt32(depIdMax + 1)).ToString();
                try
                {
                    string myInsertQuery = "INSERT INTO course  VALUES ('" + courseCode + "', '" + name + "', " + credit + ", " + depId + ");";
                    MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                    myCommand.Connection = sqlConnection;
                    myCommand.ExecuteNonQuery();
                    courseCodes[Convert.ToInt32(i)] = courseCode;
                    courseUpdateTable_btn.Enabled = false;
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    i--;
                }
            }



            decimal classIdMin = 10000;
            decimal classIdMax = classIdMin + nClass - 1;
            for (decimal i = 0; i < nClass; i++)
            {
                dataGenerateStatus_lbl.Text = "Generating " + i + "/" + nClass + " entries for \"class\" table...";

                string classId = (classIdMin + i).ToString();
                string year = rnd.Next(2010, 2020).ToString();
                string semester = rnd.Next(1, 4).ToString();
                string courseCode = courseCodes[rnd.Next(Convert.ToInt32(courseMin), Convert.ToInt32(courseMax + 1))];
                try
                {
                    string myInsertQuery = "INSERT INTO class  VALUES (" + classId + ", " + year + ", " + semester + ", '" + courseCode + "');";
                    MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                    myCommand.Connection = sqlConnection;
                    myCommand.ExecuteNonQuery();
                    classUpdateTable_btn.Enabled = false;
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    i--;
                }
            }



            for (decimal i = classIdMin; i < classIdMax; i++)
            {
                dataGenerateStatus_lbl.Text = "Generating " + i + "/~" + classIdMax + " entries for \"teach\" table...";

                string classId = i.ToString();
                string profId = rnd.Next(Convert.ToInt32(profIdMin), Convert.ToInt32(profIdMax + 1)).ToString();
                try
                {
                    string myInsertQuery = "INSERT INTO teach  VALUES (" + profId + ", " + classId + ");";
                    MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                    myCommand.Connection = sqlConnection;
                    myCommand.ExecuteNonQuery();
                    classUpdateTable_btn.Enabled = false;
                    if (rnd.Next(1, 31) % 30 == 0)
                    {
                        i--; // resulting in more than one teacher
                    }
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    i--;
                }
            }



            for (decimal i = 0; i < nClass * avgNStudentPerClass; i++)
            {
                dataGenerateStatus_lbl.Text = "Generating " + i + "/" + nClass * avgNStudentPerClass + " entries for \"taken\" table...";

                string uin = rnd.Next(Convert.ToInt32(uinMin), Convert.ToInt32(uinMax + 1)).ToString();
                string classId = rnd.Next(Convert.ToInt32(classIdMin), Convert.ToInt32(classIdMax + 1)).ToString();
                decimal randGrade = rnd.Next(0, 100);

                if (randGrade < 5)
                    randGrade = rnd.Next(0, 70);
                else if (randGrade < 95)
                    randGrade = rnd.Next(70, 95);
                else
                    randGrade = rnd.Next(95, 101);

                string grade = randGrade.ToString();

                try
                {
                    string myInsertQuery = "INSERT INTO taken  VALUES (" + uin + ", " + classId + ", " + grade + ");";
                    MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                    myCommand.Connection = sqlConnection;
                    myCommand.ExecuteNonQuery();
                    takenUpdateTable_btn.Enabled = false;
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    i--;
                }
            }



            decimal clubIdMin = 100;
            decimal clubIdMax = clubIdMin + nClubs - 1;
            for (decimal i = 0; i < nClubs; i++)
            {
                dataGenerateStatus_lbl.Text = "Generating " + i + "/" + nClubs + " entries for \"club\" table...";

                string clubId = (clubIdMin + i).ToString();
                string name = xlRange.Cells[i + 2, 5].Value2.ToString();
                string email = getEmail(name);
                try
                {
                    string myInsertQuery = "INSERT INTO club  VALUES (" + clubId + ", '" + name + "', '" + email + "');";
                    MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                    myCommand.Connection = sqlConnection;
                    myCommand.ExecuteNonQuery();
                    clubUpdateTable_btn.Enabled = false;
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    // MessageBox.Show(ex.Message + "\n" + "Happened at" + name + "where i = " + i.ToString());
                    i--;
                }
            }



            for (decimal i = 0; i < nClubs * avgNStudentsPerClub; i++)
            {
                dataGenerateStatus_lbl.Text = "Generating " + i + "/" + nClubs * avgNStudentsPerClub + " entries for \"member\" table...";

                string uin = rnd.Next(Convert.ToInt32(uinMin), Convert.ToInt32(uinMax + 1)).ToString();
                string clubId = rnd.Next(Convert.ToInt32(clubIdMin), Convert.ToInt32(clubIdMax + 1)).ToString();

                try
                {
                    string myInsertQuery = "INSERT INTO member  VALUES (" + uin + ", " + clubId + ");";
                    MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                    myCommand.Connection = sqlConnection;
                    myCommand.ExecuteNonQuery();
                    memberUpdateTable_btn.Enabled = false;
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    i--;
                }
            }



            for (int i = 0; i < nClubs; i++)
            {
                dataGenerateStatus_lbl.Text = "Generating " + i + "/" + nClubs + " entries for \"president\" table...";

                string uin = rnd.Next(Convert.ToInt32(uinMin), Convert.ToInt32(uinMax + 1)).ToString();
                string clubId = (clubIdMin + i).ToString();

                try
                {
                    string myInsertQuery = "INSERT INTO president  VALUES (" + uin + ", " + clubId + ");";
                    MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                    myCommand.Connection = sqlConnection;
                    myCommand.ExecuteNonQuery();
                    presidentUpdateTable_btn.Enabled = false;
                }
                catch (MySql.Data.MySqlClient.MySqlException ex)
                {
                    i--;
                }
            }


            dataGenerateStatus_lbl.Text = "All entries are generated!";


            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();

            //rule of thumb for releasing com objects:
            //  never use two dots, all COM objects must be referenced and released individually
            //  ex: [somthing].[something].[something] is bad

            //release com objects to fully kill excel process from running in the background
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange);
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorksheet);

            //close and release
            xlWorkbook.Close();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkbook);

            //quit and release
            xlApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);

        }

        private string getAPhoneNumber()
        {
            string phoneNumber;
            phoneNumber = "(";
            phoneNumber += rnd.Next(1, 10).ToString();
            phoneNumber += rnd.Next(0, 10).ToString();
            phoneNumber += rnd.Next(0, 10).ToString();
            phoneNumber += ")";
            phoneNumber += rnd.Next(0, 10).ToString();
            phoneNumber += rnd.Next(0, 10).ToString();
            phoneNumber += rnd.Next(0, 10).ToString();
            phoneNumber += "-";
            phoneNumber += rnd.Next(0, 10).ToString();
            phoneNumber += rnd.Next(0, 10).ToString();
            phoneNumber += rnd.Next(0, 10).ToString();
            phoneNumber += rnd.Next(0, 10).ToString();

            return phoneNumber;
        }

        private string getEmail(string input)
        {
            string email = Regex.Replace(input, @"\s", "");
            var emailSize = email.Length;
            if (emailSize > 35)
            {
                emailSize = 35;
            }
            email = email.Substring(0, emailSize) + "@uni.org";
            return email;
        }

        private string getACourseCode()
        {
            string courseCode = "";
            switch(rnd.Next(1, 8))
            {
                case 1:
                    courseCode = "ABC";
                    break;
                case 2:
                    courseCode = "DEF";
                    break;
                case 3:
                    courseCode = "GHI";
                    break;
                case 4:
                    courseCode = "JKL";
                    break;
                case 5:
                    courseCode = "MNO";
                    break;
                case 6:
                    courseCode = "PQR";
                    break;
                case 7:
                    courseCode = "STU";
                    break;
            }
            courseCode += "-";
            courseCode += rnd.Next(1000, 10000).ToString("0000");


            return courseCode;
        }

        private void deleteAllEntries_btn_Click(object sender, EventArgs e)
        {
            deleteStatus_lbl.Text = "Deleting entries in \"president\" table...";
            try
            {
                string myInsertQuery = "DELETE FROM president;";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                myCommand.ExecuteNonQuery();
                presidentUpdateTable_btn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            deleteStatus_lbl.Text = "Deleting entries in \"member\" table...";
            try
            {
                string myInsertQuery = "DELETE FROM member;";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                myCommand.ExecuteNonQuery();
                memberUpdateTable_btn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            deleteStatus_lbl.Text = "Deleting entries in \"club\" table...";
            try
            {
                string myInsertQuery = "DELETE FROM club;";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                myCommand.ExecuteNonQuery();
                clubUpdateTable_btn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            deleteStatus_lbl.Text = "Deleting entries in \"taken\" table...";
            try
            {
                string myInsertQuery = "DELETE FROM taken;";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                myCommand.ExecuteNonQuery();
                takenUpdateTable_btn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            deleteStatus_lbl.Text = "Deleting entries in \"teach\" table...";
            try
            {
                string myInsertQuery = "DELETE FROM teach;";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                myCommand.ExecuteNonQuery();
                teachUpdateTable_btn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            deleteStatus_lbl.Text = "Deleting entries in \"class\" table...";
            try
            {
                string myInsertQuery = "DELETE FROM class;";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                myCommand.ExecuteNonQuery();
                classUpdateTable_btn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            deleteStatus_lbl.Text = "Deleting entries in \"course\" table...";
            try
            {
                string myInsertQuery = "DELETE FROM course;";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                myCommand.ExecuteNonQuery();
                courseUpdateTable_btn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            deleteStatus_lbl.Text = "Deleting entries in \"student\" table...";
            try
            {
                string myInsertQuery = "DELETE FROM student;";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                myCommand.ExecuteNonQuery();
                studentUpdateTable_btn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            deleteStatus_lbl.Text = "Deleting entries in \"professor\" table...";
            try
            {
                string myInsertQuery = "DELETE FROM Professor;";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                myCommand.ExecuteNonQuery();
                profUpdateTable_btn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            deleteStatus_lbl.Text = "Deleting entries in \"department\" table...";
            try
            {
                string myInsertQuery = "DELETE FROM department;";
                MySql.Data.MySqlClient.MySqlCommand myCommand = new MySql.Data.MySqlClient.MySqlCommand(myInsertQuery);
                myCommand.Connection = sqlConnection;
                myCommand.ExecuteNonQuery();
                updateTable_btn.Enabled = false;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            deleteStatus_lbl.Text = "Deleting all entries is completed!";
        }

        private void appStudentInformation_btn_Click(object sender, EventArgs e)
        {
            decimal uin = appStudentUin_updwn.Value;

            try
            {
                MySql.Data.MySqlClient.MySqlDataAdapter studentPersonalInformationDataAdapter;
                DataSet studentPersonalInformationDataSet;

                string sqlQuery = "SELECT student.uin as 'UIN', student.name as 'Name', student.birthdate as 'Date of Birth', student.phoneNumber as 'Phone Number', student.email as 'Email', department.name as 'Department' " + 
                                  "FROM student, department " + 
                                  "WHERE department.depId = student.depId AND student.uin =" + uin + ";";
                studentPersonalInformationDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(studentPersonalInformationDataAdapter);
                studentPersonalInformationDataSet = new DataSet();
                studentPersonalInformationDataAdapter.Fill(studentPersonalInformationDataSet, "personal information");
                studentPersonalInformation_GridView.DataSource = studentPersonalInformationDataSet;
                studentPersonalInformation_GridView.DataMember = "personal information";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }



            try
            {
                MySql.Data.MySqlClient.MySqlDataAdapter studentCoursesDataAdapter;
                DataSet studentCoursesDataSet;

                string sqlQuery = "SELECT class.classId as 'Class ID', course.courseCode as 'Course Code', course.name as 'Course Name', class.year as 'Year', class.Semester as 'Semester', course.credit as 'Credit Hours', taken.grade as 'Grade', allAverages.courseAverage as 'Class Average', allAverages.bestGrade as 'Top Score', professor.name as 'Professor Name' " +
                                  "FROM professor, taken, class, course, teach, (SELECT classId, (sum(taken.grade)/count(taken.uin)) as courseAverage, max(taken.grade) as bestGrade FROM taken group by classId) as allAverages " +
                                  "WHERE  allAverages.classId = class.classId AND teach.profId = professor.profId AND teach.classId = class.classId AND course.courseCode = class.courseCode AND class.classId = taken.classId AND taken.uin = " + uin +";";
                studentCoursesDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(studentCoursesDataAdapter);
                studentCoursesDataSet = new DataSet();
                studentCoursesDataAdapter.Fill(studentCoursesDataSet, "courses taken");
                studentCoursesTaken_GridView.DataSource = studentCoursesDataSet;
                studentCoursesTaken_GridView.DataMember = "courses taken";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }



            try
            {
                MySql.Data.MySqlClient.MySqlDataAdapter studentGpaDataAdapter;
                DataSet studentGpanDataSet;

                string sqlQuery = "SELECT student.name as 'Name', (sum(taken.grade * course.credit)/(sum(course.credit))) as 'GPA', sum(case when taken.grade > 60 then course.credit end) as 'Total Credit Passed', sum(course.credit) as 'Total Credit Taken' " + 
                                  "FROM student, taken, course, class " +
                                  "WHERE course.courseCode = class.courseCode AND class.classId = taken.classId AND taken.uin = student.uin and student.uin =" + uin + ";";
                studentGpaDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(studentGpaDataAdapter);
                studentGpanDataSet = new DataSet();
                studentGpaDataAdapter.Fill(studentGpanDataSet, "GPA");
                studentGpa_GridView.DataSource = studentGpanDataSet;
                studentGpa_GridView.DataMember = "GPA";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


            try
            {
                MySql.Data.MySqlClient.MySqlDataAdapter studentMembershipDataAdapter;
                DataSet studentMembershipDataSet;

                string sqlQuery = "SELECT club.name as 'Name', 'Active Member' as 'Membership' " + 
                                  "FROM member, club " + 
                                  "WHERE club.clubId = member.clubId AND member.uin =" + uin + ";";
                studentMembershipDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(studentMembershipDataAdapter);
                studentMembershipDataSet = new DataSet();
                studentMembershipDataAdapter.Fill(studentMembershipDataSet, "Membership");
                studentClubMembership_GridView.DataSource = studentMembershipDataSet;
                studentClubMembership_GridView.DataMember = "Membership";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


            try
            {
                MySql.Data.MySqlClient.MySqlDataAdapter studentPresidentDataAdapter;
                DataSet studentPresidentDataSet;

                string sqlQuery = "SELECT club.name as 'Name', 'President' as 'Role' " +
                                  "FROM president, club " +
                                  "WHERE club.clubId = president.clubId AND president.uin =" + uin + ";";
                studentPresidentDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(studentPresidentDataAdapter);
                studentPresidentDataSet = new DataSet();
                studentPresidentDataAdapter.Fill(studentPresidentDataSet, "President");
                studentPresident_GridView.DataSource = studentPresidentDataSet;
                studentPresident_GridView.DataMember = "President";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void appPrefessorLookUp_btn_Click(object sender, EventArgs e)
        {
            decimal profId = appProfessorId_updown.Value;

            try
            {
                MySql.Data.MySqlClient.MySqlDataAdapter professorPersonalInformationDataAdapter;
                DataSet professorPersonalInformationDataSet;

                string sqlQuery = "SELECT professor.profId as 'Professor ID', professor.name as 'Name', professor.birthdate as 'Date of Birth', professor.phoneNumber as 'Phone Number', professor.email as 'Email' " + 
                                  "FROM professor " + 
                                  "WHERE professor.profId =" + profId + ";";
                professorPersonalInformationDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(professorPersonalInformationDataAdapter);
                professorPersonalInformationDataSet = new DataSet();
                professorPersonalInformationDataAdapter.Fill(professorPersonalInformationDataSet, "personal information");
                professorPersonalInformation_GridView.DataSource = professorPersonalInformationDataSet;
                professorPersonalInformation_GridView.DataMember = "personal information";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }



            try
            {
                MySql.Data.MySqlClient.MySqlDataAdapter professorCourseTaughtDataAdapter;
                DataSet professorCourseTaughtDataSet;

                string sqlQuery = "SELECT class.classId as 'Class ID', course.courseCode as 'Course Code', course.name as 'Name', class.year as 'Year', class.semester  as 'Semester', course.credit as 'Credit Hours', (sum(taken.grade)/count(taken.uin)) as 'Class Average', max(taken.grade) as 'Top Scpre' " +
                                  "FROM professor, teach, class, course, taken " +
                                  "WHERE taken.classId = class.classId  AND class.courseCode = course.courseCode AND class.classId = teach.classId AND teach.profId = professor.profId AND professor.profId =" + profId + " " +
                                  "group by class.classId;";
                professorCourseTaughtDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(professorCourseTaughtDataAdapter);
                professorCourseTaughtDataSet = new DataSet();
                professorCourseTaughtDataAdapter.Fill(professorCourseTaughtDataSet, "Course Taught");
                professorCourseTaught_GridView.DataSource = professorCourseTaughtDataSet;
                professorCourseTaught_GridView.DataMember = "Course Taught";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void appCourseLookUp_btn_Click(object sender, EventArgs e)
        {
            string courseCode = appCourseCode_txt.Text;
            try
            {
                MySql.Data.MySqlClient.MySqlDataAdapter courseHistoryTaughtDataAdapter;
                DataSet courseHistoryTaughtDataSet;
                string sqlQuery = "SELECT class.classId as 'Class ID', course.courseCode as 'Course Code', course.name as 'Course Name', course.credit as 'Credit Hours', class.year as 'Year', class.Semester as 'Semester', allAverages.courseAverage as 'Class Average', allAverages.bestGrade as 'Top Score', professor.name as 'Professor Name', professor.email as 'Professor Email', professor.profId as 'Professor ID' " +
                                  "FROM professor, course, class, teach, (SELECT classId, (sum(taken.grade)/count(taken.uin)) as courseAverage, max(taken.grade) as bestGrade FROM taken group by classId) as allAverages " +
                                  "WHERE allAverages.classId = class.classId AND professor.profId = teach.profId AND teach.classId = class.classId AND class.courseCode = course.courseCode AND course.courseCode = '" + courseCode + "';";
                courseHistoryTaughtDataAdapter = new MySql.Data.MySqlClient.MySqlDataAdapter(sqlQuery, sqlConnection);
                MySql.Data.MySqlClient.MySqlCommandBuilder cb = new MySql.Data.MySqlClient.MySqlCommandBuilder(courseHistoryTaughtDataAdapter);
                courseHistoryTaughtDataSet = new DataSet();
                courseHistoryTaughtDataAdapter.Fill(courseHistoryTaughtDataSet, "Course History");
                courseHistory_GridView.DataSource = courseHistoryTaughtDataSet;
                courseHistory_GridView.DataMember = "Course History";
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
}
}
