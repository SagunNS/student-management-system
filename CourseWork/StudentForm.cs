using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
            BindGrid();
            btnUpdate.Visible = false;
            btnCancel.Visible = false;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            var emailRegex = new Regex("^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$");
            try
            {
                Student obj = new Student();
                if (string.IsNullOrEmpty(textBoxFName.Text) || string.IsNullOrEmpty(textBoxLname.Text) || string.IsNullOrEmpty(textBoxAddress.Text) || string.IsNullOrEmpty(textBoxContactno.Text) || string.IsNullOrEmpty(textBoxEmail.Text))
                {
                    MessageBox.Show("Sorry,cannot leave text fields empty.", "Error");
                }

                else if (comboBoxGender.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select Gender.", "Error Message");
                }
                else if (comboBoxStatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select Enrol Status.", "Error Message");
                }
                else if (cmbProgEnrol.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select Program for enrolment.", "Error Message");
                }
                else if (!emailRegex.IsMatch(textBoxEmail.Text))
                {
                    MessageBox.Show("Invalid Email", "Error Message");
                }
                else if (textBoxContactno.TextLength > 10)
                {
                    MessageBox.Show("Invalid Phone Number", "Error Message");
                }
                else
                {
                    string FirstName = textBoxFName.Text;
                    string LastName = textBoxLname.Text;
                    obj.Name = FirstName + " " + LastName;
                    obj.Address = textBoxAddress.Text;
                    obj.Email = textBoxEmail.Text;
                    obj.RegDate = dptRegDate.Value;
                    obj.ProgramEnrol = cmbProgEnrol.SelectedItem.ToString();
                    obj.ContactNo = textBoxContactno.Text;
                    obj.Gender = comboBoxGender.SelectedItem.ToString();
                    obj.EnrolStatus = comboBoxStatus.SelectedItem.ToString();
                    obj.Add(obj);
                    MessageBox.Show("Data Successfully Added", "Message");
                    BindGrid();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }

        }

        private void BindGrid()
        {
            Student obj = new Student();
            List<Student> listStudents = obj.List();
            DataTable dt = Utility.ConvertToDataTable(listStudents);
            GridStudents.DataSource = dt;
        }

        private void Clear()
        {
            textBoxFName.Text = "";
            textBoxLname.Text = "";
            textBoxAddress.Text = "";
            textBoxEmail.Text = "";
            dptRegDate.Value = DateTime.Today;
            textBoxContactno.Text = "";
            cmbProgEnrol.SelectedItem = null;
            comboBoxStatus.SelectedItem = null;
            comboBoxGender.SelectedItem = null;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void GridStudents_DoubleClick(object sender, EventArgs e)
        {
            int id = 0; //get clicked id

            //read text file
            Student obj = new Student();
            List<Student> listStudents = obj.List();
            Student s = listStudents.Where(x => x.Id == id).FirstOrDefault();

        }

        private void GridStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Student obj = new Student();
                if (e.ColumnIndex == 0)
                {
                    //get the value of clicked row id column
                    string value = GridStudents[2, e.RowIndex].Value.ToString();
                    int id = 0;
                    if (String.IsNullOrEmpty(value))
                    {
                        MessageBox.Show("Invalid Data");
                    }
                    else
                    {
                        id = int.Parse(value);
                        Student s = obj.List().Where(x => x.Id == id).FirstOrDefault();
                        txtId.Text = s.Id.ToString();
                        textBoxFName.Text = s.Name.Split(' ')[0];
                        textBoxLname.Text = s.Name.Split(' ')[1];
                        textBoxAddress.Text = s.Address;
                        textBoxEmail.Text = s.Email;
                        dptRegDate.Value = s.RegDate;
                        cmbProgEnrol.SelectedItem = s.ProgramEnrol;
                        textBoxContactno.Text = s.ContactNo;
                        comboBoxGender.SelectedItem = s.Gender;
                        comboBoxStatus.SelectedItem = s.EnrolStatus;
                        buttonSubmit.Visible = false;
                        btnUpdate.Visible = true;
                        btnCancel.Visible = true;
                        btnClear.Visible = false;
                    }
                }
                else if (e.ColumnIndex == 1)
                {
                    string message = "Do you want to Delete this Record ?";
                    string title = "Delete Confirmation";
                    MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.OK)
                    {
                        try
                        {
                            //get the value of the clicked rows id column
                            string value = GridStudents[2, e.RowIndex].Value.ToString();
                            obj.Delete(int.Parse(value));
                            BindGrid();
                            MessageBox.Show("Record Successfully Deleted", "Message");
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Sorry, This row can not be deleted", "Message");
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Sorry, This row cant be edited", "Message");
            }
        }

        private void BindChart(List<Student> lst)
        {
            if (lst != null)
            {
                var result = lst
                    .GroupBy(l => l.ProgramEnrol)
                    .Select(cl => new
                    {
                        ProgramEnrol = cl.First().ProgramEnrol,
                        Count = cl.Count().ToString()
                    }).ToList();
                DataTable dt = Utility.ConvertToDataTable(result);
                chart1.DataSource = dt;
                chart1.Name = "ProgramEnrol";
                chart1.Series["Students Enrolled"].XValueMember = "ProgramEnrol";
                chart1.Series["Students Enrolled"].YValueMembers = "Count";
                this.chart1.Titles.Remove(this.chart1.Titles.FirstOrDefault());
                this.chart1.Titles.Add("Total Enrolment Chart");
                chart1.Series["Students Enrolled"].IsValueShownAsLabel = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var emailRegex = new Regex("^([\\w\\.\\-]+)@([\\w\\-]+)((\\.(\\w){2,3})+)$");
            try
            {
                Student obj = new Student();
                if (string.IsNullOrEmpty(textBoxFName.Text) || string.IsNullOrEmpty(textBoxLname.Text) || string.IsNullOrEmpty(textBoxAddress.Text) || string.IsNullOrEmpty(textBoxContactno.Text) || string.IsNullOrEmpty(textBoxEmail.Text))
                {
                    MessageBox.Show("Sorry, cannot leave text fields empty.");
                }
                else if (comboBoxGender.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select Gender.", "Error Message");
                }
                else if (comboBoxStatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select Enrol Status", "Error Message");
                }
                else if (cmbProgEnrol.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select Course for enrolment.", "Error Message");
                }
                else if (!emailRegex.IsMatch(textBoxEmail.Text))
                {
                    MessageBox.Show("Invalid Email", "Error Message");
                }
                else if (textBoxContactno.TextLength > 10)
                {
                    MessageBox.Show("Invalid Phone Number", "Error Message");
                }
                else
                {
                    obj.Id = int.Parse(txtId.Text);
                    string FirstName = textBoxFName.Text;
                    string LastName = textBoxLname.Text;
                    obj.Name = FirstName + " " + LastName;
                    obj.Address = textBoxAddress.Text;
                    obj.Email = textBoxEmail.Text;
                    obj.RegDate = dptRegDate.Value;
                    obj.ContactNo = textBoxContactno.Text;
                    obj.ProgramEnrol = cmbProgEnrol.SelectedItem.ToString();
                    obj.Gender = comboBoxGender.SelectedItem.ToString();
                    obj.EnrolStatus = comboBoxStatus.SelectedItem.ToString();
                    obj.Edit(obj);
                    buttonSubmit.Visible = true;
                    btnUpdate.Visible = false;
                    btnCancel.Visible = false;
                    btnClear.Visible = true;
                    MessageBox.Show("Record Updated Successfully", "Message");
                    BindGrid();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Message");
            }
        }
        //Bubble sort in ascending order for Registered Date
        private void btnAscReg_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            DateTime temp;
            List<Student> listStudents = obj.List();
            DateTime[] arrayStudents = new DateTime[listStudents.Count];
            for (int i = 0; i < listStudents.Count; i++)
            {
                var id = listStudents[i].Id;
                var date = listStudents[i].RegDate;
                arrayStudents[i] = date;
            }
            int l = arrayStudents.Length;
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l - 1; j++)
                {
                    if (arrayStudents[j].CompareTo(arrayStudents[j + 1]) > 0)
                    {
                        temp = arrayStudents[j];
                        arrayStudents[j] = arrayStudents[j + 1];
                        arrayStudents[j + 1] = temp;
                    }
                }
            }
            List<Student> listStudents2 = new List<Student>();
            for (int i = 0; i < arrayStudents.Length; i++)
            {
                for (int j = 0; j < listStudents.Count; j++)
                {
                    var id = listStudents[j].Id;
                    var name = listStudents[j].RegDate;
                    if (arrayStudents[i] == name)
                    {
                        listStudents2.Add(listStudents[j]);
                    }
                }
            }
            DataTable dt = Utility.ConvertToDataTable(listStudents2);
            GridStudents.DataSource = dt;
        }
        //Bubble sort in descending order for Registered Date
        private void btnDesReg_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            DateTime temp;
            List<Student> listStudents = obj.List();
            DateTime[] arrayStudents = new DateTime[listStudents.Count];
            for (int i = 0; i < listStudents.Count; i++)
            {
                var id = listStudents[i].Id;
                var date = listStudents[i].RegDate;
                arrayStudents[i] = date;
            }
            int l = arrayStudents.Length;
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l - 1; j++)
                {
                    if (arrayStudents[j].CompareTo(arrayStudents[j + 1]) < 0)
                    {
                        temp = arrayStudents[j];
                        arrayStudents[j] = arrayStudents[j + 1];
                        arrayStudents[j + 1] = temp;
                    }
                }
            }
            List<Student> listStudents2 = new List<Student>();
            for (int i = 0; i < arrayStudents.Length; i++)
            {
                for (int j = 0; j < listStudents.Count; j++)
                {
                    var id = listStudents[j].Id;
                    var name = listStudents[j].RegDate;
                    if (arrayStudents[i] == name)
                    {
                        listStudents2.Add(listStudents[j]);
                    }
                }
            }
            DataTable dt = Utility.ConvertToDataTable(listStudents2);
            GridStudents.DataSource = dt;
        }
        //Bubble sort in ascending order for Name
        private void btnAscName_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            String temp;
            List<Student> listStudents = obj.List();
            string[] arrayStudents = new string[listStudents.Count];
            for (int i = 0; i < listStudents.Count; i++)
            {
                var id = listStudents[i].Id;
                var name = listStudents[i].Name.Split(' ')[0];
                arrayStudents[i] = name;
            }
            int l = arrayStudents.Length;

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l - 1; j++)
                {
                    int a = 0;
                    if (arrayStudents[j][a].CompareTo(arrayStudents[j + 1][a]) > 0)
                    {
                        temp = arrayStudents[j];
                        arrayStudents[j] = arrayStudents[j + 1];
                        arrayStudents[j + 1] = temp;
                    }
                    else if (arrayStudents[j][0] == arrayStudents[j + 1][0])
                    {
                        if (arrayStudents[j][1].CompareTo(arrayStudents[j + 1][1]) > 0)
                        {
                            temp = arrayStudents[j];
                            arrayStudents[j] = arrayStudents[j + 1];
                            arrayStudents[j + 1] = temp;
                        }
                    }
                }
                List<Student> listStudents2 = new List<Student>();
                for (int a = 0; a < arrayStudents.Length; a++)
                {
                    for (int b = 0; b < listStudents.Count; b++)
                    {
                        var id = listStudents[b].Id;
                        var name = listStudents[b].Name.Split(' ')[0];
                        Console.WriteLine(listStudents[b].Id);
                        if (arrayStudents[a] == name)
                        {
                            listStudents2.Add(listStudents[b]);
                        }
                    }
                }
                DataTable dt = Utility.ConvertToDataTable(listStudents2);
                GridStudents.DataSource = dt;
            }
        }

        //Bubble sort in descending order for Name
        private void btnDesName_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            String temp;
            List<Student> listStudents = obj.List();
            string[] arrayStudents = new string[listStudents.Count];
            for (int i = 0; i < listStudents.Count; i++)
            {
                var id = listStudents[i].Id;
                var name = listStudents[i].Name.Split(' ')[0];
                arrayStudents[i] = name;
            }
            int l = arrayStudents.Length;

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l - 1; j++)
                {
                    int a = 0;
                    if (arrayStudents[j][a].CompareTo(arrayStudents[j + 1][a]) < 0)
                    {
                        temp = arrayStudents[j];
                        arrayStudents[j] = arrayStudents[j + 1];
                        arrayStudents[j + 1] = temp;
                    }
                    else if (arrayStudents[j][0] == arrayStudents[j + 1][0])
                    {
                        if (arrayStudents[j][1].CompareTo(arrayStudents[j + 1][1]) < 0)
                        {
                            temp = arrayStudents[j];
                            arrayStudents[j] = arrayStudents[j + 1];
                            arrayStudents[j + 1] = temp;
                        }
                    }
                }
                List<Student> listStudents2 = new List<Student>();
                for (int a = 0; a < arrayStudents.Length; a++)
                {
                    for (int b = 0; b < listStudents.Count; b++)
                    {
                        var id = listStudents[b].Id;
                        var name = listStudents[b].Name.Split(' ')[0];
                        Console.WriteLine(listStudents[b].Id);
                        if (arrayStudents[a] == name)
                        {
                            listStudents2.Add(listStudents[b]);
                        }
                    }
                }
                DataTable dt = Utility.ConvertToDataTable(listStudents2);
                GridStudents.DataSource = dt;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();

        }

        //Checks each key press and accepts only numeric values in Contactno
        private void textBoxContactno_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }
        //Checks each key press and accepts only alphabet in First Name
        private void textBoxFName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }
        //Checks each key press and accepts only alphabet in Last Name
        private void textBoxLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        //To generate weekly report of student registered.
        private void WeeklyReport()
        {
            DateTime start = dptWeeklyReport.Value.Date;
            DateTime end = start.AddDays(6);
            lblSD.Text = start.ToString("dd MMMM yyyy");
            lblED.Text = end.ToString("dd MMMM yyyy");
            Student obj = new Student();
            List<Student> listStudents = obj.List();
            try
            {
                var weeklyEnrolled = listStudents
                    .Where(a => a.RegDate >= start && a.RegDate <= end)
                    .GroupBy(l => l.ProgramEnrol)
                    .Select(c1 => new
                    {
                        Program = c1.First().ProgramEnrol,
                        Count = c1.Count().ToString()
                    }).ToList();
                DataTable dt = Utility.ConvertToDataTable(weeklyEnrolled);
                dataGridViewWeeklyReport.DataSource = dt;
                dataGridViewWeeklyReport.Columns[0].Width = 178;
                dataGridViewWeeklyReport.Columns[1].Width = 178;
            }
            catch (Exception)
            {
                MessageBox.Show("No Data to view");
            }

        }
        private void btnReport_Click(object sender, EventArgs e)
        {
            WeeklyReport();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            Student obj = new Student();
            List<Student> listStudents = obj.List();
            DataTable dt = Utility.ConvertToDataTable(listStudents);
            GridStudents.DataSource = dt;
            BindChart(listStudents);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            buttonSubmit.Visible = true;
            btnUpdate.Visible = false;
            btnCancel.Visible = false;
            btnClear.Visible = true;
        }


    }
}
