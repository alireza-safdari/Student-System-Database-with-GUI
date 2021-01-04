using System;

namespace Student_Management_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.departmentInsert = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.delete_btn = new System.Windows.Forms.Button();
            this.update_btn = new System.Windows.Forms.Button();
            this.email_txt = new System.Windows.Forms.MaskedTextBox();
            this.create_btn = new System.Windows.Forms.Button();
            this.email_lbl = new System.Windows.Forms.Label();
            this.phoneNumber_txt = new System.Windows.Forms.MaskedTextBox();
            this.phoneNumber_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.depId_label = new System.Windows.Forms.Label();
            this.depId_updwn = new System.Windows.Forms.NumericUpDown();
            this.name_txt = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.departments_lbl = new System.Windows.Forms.Label();
            this.updateTable_btn = new System.Windows.Forms.Button();
            this.department_GridView = new System.Windows.Forms.DataGridView();
            this.refresh_btn = new System.Windows.Forms.Button();
            this.professorInsert = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.profBirthdate_date = new System.Windows.Forms.DateTimePicker();
            this.profBirthdate_lbl = new System.Windows.Forms.Label();
            this.profDelete_btn = new System.Windows.Forms.Button();
            this.profUpdate_btn = new System.Windows.Forms.Button();
            this.profCreate_btn = new System.Windows.Forms.Button();
            this.profEmail_txt = new System.Windows.Forms.MaskedTextBox();
            this.profEmail_lbl = new System.Windows.Forms.Label();
            this.profPhoneNumber_txt = new System.Windows.Forms.MaskedTextBox();
            this.profPhoneNumber_lbl = new System.Windows.Forms.Label();
            this.profName_lbl = new System.Windows.Forms.Label();
            this.profId_lbl = new System.Windows.Forms.Label();
            this.profId_updwn = new System.Windows.Forms.NumericUpDown();
            this.profName_txt = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.professors_lbl = new System.Windows.Forms.Label();
            this.profUpdateTable_btn = new System.Windows.Forms.Button();
            this.professor_GridView = new System.Windows.Forms.DataGridView();
            this.profRefreshTable_btn = new System.Windows.Forms.Button();
            this.studentInsert = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.studentDepId_updwn = new System.Windows.Forms.NumericUpDown();
            this.studentDepId_lbl = new System.Windows.Forms.Label();
            this.studentBirthdate_date = new System.Windows.Forms.DateTimePicker();
            this.studentBirthdate_lbl = new System.Windows.Forms.Label();
            this.studentDelete_btn = new System.Windows.Forms.Button();
            this.studentUpdate_btn = new System.Windows.Forms.Button();
            this.studentCreate_btn = new System.Windows.Forms.Button();
            this.studentEmail_txt = new System.Windows.Forms.MaskedTextBox();
            this.studentEmail_lbl = new System.Windows.Forms.Label();
            this.studentPhoneNumber_txt = new System.Windows.Forms.MaskedTextBox();
            this.studentPhoneNumber_lbl = new System.Windows.Forms.Label();
            this.studentName_lbl = new System.Windows.Forms.Label();
            this.studentUin_lbl = new System.Windows.Forms.Label();
            this.studentUin_updwn = new System.Windows.Forms.NumericUpDown();
            this.studentName_txt = new System.Windows.Forms.MaskedTextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.studentLookUp_btn = new System.Windows.Forms.Button();
            this.student_lbl = new System.Windows.Forms.Label();
            this.studentDepIdTable_lbl = new System.Windows.Forms.Label();
            this.studentDepId_GridView = new System.Windows.Forms.DataGridView();
            this.studentUpdateTable_btn = new System.Windows.Forms.Button();
            this.student_GridView = new System.Windows.Forms.DataGridView();
            this.studentRefreshTable_btn = new System.Windows.Forms.Button();
            this.courseInsert = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.courseCredit_updwn = new System.Windows.Forms.NumericUpDown();
            this.courseDepId_updwn = new System.Windows.Forms.NumericUpDown();
            this.courseDepId_lbl = new System.Windows.Forms.Label();
            this.courseDelete_btn = new System.Windows.Forms.Button();
            this.courseUpdate_btn = new System.Windows.Forms.Button();
            this.courseCreate_btn = new System.Windows.Forms.Button();
            this.courseCode_txt = new System.Windows.Forms.MaskedTextBox();
            this.courseCredit_lbl = new System.Windows.Forms.Label();
            this.courseName_lbl = new System.Windows.Forms.Label();
            this.courseCode_lbl = new System.Windows.Forms.Label();
            this.courseName_txt = new System.Windows.Forms.MaskedTextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.courseDepIdLookUp_btn = new System.Windows.Forms.Button();
            this.course_lbl = new System.Windows.Forms.Label();
            this.courseDepIdTable_lbl = new System.Windows.Forms.Label();
            this.courseDepId_GridView = new System.Windows.Forms.DataGridView();
            this.courseUpdateTable_btn = new System.Windows.Forms.Button();
            this.course_GridView = new System.Windows.Forms.DataGridView();
            this.courseRefreshTable_btn = new System.Windows.Forms.Button();
            this.classInsert = new System.Windows.Forms.TabPage();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.classId_updwn = new System.Windows.Forms.NumericUpDown();
            this.classSemester_updwn = new System.Windows.Forms.NumericUpDown();
            this.classYear_updwn = new System.Windows.Forms.NumericUpDown();
            this.classCourseCode_lbl = new System.Windows.Forms.Label();
            this.classDelete_btn = new System.Windows.Forms.Button();
            this.classUpdate_btn = new System.Windows.Forms.Button();
            this.classCreate_btn = new System.Windows.Forms.Button();
            this.classSemester_lbl = new System.Windows.Forms.Label();
            this.classYear_lbl = new System.Windows.Forms.Label();
            this.classId_lbl = new System.Windows.Forms.Label();
            this.classCourseCode_txt = new System.Windows.Forms.MaskedTextBox();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.classCourseCodeLookUp_btn = new System.Windows.Forms.Button();
            this.class_lbl = new System.Windows.Forms.Label();
            this.classCourseCodeTable_lbl = new System.Windows.Forms.Label();
            this.classCourseCode_GridView = new System.Windows.Forms.DataGridView();
            this.classUpdateTable_btn = new System.Windows.Forms.Button();
            this.class_GridView = new System.Windows.Forms.DataGridView();
            this.classRefreshTable_btn = new System.Windows.Forms.Button();
            this.teachInsert = new System.Windows.Forms.TabPage();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.teachClassId_updwn = new System.Windows.Forms.NumericUpDown();
            this.teachProfId_updwn = new System.Windows.Forms.NumericUpDown();
            this.teachclassId_lbl = new System.Windows.Forms.Label();
            this.teachDelete_btn = new System.Windows.Forms.Button();
            this.teachUpdate_btn = new System.Windows.Forms.Button();
            this.teachCreate_btn = new System.Windows.Forms.Button();
            this.teachProfId_lbl = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.teachClassIdLookUp_btn = new System.Windows.Forms.Button();
            this.teachClassIdTable_lbl = new System.Windows.Forms.Label();
            this.teachClassId_GridView = new System.Windows.Forms.DataGridView();
            this.teachProfIdLookUp_btn = new System.Windows.Forms.Button();
            this.teach_lbl = new System.Windows.Forms.Label();
            this.teachProfIdTable_lbl = new System.Windows.Forms.Label();
            this.teachProfId_GridView = new System.Windows.Forms.DataGridView();
            this.teachUpdateTable_btn = new System.Windows.Forms.Button();
            this.teach_GridView = new System.Windows.Forms.DataGridView();
            this.teachRefreshTable_btn = new System.Windows.Forms.Button();
            this.teakenInsert = new System.Windows.Forms.TabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.takenGrade_updwn = new System.Windows.Forms.NumericUpDown();
            this.takenGrade_lbl = new System.Windows.Forms.Label();
            this.takenClassId_updwn = new System.Windows.Forms.NumericUpDown();
            this.takenUin_updwn = new System.Windows.Forms.NumericUpDown();
            this.takenClassId_lbl = new System.Windows.Forms.Label();
            this.teakenDelete_btn = new System.Windows.Forms.Button();
            this.teakenUpdate_btn = new System.Windows.Forms.Button();
            this.teakenCreate_btn = new System.Windows.Forms.Button();
            this.takenUin_lbl = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.takenClassIdLookUp_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.takenClassId_GridView = new System.Windows.Forms.DataGridView();
            this.takenUinLookUp_btn = new System.Windows.Forms.Button();
            this.taken_lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.takenUin_GridView = new System.Windows.Forms.DataGridView();
            this.takenUpdateTable_btn = new System.Windows.Forms.Button();
            this.taken_GridView = new System.Windows.Forms.DataGridView();
            this.takenRefreshTable_btn = new System.Windows.Forms.Button();
            this.clubInsert = new System.Windows.Forms.TabPage();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.clubDelete_btn = new System.Windows.Forms.Button();
            this.clubUpdate_btn = new System.Windows.Forms.Button();
            this.clubEmail_txt = new System.Windows.Forms.MaskedTextBox();
            this.clubCreate_btn = new System.Windows.Forms.Button();
            this.clubEmail_lbl = new System.Windows.Forms.Label();
            this.clubName_lbl = new System.Windows.Forms.Label();
            this.clubId_lbl = new System.Windows.Forms.Label();
            this.clubId_updwn = new System.Windows.Forms.NumericUpDown();
            this.clubName_txt = new System.Windows.Forms.MaskedTextBox();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.club_lbl = new System.Windows.Forms.Label();
            this.clubUpdateTable_btn = new System.Windows.Forms.Button();
            this.club_GridView = new System.Windows.Forms.DataGridView();
            this.clubRefreshTable_btn = new System.Windows.Forms.Button();
            this.memberInsert = new System.Windows.Forms.TabPage();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.memberClubId_updwn = new System.Windows.Forms.NumericUpDown();
            this.memberUin_updwn = new System.Windows.Forms.NumericUpDown();
            this.memberClubId_lbl = new System.Windows.Forms.Label();
            this.memberDelete_btn = new System.Windows.Forms.Button();
            this.memberUpdate_btn = new System.Windows.Forms.Button();
            this.memberCreate_btn = new System.Windows.Forms.Button();
            this.memberUin_lbl = new System.Windows.Forms.Label();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.memberClubIdLookUp_btn = new System.Windows.Forms.Button();
            this.memberClubIdLookUp_lbl = new System.Windows.Forms.Label();
            this.memberClubId_GridView = new System.Windows.Forms.DataGridView();
            this.memberUinLookUp_btn = new System.Windows.Forms.Button();
            this.member_lbl = new System.Windows.Forms.Label();
            this.memberUinLookUp_lbl = new System.Windows.Forms.Label();
            this.memberUin_GridView = new System.Windows.Forms.DataGridView();
            this.memberUpdateTable_btn = new System.Windows.Forms.Button();
            this.member_GridView = new System.Windows.Forms.DataGridView();
            this.memberRefreshTable_btn = new System.Windows.Forms.Button();
            this.presidentInsert = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.connectToServerBtn = new System.Windows.Forms.Button();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.presidentClubId_updwn = new System.Windows.Forms.NumericUpDown();
            this.presidentUin_updwn = new System.Windows.Forms.NumericUpDown();
            this.presidentClubId_lbl = new System.Windows.Forms.Label();
            this.presidentDelete_btn = new System.Windows.Forms.Button();
            this.presidentUpdate_btn = new System.Windows.Forms.Button();
            this.presidentCreate_btn = new System.Windows.Forms.Button();
            this.presidentUin_lbl = new System.Windows.Forms.Label();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.presidentClubIdLookUp_btn = new System.Windows.Forms.Button();
            this.presidentClubIdLookUp_lbl = new System.Windows.Forms.Label();
            this.presidentClubId_GridView = new System.Windows.Forms.DataGridView();
            this.presidentUinLookUp_btn = new System.Windows.Forms.Button();
            this.president_lbl = new System.Windows.Forms.Label();
            this.presidentUinLookUp_lbl = new System.Windows.Forms.Label();
            this.presidentUin_GridView = new System.Windows.Forms.DataGridView();
            this.presidentUpdateTable_btn = new System.Windows.Forms.Button();
            this.president_GridView = new System.Windows.Forms.DataGridView();
            this.presidentRefreshTable_btn = new System.Windows.Forms.Button();
            this.studentPrimaryKey_lbl = new System.Windows.Forms.Label();
            this.studentForeignKey_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.departmentInsert.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depId_updwn)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.department_GridView)).BeginInit();
            this.professorInsert.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profId_updwn)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professor_GridView)).BeginInit();
            this.studentInsert.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDepId_updwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentUin_updwn)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDepId_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_GridView)).BeginInit();
            this.courseInsert.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseCredit_updwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDepId_updwn)).BeginInit();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseDepId_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_GridView)).BeginInit();
            this.classInsert.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classId_updwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classSemester_updwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classYear_updwn)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classCourseCode_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_GridView)).BeginInit();
            this.teachInsert.SuspendLayout();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachClassId_updwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachProfId_updwn)).BeginInit();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachClassId_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachProfId_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teach_GridView)).BeginInit();
            this.teakenInsert.SuspendLayout();
            this.groupBox15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.takenGrade_updwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takenClassId_updwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takenUin_updwn)).BeginInit();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.takenClassId_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.takenUin_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taken_GridView)).BeginInit();
            this.clubInsert.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clubId_updwn)).BeginInit();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.club_GridView)).BeginInit();
            this.memberInsert.SuspendLayout();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberClubId_updwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberUin_updwn)).BeginInit();
            this.groupBox18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberClubId_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberUin_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_GridView)).BeginInit();
            this.presidentInsert.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presidentClubId_updwn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presidentUin_updwn)).BeginInit();
            this.groupBox20.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presidentClubId_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.presidentUin_GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.president_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1160, 737);
            this.tabControl1.TabIndex = 20;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1152, 711);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insert Entry";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.departmentInsert);
            this.tabControl2.Controls.Add(this.professorInsert);
            this.tabControl2.Controls.Add(this.studentInsert);
            this.tabControl2.Controls.Add(this.courseInsert);
            this.tabControl2.Controls.Add(this.classInsert);
            this.tabControl2.Controls.Add(this.teachInsert);
            this.tabControl2.Controls.Add(this.teakenInsert);
            this.tabControl2.Controls.Add(this.clubInsert);
            this.tabControl2.Controls.Add(this.memberInsert);
            this.tabControl2.Controls.Add(this.presidentInsert);
            this.tabControl2.Location = new System.Drawing.Point(6, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(1140, 699);
            this.tabControl2.TabIndex = 30;
            // 
            // departmentInsert
            // 
            this.departmentInsert.Controls.Add(this.groupBox1);
            this.departmentInsert.Controls.Add(this.groupBox2);
            this.departmentInsert.Location = new System.Drawing.Point(4, 22);
            this.departmentInsert.Name = "departmentInsert";
            this.departmentInsert.Padding = new System.Windows.Forms.Padding(3);
            this.departmentInsert.Size = new System.Drawing.Size(1132, 673);
            this.departmentInsert.TabIndex = 1;
            this.departmentInsert.Text = "Departments";
            this.departmentInsert.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.delete_btn);
            this.groupBox1.Controls.Add(this.update_btn);
            this.groupBox1.Controls.Add(this.email_txt);
            this.groupBox1.Controls.Add(this.create_btn);
            this.groupBox1.Controls.Add(this.email_lbl);
            this.groupBox1.Controls.Add(this.phoneNumber_txt);
            this.groupBox1.Controls.Add(this.phoneNumber_lbl);
            this.groupBox1.Controls.Add(this.name_lbl);
            this.groupBox1.Controls.Add(this.depId_label);
            this.groupBox1.Controls.Add(this.depId_updwn);
            this.groupBox1.Controls.Add(this.name_txt);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1120, 93);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tuple Operations";
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(1050, 57);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(60, 20);
            this.delete_btn.TabIndex = 7;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(984, 57);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(60, 20);
            this.update_btn.TabIndex = 6;
            this.update_btn.Text = "Update";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // email_txt
            // 
            this.email_txt.Location = new System.Drawing.Point(913, 21);
            this.email_txt.Name = "email_txt";
            this.email_txt.Size = new System.Drawing.Size(197, 20);
            this.email_txt.TabIndex = 4;
            // 
            // create_btn
            // 
            this.create_btn.Location = new System.Drawing.Point(918, 57);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(60, 20);
            this.create_btn.TabIndex = 5;
            this.create_btn.Text = "Create";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Location = new System.Drawing.Point(872, 25);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(35, 13);
            this.email_lbl.TabIndex = 6;
            this.email_lbl.Text = "Email:";
            // 
            // phoneNumber_txt
            // 
            this.phoneNumber_txt.Location = new System.Drawing.Point(673, 21);
            this.phoneNumber_txt.Name = "phoneNumber_txt";
            this.phoneNumber_txt.Size = new System.Drawing.Size(158, 20);
            this.phoneNumber_txt.TabIndex = 3;
            // 
            // phoneNumber_lbl
            // 
            this.phoneNumber_lbl.AutoSize = true;
            this.phoneNumber_lbl.Location = new System.Drawing.Point(590, 25);
            this.phoneNumber_lbl.Name = "phoneNumber_lbl";
            this.phoneNumber_lbl.Size = new System.Drawing.Size(81, 13);
            this.phoneNumber_lbl.TabIndex = 4;
            this.phoneNumber_lbl.Text = "Phone Number:";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Location = new System.Drawing.Point(246, 25);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(38, 13);
            this.name_lbl.TabIndex = 3;
            this.name_lbl.Text = "Name:";
            // 
            // depId_label
            // 
            this.depId_label.AutoSize = true;
            this.depId_label.ForeColor = System.Drawing.Color.Red;
            this.depId_label.Location = new System.Drawing.Point(21, 25);
            this.depId_label.Name = "depId_label";
            this.depId_label.Size = new System.Drawing.Size(79, 13);
            this.depId_label.TabIndex = 2;
            this.depId_label.Text = "Department ID:";
            // 
            // depId_updwn
            // 
            this.depId_updwn.Location = new System.Drawing.Point(101, 21);
            this.depId_updwn.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.depId_updwn.Name = "depId_updwn";
            this.depId_updwn.Size = new System.Drawing.Size(97, 20);
            this.depId_updwn.TabIndex = 1;
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(285, 21);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(273, 20);
            this.name_txt.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.departments_lbl);
            this.groupBox2.Controls.Add(this.updateTable_btn);
            this.groupBox2.Controls.Add(this.department_GridView);
            this.groupBox2.Controls.Add(this.refresh_btn);
            this.groupBox2.Location = new System.Drawing.Point(6, 105);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1120, 562);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Table Operations";
            // 
            // departments_lbl
            // 
            this.departments_lbl.AutoSize = true;
            this.departments_lbl.Location = new System.Drawing.Point(21, 24);
            this.departments_lbl.Name = "departments_lbl";
            this.departments_lbl.Size = new System.Drawing.Size(70, 13);
            this.departments_lbl.TabIndex = 11;
            this.departments_lbl.Text = "Departments:";
            // 
            // updateTable_btn
            // 
            this.updateTable_btn.Enabled = false;
            this.updateTable_btn.Location = new System.Drawing.Point(612, 19);
            this.updateTable_btn.Name = "updateTable_btn";
            this.updateTable_btn.Size = new System.Drawing.Size(110, 22);
            this.updateTable_btn.TabIndex = 10;
            this.updateTable_btn.Text = "Update Table";
            this.updateTable_btn.UseVisualStyleBackColor = true;
            this.updateTable_btn.Click += new System.EventHandler(this.updateTable_btn_Click);
            // 
            // department_GridView
            // 
            this.department_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.department_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.department_GridView.Location = new System.Drawing.Point(22, 46);
            this.department_GridView.Name = "department_GridView";
            this.department_GridView.Size = new System.Drawing.Size(700, 510);
            this.department_GridView.TabIndex = 9;
            // 
            // refresh_btn
            // 
            this.refresh_btn.Location = new System.Drawing.Point(496, 19);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(110, 22);
            this.refresh_btn.TabIndex = 9;
            this.refresh_btn.Text = "Refresh Table";
            this.refresh_btn.UseVisualStyleBackColor = true;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // professorInsert
            // 
            this.professorInsert.Controls.Add(this.groupBox3);
            this.professorInsert.Controls.Add(this.groupBox4);
            this.professorInsert.Location = new System.Drawing.Point(4, 22);
            this.professorInsert.Name = "professorInsert";
            this.professorInsert.Size = new System.Drawing.Size(1132, 673);
            this.professorInsert.TabIndex = 6;
            this.professorInsert.Text = "Professors";
            this.professorInsert.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.profBirthdate_date);
            this.groupBox3.Controls.Add(this.profBirthdate_lbl);
            this.groupBox3.Controls.Add(this.profDelete_btn);
            this.groupBox3.Controls.Add(this.profUpdate_btn);
            this.groupBox3.Controls.Add(this.profCreate_btn);
            this.groupBox3.Controls.Add(this.profEmail_txt);
            this.groupBox3.Controls.Add(this.profEmail_lbl);
            this.groupBox3.Controls.Add(this.profPhoneNumber_txt);
            this.groupBox3.Controls.Add(this.profPhoneNumber_lbl);
            this.groupBox3.Controls.Add(this.profName_lbl);
            this.groupBox3.Controls.Add(this.profId_lbl);
            this.groupBox3.Controls.Add(this.profId_updwn);
            this.groupBox3.Controls.Add(this.profName_txt);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1120, 93);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tuple Operations";
            // 
            // profBirthdate_date
            // 
            this.profBirthdate_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.profBirthdate_date.Location = new System.Drawing.Point(630, 21);
            this.profBirthdate_date.Name = "profBirthdate_date";
            this.profBirthdate_date.Size = new System.Drawing.Size(110, 20);
            this.profBirthdate_date.TabIndex = 3;
            // 
            // profBirthdate_lbl
            // 
            this.profBirthdate_lbl.AutoSize = true;
            this.profBirthdate_lbl.Location = new System.Drawing.Point(572, 25);
            this.profBirthdate_lbl.Name = "profBirthdate_lbl";
            this.profBirthdate_lbl.Size = new System.Drawing.Size(52, 13);
            this.profBirthdate_lbl.TabIndex = 11;
            this.profBirthdate_lbl.Text = "Birthdate:";
            // 
            // profDelete_btn
            // 
            this.profDelete_btn.Location = new System.Drawing.Point(1050, 57);
            this.profDelete_btn.Name = "profDelete_btn";
            this.profDelete_btn.Size = new System.Drawing.Size(60, 20);
            this.profDelete_btn.TabIndex = 8;
            this.profDelete_btn.Text = "Delete";
            this.profDelete_btn.UseVisualStyleBackColor = true;
            this.profDelete_btn.Click += new System.EventHandler(this.profDelete_btn_Click);
            // 
            // profUpdate_btn
            // 
            this.profUpdate_btn.Location = new System.Drawing.Point(984, 57);
            this.profUpdate_btn.Name = "profUpdate_btn";
            this.profUpdate_btn.Size = new System.Drawing.Size(60, 20);
            this.profUpdate_btn.TabIndex = 7;
            this.profUpdate_btn.Text = "Update";
            this.profUpdate_btn.UseVisualStyleBackColor = true;
            this.profUpdate_btn.Click += new System.EventHandler(this.profUpdate_btn_Click);
            // 
            // profCreate_btn
            // 
            this.profCreate_btn.Location = new System.Drawing.Point(918, 57);
            this.profCreate_btn.Name = "profCreate_btn";
            this.profCreate_btn.Size = new System.Drawing.Size(60, 20);
            this.profCreate_btn.TabIndex = 6;
            this.profCreate_btn.Text = "Create";
            this.profCreate_btn.UseVisualStyleBackColor = true;
            this.profCreate_btn.Click += new System.EventHandler(this.profCreate_btn_Click);
            // 
            // profEmail_txt
            // 
            this.profEmail_txt.Location = new System.Drawing.Point(62, 55);
            this.profEmail_txt.Name = "profEmail_txt";
            this.profEmail_txt.Size = new System.Drawing.Size(197, 20);
            this.profEmail_txt.TabIndex = 5;
            // 
            // profEmail_lbl
            // 
            this.profEmail_lbl.AutoSize = true;
            this.profEmail_lbl.Location = new System.Drawing.Point(21, 59);
            this.profEmail_lbl.Name = "profEmail_lbl";
            this.profEmail_lbl.Size = new System.Drawing.Size(35, 13);
            this.profEmail_lbl.TabIndex = 6;
            this.profEmail_lbl.Text = "Email:";
            // 
            // profPhoneNumber_txt
            // 
            this.profPhoneNumber_txt.Location = new System.Drawing.Point(853, 21);
            this.profPhoneNumber_txt.Name = "profPhoneNumber_txt";
            this.profPhoneNumber_txt.Size = new System.Drawing.Size(257, 20);
            this.profPhoneNumber_txt.TabIndex = 4;
            // 
            // profPhoneNumber_lbl
            // 
            this.profPhoneNumber_lbl.AutoSize = true;
            this.profPhoneNumber_lbl.Location = new System.Drawing.Point(770, 25);
            this.profPhoneNumber_lbl.Name = "profPhoneNumber_lbl";
            this.profPhoneNumber_lbl.Size = new System.Drawing.Size(81, 13);
            this.profPhoneNumber_lbl.TabIndex = 4;
            this.profPhoneNumber_lbl.Text = "Phone Number:";
            // 
            // profName_lbl
            // 
            this.profName_lbl.AutoSize = true;
            this.profName_lbl.Location = new System.Drawing.Point(215, 25);
            this.profName_lbl.Name = "profName_lbl";
            this.profName_lbl.Size = new System.Drawing.Size(38, 13);
            this.profName_lbl.TabIndex = 3;
            this.profName_lbl.Text = "Name:";
            // 
            // profId_lbl
            // 
            this.profId_lbl.AutoSize = true;
            this.profId_lbl.ForeColor = System.Drawing.Color.Red;
            this.profId_lbl.Location = new System.Drawing.Point(21, 25);
            this.profId_lbl.Name = "profId_lbl";
            this.profId_lbl.Size = new System.Drawing.Size(68, 13);
            this.profId_lbl.TabIndex = 2;
            this.profId_lbl.Text = "Professor ID:";
            // 
            // profId_updwn
            // 
            this.profId_updwn.Location = new System.Drawing.Point(92, 21);
            this.profId_updwn.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.profId_updwn.Name = "profId_updwn";
            this.profId_updwn.Size = new System.Drawing.Size(97, 20);
            this.profId_updwn.TabIndex = 1;
            // 
            // profName_txt
            // 
            this.profName_txt.Location = new System.Drawing.Point(254, 21);
            this.profName_txt.Name = "profName_txt";
            this.profName_txt.Size = new System.Drawing.Size(273, 20);
            this.profName_txt.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.professors_lbl);
            this.groupBox4.Controls.Add(this.profUpdateTable_btn);
            this.groupBox4.Controls.Add(this.professor_GridView);
            this.groupBox4.Controls.Add(this.profRefreshTable_btn);
            this.groupBox4.Location = new System.Drawing.Point(6, 105);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1120, 562);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Table Operations";
            // 
            // professors_lbl
            // 
            this.professors_lbl.AutoSize = true;
            this.professors_lbl.Location = new System.Drawing.Point(21, 24);
            this.professors_lbl.Name = "professors_lbl";
            this.professors_lbl.Size = new System.Drawing.Size(59, 13);
            this.professors_lbl.TabIndex = 12;
            this.professors_lbl.Text = "Professors:";
            // 
            // profUpdateTable_btn
            // 
            this.profUpdateTable_btn.Enabled = false;
            this.profUpdateTable_btn.Location = new System.Drawing.Point(612, 19);
            this.profUpdateTable_btn.Name = "profUpdateTable_btn";
            this.profUpdateTable_btn.Size = new System.Drawing.Size(110, 22);
            this.profUpdateTable_btn.TabIndex = 11;
            this.profUpdateTable_btn.Text = "Update Table";
            this.profUpdateTable_btn.UseVisualStyleBackColor = true;
            this.profUpdateTable_btn.Click += new System.EventHandler(this.profUpdateTable_btn_Click);
            // 
            // professor_GridView
            // 
            this.professor_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.professor_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.professor_GridView.Location = new System.Drawing.Point(22, 46);
            this.professor_GridView.Name = "professor_GridView";
            this.professor_GridView.Size = new System.Drawing.Size(700, 510);
            this.professor_GridView.TabIndex = 9;
            // 
            // profRefreshTable_btn
            // 
            this.profRefreshTable_btn.Location = new System.Drawing.Point(496, 19);
            this.profRefreshTable_btn.Name = "profRefreshTable_btn";
            this.profRefreshTable_btn.Size = new System.Drawing.Size(110, 22);
            this.profRefreshTable_btn.TabIndex = 10;
            this.profRefreshTable_btn.Text = "Refresh Table";
            this.profRefreshTable_btn.UseVisualStyleBackColor = true;
            this.profRefreshTable_btn.Click += new System.EventHandler(this.profRefreshTable_btn_Click);
            // 
            // studentInsert
            // 
            this.studentInsert.Controls.Add(this.groupBox5);
            this.studentInsert.Controls.Add(this.groupBox6);
            this.studentInsert.Location = new System.Drawing.Point(4, 22);
            this.studentInsert.Name = "studentInsert";
            this.studentInsert.Size = new System.Drawing.Size(1132, 673);
            this.studentInsert.TabIndex = 5;
            this.studentInsert.Text = "Students";
            this.studentInsert.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.studentForeignKey_lbl);
            this.groupBox5.Controls.Add(this.studentPrimaryKey_lbl);
            this.groupBox5.Controls.Add(this.studentDepId_updwn);
            this.groupBox5.Controls.Add(this.studentDepId_lbl);
            this.groupBox5.Controls.Add(this.studentBirthdate_date);
            this.groupBox5.Controls.Add(this.studentBirthdate_lbl);
            this.groupBox5.Controls.Add(this.studentDelete_btn);
            this.groupBox5.Controls.Add(this.studentUpdate_btn);
            this.groupBox5.Controls.Add(this.studentCreate_btn);
            this.groupBox5.Controls.Add(this.studentEmail_txt);
            this.groupBox5.Controls.Add(this.studentEmail_lbl);
            this.groupBox5.Controls.Add(this.studentPhoneNumber_txt);
            this.groupBox5.Controls.Add(this.studentPhoneNumber_lbl);
            this.groupBox5.Controls.Add(this.studentName_lbl);
            this.groupBox5.Controls.Add(this.studentUin_lbl);
            this.groupBox5.Controls.Add(this.studentUin_updwn);
            this.groupBox5.Controls.Add(this.studentName_txt);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1120, 93);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tuple Operations";
            // 
            // studentDepId_updwn
            // 
            this.studentDepId_updwn.Location = new System.Drawing.Point(382, 55);
            this.studentDepId_updwn.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.studentDepId_updwn.Name = "studentDepId_updwn";
            this.studentDepId_updwn.Size = new System.Drawing.Size(106, 20);
            this.studentDepId_updwn.TabIndex = 13;
            // 
            // studentDepId_lbl
            // 
            this.studentDepId_lbl.AutoSize = true;
            this.studentDepId_lbl.ForeColor = System.Drawing.Color.Blue;
            this.studentDepId_lbl.Location = new System.Drawing.Point(299, 59);
            this.studentDepId_lbl.Name = "studentDepId_lbl";
            this.studentDepId_lbl.Size = new System.Drawing.Size(79, 13);
            this.studentDepId_lbl.TabIndex = 12;
            this.studentDepId_lbl.Text = "Department ID:";
            // 
            // studentBirthdate_date
            // 
            this.studentBirthdate_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.studentBirthdate_date.Location = new System.Drawing.Point(504, 21);
            this.studentBirthdate_date.Name = "studentBirthdate_date";
            this.studentBirthdate_date.Size = new System.Drawing.Size(110, 20);
            this.studentBirthdate_date.TabIndex = 3;
            // 
            // studentBirthdate_lbl
            // 
            this.studentBirthdate_lbl.AutoSize = true;
            this.studentBirthdate_lbl.Location = new System.Drawing.Point(451, 25);
            this.studentBirthdate_lbl.Name = "studentBirthdate_lbl";
            this.studentBirthdate_lbl.Size = new System.Drawing.Size(52, 13);
            this.studentBirthdate_lbl.TabIndex = 11;
            this.studentBirthdate_lbl.Text = "Birthdate:";
            // 
            // studentDelete_btn
            // 
            this.studentDelete_btn.Location = new System.Drawing.Point(1050, 57);
            this.studentDelete_btn.Name = "studentDelete_btn";
            this.studentDelete_btn.Size = new System.Drawing.Size(60, 20);
            this.studentDelete_btn.TabIndex = 8;
            this.studentDelete_btn.Text = "Delete";
            this.studentDelete_btn.UseVisualStyleBackColor = true;
            this.studentDelete_btn.Click += new System.EventHandler(this.studentDelete_btn_Click);
            // 
            // studentUpdate_btn
            // 
            this.studentUpdate_btn.Location = new System.Drawing.Point(984, 57);
            this.studentUpdate_btn.Name = "studentUpdate_btn";
            this.studentUpdate_btn.Size = new System.Drawing.Size(60, 20);
            this.studentUpdate_btn.TabIndex = 7;
            this.studentUpdate_btn.Text = "Update";
            this.studentUpdate_btn.UseVisualStyleBackColor = true;
            this.studentUpdate_btn.Click += new System.EventHandler(this.studentUpdate_btn_Click);
            // 
            // studentCreate_btn
            // 
            this.studentCreate_btn.Location = new System.Drawing.Point(918, 57);
            this.studentCreate_btn.Name = "studentCreate_btn";
            this.studentCreate_btn.Size = new System.Drawing.Size(60, 20);
            this.studentCreate_btn.TabIndex = 6;
            this.studentCreate_btn.Text = "Create";
            this.studentCreate_btn.UseVisualStyleBackColor = true;
            this.studentCreate_btn.Click += new System.EventHandler(this.studentCreate_btn_Click);
            // 
            // studentEmail_txt
            // 
            this.studentEmail_txt.Location = new System.Drawing.Point(58, 55);
            this.studentEmail_txt.Name = "studentEmail_txt";
            this.studentEmail_txt.Size = new System.Drawing.Size(206, 20);
            this.studentEmail_txt.TabIndex = 5;
            // 
            // studentEmail_lbl
            // 
            this.studentEmail_lbl.AutoSize = true;
            this.studentEmail_lbl.Location = new System.Drawing.Point(21, 59);
            this.studentEmail_lbl.Name = "studentEmail_lbl";
            this.studentEmail_lbl.Size = new System.Drawing.Size(35, 13);
            this.studentEmail_lbl.TabIndex = 6;
            this.studentEmail_lbl.Text = "Email:";
            // 
            // studentPhoneNumber_txt
            // 
            this.studentPhoneNumber_txt.Location = new System.Drawing.Point(719, 21);
            this.studentPhoneNumber_txt.Name = "studentPhoneNumber_txt";
            this.studentPhoneNumber_txt.Size = new System.Drawing.Size(165, 20);
            this.studentPhoneNumber_txt.TabIndex = 4;
            // 
            // studentPhoneNumber_lbl
            // 
            this.studentPhoneNumber_lbl.AutoSize = true;
            this.studentPhoneNumber_lbl.Location = new System.Drawing.Point(636, 25);
            this.studentPhoneNumber_lbl.Name = "studentPhoneNumber_lbl";
            this.studentPhoneNumber_lbl.Size = new System.Drawing.Size(81, 13);
            this.studentPhoneNumber_lbl.TabIndex = 4;
            this.studentPhoneNumber_lbl.Text = "Phone Number:";
            // 
            // studentName_lbl
            // 
            this.studentName_lbl.AutoSize = true;
            this.studentName_lbl.Location = new System.Drawing.Point(164, 25);
            this.studentName_lbl.Name = "studentName_lbl";
            this.studentName_lbl.Size = new System.Drawing.Size(38, 13);
            this.studentName_lbl.TabIndex = 3;
            this.studentName_lbl.Text = "Name:";
            // 
            // studentUin_lbl
            // 
            this.studentUin_lbl.AutoSize = true;
            this.studentUin_lbl.ForeColor = System.Drawing.Color.Red;
            this.studentUin_lbl.Location = new System.Drawing.Point(21, 25);
            this.studentUin_lbl.Name = "studentUin_lbl";
            this.studentUin_lbl.Size = new System.Drawing.Size(29, 13);
            this.studentUin_lbl.TabIndex = 2;
            this.studentUin_lbl.Text = "UIN:";
            // 
            // studentUin_updwn
            // 
            this.studentUin_updwn.Location = new System.Drawing.Point(54, 21);
            this.studentUin_updwn.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.studentUin_updwn.Name = "studentUin_updwn";
            this.studentUin_updwn.Size = new System.Drawing.Size(97, 20);
            this.studentUin_updwn.TabIndex = 1;
            // 
            // studentName_txt
            // 
            this.studentName_txt.Location = new System.Drawing.Point(203, 21);
            this.studentName_txt.Name = "studentName_txt";
            this.studentName_txt.Size = new System.Drawing.Size(242, 20);
            this.studentName_txt.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.studentLookUp_btn);
            this.groupBox6.Controls.Add(this.student_lbl);
            this.groupBox6.Controls.Add(this.studentDepIdTable_lbl);
            this.groupBox6.Controls.Add(this.studentDepId_GridView);
            this.groupBox6.Controls.Add(this.studentUpdateTable_btn);
            this.groupBox6.Controls.Add(this.student_GridView);
            this.groupBox6.Controls.Add(this.studentRefreshTable_btn);
            this.groupBox6.Location = new System.Drawing.Point(6, 105);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1120, 562);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Table Operations";
            // 
            // studentLookUp_btn
            // 
            this.studentLookUp_btn.Location = new System.Drawing.Point(1040, 19);
            this.studentLookUp_btn.Name = "studentLookUp_btn";
            this.studentLookUp_btn.Size = new System.Drawing.Size(70, 22);
            this.studentLookUp_btn.TabIndex = 16;
            this.studentLookUp_btn.Text = "Look Up";
            this.studentLookUp_btn.UseVisualStyleBackColor = true;
            this.studentLookUp_btn.Click += new System.EventHandler(this.studentLookUp_btn_Click);
            // 
            // student_lbl
            // 
            this.student_lbl.AutoSize = true;
            this.student_lbl.Location = new System.Drawing.Point(21, 24);
            this.student_lbl.Name = "student_lbl";
            this.student_lbl.Size = new System.Drawing.Size(52, 13);
            this.student_lbl.TabIndex = 15;
            this.student_lbl.Text = "Students:";
            // 
            // studentDepIdTable_lbl
            // 
            this.studentDepIdTable_lbl.AutoSize = true;
            this.studentDepIdTable_lbl.ForeColor = System.Drawing.Color.Blue;
            this.studentDepIdTable_lbl.Location = new System.Drawing.Point(750, 24);
            this.studentDepIdTable_lbl.Name = "studentDepIdTable_lbl";
            this.studentDepIdTable_lbl.Size = new System.Drawing.Size(84, 13);
            this.studentDepIdTable_lbl.TabIndex = 14;
            this.studentDepIdTable_lbl.Text = "Department IDs:";
            // 
            // studentDepId_GridView
            // 
            this.studentDepId_GridView.AllowUserToAddRows = false;
            this.studentDepId_GridView.AllowUserToDeleteRows = false;
            this.studentDepId_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentDepId_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDepId_GridView.Location = new System.Drawing.Point(753, 46);
            this.studentDepId_GridView.Name = "studentDepId_GridView";
            this.studentDepId_GridView.ReadOnly = true;
            this.studentDepId_GridView.Size = new System.Drawing.Size(357, 510);
            this.studentDepId_GridView.TabIndex = 12;
            // 
            // studentUpdateTable_btn
            // 
            this.studentUpdateTable_btn.Enabled = false;
            this.studentUpdateTable_btn.Location = new System.Drawing.Point(612, 19);
            this.studentUpdateTable_btn.Name = "studentUpdateTable_btn";
            this.studentUpdateTable_btn.Size = new System.Drawing.Size(110, 22);
            this.studentUpdateTable_btn.TabIndex = 11;
            this.studentUpdateTable_btn.Text = "Update Table";
            this.studentUpdateTable_btn.UseVisualStyleBackColor = true;
            this.studentUpdateTable_btn.Click += new System.EventHandler(this.studentUpdateTable_btn_Click);
            // 
            // student_GridView
            // 
            this.student_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.student_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.student_GridView.Location = new System.Drawing.Point(22, 46);
            this.student_GridView.Name = "student_GridView";
            this.student_GridView.Size = new System.Drawing.Size(700, 510);
            this.student_GridView.TabIndex = 9;
            // 
            // studentRefreshTable_btn
            // 
            this.studentRefreshTable_btn.Location = new System.Drawing.Point(496, 19);
            this.studentRefreshTable_btn.Name = "studentRefreshTable_btn";
            this.studentRefreshTable_btn.Size = new System.Drawing.Size(110, 22);
            this.studentRefreshTable_btn.TabIndex = 10;
            this.studentRefreshTable_btn.Text = "Refresh Table";
            this.studentRefreshTable_btn.UseVisualStyleBackColor = true;
            this.studentRefreshTable_btn.Click += new System.EventHandler(this.studentRefreshTable_btn_Click);
            // 
            // courseInsert
            // 
            this.courseInsert.Controls.Add(this.groupBox7);
            this.courseInsert.Controls.Add(this.groupBox8);
            this.courseInsert.Location = new System.Drawing.Point(4, 22);
            this.courseInsert.Name = "courseInsert";
            this.courseInsert.Size = new System.Drawing.Size(1132, 673);
            this.courseInsert.TabIndex = 3;
            this.courseInsert.Text = "Courses";
            this.courseInsert.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.courseCredit_updwn);
            this.groupBox7.Controls.Add(this.courseDepId_updwn);
            this.groupBox7.Controls.Add(this.courseDepId_lbl);
            this.groupBox7.Controls.Add(this.courseDelete_btn);
            this.groupBox7.Controls.Add(this.courseUpdate_btn);
            this.groupBox7.Controls.Add(this.courseCreate_btn);
            this.groupBox7.Controls.Add(this.courseCode_txt);
            this.groupBox7.Controls.Add(this.courseCredit_lbl);
            this.groupBox7.Controls.Add(this.courseName_lbl);
            this.groupBox7.Controls.Add(this.courseCode_lbl);
            this.groupBox7.Controls.Add(this.courseName_txt);
            this.groupBox7.Location = new System.Drawing.Point(6, 6);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1120, 93);
            this.groupBox7.TabIndex = 21;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tuple Operations";
            // 
            // courseCredit_updwn
            // 
            this.courseCredit_updwn.Location = new System.Drawing.Point(763, 21);
            this.courseCredit_updwn.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.courseCredit_updwn.Name = "courseCredit_updwn";
            this.courseCredit_updwn.Size = new System.Drawing.Size(106, 20);
            this.courseCredit_updwn.TabIndex = 14;
            // 
            // courseDepId_updwn
            // 
            this.courseDepId_updwn.Location = new System.Drawing.Point(1004, 21);
            this.courseDepId_updwn.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.courseDepId_updwn.Name = "courseDepId_updwn";
            this.courseDepId_updwn.Size = new System.Drawing.Size(106, 20);
            this.courseDepId_updwn.TabIndex = 13;
            // 
            // courseDepId_lbl
            // 
            this.courseDepId_lbl.AutoSize = true;
            this.courseDepId_lbl.ForeColor = System.Drawing.Color.Blue;
            this.courseDepId_lbl.Location = new System.Drawing.Point(921, 25);
            this.courseDepId_lbl.Name = "courseDepId_lbl";
            this.courseDepId_lbl.Size = new System.Drawing.Size(79, 13);
            this.courseDepId_lbl.TabIndex = 12;
            this.courseDepId_lbl.Text = "Department ID:";
            // 
            // courseDelete_btn
            // 
            this.courseDelete_btn.Location = new System.Drawing.Point(1050, 57);
            this.courseDelete_btn.Name = "courseDelete_btn";
            this.courseDelete_btn.Size = new System.Drawing.Size(60, 20);
            this.courseDelete_btn.TabIndex = 8;
            this.courseDelete_btn.Text = "Delete";
            this.courseDelete_btn.UseVisualStyleBackColor = true;
            this.courseDelete_btn.Click += new System.EventHandler(this.courseDelete_btn_Click);
            // 
            // courseUpdate_btn
            // 
            this.courseUpdate_btn.Location = new System.Drawing.Point(984, 57);
            this.courseUpdate_btn.Name = "courseUpdate_btn";
            this.courseUpdate_btn.Size = new System.Drawing.Size(60, 20);
            this.courseUpdate_btn.TabIndex = 7;
            this.courseUpdate_btn.Text = "Update";
            this.courseUpdate_btn.UseVisualStyleBackColor = true;
            this.courseUpdate_btn.Click += new System.EventHandler(this.courseUpdate_btn_Click);
            // 
            // courseCreate_btn
            // 
            this.courseCreate_btn.Location = new System.Drawing.Point(918, 57);
            this.courseCreate_btn.Name = "courseCreate_btn";
            this.courseCreate_btn.Size = new System.Drawing.Size(60, 20);
            this.courseCreate_btn.TabIndex = 6;
            this.courseCreate_btn.Text = "Create";
            this.courseCreate_btn.UseVisualStyleBackColor = true;
            this.courseCreate_btn.Click += new System.EventHandler(this.courseCreate_btn_Click);
            // 
            // courseCode_txt
            // 
            this.courseCode_txt.Location = new System.Drawing.Point(98, 21);
            this.courseCode_txt.Name = "courseCode_txt";
            this.courseCode_txt.Size = new System.Drawing.Size(144, 20);
            this.courseCode_txt.TabIndex = 5;
            // 
            // courseCredit_lbl
            // 
            this.courseCredit_lbl.AutoSize = true;
            this.courseCredit_lbl.Location = new System.Drawing.Point(689, 25);
            this.courseCredit_lbl.Name = "courseCredit_lbl";
            this.courseCredit_lbl.Size = new System.Drawing.Size(68, 13);
            this.courseCredit_lbl.TabIndex = 4;
            this.courseCredit_lbl.Text = "Credit Hours:";
            // 
            // courseName_lbl
            // 
            this.courseName_lbl.AutoSize = true;
            this.courseName_lbl.Location = new System.Drawing.Point(282, 25);
            this.courseName_lbl.Name = "courseName_lbl";
            this.courseName_lbl.Size = new System.Drawing.Size(38, 13);
            this.courseName_lbl.TabIndex = 3;
            this.courseName_lbl.Text = "Name:";
            // 
            // courseCode_lbl
            // 
            this.courseCode_lbl.AutoSize = true;
            this.courseCode_lbl.ForeColor = System.Drawing.Color.Red;
            this.courseCode_lbl.Location = new System.Drawing.Point(21, 25);
            this.courseCode_lbl.Name = "courseCode_lbl";
            this.courseCode_lbl.Size = new System.Drawing.Size(71, 13);
            this.courseCode_lbl.TabIndex = 2;
            this.courseCode_lbl.Text = "Course Code:";
            // 
            // courseName_txt
            // 
            this.courseName_txt.Location = new System.Drawing.Point(326, 21);
            this.courseName_txt.Name = "courseName_txt";
            this.courseName_txt.Size = new System.Drawing.Size(332, 20);
            this.courseName_txt.TabIndex = 2;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.courseDepIdLookUp_btn);
            this.groupBox8.Controls.Add(this.course_lbl);
            this.groupBox8.Controls.Add(this.courseDepIdTable_lbl);
            this.groupBox8.Controls.Add(this.courseDepId_GridView);
            this.groupBox8.Controls.Add(this.courseUpdateTable_btn);
            this.groupBox8.Controls.Add(this.course_GridView);
            this.groupBox8.Controls.Add(this.courseRefreshTable_btn);
            this.groupBox8.Location = new System.Drawing.Point(6, 105);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1120, 562);
            this.groupBox8.TabIndex = 20;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Table Operations";
            // 
            // courseDepIdLookUp_btn
            // 
            this.courseDepIdLookUp_btn.Location = new System.Drawing.Point(1040, 19);
            this.courseDepIdLookUp_btn.Name = "courseDepIdLookUp_btn";
            this.courseDepIdLookUp_btn.Size = new System.Drawing.Size(70, 22);
            this.courseDepIdLookUp_btn.TabIndex = 16;
            this.courseDepIdLookUp_btn.Text = "Look Up";
            this.courseDepIdLookUp_btn.UseVisualStyleBackColor = true;
            this.courseDepIdLookUp_btn.Click += new System.EventHandler(this.courseDepIdLookUp_btn_Click);
            // 
            // course_lbl
            // 
            this.course_lbl.AutoSize = true;
            this.course_lbl.Location = new System.Drawing.Point(21, 24);
            this.course_lbl.Name = "course_lbl";
            this.course_lbl.Size = new System.Drawing.Size(48, 13);
            this.course_lbl.TabIndex = 15;
            this.course_lbl.Text = "Courses:";
            // 
            // courseDepIdTable_lbl
            // 
            this.courseDepIdTable_lbl.AutoSize = true;
            this.courseDepIdTable_lbl.ForeColor = System.Drawing.Color.Blue;
            this.courseDepIdTable_lbl.Location = new System.Drawing.Point(750, 24);
            this.courseDepIdTable_lbl.Name = "courseDepIdTable_lbl";
            this.courseDepIdTable_lbl.Size = new System.Drawing.Size(84, 13);
            this.courseDepIdTable_lbl.TabIndex = 14;
            this.courseDepIdTable_lbl.Text = "Department IDs:";
            // 
            // courseDepId_GridView
            // 
            this.courseDepId_GridView.AllowUserToAddRows = false;
            this.courseDepId_GridView.AllowUserToDeleteRows = false;
            this.courseDepId_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.courseDepId_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courseDepId_GridView.Location = new System.Drawing.Point(753, 46);
            this.courseDepId_GridView.Name = "courseDepId_GridView";
            this.courseDepId_GridView.ReadOnly = true;
            this.courseDepId_GridView.Size = new System.Drawing.Size(357, 510);
            this.courseDepId_GridView.TabIndex = 12;
            // 
            // courseUpdateTable_btn
            // 
            this.courseUpdateTable_btn.Enabled = false;
            this.courseUpdateTable_btn.Location = new System.Drawing.Point(612, 19);
            this.courseUpdateTable_btn.Name = "courseUpdateTable_btn";
            this.courseUpdateTable_btn.Size = new System.Drawing.Size(110, 22);
            this.courseUpdateTable_btn.TabIndex = 11;
            this.courseUpdateTable_btn.Text = "Update Table";
            this.courseUpdateTable_btn.UseVisualStyleBackColor = true;
            this.courseUpdateTable_btn.Click += new System.EventHandler(this.courseUpdateTable_btn_Click);
            // 
            // course_GridView
            // 
            this.course_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.course_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.course_GridView.Location = new System.Drawing.Point(22, 46);
            this.course_GridView.Name = "course_GridView";
            this.course_GridView.Size = new System.Drawing.Size(700, 510);
            this.course_GridView.TabIndex = 9;
            // 
            // courseRefreshTable_btn
            // 
            this.courseRefreshTable_btn.Location = new System.Drawing.Point(496, 19);
            this.courseRefreshTable_btn.Name = "courseRefreshTable_btn";
            this.courseRefreshTable_btn.Size = new System.Drawing.Size(110, 22);
            this.courseRefreshTable_btn.TabIndex = 10;
            this.courseRefreshTable_btn.Text = "Refresh Table";
            this.courseRefreshTable_btn.UseVisualStyleBackColor = true;
            this.courseRefreshTable_btn.Click += new System.EventHandler(this.courseRefreshTable_btn_Click);
            // 
            // classInsert
            // 
            this.classInsert.Controls.Add(this.groupBox9);
            this.classInsert.Controls.Add(this.groupBox10);
            this.classInsert.Location = new System.Drawing.Point(4, 22);
            this.classInsert.Name = "classInsert";
            this.classInsert.Size = new System.Drawing.Size(1132, 673);
            this.classInsert.TabIndex = 4;
            this.classInsert.Text = "Classes";
            this.classInsert.UseVisualStyleBackColor = true;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Controls.Add(this.classId_updwn);
            this.groupBox9.Controls.Add(this.classSemester_updwn);
            this.groupBox9.Controls.Add(this.classYear_updwn);
            this.groupBox9.Controls.Add(this.classCourseCode_lbl);
            this.groupBox9.Controls.Add(this.classDelete_btn);
            this.groupBox9.Controls.Add(this.classUpdate_btn);
            this.groupBox9.Controls.Add(this.classCreate_btn);
            this.groupBox9.Controls.Add(this.classSemester_lbl);
            this.groupBox9.Controls.Add(this.classYear_lbl);
            this.groupBox9.Controls.Add(this.classId_lbl);
            this.groupBox9.Controls.Add(this.classCourseCode_txt);
            this.groupBox9.Location = new System.Drawing.Point(6, 6);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(1120, 93);
            this.groupBox9.TabIndex = 23;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Tuple Operations";
            // 
            // classId_updwn
            // 
            this.classId_updwn.Location = new System.Drawing.Point(76, 23);
            this.classId_updwn.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.classId_updwn.Name = "classId_updwn";
            this.classId_updwn.Size = new System.Drawing.Size(179, 20);
            this.classId_updwn.TabIndex = 15;
            // 
            // classSemester_updwn
            // 
            this.classSemester_updwn.Location = new System.Drawing.Point(558, 23);
            this.classSemester_updwn.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.classSemester_updwn.Name = "classSemester_updwn";
            this.classSemester_updwn.Size = new System.Drawing.Size(106, 20);
            this.classSemester_updwn.TabIndex = 14;
            // 
            // classYear_updwn
            // 
            this.classYear_updwn.Location = new System.Drawing.Point(337, 23);
            this.classYear_updwn.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.classYear_updwn.Name = "classYear_updwn";
            this.classYear_updwn.Size = new System.Drawing.Size(106, 20);
            this.classYear_updwn.TabIndex = 13;
            // 
            // classCourseCode_lbl
            // 
            this.classCourseCode_lbl.AutoSize = true;
            this.classCourseCode_lbl.ForeColor = System.Drawing.Color.Blue;
            this.classCourseCode_lbl.Location = new System.Drawing.Point(711, 25);
            this.classCourseCode_lbl.Name = "classCourseCode_lbl";
            this.classCourseCode_lbl.Size = new System.Drawing.Size(71, 13);
            this.classCourseCode_lbl.TabIndex = 12;
            this.classCourseCode_lbl.Text = "Course Code:";
            // 
            // classDelete_btn
            // 
            this.classDelete_btn.Location = new System.Drawing.Point(1050, 57);
            this.classDelete_btn.Name = "classDelete_btn";
            this.classDelete_btn.Size = new System.Drawing.Size(60, 20);
            this.classDelete_btn.TabIndex = 8;
            this.classDelete_btn.Text = "Delete";
            this.classDelete_btn.UseVisualStyleBackColor = true;
            this.classDelete_btn.Click += new System.EventHandler(this.classDelete_btn_Click);
            // 
            // classUpdate_btn
            // 
            this.classUpdate_btn.Location = new System.Drawing.Point(984, 57);
            this.classUpdate_btn.Name = "classUpdate_btn";
            this.classUpdate_btn.Size = new System.Drawing.Size(60, 20);
            this.classUpdate_btn.TabIndex = 7;
            this.classUpdate_btn.Text = "Update";
            this.classUpdate_btn.UseVisualStyleBackColor = true;
            this.classUpdate_btn.Click += new System.EventHandler(this.classUpdate_btn_Click);
            // 
            // classCreate_btn
            // 
            this.classCreate_btn.Location = new System.Drawing.Point(918, 57);
            this.classCreate_btn.Name = "classCreate_btn";
            this.classCreate_btn.Size = new System.Drawing.Size(60, 20);
            this.classCreate_btn.TabIndex = 6;
            this.classCreate_btn.Text = "Create";
            this.classCreate_btn.UseVisualStyleBackColor = true;
            this.classCreate_btn.Click += new System.EventHandler(this.classCreate_btn_Click);
            // 
            // classSemester_lbl
            // 
            this.classSemester_lbl.AutoSize = true;
            this.classSemester_lbl.Location = new System.Drawing.Point(498, 25);
            this.classSemester_lbl.Name = "classSemester_lbl";
            this.classSemester_lbl.Size = new System.Drawing.Size(54, 13);
            this.classSemester_lbl.TabIndex = 4;
            this.classSemester_lbl.Text = "Semester:";
            // 
            // classYear_lbl
            // 
            this.classYear_lbl.AutoSize = true;
            this.classYear_lbl.Location = new System.Drawing.Point(299, 25);
            this.classYear_lbl.Name = "classYear_lbl";
            this.classYear_lbl.Size = new System.Drawing.Size(32, 13);
            this.classYear_lbl.TabIndex = 3;
            this.classYear_lbl.Text = "Year:";
            // 
            // classId_lbl
            // 
            this.classId_lbl.AutoSize = true;
            this.classId_lbl.ForeColor = System.Drawing.Color.Red;
            this.classId_lbl.Location = new System.Drawing.Point(21, 25);
            this.classId_lbl.Name = "classId_lbl";
            this.classId_lbl.Size = new System.Drawing.Size(49, 13);
            this.classId_lbl.TabIndex = 2;
            this.classId_lbl.Text = "Class ID:";
            // 
            // classCourseCode_txt
            // 
            this.classCourseCode_txt.Location = new System.Drawing.Point(788, 21);
            this.classCourseCode_txt.Name = "classCourseCode_txt";
            this.classCourseCode_txt.Size = new System.Drawing.Size(135, 20);
            this.classCourseCode_txt.TabIndex = 2;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.classCourseCodeLookUp_btn);
            this.groupBox10.Controls.Add(this.class_lbl);
            this.groupBox10.Controls.Add(this.classCourseCodeTable_lbl);
            this.groupBox10.Controls.Add(this.classCourseCode_GridView);
            this.groupBox10.Controls.Add(this.classUpdateTable_btn);
            this.groupBox10.Controls.Add(this.class_GridView);
            this.groupBox10.Controls.Add(this.classRefreshTable_btn);
            this.groupBox10.Location = new System.Drawing.Point(6, 105);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(1120, 562);
            this.groupBox10.TabIndex = 22;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Table Operations";
            // 
            // classCourseCodeLookUp_btn
            // 
            this.classCourseCodeLookUp_btn.Location = new System.Drawing.Point(1040, 19);
            this.classCourseCodeLookUp_btn.Name = "classCourseCodeLookUp_btn";
            this.classCourseCodeLookUp_btn.Size = new System.Drawing.Size(70, 22);
            this.classCourseCodeLookUp_btn.TabIndex = 16;
            this.classCourseCodeLookUp_btn.Text = "Look Up";
            this.classCourseCodeLookUp_btn.UseVisualStyleBackColor = true;
            this.classCourseCodeLookUp_btn.Click += new System.EventHandler(this.classCourseCodeLookUp_btn_Click);
            // 
            // class_lbl
            // 
            this.class_lbl.AutoSize = true;
            this.class_lbl.Location = new System.Drawing.Point(21, 24);
            this.class_lbl.Name = "class_lbl";
            this.class_lbl.Size = new System.Drawing.Size(46, 13);
            this.class_lbl.TabIndex = 15;
            this.class_lbl.Text = "Classes:";
            // 
            // classCourseCodeTable_lbl
            // 
            this.classCourseCodeTable_lbl.AutoSize = true;
            this.classCourseCodeTable_lbl.ForeColor = System.Drawing.Color.Blue;
            this.classCourseCodeTable_lbl.Location = new System.Drawing.Point(750, 24);
            this.classCourseCodeTable_lbl.Name = "classCourseCodeTable_lbl";
            this.classCourseCodeTable_lbl.Size = new System.Drawing.Size(76, 13);
            this.classCourseCodeTable_lbl.TabIndex = 14;
            this.classCourseCodeTable_lbl.Text = "Course Codes:";
            // 
            // classCourseCode_GridView
            // 
            this.classCourseCode_GridView.AllowUserToAddRows = false;
            this.classCourseCode_GridView.AllowUserToDeleteRows = false;
            this.classCourseCode_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.classCourseCode_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.classCourseCode_GridView.Location = new System.Drawing.Point(753, 46);
            this.classCourseCode_GridView.Name = "classCourseCode_GridView";
            this.classCourseCode_GridView.ReadOnly = true;
            this.classCourseCode_GridView.Size = new System.Drawing.Size(357, 510);
            this.classCourseCode_GridView.TabIndex = 12;
            // 
            // classUpdateTable_btn
            // 
            this.classUpdateTable_btn.Enabled = false;
            this.classUpdateTable_btn.Location = new System.Drawing.Point(612, 19);
            this.classUpdateTable_btn.Name = "classUpdateTable_btn";
            this.classUpdateTable_btn.Size = new System.Drawing.Size(110, 22);
            this.classUpdateTable_btn.TabIndex = 11;
            this.classUpdateTable_btn.Text = "Update Table";
            this.classUpdateTable_btn.UseVisualStyleBackColor = true;
            this.classUpdateTable_btn.Click += new System.EventHandler(this.classUpdateTable_btn_Click);
            // 
            // class_GridView
            // 
            this.class_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.class_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.class_GridView.Location = new System.Drawing.Point(22, 46);
            this.class_GridView.Name = "class_GridView";
            this.class_GridView.Size = new System.Drawing.Size(700, 510);
            this.class_GridView.TabIndex = 9;
            // 
            // classRefreshTable_btn
            // 
            this.classRefreshTable_btn.Location = new System.Drawing.Point(496, 19);
            this.classRefreshTable_btn.Name = "classRefreshTable_btn";
            this.classRefreshTable_btn.Size = new System.Drawing.Size(110, 22);
            this.classRefreshTable_btn.TabIndex = 10;
            this.classRefreshTable_btn.Text = "Refresh Table";
            this.classRefreshTable_btn.UseVisualStyleBackColor = true;
            this.classRefreshTable_btn.Click += new System.EventHandler(this.classRefreshTable_btn_Click);
            // 
            // teachInsert
            // 
            this.teachInsert.Controls.Add(this.groupBox13);
            this.teachInsert.Controls.Add(this.groupBox14);
            this.teachInsert.Location = new System.Drawing.Point(4, 22);
            this.teachInsert.Name = "teachInsert";
            this.teachInsert.Size = new System.Drawing.Size(1132, 673);
            this.teachInsert.TabIndex = 7;
            this.teachInsert.Text = "Teach";
            this.teachInsert.UseVisualStyleBackColor = true;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.label11);
            this.groupBox13.Controls.Add(this.label12);
            this.groupBox13.Controls.Add(this.teachClassId_updwn);
            this.groupBox13.Controls.Add(this.teachProfId_updwn);
            this.groupBox13.Controls.Add(this.teachclassId_lbl);
            this.groupBox13.Controls.Add(this.teachDelete_btn);
            this.groupBox13.Controls.Add(this.teachUpdate_btn);
            this.groupBox13.Controls.Add(this.teachCreate_btn);
            this.groupBox13.Controls.Add(this.teachProfId_lbl);
            this.groupBox13.Location = new System.Drawing.Point(6, 6);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(1120, 93);
            this.groupBox13.TabIndex = 25;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Tuple Operations";
            // 
            // teachClassId_updwn
            // 
            this.teachClassId_updwn.Location = new System.Drawing.Point(342, 23);
            this.teachClassId_updwn.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.teachClassId_updwn.Name = "teachClassId_updwn";
            this.teachClassId_updwn.Size = new System.Drawing.Size(179, 20);
            this.teachClassId_updwn.TabIndex = 16;
            // 
            // teachProfId_updwn
            // 
            this.teachProfId_updwn.Location = new System.Drawing.Point(91, 23);
            this.teachProfId_updwn.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.teachProfId_updwn.Name = "teachProfId_updwn";
            this.teachProfId_updwn.Size = new System.Drawing.Size(179, 20);
            this.teachProfId_updwn.TabIndex = 15;
            // 
            // teachclassId_lbl
            // 
            this.teachclassId_lbl.AutoSize = true;
            this.teachclassId_lbl.ForeColor = System.Drawing.Color.Blue;
            this.teachclassId_lbl.Location = new System.Drawing.Point(287, 25);
            this.teachclassId_lbl.Name = "teachclassId_lbl";
            this.teachclassId_lbl.Size = new System.Drawing.Size(49, 13);
            this.teachclassId_lbl.TabIndex = 12;
            this.teachclassId_lbl.Text = "Class ID:";
            // 
            // teachDelete_btn
            // 
            this.teachDelete_btn.Location = new System.Drawing.Point(1050, 57);
            this.teachDelete_btn.Name = "teachDelete_btn";
            this.teachDelete_btn.Size = new System.Drawing.Size(60, 20);
            this.teachDelete_btn.TabIndex = 8;
            this.teachDelete_btn.Text = "Delete";
            this.teachDelete_btn.UseVisualStyleBackColor = true;
            this.teachDelete_btn.Click += new System.EventHandler(this.teachDelete_btn_Click);
            // 
            // teachUpdate_btn
            // 
            this.teachUpdate_btn.Enabled = false;
            this.teachUpdate_btn.Location = new System.Drawing.Point(984, 57);
            this.teachUpdate_btn.Name = "teachUpdate_btn";
            this.teachUpdate_btn.Size = new System.Drawing.Size(60, 20);
            this.teachUpdate_btn.TabIndex = 7;
            this.teachUpdate_btn.Text = "Update";
            this.teachUpdate_btn.UseVisualStyleBackColor = true;
            // 
            // teachCreate_btn
            // 
            this.teachCreate_btn.Location = new System.Drawing.Point(918, 57);
            this.teachCreate_btn.Name = "teachCreate_btn";
            this.teachCreate_btn.Size = new System.Drawing.Size(60, 20);
            this.teachCreate_btn.TabIndex = 6;
            this.teachCreate_btn.Text = "Create";
            this.teachCreate_btn.UseVisualStyleBackColor = true;
            this.teachCreate_btn.Click += new System.EventHandler(this.teachCreate_btn_Click);
            // 
            // teachProfId_lbl
            // 
            this.teachProfId_lbl.AutoSize = true;
            this.teachProfId_lbl.ForeColor = System.Drawing.Color.Blue;
            this.teachProfId_lbl.Location = new System.Drawing.Point(21, 25);
            this.teachProfId_lbl.Name = "teachProfId_lbl";
            this.teachProfId_lbl.Size = new System.Drawing.Size(68, 13);
            this.teachProfId_lbl.TabIndex = 2;
            this.teachProfId_lbl.Text = "Professor ID:";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.teachClassIdLookUp_btn);
            this.groupBox14.Controls.Add(this.teachClassIdTable_lbl);
            this.groupBox14.Controls.Add(this.teachClassId_GridView);
            this.groupBox14.Controls.Add(this.teachProfIdLookUp_btn);
            this.groupBox14.Controls.Add(this.teach_lbl);
            this.groupBox14.Controls.Add(this.teachProfIdTable_lbl);
            this.groupBox14.Controls.Add(this.teachProfId_GridView);
            this.groupBox14.Controls.Add(this.teachUpdateTable_btn);
            this.groupBox14.Controls.Add(this.teach_GridView);
            this.groupBox14.Controls.Add(this.teachRefreshTable_btn);
            this.groupBox14.Location = new System.Drawing.Point(6, 105);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(1120, 562);
            this.groupBox14.TabIndex = 24;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Table Operations";
            // 
            // teachClassIdLookUp_btn
            // 
            this.teachClassIdLookUp_btn.Location = new System.Drawing.Point(1040, 299);
            this.teachClassIdLookUp_btn.Name = "teachClassIdLookUp_btn";
            this.teachClassIdLookUp_btn.Size = new System.Drawing.Size(70, 22);
            this.teachClassIdLookUp_btn.TabIndex = 19;
            this.teachClassIdLookUp_btn.Text = "Look Up";
            this.teachClassIdLookUp_btn.UseVisualStyleBackColor = true;
            this.teachClassIdLookUp_btn.Click += new System.EventHandler(this.teachClassIdLookUp_btn_Click);
            // 
            // teachClassIdTable_lbl
            // 
            this.teachClassIdTable_lbl.AutoSize = true;
            this.teachClassIdTable_lbl.ForeColor = System.Drawing.Color.Blue;
            this.teachClassIdTable_lbl.Location = new System.Drawing.Point(750, 304);
            this.teachClassIdTable_lbl.Name = "teachClassIdTable_lbl";
            this.teachClassIdTable_lbl.Size = new System.Drawing.Size(60, 13);
            this.teachClassIdTable_lbl.TabIndex = 18;
            this.teachClassIdTable_lbl.Text = "Classes ID:";
            // 
            // teachClassId_GridView
            // 
            this.teachClassId_GridView.AllowUserToAddRows = false;
            this.teachClassId_GridView.AllowUserToDeleteRows = false;
            this.teachClassId_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teachClassId_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachClassId_GridView.Location = new System.Drawing.Point(753, 326);
            this.teachClassId_GridView.Name = "teachClassId_GridView";
            this.teachClassId_GridView.ReadOnly = true;
            this.teachClassId_GridView.Size = new System.Drawing.Size(357, 230);
            this.teachClassId_GridView.TabIndex = 17;
            // 
            // teachProfIdLookUp_btn
            // 
            this.teachProfIdLookUp_btn.Location = new System.Drawing.Point(1040, 19);
            this.teachProfIdLookUp_btn.Name = "teachProfIdLookUp_btn";
            this.teachProfIdLookUp_btn.Size = new System.Drawing.Size(70, 22);
            this.teachProfIdLookUp_btn.TabIndex = 16;
            this.teachProfIdLookUp_btn.Text = "Look Up";
            this.teachProfIdLookUp_btn.UseVisualStyleBackColor = true;
            this.teachProfIdLookUp_btn.Click += new System.EventHandler(this.teachProfIdLookUp_btn_Click);
            // 
            // teach_lbl
            // 
            this.teach_lbl.AutoSize = true;
            this.teach_lbl.Location = new System.Drawing.Point(21, 24);
            this.teach_lbl.Name = "teach_lbl";
            this.teach_lbl.Size = new System.Drawing.Size(132, 13);
            this.teach_lbl.TabIndex = 15;
            this.teach_lbl.Text = "Professors Teach Classes:";
            // 
            // teachProfIdTable_lbl
            // 
            this.teachProfIdTable_lbl.AutoSize = true;
            this.teachProfIdTable_lbl.ForeColor = System.Drawing.Color.Blue;
            this.teachProfIdTable_lbl.Location = new System.Drawing.Point(750, 24);
            this.teachProfIdTable_lbl.Name = "teachProfIdTable_lbl";
            this.teachProfIdTable_lbl.Size = new System.Drawing.Size(73, 13);
            this.teachProfIdTable_lbl.TabIndex = 14;
            this.teachProfIdTable_lbl.Text = "Professors ID:";
            // 
            // teachProfId_GridView
            // 
            this.teachProfId_GridView.AllowUserToAddRows = false;
            this.teachProfId_GridView.AllowUserToDeleteRows = false;
            this.teachProfId_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teachProfId_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teachProfId_GridView.Location = new System.Drawing.Point(753, 46);
            this.teachProfId_GridView.Name = "teachProfId_GridView";
            this.teachProfId_GridView.ReadOnly = true;
            this.teachProfId_GridView.Size = new System.Drawing.Size(357, 230);
            this.teachProfId_GridView.TabIndex = 12;
            // 
            // teachUpdateTable_btn
            // 
            this.teachUpdateTable_btn.Enabled = false;
            this.teachUpdateTable_btn.Location = new System.Drawing.Point(612, 19);
            this.teachUpdateTable_btn.Name = "teachUpdateTable_btn";
            this.teachUpdateTable_btn.Size = new System.Drawing.Size(110, 22);
            this.teachUpdateTable_btn.TabIndex = 11;
            this.teachUpdateTable_btn.Text = "Update Table";
            this.teachUpdateTable_btn.UseVisualStyleBackColor = true;
            this.teachUpdateTable_btn.Click += new System.EventHandler(this.teachUpdateTable_btn_Click);
            // 
            // teach_GridView
            // 
            this.teach_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.teach_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teach_GridView.Location = new System.Drawing.Point(22, 46);
            this.teach_GridView.Name = "teach_GridView";
            this.teach_GridView.Size = new System.Drawing.Size(700, 510);
            this.teach_GridView.TabIndex = 9;
            // 
            // teachRefreshTable_btn
            // 
            this.teachRefreshTable_btn.Location = new System.Drawing.Point(496, 19);
            this.teachRefreshTable_btn.Name = "teachRefreshTable_btn";
            this.teachRefreshTable_btn.Size = new System.Drawing.Size(110, 22);
            this.teachRefreshTable_btn.TabIndex = 10;
            this.teachRefreshTable_btn.Text = "Refresh Table";
            this.teachRefreshTable_btn.UseVisualStyleBackColor = true;
            this.teachRefreshTable_btn.Click += new System.EventHandler(this.teachRefreshTable_btn_Click);
            // 
            // teakenInsert
            // 
            this.teakenInsert.Controls.Add(this.groupBox15);
            this.teakenInsert.Controls.Add(this.groupBox16);
            this.teakenInsert.Location = new System.Drawing.Point(4, 22);
            this.teakenInsert.Name = "teakenInsert";
            this.teakenInsert.Size = new System.Drawing.Size(1132, 673);
            this.teakenInsert.TabIndex = 8;
            this.teakenInsert.Text = "Taken";
            this.teakenInsert.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.label13);
            this.groupBox15.Controls.Add(this.label14);
            this.groupBox15.Controls.Add(this.takenGrade_updwn);
            this.groupBox15.Controls.Add(this.takenGrade_lbl);
            this.groupBox15.Controls.Add(this.takenClassId_updwn);
            this.groupBox15.Controls.Add(this.takenUin_updwn);
            this.groupBox15.Controls.Add(this.takenClassId_lbl);
            this.groupBox15.Controls.Add(this.teakenDelete_btn);
            this.groupBox15.Controls.Add(this.teakenUpdate_btn);
            this.groupBox15.Controls.Add(this.teakenCreate_btn);
            this.groupBox15.Controls.Add(this.takenUin_lbl);
            this.groupBox15.Location = new System.Drawing.Point(6, 6);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(1120, 93);
            this.groupBox15.TabIndex = 27;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Tuple Operations";
            // 
            // takenGrade_updwn
            // 
            this.takenGrade_updwn.DecimalPlaces = 2;
            this.takenGrade_updwn.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.takenGrade_updwn.Location = new System.Drawing.Point(588, 23);
            this.takenGrade_updwn.Name = "takenGrade_updwn";
            this.takenGrade_updwn.Size = new System.Drawing.Size(179, 20);
            this.takenGrade_updwn.TabIndex = 18;
            // 
            // takenGrade_lbl
            // 
            this.takenGrade_lbl.AutoSize = true;
            this.takenGrade_lbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.takenGrade_lbl.Location = new System.Drawing.Point(543, 25);
            this.takenGrade_lbl.Name = "takenGrade_lbl";
            this.takenGrade_lbl.Size = new System.Drawing.Size(39, 13);
            this.takenGrade_lbl.TabIndex = 17;
            this.takenGrade_lbl.Text = "Grade:";
            // 
            // takenClassId_updwn
            // 
            this.takenClassId_updwn.Location = new System.Drawing.Point(342, 23);
            this.takenClassId_updwn.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.takenClassId_updwn.Name = "takenClassId_updwn";
            this.takenClassId_updwn.Size = new System.Drawing.Size(179, 20);
            this.takenClassId_updwn.TabIndex = 16;
            // 
            // takenUin_updwn
            // 
            this.takenUin_updwn.Location = new System.Drawing.Point(91, 23);
            this.takenUin_updwn.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.takenUin_updwn.Name = "takenUin_updwn";
            this.takenUin_updwn.Size = new System.Drawing.Size(179, 20);
            this.takenUin_updwn.TabIndex = 15;
            // 
            // takenClassId_lbl
            // 
            this.takenClassId_lbl.AutoSize = true;
            this.takenClassId_lbl.ForeColor = System.Drawing.Color.Blue;
            this.takenClassId_lbl.Location = new System.Drawing.Point(287, 25);
            this.takenClassId_lbl.Name = "takenClassId_lbl";
            this.takenClassId_lbl.Size = new System.Drawing.Size(49, 13);
            this.takenClassId_lbl.TabIndex = 12;
            this.takenClassId_lbl.Text = "Class ID:";
            // 
            // teakenDelete_btn
            // 
            this.teakenDelete_btn.Location = new System.Drawing.Point(1050, 57);
            this.teakenDelete_btn.Name = "teakenDelete_btn";
            this.teakenDelete_btn.Size = new System.Drawing.Size(60, 20);
            this.teakenDelete_btn.TabIndex = 8;
            this.teakenDelete_btn.Text = "Delete";
            this.teakenDelete_btn.UseVisualStyleBackColor = true;
            this.teakenDelete_btn.Click += new System.EventHandler(this.teakenDelete_btn_Click);
            // 
            // teakenUpdate_btn
            // 
            this.teakenUpdate_btn.Location = new System.Drawing.Point(984, 57);
            this.teakenUpdate_btn.Name = "teakenUpdate_btn";
            this.teakenUpdate_btn.Size = new System.Drawing.Size(60, 20);
            this.teakenUpdate_btn.TabIndex = 7;
            this.teakenUpdate_btn.Text = "Update";
            this.teakenUpdate_btn.UseVisualStyleBackColor = true;
            this.teakenUpdate_btn.Click += new System.EventHandler(this.teakenUpdate_btn_Click);
            // 
            // teakenCreate_btn
            // 
            this.teakenCreate_btn.Location = new System.Drawing.Point(918, 57);
            this.teakenCreate_btn.Name = "teakenCreate_btn";
            this.teakenCreate_btn.Size = new System.Drawing.Size(60, 20);
            this.teakenCreate_btn.TabIndex = 6;
            this.teakenCreate_btn.Text = "Create";
            this.teakenCreate_btn.UseVisualStyleBackColor = true;
            this.teakenCreate_btn.Click += new System.EventHandler(this.teakenCreate_btn_Click);
            // 
            // takenUin_lbl
            // 
            this.takenUin_lbl.AutoSize = true;
            this.takenUin_lbl.ForeColor = System.Drawing.Color.Blue;
            this.takenUin_lbl.Location = new System.Drawing.Point(21, 25);
            this.takenUin_lbl.Name = "takenUin_lbl";
            this.takenUin_lbl.Size = new System.Drawing.Size(69, 13);
            this.takenUin_lbl.TabIndex = 2;
            this.takenUin_lbl.Text = "Student UIN:";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.takenClassIdLookUp_btn);
            this.groupBox16.Controls.Add(this.label3);
            this.groupBox16.Controls.Add(this.takenClassId_GridView);
            this.groupBox16.Controls.Add(this.takenUinLookUp_btn);
            this.groupBox16.Controls.Add(this.taken_lbl);
            this.groupBox16.Controls.Add(this.label5);
            this.groupBox16.Controls.Add(this.takenUin_GridView);
            this.groupBox16.Controls.Add(this.takenUpdateTable_btn);
            this.groupBox16.Controls.Add(this.taken_GridView);
            this.groupBox16.Controls.Add(this.takenRefreshTable_btn);
            this.groupBox16.Location = new System.Drawing.Point(6, 105);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(1120, 562);
            this.groupBox16.TabIndex = 26;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Table Operations";
            // 
            // takenClassIdLookUp_btn
            // 
            this.takenClassIdLookUp_btn.Location = new System.Drawing.Point(1040, 299);
            this.takenClassIdLookUp_btn.Name = "takenClassIdLookUp_btn";
            this.takenClassIdLookUp_btn.Size = new System.Drawing.Size(70, 22);
            this.takenClassIdLookUp_btn.TabIndex = 19;
            this.takenClassIdLookUp_btn.Text = "Look Up";
            this.takenClassIdLookUp_btn.UseVisualStyleBackColor = true;
            this.takenClassIdLookUp_btn.Click += new System.EventHandler(this.takenClassIdLookUp_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(750, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Classes ID:";
            // 
            // takenClassId_GridView
            // 
            this.takenClassId_GridView.AllowUserToAddRows = false;
            this.takenClassId_GridView.AllowUserToDeleteRows = false;
            this.takenClassId_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.takenClassId_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.takenClassId_GridView.Location = new System.Drawing.Point(753, 326);
            this.takenClassId_GridView.Name = "takenClassId_GridView";
            this.takenClassId_GridView.ReadOnly = true;
            this.takenClassId_GridView.Size = new System.Drawing.Size(357, 230);
            this.takenClassId_GridView.TabIndex = 17;
            // 
            // takenUinLookUp_btn
            // 
            this.takenUinLookUp_btn.Location = new System.Drawing.Point(1040, 19);
            this.takenUinLookUp_btn.Name = "takenUinLookUp_btn";
            this.takenUinLookUp_btn.Size = new System.Drawing.Size(70, 22);
            this.takenUinLookUp_btn.TabIndex = 16;
            this.takenUinLookUp_btn.Text = "Look Up";
            this.takenUinLookUp_btn.UseVisualStyleBackColor = true;
            this.takenUinLookUp_btn.Click += new System.EventHandler(this.takenUinLookUp_btn_Click);
            // 
            // taken_lbl
            // 
            this.taken_lbl.AutoSize = true;
            this.taken_lbl.Location = new System.Drawing.Point(21, 24);
            this.taken_lbl.Name = "taken_lbl";
            this.taken_lbl.Size = new System.Drawing.Size(125, 13);
            this.taken_lbl.TabIndex = 15;
            this.taken_lbl.Text = "Students Taken Classes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(750, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Student UIN:";
            // 
            // takenUin_GridView
            // 
            this.takenUin_GridView.AllowUserToAddRows = false;
            this.takenUin_GridView.AllowUserToDeleteRows = false;
            this.takenUin_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.takenUin_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.takenUin_GridView.Location = new System.Drawing.Point(753, 46);
            this.takenUin_GridView.Name = "takenUin_GridView";
            this.takenUin_GridView.ReadOnly = true;
            this.takenUin_GridView.Size = new System.Drawing.Size(357, 230);
            this.takenUin_GridView.TabIndex = 12;
            // 
            // takenUpdateTable_btn
            // 
            this.takenUpdateTable_btn.Enabled = false;
            this.takenUpdateTable_btn.Location = new System.Drawing.Point(612, 19);
            this.takenUpdateTable_btn.Name = "takenUpdateTable_btn";
            this.takenUpdateTable_btn.Size = new System.Drawing.Size(110, 22);
            this.takenUpdateTable_btn.TabIndex = 11;
            this.takenUpdateTable_btn.Text = "Update Table";
            this.takenUpdateTable_btn.UseVisualStyleBackColor = true;
            this.takenUpdateTable_btn.Click += new System.EventHandler(this.takenUpdateTable_btn_Click);
            // 
            // taken_GridView
            // 
            this.taken_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.taken_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.taken_GridView.Location = new System.Drawing.Point(22, 46);
            this.taken_GridView.Name = "taken_GridView";
            this.taken_GridView.Size = new System.Drawing.Size(700, 510);
            this.taken_GridView.TabIndex = 9;
            // 
            // takenRefreshTable_btn
            // 
            this.takenRefreshTable_btn.Location = new System.Drawing.Point(496, 19);
            this.takenRefreshTable_btn.Name = "takenRefreshTable_btn";
            this.takenRefreshTable_btn.Size = new System.Drawing.Size(110, 22);
            this.takenRefreshTable_btn.TabIndex = 10;
            this.takenRefreshTable_btn.Text = "Refresh Table";
            this.takenRefreshTable_btn.UseVisualStyleBackColor = true;
            this.takenRefreshTable_btn.Click += new System.EventHandler(this.takenRefreshTable_btn_Click);
            // 
            // clubInsert
            // 
            this.clubInsert.Controls.Add(this.groupBox11);
            this.clubInsert.Controls.Add(this.groupBox12);
            this.clubInsert.Location = new System.Drawing.Point(4, 22);
            this.clubInsert.Name = "clubInsert";
            this.clubInsert.Size = new System.Drawing.Size(1132, 673);
            this.clubInsert.TabIndex = 2;
            this.clubInsert.Text = "Clubs";
            this.clubInsert.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label15);
            this.groupBox11.Controls.Add(this.label16);
            this.groupBox11.Controls.Add(this.clubDelete_btn);
            this.groupBox11.Controls.Add(this.clubUpdate_btn);
            this.groupBox11.Controls.Add(this.clubEmail_txt);
            this.groupBox11.Controls.Add(this.clubCreate_btn);
            this.groupBox11.Controls.Add(this.clubEmail_lbl);
            this.groupBox11.Controls.Add(this.clubName_lbl);
            this.groupBox11.Controls.Add(this.clubId_lbl);
            this.groupBox11.Controls.Add(this.clubId_updwn);
            this.groupBox11.Controls.Add(this.clubName_txt);
            this.groupBox11.Location = new System.Drawing.Point(6, 6);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(1120, 93);
            this.groupBox11.TabIndex = 17;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Tuple Operations";
            // 
            // clubDelete_btn
            // 
            this.clubDelete_btn.Location = new System.Drawing.Point(1050, 57);
            this.clubDelete_btn.Name = "clubDelete_btn";
            this.clubDelete_btn.Size = new System.Drawing.Size(60, 20);
            this.clubDelete_btn.TabIndex = 7;
            this.clubDelete_btn.Text = "Delete";
            this.clubDelete_btn.UseVisualStyleBackColor = true;
            this.clubDelete_btn.Click += new System.EventHandler(this.clubDelete_btn_Click);
            // 
            // clubUpdate_btn
            // 
            this.clubUpdate_btn.Location = new System.Drawing.Point(984, 57);
            this.clubUpdate_btn.Name = "clubUpdate_btn";
            this.clubUpdate_btn.Size = new System.Drawing.Size(60, 20);
            this.clubUpdate_btn.TabIndex = 6;
            this.clubUpdate_btn.Text = "Update";
            this.clubUpdate_btn.UseVisualStyleBackColor = true;
            this.clubUpdate_btn.Click += new System.EventHandler(this.clubUpdate_btn_Click);
            // 
            // clubEmail_txt
            // 
            this.clubEmail_txt.Location = new System.Drawing.Point(655, 21);
            this.clubEmail_txt.Name = "clubEmail_txt";
            this.clubEmail_txt.Size = new System.Drawing.Size(197, 20);
            this.clubEmail_txt.TabIndex = 4;
            // 
            // clubCreate_btn
            // 
            this.clubCreate_btn.Location = new System.Drawing.Point(918, 57);
            this.clubCreate_btn.Name = "clubCreate_btn";
            this.clubCreate_btn.Size = new System.Drawing.Size(60, 20);
            this.clubCreate_btn.TabIndex = 5;
            this.clubCreate_btn.Text = "Create";
            this.clubCreate_btn.UseVisualStyleBackColor = true;
            this.clubCreate_btn.Click += new System.EventHandler(this.clubCreate_btn_Click);
            // 
            // clubEmail_lbl
            // 
            this.clubEmail_lbl.AutoSize = true;
            this.clubEmail_lbl.Location = new System.Drawing.Point(614, 25);
            this.clubEmail_lbl.Name = "clubEmail_lbl";
            this.clubEmail_lbl.Size = new System.Drawing.Size(35, 13);
            this.clubEmail_lbl.TabIndex = 6;
            this.clubEmail_lbl.Text = "Email:";
            // 
            // clubName_lbl
            // 
            this.clubName_lbl.AutoSize = true;
            this.clubName_lbl.Location = new System.Drawing.Point(246, 25);
            this.clubName_lbl.Name = "clubName_lbl";
            this.clubName_lbl.Size = new System.Drawing.Size(38, 13);
            this.clubName_lbl.TabIndex = 3;
            this.clubName_lbl.Text = "Name:";
            // 
            // clubId_lbl
            // 
            this.clubId_lbl.AutoSize = true;
            this.clubId_lbl.ForeColor = System.Drawing.Color.Red;
            this.clubId_lbl.Location = new System.Drawing.Point(21, 25);
            this.clubId_lbl.Name = "clubId_lbl";
            this.clubId_lbl.Size = new System.Drawing.Size(45, 13);
            this.clubId_lbl.TabIndex = 2;
            this.clubId_lbl.Text = "Club ID:";
            // 
            // clubId_updwn
            // 
            this.clubId_updwn.Location = new System.Drawing.Point(72, 22);
            this.clubId_updwn.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.clubId_updwn.Name = "clubId_updwn";
            this.clubId_updwn.Size = new System.Drawing.Size(97, 20);
            this.clubId_updwn.TabIndex = 1;
            // 
            // clubName_txt
            // 
            this.clubName_txt.Location = new System.Drawing.Point(285, 21);
            this.clubName_txt.Name = "clubName_txt";
            this.clubName_txt.Size = new System.Drawing.Size(273, 20);
            this.clubName_txt.TabIndex = 2;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.club_lbl);
            this.groupBox12.Controls.Add(this.clubUpdateTable_btn);
            this.groupBox12.Controls.Add(this.club_GridView);
            this.groupBox12.Controls.Add(this.clubRefreshTable_btn);
            this.groupBox12.Location = new System.Drawing.Point(6, 105);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(1120, 562);
            this.groupBox12.TabIndex = 16;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Table Operations";
            // 
            // club_lbl
            // 
            this.club_lbl.AutoSize = true;
            this.club_lbl.Location = new System.Drawing.Point(21, 24);
            this.club_lbl.Name = "club_lbl";
            this.club_lbl.Size = new System.Drawing.Size(36, 13);
            this.club_lbl.TabIndex = 11;
            this.club_lbl.Text = "Clubs:";
            // 
            // clubUpdateTable_btn
            // 
            this.clubUpdateTable_btn.Enabled = false;
            this.clubUpdateTable_btn.Location = new System.Drawing.Point(612, 19);
            this.clubUpdateTable_btn.Name = "clubUpdateTable_btn";
            this.clubUpdateTable_btn.Size = new System.Drawing.Size(110, 22);
            this.clubUpdateTable_btn.TabIndex = 10;
            this.clubUpdateTable_btn.Text = "Update Table";
            this.clubUpdateTable_btn.UseVisualStyleBackColor = true;
            this.clubUpdateTable_btn.Click += new System.EventHandler(this.clubUpdateTable_btn_Click);
            // 
            // club_GridView
            // 
            this.club_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.club_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.club_GridView.Location = new System.Drawing.Point(22, 46);
            this.club_GridView.Name = "club_GridView";
            this.club_GridView.Size = new System.Drawing.Size(700, 510);
            this.club_GridView.TabIndex = 9;
            // 
            // clubRefreshTable_btn
            // 
            this.clubRefreshTable_btn.Location = new System.Drawing.Point(496, 19);
            this.clubRefreshTable_btn.Name = "clubRefreshTable_btn";
            this.clubRefreshTable_btn.Size = new System.Drawing.Size(110, 22);
            this.clubRefreshTable_btn.TabIndex = 9;
            this.clubRefreshTable_btn.Text = "Refresh Table";
            this.clubRefreshTable_btn.UseVisualStyleBackColor = true;
            this.clubRefreshTable_btn.Click += new System.EventHandler(this.clubRefreshTable_btn_Click);
            // 
            // memberInsert
            // 
            this.memberInsert.Controls.Add(this.groupBox17);
            this.memberInsert.Controls.Add(this.groupBox18);
            this.memberInsert.Location = new System.Drawing.Point(4, 22);
            this.memberInsert.Name = "memberInsert";
            this.memberInsert.Size = new System.Drawing.Size(1132, 673);
            this.memberInsert.TabIndex = 9;
            this.memberInsert.Text = "Members";
            this.memberInsert.UseVisualStyleBackColor = true;
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.label17);
            this.groupBox17.Controls.Add(this.label18);
            this.groupBox17.Controls.Add(this.memberClubId_updwn);
            this.groupBox17.Controls.Add(this.memberUin_updwn);
            this.groupBox17.Controls.Add(this.memberClubId_lbl);
            this.groupBox17.Controls.Add(this.memberDelete_btn);
            this.groupBox17.Controls.Add(this.memberUpdate_btn);
            this.groupBox17.Controls.Add(this.memberCreate_btn);
            this.groupBox17.Controls.Add(this.memberUin_lbl);
            this.groupBox17.Location = new System.Drawing.Point(6, 6);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(1120, 93);
            this.groupBox17.TabIndex = 29;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Tuple Operations";
            // 
            // memberClubId_updwn
            // 
            this.memberClubId_updwn.Location = new System.Drawing.Point(338, 23);
            this.memberClubId_updwn.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.memberClubId_updwn.Name = "memberClubId_updwn";
            this.memberClubId_updwn.Size = new System.Drawing.Size(179, 20);
            this.memberClubId_updwn.TabIndex = 16;
            // 
            // memberUin_updwn
            // 
            this.memberUin_updwn.Location = new System.Drawing.Point(91, 23);
            this.memberUin_updwn.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.memberUin_updwn.Name = "memberUin_updwn";
            this.memberUin_updwn.Size = new System.Drawing.Size(179, 20);
            this.memberUin_updwn.TabIndex = 15;
            // 
            // memberClubId_lbl
            // 
            this.memberClubId_lbl.AutoSize = true;
            this.memberClubId_lbl.ForeColor = System.Drawing.Color.Blue;
            this.memberClubId_lbl.Location = new System.Drawing.Point(287, 25);
            this.memberClubId_lbl.Name = "memberClubId_lbl";
            this.memberClubId_lbl.Size = new System.Drawing.Size(45, 13);
            this.memberClubId_lbl.TabIndex = 12;
            this.memberClubId_lbl.Text = "Club ID:";
            // 
            // memberDelete_btn
            // 
            this.memberDelete_btn.Location = new System.Drawing.Point(1050, 57);
            this.memberDelete_btn.Name = "memberDelete_btn";
            this.memberDelete_btn.Size = new System.Drawing.Size(60, 20);
            this.memberDelete_btn.TabIndex = 8;
            this.memberDelete_btn.Text = "Delete";
            this.memberDelete_btn.UseVisualStyleBackColor = true;
            this.memberDelete_btn.Click += new System.EventHandler(this.memberDelete_btn_Click);
            // 
            // memberUpdate_btn
            // 
            this.memberUpdate_btn.Enabled = false;
            this.memberUpdate_btn.Location = new System.Drawing.Point(984, 57);
            this.memberUpdate_btn.Name = "memberUpdate_btn";
            this.memberUpdate_btn.Size = new System.Drawing.Size(60, 20);
            this.memberUpdate_btn.TabIndex = 7;
            this.memberUpdate_btn.Text = "Update";
            this.memberUpdate_btn.UseVisualStyleBackColor = true;
            // 
            // memberCreate_btn
            // 
            this.memberCreate_btn.Location = new System.Drawing.Point(918, 57);
            this.memberCreate_btn.Name = "memberCreate_btn";
            this.memberCreate_btn.Size = new System.Drawing.Size(60, 20);
            this.memberCreate_btn.TabIndex = 6;
            this.memberCreate_btn.Text = "Create";
            this.memberCreate_btn.UseVisualStyleBackColor = true;
            this.memberCreate_btn.Click += new System.EventHandler(this.memberCreate_btn_Click);
            // 
            // memberUin_lbl
            // 
            this.memberUin_lbl.AutoSize = true;
            this.memberUin_lbl.ForeColor = System.Drawing.Color.Blue;
            this.memberUin_lbl.Location = new System.Drawing.Point(21, 25);
            this.memberUin_lbl.Name = "memberUin_lbl";
            this.memberUin_lbl.Size = new System.Drawing.Size(69, 13);
            this.memberUin_lbl.TabIndex = 2;
            this.memberUin_lbl.Text = "Student UIN:";
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.memberClubIdLookUp_btn);
            this.groupBox18.Controls.Add(this.memberClubIdLookUp_lbl);
            this.groupBox18.Controls.Add(this.memberClubId_GridView);
            this.groupBox18.Controls.Add(this.memberUinLookUp_btn);
            this.groupBox18.Controls.Add(this.member_lbl);
            this.groupBox18.Controls.Add(this.memberUinLookUp_lbl);
            this.groupBox18.Controls.Add(this.memberUin_GridView);
            this.groupBox18.Controls.Add(this.memberUpdateTable_btn);
            this.groupBox18.Controls.Add(this.member_GridView);
            this.groupBox18.Controls.Add(this.memberRefreshTable_btn);
            this.groupBox18.Location = new System.Drawing.Point(6, 105);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(1120, 562);
            this.groupBox18.TabIndex = 28;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Table Operations";
            // 
            // memberClubIdLookUp_btn
            // 
            this.memberClubIdLookUp_btn.Location = new System.Drawing.Point(1040, 299);
            this.memberClubIdLookUp_btn.Name = "memberClubIdLookUp_btn";
            this.memberClubIdLookUp_btn.Size = new System.Drawing.Size(70, 22);
            this.memberClubIdLookUp_btn.TabIndex = 19;
            this.memberClubIdLookUp_btn.Text = "Look Up";
            this.memberClubIdLookUp_btn.UseVisualStyleBackColor = true;
            this.memberClubIdLookUp_btn.Click += new System.EventHandler(this.memberClubIdLookUp_btn_Click);
            // 
            // memberClubIdLookUp_lbl
            // 
            this.memberClubIdLookUp_lbl.AutoSize = true;
            this.memberClubIdLookUp_lbl.ForeColor = System.Drawing.Color.Blue;
            this.memberClubIdLookUp_lbl.Location = new System.Drawing.Point(750, 304);
            this.memberClubIdLookUp_lbl.Name = "memberClubIdLookUp_lbl";
            this.memberClubIdLookUp_lbl.Size = new System.Drawing.Size(45, 13);
            this.memberClubIdLookUp_lbl.TabIndex = 18;
            this.memberClubIdLookUp_lbl.Text = "Club ID:";
            // 
            // memberClubId_GridView
            // 
            this.memberClubId_GridView.AllowUserToAddRows = false;
            this.memberClubId_GridView.AllowUserToDeleteRows = false;
            this.memberClubId_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.memberClubId_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberClubId_GridView.Location = new System.Drawing.Point(753, 326);
            this.memberClubId_GridView.Name = "memberClubId_GridView";
            this.memberClubId_GridView.ReadOnly = true;
            this.memberClubId_GridView.Size = new System.Drawing.Size(357, 230);
            this.memberClubId_GridView.TabIndex = 17;
            // 
            // memberUinLookUp_btn
            // 
            this.memberUinLookUp_btn.Location = new System.Drawing.Point(1040, 19);
            this.memberUinLookUp_btn.Name = "memberUinLookUp_btn";
            this.memberUinLookUp_btn.Size = new System.Drawing.Size(70, 22);
            this.memberUinLookUp_btn.TabIndex = 16;
            this.memberUinLookUp_btn.Text = "Look Up";
            this.memberUinLookUp_btn.UseVisualStyleBackColor = true;
            this.memberUinLookUp_btn.Click += new System.EventHandler(this.memberUinLookUp_btn_Click);
            // 
            // member_lbl
            // 
            this.member_lbl.AutoSize = true;
            this.member_lbl.Location = new System.Drawing.Point(21, 24);
            this.member_lbl.Name = "member_lbl";
            this.member_lbl.Size = new System.Drawing.Size(162, 13);
            this.member_lbl.TabIndex = 15;
            this.member_lbl.Text = "Students and Club Memberships:";
            // 
            // memberUinLookUp_lbl
            // 
            this.memberUinLookUp_lbl.AutoSize = true;
            this.memberUinLookUp_lbl.ForeColor = System.Drawing.Color.Blue;
            this.memberUinLookUp_lbl.Location = new System.Drawing.Point(750, 24);
            this.memberUinLookUp_lbl.Name = "memberUinLookUp_lbl";
            this.memberUinLookUp_lbl.Size = new System.Drawing.Size(69, 13);
            this.memberUinLookUp_lbl.TabIndex = 14;
            this.memberUinLookUp_lbl.Text = "Student UIN:";
            // 
            // memberUin_GridView
            // 
            this.memberUin_GridView.AllowUserToAddRows = false;
            this.memberUin_GridView.AllowUserToDeleteRows = false;
            this.memberUin_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.memberUin_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberUin_GridView.Location = new System.Drawing.Point(753, 46);
            this.memberUin_GridView.Name = "memberUin_GridView";
            this.memberUin_GridView.ReadOnly = true;
            this.memberUin_GridView.Size = new System.Drawing.Size(357, 230);
            this.memberUin_GridView.TabIndex = 12;
            // 
            // memberUpdateTable_btn
            // 
            this.memberUpdateTable_btn.Enabled = false;
            this.memberUpdateTable_btn.Location = new System.Drawing.Point(612, 19);
            this.memberUpdateTable_btn.Name = "memberUpdateTable_btn";
            this.memberUpdateTable_btn.Size = new System.Drawing.Size(110, 22);
            this.memberUpdateTable_btn.TabIndex = 11;
            this.memberUpdateTable_btn.Text = "Update Table";
            this.memberUpdateTable_btn.UseVisualStyleBackColor = true;
            this.memberUpdateTable_btn.Click += new System.EventHandler(this.memberUpdateTable_btn_Click);
            // 
            // member_GridView
            // 
            this.member_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.member_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.member_GridView.Location = new System.Drawing.Point(22, 46);
            this.member_GridView.Name = "member_GridView";
            this.member_GridView.Size = new System.Drawing.Size(700, 510);
            this.member_GridView.TabIndex = 9;
            // 
            // memberRefreshTable_btn
            // 
            this.memberRefreshTable_btn.Location = new System.Drawing.Point(496, 19);
            this.memberRefreshTable_btn.Name = "memberRefreshTable_btn";
            this.memberRefreshTable_btn.Size = new System.Drawing.Size(110, 22);
            this.memberRefreshTable_btn.TabIndex = 10;
            this.memberRefreshTable_btn.Text = "Refresh Table";
            this.memberRefreshTable_btn.UseVisualStyleBackColor = true;
            this.memberRefreshTable_btn.Click += new System.EventHandler(this.memberRefreshTable_btn_Click);
            // 
            // presidentInsert
            // 
            this.presidentInsert.Controls.Add(this.groupBox19);
            this.presidentInsert.Controls.Add(this.groupBox20);
            this.presidentInsert.Location = new System.Drawing.Point(4, 22);
            this.presidentInsert.Name = "presidentInsert";
            this.presidentInsert.Size = new System.Drawing.Size(1132, 673);
            this.presidentInsert.TabIndex = 10;
            this.presidentInsert.Text = "President";
            this.presidentInsert.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.connectToServerBtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1152, 711);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // connectToServerBtn
            // 
            this.connectToServerBtn.Location = new System.Drawing.Point(99, 81);
            this.connectToServerBtn.Name = "connectToServerBtn";
            this.connectToServerBtn.Size = new System.Drawing.Size(110, 23);
            this.connectToServerBtn.TabIndex = 0;
            this.connectToServerBtn.Text = "Connect to MySQL";
            this.connectToServerBtn.UseVisualStyleBackColor = true;
            this.connectToServerBtn.Click += new System.EventHandler(this.connectToServer_Click);
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.label19);
            this.groupBox19.Controls.Add(this.label20);
            this.groupBox19.Controls.Add(this.presidentClubId_updwn);
            this.groupBox19.Controls.Add(this.presidentUin_updwn);
            this.groupBox19.Controls.Add(this.presidentClubId_lbl);
            this.groupBox19.Controls.Add(this.presidentDelete_btn);
            this.groupBox19.Controls.Add(this.presidentUpdate_btn);
            this.groupBox19.Controls.Add(this.presidentCreate_btn);
            this.groupBox19.Controls.Add(this.presidentUin_lbl);
            this.groupBox19.Location = new System.Drawing.Point(6, 6);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(1120, 93);
            this.groupBox19.TabIndex = 31;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Tuple Operations";
            // 
            // presidentClubId_updwn
            // 
            this.presidentClubId_updwn.Location = new System.Drawing.Point(338, 23);
            this.presidentClubId_updwn.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.presidentClubId_updwn.Name = "presidentClubId_updwn";
            this.presidentClubId_updwn.Size = new System.Drawing.Size(179, 20);
            this.presidentClubId_updwn.TabIndex = 16;
            // 
            // presidentUin_updwn
            // 
            this.presidentUin_updwn.Location = new System.Drawing.Point(91, 23);
            this.presidentUin_updwn.Maximum = new decimal(new int[] {
            -1,
            -1,
            -1,
            0});
            this.presidentUin_updwn.Name = "presidentUin_updwn";
            this.presidentUin_updwn.Size = new System.Drawing.Size(179, 20);
            this.presidentUin_updwn.TabIndex = 15;
            // 
            // presidentClubId_lbl
            // 
            this.presidentClubId_lbl.AutoSize = true;
            this.presidentClubId_lbl.ForeColor = System.Drawing.Color.Blue;
            this.presidentClubId_lbl.Location = new System.Drawing.Point(287, 25);
            this.presidentClubId_lbl.Name = "presidentClubId_lbl";
            this.presidentClubId_lbl.Size = new System.Drawing.Size(45, 13);
            this.presidentClubId_lbl.TabIndex = 12;
            this.presidentClubId_lbl.Text = "Club ID:";
            // 
            // presidentDelete_btn
            // 
            this.presidentDelete_btn.Location = new System.Drawing.Point(1050, 57);
            this.presidentDelete_btn.Name = "presidentDelete_btn";
            this.presidentDelete_btn.Size = new System.Drawing.Size(60, 20);
            this.presidentDelete_btn.TabIndex = 8;
            this.presidentDelete_btn.Text = "Delete";
            this.presidentDelete_btn.UseVisualStyleBackColor = true;
            this.presidentDelete_btn.Click += new System.EventHandler(this.presidentDelete_btn_Click);
            // 
            // presidentUpdate_btn
            // 
            this.presidentUpdate_btn.Enabled = false;
            this.presidentUpdate_btn.Location = new System.Drawing.Point(984, 57);
            this.presidentUpdate_btn.Name = "presidentUpdate_btn";
            this.presidentUpdate_btn.Size = new System.Drawing.Size(60, 20);
            this.presidentUpdate_btn.TabIndex = 7;
            this.presidentUpdate_btn.Text = "Update";
            this.presidentUpdate_btn.UseVisualStyleBackColor = true;
            // 
            // presidentCreate_btn
            // 
            this.presidentCreate_btn.Location = new System.Drawing.Point(918, 57);
            this.presidentCreate_btn.Name = "presidentCreate_btn";
            this.presidentCreate_btn.Size = new System.Drawing.Size(60, 20);
            this.presidentCreate_btn.TabIndex = 6;
            this.presidentCreate_btn.Text = "Create";
            this.presidentCreate_btn.UseVisualStyleBackColor = true;
            this.presidentCreate_btn.Click += new System.EventHandler(this.presidentCreate_btn_Click);
            // 
            // presidentUin_lbl
            // 
            this.presidentUin_lbl.AutoSize = true;
            this.presidentUin_lbl.ForeColor = System.Drawing.Color.Blue;
            this.presidentUin_lbl.Location = new System.Drawing.Point(21, 25);
            this.presidentUin_lbl.Name = "presidentUin_lbl";
            this.presidentUin_lbl.Size = new System.Drawing.Size(69, 13);
            this.presidentUin_lbl.TabIndex = 2;
            this.presidentUin_lbl.Text = "Student UIN:";
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.presidentClubIdLookUp_btn);
            this.groupBox20.Controls.Add(this.presidentClubIdLookUp_lbl);
            this.groupBox20.Controls.Add(this.presidentClubId_GridView);
            this.groupBox20.Controls.Add(this.presidentUinLookUp_btn);
            this.groupBox20.Controls.Add(this.president_lbl);
            this.groupBox20.Controls.Add(this.presidentUinLookUp_lbl);
            this.groupBox20.Controls.Add(this.presidentUin_GridView);
            this.groupBox20.Controls.Add(this.presidentUpdateTable_btn);
            this.groupBox20.Controls.Add(this.president_GridView);
            this.groupBox20.Controls.Add(this.presidentRefreshTable_btn);
            this.groupBox20.Location = new System.Drawing.Point(6, 105);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(1120, 562);
            this.groupBox20.TabIndex = 30;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Table Operations";
            // 
            // presidentClubIdLookUp_btn
            // 
            this.presidentClubIdLookUp_btn.Location = new System.Drawing.Point(1040, 299);
            this.presidentClubIdLookUp_btn.Name = "presidentClubIdLookUp_btn";
            this.presidentClubIdLookUp_btn.Size = new System.Drawing.Size(70, 22);
            this.presidentClubIdLookUp_btn.TabIndex = 19;
            this.presidentClubIdLookUp_btn.Text = "Look Up";
            this.presidentClubIdLookUp_btn.UseVisualStyleBackColor = true;
            this.presidentClubIdLookUp_btn.Click += new System.EventHandler(this.presidentClubIdLookUp_btn_Click);
            // 
            // presidentClubIdLookUp_lbl
            // 
            this.presidentClubIdLookUp_lbl.AutoSize = true;
            this.presidentClubIdLookUp_lbl.ForeColor = System.Drawing.Color.Blue;
            this.presidentClubIdLookUp_lbl.Location = new System.Drawing.Point(750, 304);
            this.presidentClubIdLookUp_lbl.Name = "presidentClubIdLookUp_lbl";
            this.presidentClubIdLookUp_lbl.Size = new System.Drawing.Size(45, 13);
            this.presidentClubIdLookUp_lbl.TabIndex = 18;
            this.presidentClubIdLookUp_lbl.Text = "Club ID:";
            // 
            // presidentClubId_GridView
            // 
            this.presidentClubId_GridView.AllowUserToAddRows = false;
            this.presidentClubId_GridView.AllowUserToDeleteRows = false;
            this.presidentClubId_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.presidentClubId_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.presidentClubId_GridView.Location = new System.Drawing.Point(753, 326);
            this.presidentClubId_GridView.Name = "presidentClubId_GridView";
            this.presidentClubId_GridView.ReadOnly = true;
            this.presidentClubId_GridView.Size = new System.Drawing.Size(357, 230);
            this.presidentClubId_GridView.TabIndex = 17;
            // 
            // presidentUinLookUp_btn
            // 
            this.presidentUinLookUp_btn.Location = new System.Drawing.Point(1040, 19);
            this.presidentUinLookUp_btn.Name = "presidentUinLookUp_btn";
            this.presidentUinLookUp_btn.Size = new System.Drawing.Size(70, 22);
            this.presidentUinLookUp_btn.TabIndex = 16;
            this.presidentUinLookUp_btn.Text = "Look Up";
            this.presidentUinLookUp_btn.UseVisualStyleBackColor = true;
            this.presidentUinLookUp_btn.Click += new System.EventHandler(this.presidentUinLookUp_btn_Click);
            // 
            // president_lbl
            // 
            this.president_lbl.AutoSize = true;
            this.president_lbl.Location = new System.Drawing.Point(21, 24);
            this.president_lbl.Name = "president_lbl";
            this.president_lbl.Size = new System.Drawing.Size(144, 13);
            this.president_lbl.TabIndex = 15;
            this.president_lbl.Text = "Students and Club President:";
            // 
            // presidentUinLookUp_lbl
            // 
            this.presidentUinLookUp_lbl.AutoSize = true;
            this.presidentUinLookUp_lbl.ForeColor = System.Drawing.Color.Blue;
            this.presidentUinLookUp_lbl.Location = new System.Drawing.Point(750, 24);
            this.presidentUinLookUp_lbl.Name = "presidentUinLookUp_lbl";
            this.presidentUinLookUp_lbl.Size = new System.Drawing.Size(69, 13);
            this.presidentUinLookUp_lbl.TabIndex = 14;
            this.presidentUinLookUp_lbl.Text = "Student UIN:";
            // 
            // presidentUin_GridView
            // 
            this.presidentUin_GridView.AllowUserToAddRows = false;
            this.presidentUin_GridView.AllowUserToDeleteRows = false;
            this.presidentUin_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.presidentUin_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.presidentUin_GridView.Location = new System.Drawing.Point(753, 46);
            this.presidentUin_GridView.Name = "presidentUin_GridView";
            this.presidentUin_GridView.ReadOnly = true;
            this.presidentUin_GridView.Size = new System.Drawing.Size(357, 230);
            this.presidentUin_GridView.TabIndex = 12;
            // 
            // presidentUpdateTable_btn
            // 
            this.presidentUpdateTable_btn.Enabled = false;
            this.presidentUpdateTable_btn.Location = new System.Drawing.Point(612, 19);
            this.presidentUpdateTable_btn.Name = "presidentUpdateTable_btn";
            this.presidentUpdateTable_btn.Size = new System.Drawing.Size(110, 22);
            this.presidentUpdateTable_btn.TabIndex = 11;
            this.presidentUpdateTable_btn.Text = "Update Table";
            this.presidentUpdateTable_btn.UseVisualStyleBackColor = true;
            this.presidentUpdateTable_btn.Click += new System.EventHandler(this.presidentUpdateTable_btn_Click);
            // 
            // president_GridView
            // 
            this.president_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.president_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.president_GridView.Location = new System.Drawing.Point(22, 46);
            this.president_GridView.Name = "president_GridView";
            this.president_GridView.Size = new System.Drawing.Size(700, 510);
            this.president_GridView.TabIndex = 9;
            // 
            // presidentRefreshTable_btn
            // 
            this.presidentRefreshTable_btn.Location = new System.Drawing.Point(496, 19);
            this.presidentRefreshTable_btn.Name = "presidentRefreshTable_btn";
            this.presidentRefreshTable_btn.Size = new System.Drawing.Size(110, 22);
            this.presidentRefreshTable_btn.TabIndex = 10;
            this.presidentRefreshTable_btn.Text = "Refresh Table";
            this.presidentRefreshTable_btn.UseVisualStyleBackColor = true;
            this.presidentRefreshTable_btn.Click += new System.EventHandler(this.presidentRefreshTable_btn_Click);
            // 
            // studentPrimaryKey_lbl
            // 
            this.studentPrimaryKey_lbl.AutoSize = true;
            this.studentPrimaryKey_lbl.ForeColor = System.Drawing.Color.Red;
            this.studentPrimaryKey_lbl.Location = new System.Drawing.Point(750, 59);
            this.studentPrimaryKey_lbl.Name = "studentPrimaryKey_lbl";
            this.studentPrimaryKey_lbl.Size = new System.Drawing.Size(62, 13);
            this.studentPrimaryKey_lbl.TabIndex = 14;
            this.studentPrimaryKey_lbl.Text = "Primary Key";
            // 
            // studentForeignKey_lbl
            // 
            this.studentForeignKey_lbl.AutoSize = true;
            this.studentForeignKey_lbl.ForeColor = System.Drawing.Color.Blue;
            this.studentForeignKey_lbl.Location = new System.Drawing.Point(818, 59);
            this.studentForeignKey_lbl.Name = "studentForeignKey_lbl";
            this.studentForeignKey_lbl.Size = new System.Drawing.Size(63, 13);
            this.studentForeignKey_lbl.TabIndex = 15;
            this.studentForeignKey_lbl.Text = "Foreign Key";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(818, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Foreign Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(750, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Primary Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(818, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Foreign Key";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(750, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Primary Key";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Blue;
            this.label7.Location = new System.Drawing.Point(818, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Foreign Key";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(750, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Primary Key";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(818, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Foreign Key";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(750, 59);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Primary Key";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(818, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Foreign Key";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(750, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Primary Key";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(818, 59);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Foreign Key";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(750, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "Primary Key";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(818, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 13);
            this.label15.TabIndex = 17;
            this.label15.Text = "Foreign Key";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(750, 59);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 13);
            this.label16.TabIndex = 16;
            this.label16.Text = "Primary Key";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(818, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 13);
            this.label17.TabIndex = 18;
            this.label17.Text = "Foreign Key";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(750, 59);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(62, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Primary Key";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(818, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 18;
            this.label19.Text = "Foreign Key";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(750, 59);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 13);
            this.label20.TabIndex = 17;
            this.label20.Text = "Primary Key";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.departmentInsert.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.depId_updwn)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.department_GridView)).EndInit();
            this.professorInsert.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profId_updwn)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professor_GridView)).EndInit();
            this.studentInsert.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDepId_updwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentUin_updwn)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentDepId_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.student_GridView)).EndInit();
            this.courseInsert.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseCredit_updwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDepId_updwn)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courseDepId_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.course_GridView)).EndInit();
            this.classInsert.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classId_updwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classSemester_updwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classYear_updwn)).EndInit();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classCourseCode_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class_GridView)).EndInit();
            this.teachInsert.ResumeLayout(false);
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachClassId_updwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachProfId_updwn)).EndInit();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teachClassId_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachProfId_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teach_GridView)).EndInit();
            this.teakenInsert.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.takenGrade_updwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takenClassId_updwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takenUin_updwn)).EndInit();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.takenClassId_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.takenUin_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taken_GridView)).EndInit();
            this.clubInsert.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clubId_updwn)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.club_GridView)).EndInit();
            this.memberInsert.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberClubId_updwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberUin_updwn)).EndInit();
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberClubId_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberUin_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.member_GridView)).EndInit();
            this.presidentInsert.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presidentClubId_updwn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presidentUin_updwn)).EndInit();
            this.groupBox20.ResumeLayout(false);
            this.groupBox20.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.presidentClubId_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.presidentUin_GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.president_GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage departmentInsert;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button create_btn;
        private System.Windows.Forms.MaskedTextBox email_txt;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.MaskedTextBox phoneNumber_txt;
        private System.Windows.Forms.Label phoneNumber_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label depId_label;
        private System.Windows.Forms.NumericUpDown depId_updwn;
        private System.Windows.Forms.MaskedTextBox name_txt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label departments_lbl;
        private System.Windows.Forms.Button updateTable_btn;
        private System.Windows.Forms.DataGridView department_GridView;
        private System.Windows.Forms.Button refresh_btn;
        private System.Windows.Forms.TabPage professorInsert;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker profBirthdate_date;
        private System.Windows.Forms.Label profBirthdate_lbl;
        private System.Windows.Forms.Button profDelete_btn;
        private System.Windows.Forms.Button profUpdate_btn;
        private System.Windows.Forms.Button profCreate_btn;
        private System.Windows.Forms.MaskedTextBox profEmail_txt;
        private System.Windows.Forms.Label profEmail_lbl;
        private System.Windows.Forms.MaskedTextBox profPhoneNumber_txt;
        private System.Windows.Forms.Label profPhoneNumber_lbl;
        private System.Windows.Forms.Label profName_lbl;
        private System.Windows.Forms.Label profId_lbl;
        private System.Windows.Forms.NumericUpDown profId_updwn;
        private System.Windows.Forms.MaskedTextBox profName_txt;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label professors_lbl;
        private System.Windows.Forms.Button profUpdateTable_btn;
        private System.Windows.Forms.DataGridView professor_GridView;
        private System.Windows.Forms.Button profRefreshTable_btn;
        private System.Windows.Forms.TabPage studentInsert;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown studentDepId_updwn;
        private System.Windows.Forms.Label studentDepId_lbl;
        private System.Windows.Forms.DateTimePicker studentBirthdate_date;
        private System.Windows.Forms.Label studentBirthdate_lbl;
        private System.Windows.Forms.Button studentDelete_btn;
        private System.Windows.Forms.Button studentUpdate_btn;
        private System.Windows.Forms.Button studentCreate_btn;
        private System.Windows.Forms.MaskedTextBox studentEmail_txt;
        private System.Windows.Forms.Label studentEmail_lbl;
        private System.Windows.Forms.MaskedTextBox studentPhoneNumber_txt;
        private System.Windows.Forms.Label studentPhoneNumber_lbl;
        private System.Windows.Forms.Label studentName_lbl;
        private System.Windows.Forms.Label studentUin_lbl;
        private System.Windows.Forms.NumericUpDown studentUin_updwn;
        private System.Windows.Forms.MaskedTextBox studentName_txt;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button studentLookUp_btn;
        private System.Windows.Forms.Label student_lbl;
        private System.Windows.Forms.Label studentDepIdTable_lbl;
        private System.Windows.Forms.DataGridView studentDepId_GridView;
        private System.Windows.Forms.Button studentUpdateTable_btn;
        private System.Windows.Forms.DataGridView student_GridView;
        private System.Windows.Forms.Button studentRefreshTable_btn;
        private System.Windows.Forms.TabPage courseInsert;
        private System.Windows.Forms.TabPage classInsert;
        private System.Windows.Forms.TabPage teachInsert;
        private System.Windows.Forms.TabPage teakenInsert;
        private System.Windows.Forms.TabPage clubInsert;
        private System.Windows.Forms.TabPage memberInsert;
        private System.Windows.Forms.TabPage presidentInsert;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button connectToServerBtn;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.NumericUpDown courseDepId_updwn;
        private System.Windows.Forms.Label courseDepId_lbl;
        private System.Windows.Forms.Button courseDelete_btn;
        private System.Windows.Forms.Button courseUpdate_btn;
        private System.Windows.Forms.Button courseCreate_btn;
        private System.Windows.Forms.MaskedTextBox courseCode_txt;
        private System.Windows.Forms.Label courseName_lbl;
        private System.Windows.Forms.Label courseCode_lbl;
        private System.Windows.Forms.MaskedTextBox courseName_txt;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button courseDepIdLookUp_btn;
        private System.Windows.Forms.Label course_lbl;
        private System.Windows.Forms.Label courseDepIdTable_lbl;
        private System.Windows.Forms.DataGridView courseDepId_GridView;
        private System.Windows.Forms.Button courseUpdateTable_btn;
        private System.Windows.Forms.DataGridView course_GridView;
        private System.Windows.Forms.Button courseRefreshTable_btn;
        private System.Windows.Forms.NumericUpDown courseCredit_updwn;
        private System.Windows.Forms.Label courseCredit_lbl;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.NumericUpDown classId_updwn;
        private System.Windows.Forms.NumericUpDown classSemester_updwn;
        private System.Windows.Forms.NumericUpDown classYear_updwn;
        private System.Windows.Forms.Label classCourseCode_lbl;
        private System.Windows.Forms.Button classDelete_btn;
        private System.Windows.Forms.Button classUpdate_btn;
        private System.Windows.Forms.Button classCreate_btn;
        private System.Windows.Forms.Label classSemester_lbl;
        private System.Windows.Forms.Label classYear_lbl;
        private System.Windows.Forms.Label classId_lbl;
        private System.Windows.Forms.MaskedTextBox classCourseCode_txt;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button classCourseCodeLookUp_btn;
        private System.Windows.Forms.Label class_lbl;
        private System.Windows.Forms.Label classCourseCodeTable_lbl;
        private System.Windows.Forms.DataGridView classCourseCode_GridView;
        private System.Windows.Forms.Button classUpdateTable_btn;
        private System.Windows.Forms.DataGridView class_GridView;
        private System.Windows.Forms.Button classRefreshTable_btn;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Button clubDelete_btn;
        private System.Windows.Forms.Button clubUpdate_btn;
        private System.Windows.Forms.MaskedTextBox clubEmail_txt;
        private System.Windows.Forms.Button clubCreate_btn;
        private System.Windows.Forms.Label clubEmail_lbl;
        private System.Windows.Forms.Label clubName_lbl;
        private System.Windows.Forms.Label clubId_lbl;
        private System.Windows.Forms.NumericUpDown clubId_updwn;
        private System.Windows.Forms.MaskedTextBox clubName_txt;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label club_lbl;
        private System.Windows.Forms.Button clubUpdateTable_btn;
        private System.Windows.Forms.DataGridView club_GridView;
        private System.Windows.Forms.Button clubRefreshTable_btn;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.NumericUpDown teachProfId_updwn;
        private System.Windows.Forms.Label teachclassId_lbl;
        private System.Windows.Forms.Button teachDelete_btn;
        private System.Windows.Forms.Button teachCreate_btn;
        private System.Windows.Forms.Label teachProfId_lbl;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.Button teachProfIdLookUp_btn;
        private System.Windows.Forms.Label teach_lbl;
        private System.Windows.Forms.Label teachProfIdTable_lbl;
        private System.Windows.Forms.DataGridView teachProfId_GridView;
        private System.Windows.Forms.Button teachUpdateTable_btn;
        private System.Windows.Forms.DataGridView teach_GridView;
        private System.Windows.Forms.Button teachRefreshTable_btn;
        private System.Windows.Forms.NumericUpDown teachClassId_updwn;
        private System.Windows.Forms.Button teachClassIdLookUp_btn;
        private System.Windows.Forms.Label teachClassIdTable_lbl;
        private System.Windows.Forms.DataGridView teachClassId_GridView;
        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.Button teachUpdate_btn;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.NumericUpDown takenGrade_updwn;
        private System.Windows.Forms.Label takenGrade_lbl;
        private System.Windows.Forms.NumericUpDown takenClassId_updwn;
        private System.Windows.Forms.NumericUpDown takenUin_updwn;
        private System.Windows.Forms.Label takenClassId_lbl;
        private System.Windows.Forms.Button teakenDelete_btn;
        private System.Windows.Forms.Button teakenUpdate_btn;
        private System.Windows.Forms.Button teakenCreate_btn;
        private System.Windows.Forms.Label takenUin_lbl;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Button takenClassIdLookUp_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView takenClassId_GridView;
        private System.Windows.Forms.Button takenUinLookUp_btn;
        private System.Windows.Forms.Label taken_lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView takenUin_GridView;
        private System.Windows.Forms.Button takenUpdateTable_btn;
        private System.Windows.Forms.DataGridView taken_GridView;
        private System.Windows.Forms.Button takenRefreshTable_btn;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.NumericUpDown memberClubId_updwn;
        private System.Windows.Forms.NumericUpDown memberUin_updwn;
        private System.Windows.Forms.Label memberClubId_lbl;
        private System.Windows.Forms.Button memberDelete_btn;
        private System.Windows.Forms.Button memberUpdate_btn;
        private System.Windows.Forms.Button memberCreate_btn;
        private System.Windows.Forms.Label memberUin_lbl;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.Button memberClubIdLookUp_btn;
        private System.Windows.Forms.Label memberClubIdLookUp_lbl;
        private System.Windows.Forms.DataGridView memberClubId_GridView;
        private System.Windows.Forms.Button memberUinLookUp_btn;
        private System.Windows.Forms.Label member_lbl;
        private System.Windows.Forms.Label memberUinLookUp_lbl;
        private System.Windows.Forms.DataGridView memberUin_GridView;
        private System.Windows.Forms.Button memberUpdateTable_btn;
        private System.Windows.Forms.DataGridView member_GridView;
        private System.Windows.Forms.Button memberRefreshTable_btn;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.NumericUpDown presidentClubId_updwn;
        private System.Windows.Forms.NumericUpDown presidentUin_updwn;
        private System.Windows.Forms.Label presidentClubId_lbl;
        private System.Windows.Forms.Button presidentDelete_btn;
        private System.Windows.Forms.Button presidentUpdate_btn;
        private System.Windows.Forms.Button presidentCreate_btn;
        private System.Windows.Forms.Label presidentUin_lbl;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.Button presidentClubIdLookUp_btn;
        private System.Windows.Forms.Label presidentClubIdLookUp_lbl;
        private System.Windows.Forms.DataGridView presidentClubId_GridView;
        private System.Windows.Forms.Button presidentUinLookUp_btn;
        private System.Windows.Forms.Label president_lbl;
        private System.Windows.Forms.Label presidentUinLookUp_lbl;
        private System.Windows.Forms.DataGridView presidentUin_GridView;
        private System.Windows.Forms.Button presidentUpdateTable_btn;
        private System.Windows.Forms.DataGridView president_GridView;
        private System.Windows.Forms.Button presidentRefreshTable_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label studentForeignKey_lbl;
        private System.Windows.Forms.Label studentPrimaryKey_lbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}

