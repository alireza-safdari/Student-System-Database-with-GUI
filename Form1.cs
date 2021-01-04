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
    }
}
