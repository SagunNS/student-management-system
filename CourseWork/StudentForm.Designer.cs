namespace CourseWork
{
    partial class StudentForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.labelFname = new System.Windows.Forms.Label();
            this.textBoxFName = new System.Windows.Forms.TextBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelRegDate = new System.Windows.Forms.Label();
            this.dptRegDate = new System.Windows.Forms.DateTimePicker();
            this.textBoxContactno = new System.Windows.Forms.TextBox();
            this.labelContactNo = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.comboBoxGender = new System.Windows.Forms.ComboBox();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxLname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GridStudents = new System.Windows.Forms.DataGridView();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.PrograminRole = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmbProgEnrol = new System.Windows.Forms.ComboBox();
            this.btnAscReg = new System.Windows.Forms.Button();
            this.btnDesReg = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.btnDesName = new System.Windows.Forms.Button();
            this.btnAscName = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabStudentForm = new System.Windows.Forms.TabPage();
            this.btnCancel = new System.Windows.Forms.Button();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.lblEnrolStaus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.studentReport = new System.Windows.Forms.Label();
            this.weeklyReportGrid = new System.Windows.Forms.Label();
            this.totalEnrolChart = new System.Windows.Forms.Label();
            this.btnChart = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.dataGridViewWeeklyReport = new System.Windows.Forms.DataGridView();
            this.Start = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.Label();
            this.lblED = new System.Windows.Forms.Label();
            this.lblSD = new System.Windows.Forms.Label();
            this.dptWeeklyReport = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.GridStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabStudentForm.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeeklyReport)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFname
            // 
            this.labelFname.AccessibleName = "lblFName";
            this.labelFname.AutoSize = true;
            this.labelFname.Location = new System.Drawing.Point(22, 80);
            this.labelFname.Name = "labelFname";
            this.labelFname.Size = new System.Drawing.Size(57, 13);
            this.labelFname.TabIndex = 0;
            this.labelFname.Text = "First Name";

            // 
            // textBoxFName
            // 
            this.textBoxFName.AccessibleName = "txtFName";
            this.textBoxFName.Location = new System.Drawing.Point(117, 73);
            this.textBoxFName.Name = "textBoxFName";
            this.textBoxFName.Size = new System.Drawing.Size(147, 20);
            this.textBoxFName.TabIndex = 1;
            this.textBoxFName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFName_KeyPress);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.AccessibleName = "txtAddress";
            this.textBoxAddress.Location = new System.Drawing.Point(117, 106);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(147, 20);
            this.textBoxAddress.TabIndex = 3;
            // 
            // labelAddress
            // 
            this.labelAddress.AccessibleName = "lalAddress";
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(22, 113);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(45, 13);
            this.labelAddress.TabIndex = 2;
            this.labelAddress.Text = "Address";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.AccessibleName = "txtBoxEmail";
            this.textBoxEmail.Location = new System.Drawing.Point(117, 142);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(147, 20);
            this.textBoxEmail.TabIndex = 5;
            // 
            // labelEmail
            // 
            this.labelEmail.AccessibleName = "lblEmail";
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(22, 149);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 4;
            this.labelEmail.Text = "Email";
            // 
            // labelRegDate
            // 
            this.labelRegDate.AccessibleName = "labelRegDate";
            this.labelRegDate.AutoSize = true;
            this.labelRegDate.Location = new System.Drawing.Point(333, 184);
            this.labelRegDate.Name = "labelRegDate";
            this.labelRegDate.Size = new System.Drawing.Size(89, 13);
            this.labelRegDate.TabIndex = 6;
            this.labelRegDate.Text = "Registration Date";
            // 
            // dptRegDate
            // 
            this.dptRegDate.AccessibleName = "dptRegDate";
            this.dptRegDate.Location = new System.Drawing.Point(428, 181);
            this.dptRegDate.Name = "dptRegDate";
            this.dptRegDate.Size = new System.Drawing.Size(147, 20);
            this.dptRegDate.TabIndex = 7;
            // 
            // textBoxContactno
            // 
            this.textBoxContactno.AccessibleName = "txtBoxContact";
            this.textBoxContactno.Location = new System.Drawing.Point(118, 183);
            this.textBoxContactno.MaxLength = 10;
            this.textBoxContactno.Name = "textBoxContactno";
            this.textBoxContactno.Size = new System.Drawing.Size(146, 20);
            this.textBoxContactno.TabIndex = 9;
            this.textBoxContactno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxContactno_KeyPress);
            // 
            // labelContactNo
            // 
            this.labelContactNo.AccessibleName = "lblContact";
            this.labelContactNo.AutoSize = true;
            this.labelContactNo.Location = new System.Drawing.Point(22, 187);
            this.labelContactNo.Name = "labelContactNo";
            this.labelContactNo.Size = new System.Drawing.Size(64, 13);
            this.labelContactNo.TabIndex = 8;
            this.labelContactNo.Text = "Contact No.";
            // 
            // labelGender
            // 
            this.labelGender.AccessibleName = "lblGender";
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(333, 146);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(42, 13);
            this.labelGender.TabIndex = 10;
            this.labelGender.Text = "Gender";
            // 
            // comboBoxGender
            // 
            this.comboBoxGender.AccessibleName = "GenderCMB";
            this.comboBoxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGender.FormattingEnabled = true;
            this.comboBoxGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Others"});
            this.comboBoxGender.Location = new System.Drawing.Point(428, 142);
            this.comboBoxGender.Name = "comboBoxGender";
            this.comboBoxGender.Size = new System.Drawing.Size(147, 21);
            this.comboBoxGender.TabIndex = 11;
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.AccessibleName = "btnSubmit";
            this.buttonSubmit.Location = new System.Drawing.Point(795, 228);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(75, 23);
            this.buttonSubmit.TabIndex = 12;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxLname
            // 
            this.textBoxLname.AccessibleName = "txtLname";
            this.textBoxLname.Location = new System.Drawing.Point(428, 74);
            this.textBoxLname.Name = "textBoxLname";
            this.textBoxLname.Size = new System.Drawing.Size(147, 20);
            this.textBoxLname.TabIndex = 14;
            this.textBoxLname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLname_KeyPress);
            // 
            // label1
            // 
            this.label1.AccessibleName = "lblLname";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Last Name";
            // 
            // GridStudents
            // 
            this.GridStudents.AccessibleName = "Grid";
            this.GridStudents.AllowUserToAddRows = false;
            this.GridStudents.AllowUserToDeleteRows = false;
            this.GridStudents.AllowUserToResizeColumns = false;
            this.GridStudents.AllowUserToResizeRows = false;
            this.GridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Edit,
            this.Delete});
            this.GridStudents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.GridStudents.Location = new System.Drawing.Point(25, 292);
            this.GridStudents.Name = "GridStudents";
            this.GridStudents.ShowEditingIcon = false;
            this.GridStudents.Size = new System.Drawing.Size(836, 248);
            this.GridStudents.TabIndex = 15;
            this.GridStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridStudents_CellContentClick);
            this.GridStudents.DoubleClick += new System.EventHandler(this.GridStudents_DoubleClick);
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.Name = "Edit";
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(795, 228);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtId
            // 
            this.txtId.AccessibleName = "txtId";
            this.txtId.Location = new System.Drawing.Point(117, 37);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(146, 20);
            this.txtId.TabIndex = 17;
            this.txtId.Visible = false;
            // 
            // PrograminRole
            // 
            this.PrograminRole.AutoSize = true;
            this.PrograminRole.Location = new System.Drawing.Point(333, 110);
            this.PrograminRole.Name = "PrograminRole";
            this.PrograminRole.Size = new System.Drawing.Size(73, 13);
            this.PrograminRole.TabIndex = 18;
            this.PrograminRole.Text = "Program Enrol";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.LightGray;
            this.chart1.BorderlineColor = System.Drawing.Color.LightGray;
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(13, 186);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Students Enrolled";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(373, 209);
            this.chart1.TabIndex = 20;
            this.chart1.Text = "chart1";
            // 
            // cmbProgEnrol
            // 
            this.cmbProgEnrol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProgEnrol.FormattingEnabled = true;
            this.cmbProgEnrol.Items.AddRange(new object[] {
            "Computing",
            "Networking",
            "MultiMedia"});
            this.cmbProgEnrol.Location = new System.Drawing.Point(428, 110);
            this.cmbProgEnrol.Name = "cmbProgEnrol";
            this.cmbProgEnrol.Size = new System.Drawing.Size(147, 21);
            this.cmbProgEnrol.TabIndex = 21;
            // 
            // btnAscReg
            // 
            this.btnAscReg.Location = new System.Drawing.Point(714, 113);
            this.btnAscReg.Name = "btnAscReg";
            this.btnAscReg.Size = new System.Drawing.Size(75, 23);
            this.btnAscReg.TabIndex = 22;
            this.btnAscReg.Text = " ▲";
            this.btnAscReg.UseVisualStyleBackColor = true;
            this.btnAscReg.Click += new System.EventHandler(this.btnAscReg_Click);
            // 
            // btnDesReg
            // 
            this.btnDesReg.Location = new System.Drawing.Point(786, 113);
            this.btnDesReg.Name = "btnDesReg";
            this.btnDesReg.Size = new System.Drawing.Size(75, 23);
            this.btnDesReg.TabIndex = 23;
            this.btnDesReg.Text = "▼";
            this.btnDesReg.UseVisualStyleBackColor = true;
            this.btnDesReg.Click += new System.EventHandler(this.btnDesReg_Click);
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.Location = new System.Drawing.Point(620, 113);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(72, 13);
            this.Register.TabIndex = 24;
            this.Register.Text = "Register Date";

            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(623, 154);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 25;
            this.labelName.Text = "Name";

            // 
            // btnDesName
            // 
            this.btnDesName.Location = new System.Drawing.Point(786, 154);
            this.btnDesName.Name = "btnDesName";
            this.btnDesName.Size = new System.Drawing.Size(75, 23);
            this.btnDesName.TabIndex = 27;
            this.btnDesName.Text = "▼";
            this.btnDesName.UseVisualStyleBackColor = true;
            this.btnDesName.Click += new System.EventHandler(this.btnDesName_Click);
            // 
            // btnAscName
            // 
            this.btnAscName.Location = new System.Drawing.Point(714, 154);
            this.btnAscName.Name = "btnAscName";
            this.btnAscName.Size = new System.Drawing.Size(75, 23);
            this.btnAscName.TabIndex = 26;
            this.btnAscName.Text = " ▲";
            this.btnAscName.UseVisualStyleBackColor = true;
            this.btnAscName.Click += new System.EventHandler(this.btnAscName_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(714, 228);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 28;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBy.Location = new System.Drawing.Point(620, 75);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(57, 16);
            this.lblSortBy.TabIndex = 29;
            this.lblSortBy.Text = "Sort By :";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabStudentForm);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-5, -2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(894, 591);
            this.tabControl1.TabIndex = 31;
            // 
            // tabStudentForm
            // 
            this.tabStudentForm.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabStudentForm.Controls.Add(this.btnCancel);
            this.tabStudentForm.Controls.Add(this.comboBoxStatus);
            this.tabStudentForm.Controls.Add(this.lblEnrolStaus);
            this.tabStudentForm.Controls.Add(this.label2);
            this.tabStudentForm.Controls.Add(this.txtId);
            this.tabStudentForm.Controls.Add(this.textBoxFName);
            this.tabStudentForm.Controls.Add(this.lblSortBy);
            this.tabStudentForm.Controls.Add(this.btnClear);
            this.tabStudentForm.Controls.Add(this.labelFname);
            this.tabStudentForm.Controls.Add(this.btnDesName);
            this.tabStudentForm.Controls.Add(this.labelAddress);
            this.tabStudentForm.Controls.Add(this.btnAscName);
            this.tabStudentForm.Controls.Add(this.textBoxAddress);
            this.tabStudentForm.Controls.Add(this.labelName);
            this.tabStudentForm.Controls.Add(this.labelEmail);
            this.tabStudentForm.Controls.Add(this.Register);
            this.tabStudentForm.Controls.Add(this.textBoxEmail);
            this.tabStudentForm.Controls.Add(this.btnDesReg);
            this.tabStudentForm.Controls.Add(this.labelRegDate);
            this.tabStudentForm.Controls.Add(this.btnAscReg);
            this.tabStudentForm.Controls.Add(this.dptRegDate);
            this.tabStudentForm.Controls.Add(this.cmbProgEnrol);
            this.tabStudentForm.Controls.Add(this.labelContactNo);
            this.tabStudentForm.Controls.Add(this.textBoxContactno);
            this.tabStudentForm.Controls.Add(this.PrograminRole);
            this.tabStudentForm.Controls.Add(this.labelGender);
            this.tabStudentForm.Controls.Add(this.btnUpdate);
            this.tabStudentForm.Controls.Add(this.comboBoxGender);
            this.tabStudentForm.Controls.Add(this.GridStudents);
            this.tabStudentForm.Controls.Add(this.buttonSubmit);
            this.tabStudentForm.Controls.Add(this.textBoxLname);
            this.tabStudentForm.Controls.Add(this.label1);
            this.tabStudentForm.Location = new System.Drawing.Point(4, 22);
            this.tabStudentForm.Name = "tabStudentForm";
            this.tabStudentForm.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudentForm.Size = new System.Drawing.Size(886, 565);
            this.tabStudentForm.TabIndex = 0;
            this.tabStudentForm.Text = "Student Form";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleName = "btnCancel";
            this.btnCancel.Location = new System.Drawing.Point(714, 228);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.AccessibleName = "cmbEnrolStatus";
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Enrolled",
            "Rejected",
            "Pending"});
            this.comboBoxStatus.Location = new System.Drawing.Point(118, 225);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(147, 21);
            this.comboBoxStatus.TabIndex = 33;
            // 
            // lblEnrolStaus
            // 
            this.lblEnrolStaus.AutoSize = true;
            this.lblEnrolStaus.Location = new System.Drawing.Point(22, 228);
            this.lblEnrolStaus.Name = "lblEnrolStaus";
            this.lblEnrolStaus.Size = new System.Drawing.Size(61, 13);
            this.lblEnrolStaus.TabIndex = 31;
            this.lblEnrolStaus.Text = "Enrol Staus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(280, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 31);
            this.label2.TabIndex = 30;
            this.label2.Text = "Student Information System";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.dptWeeklyReport);
            this.tabPage2.Controls.Add(this.lblSD);
            this.tabPage2.Controls.Add(this.lblED);
            this.tabPage2.Controls.Add(this.EndDate);
            this.tabPage2.Controls.Add(this.Start);
            this.tabPage2.Controls.Add(this.dataGridViewWeeklyReport);
            this.tabPage2.Controls.Add(this.studentReport);
            this.tabPage2.Controls.Add(this.weeklyReportGrid);
            this.tabPage2.Controls.Add(this.totalEnrolChart);
            this.tabPage2.Controls.Add(this.btnChart);
            this.tabPage2.Controls.Add(this.btnReport);
            this.tabPage2.Controls.Add(this.chart1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 565);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Report";
            // 
            // studentReport
            // 
            this.studentReport.AutoSize = true;
            this.studentReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentReport.Location = new System.Drawing.Point(336, 13);
            this.studentReport.Name = "studentReport";
            this.studentReport.Size = new System.Drawing.Size(211, 31);
            this.studentReport.TabIndex = 26;
            this.studentReport.Text = "Student Report";
            // 
            // weeklyReportGrid
            // 
            this.weeklyReportGrid.AutoSize = true;
            this.weeklyReportGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyReportGrid.Location = new System.Drawing.Point(504, 75);
            this.weeklyReportGrid.Name = "weeklyReportGrid";
            this.weeklyReportGrid.Size = new System.Drawing.Size(321, 24);
            this.weeklyReportGrid.TabIndex = 25;
            this.weeklyReportGrid.Text = "Weekly Course Enrolment Report";
            // 
            // totalEnrolChart
            // 
            this.totalEnrolChart.AutoSize = true;
            this.totalEnrolChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalEnrolChart.Location = new System.Drawing.Point(45, 75);
            this.totalEnrolChart.Name = "totalEnrolChart";
            this.totalEnrolChart.Size = new System.Drawing.Size(283, 24);
            this.totalEnrolChart.TabIndex = 24;
            this.totalEnrolChart.Text = "Total Students Enrolled Chart";
            // 
            // btnChart
            // 
            this.btnChart.Location = new System.Drawing.Point(13, 150);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(112, 26);
            this.btnChart.TabIndex = 23;
            this.btnChart.Text = "Enrolment Chart";
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(760, 156);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(112, 24);
            this.btnReport.TabIndex = 22;
            this.btnReport.Text = "Weekly Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // dataGridViewWeeklyReport
            // 
            this.dataGridViewWeeklyReport.AllowUserToAddRows = false;
            this.dataGridViewWeeklyReport.AllowUserToDeleteRows = false;
            this.dataGridViewWeeklyReport.AllowUserToResizeColumns = false;
            this.dataGridViewWeeklyReport.AllowUserToResizeRows = false;
            this.dataGridViewWeeklyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWeeklyReport.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewWeeklyReport.Location = new System.Drawing.Point(472, 239);
            this.dataGridViewWeeklyReport.Name = "dataGridViewWeeklyReport";
            this.dataGridViewWeeklyReport.Size = new System.Drawing.Size(400, 119);
            this.dataGridViewWeeklyReport.TabIndex = 27;
            // 
            // Start
            // 
            this.Start.AutoSize = true;
            this.Start.Location = new System.Drawing.Point(469, 381);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(58, 13);
            this.Start.TabIndex = 28;
            this.Start.Text = "Start Date:";
            // 
            // EndDate
            // 
            this.EndDate.AutoSize = true;
            this.EndDate.Location = new System.Drawing.Point(706, 381);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(55, 13);
            this.EndDate.TabIndex = 29;
            this.EndDate.Text = "End Date:";
            // 
            // lblED
            // 
            this.lblED.AutoSize = true;
            this.lblED.Location = new System.Drawing.Point(786, 381);
            this.lblED.Name = "lblED";
            this.lblED.Size = new System.Drawing.Size(0, 13);
            this.lblED.TabIndex = 30;
            // 
            // lblSD
            // 
            this.lblSD.AutoSize = true;
            this.lblSD.Location = new System.Drawing.Point(549, 381);
            this.lblSD.Name = "lblSD";
            this.lblSD.Size = new System.Drawing.Size(0, 13);
            this.lblSD.TabIndex = 31;
            // 
            // dptWeeklyReport
            // 
            this.dptWeeklyReport.Location = new System.Drawing.Point(472, 156);
            this.dptWeeklyReport.Name = "dptWeeklyReport";
            this.dptWeeklyReport.Size = new System.Drawing.Size(200, 20);
            this.dptWeeklyReport.TabIndex = 32;

            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 572);
            this.Controls.Add(this.tabControl1);
            this.Name = "StudentForm";
            this.Text = "Student Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabStudentForm.ResumeLayout(false);
            this.tabStudentForm.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWeeklyReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelFname;
        private System.Windows.Forms.TextBox textBoxFName;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelRegDate;
        private System.Windows.Forms.DateTimePicker dptRegDate;
        private System.Windows.Forms.TextBox textBoxContactno;
        private System.Windows.Forms.Label labelContactNo;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboBoxGender;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox textBoxLname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView GridStudents;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label PrograminRole;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.ComboBox cmbProgEnrol;
        private System.Windows.Forms.Button btnAscReg;
        private System.Windows.Forms.Button btnDesReg;
        private System.Windows.Forms.Label Register;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnDesName;
        private System.Windows.Forms.Button btnAscName;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabStudentForm;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnChart;
        private System.Windows.Forms.Label studentReport;
        private System.Windows.Forms.Label weeklyReportGrid;
        private System.Windows.Forms.Label totalEnrolChart;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label lblEnrolStaus;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dptWeeklyReport;
        private System.Windows.Forms.Label lblSD;
        private System.Windows.Forms.Label lblED;
        private System.Windows.Forms.Label EndDate;
        private System.Windows.Forms.Label Start;
        private System.Windows.Forms.DataGridView dataGridViewWeeklyReport;
    }
}

