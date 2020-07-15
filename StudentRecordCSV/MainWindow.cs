using StudentDataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace StudentRecordCSV
{
    public partial class MainWindow : Form
    {
        BindingList<Student> students;
        public MainWindow()
        {
            InitializeComponent();
            students = new BindingList<Student>(StudentIO.LoadStudents());
            ShowData();
            idText.Text = StudentIO.NextId().ToString();
            editStudentButton.Enabled = false;
        }

        private void ShowData()
        {
            studentsListBox.DataSource = students;
            studentsListBox.DisplayMember = "Name";
        }

        private void loadStudentsButton_Click(object sender, EventArgs e)
        {
            handleLoadButtonClick();
        }

        private void handleLoadButtonClick()
        {
            toggleStudentDetailsEdit(false);
            List<Student> loadedStudents = StudentIO.LoadStudents();
            if (studentsListBox.Items.Count != loadedStudents.Count)
            {
                students = new BindingList<Student>(loadedStudents);
                ShowData();
            }
            idText.Text = StudentIO.NextId().ToString();


        }

        private void saveStudentButton_Click(object sender, EventArgs e)
        {
            toggleStudentDetailsEdit(false);
            updateStudentDetails(studentsListBox.SelectedIndex);
            int _id = StudentIO.NextId();
            string _name = nameText.Text;
            string _class = classText.Text;
            string _section = sectionText.Text;
            string _contact = contactText.Text;
            string _address = addressText.Text;

            if (IsValid(_name) && IsValid(_class) && IsValid(_section) && IsValid(_contact) && IsValid(_address))
            {
                Student student = new Student(_id, _name, _class, _section, _contact, _address);
                StudentIO.SaveStudent(student);
                students.Add(student);
                idText.Text = StudentIO.NextId().ToString();

            }
            else
            {
                MessageBox.Show(text: "Please enter all the details!", caption: "Invalid Input Error!", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
            studentsListBox.SelectedIndex = studentsListBox.Items.Count - 1;

        }

        private void studentsListBox_DoubleClick(object sender, EventArgs e)
        {
            handleStudentDelete();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            toggleStudentDetailsEdit(false);
            nameText.Clear();
            classText.Clear();
            sectionText.Clear();
            contactText.Clear();
            addressText.Clear();
            nameText.Focus();
        }

        private bool IsValid(string text)
        {
            return text.Trim().Length > 0;
        }

        private void exportStudentsButton_Click(object sender, EventArgs e)
        {
            toggleStudentDetailsEdit(false);
            string path;
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "CSV (*.csv)|*.csv";
            dialog.Title = "Export Students as CSV";
            dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                path = dialog.FileName;
                if (StudentIO.ExportStudents(path))
                {
                    MessageBox.Show("Students exported successfully!", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("There was a problem completing the request. Please make sure there are students to export and then try again or contact system administrator!", "Could not complete request!", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void studentsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = studentsListBox.SelectedIndex;
            if (index != -1)
            {
                updateStudentDetails(index);
                deleteStudentButton.Enabled = true;
                editStudentButton.Enabled = true;
            }
            else
            {
                deleteStudentButton.Enabled = false;
                editStudentButton.Enabled = false;
            }
            toggleStudentDetailsEdit(false);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            handleStudentDelete();

        }

        private void handleStudentDelete()
        {
            int index = studentsListBox.SelectedIndex;
            if (index < students.Count && index != -1)
            {
                bool isLastIndex = index == studentsListBox.Items.Count - 1;
                students.RemoveAt(index);
                StudentIO.RemoveStudent(index);
                if (isLastIndex)
                {
                    index = index - 1;
                }
            }
            if (studentsListBox.SelectedIndex != -1)
            {
                studentsListBox.SelectedIndex = index;
                updateStudentDetails(index);
                toggleStudentDetailsEdit(false);
            }
            else
            {
                idDisplayText.Clear();
                nameDisplayText.Clear();
                classDisplayText.Clear();
                sectionDisplayText.Clear();
                contactDisplayText.Clear();
                addressDisplayText.Clear();
                editStudentButton.Enabled = false;
            }
            idText.Text = StudentIO.NextId().ToString();
        }

        private void updateStudentDetails(int index)
        {
            if (index == -1)
            {
                deleteStudentButton.Enabled = false;
                editStudentButton.Enabled = false;
                return;
            }
            Student student = students.ElementAt(index);
            idDisplayText.Text = student.Id.ToString();
            nameDisplayText.Text = student.Name;
            classDisplayText.Text = student.Class;
            sectionDisplayText.Text = student.Section;
            contactDisplayText.Text = student.Contact;
            addressDisplayText.Text = student.Address;
        }

        private void editStudentButton_Click(object sender, EventArgs e)
        {
            toggleStudentDetailsEdit(true);
        }

        private void toggleStudentDetailsEdit(bool set)
        {
            nameDisplayText.Enabled = set;
            classDisplayText.Enabled = set;
            sectionDisplayText.Enabled = set;
            contactDisplayText.Enabled = set;
            addressDisplayText.Enabled = set;
            if (students.Count == 0)
                editStudentButton.Enabled = set;
            else
                editStudentButton.Enabled = !set;

            updateStudentButton.Enabled = set;
        }

        private void updateStudentButton_Click(object sender, EventArgs e)
        {
            toggleStudentDetailsEdit(false);
            if (!isStudentDetailChanged())
            {
                return;
            }
            int _id = int.Parse(idDisplayText.Text);
            string _name = nameDisplayText.Text;
            string _class = classDisplayText.Text;
            string _section = sectionDisplayText.Text;
            string _contact = contactDisplayText.Text;
            string _address = addressDisplayText.Text;

            StudentIO.UpdateStudent(studentsListBox.SelectedIndex, new Student(_id, _name, _class, _section, _contact, _address));
        }

        private bool isStudentDetailChanged()
        {
            Student student = students.ElementAt(studentsListBox.SelectedIndex);
            string _name = nameDisplayText.Text;
            string _class = classDisplayText.Text;
            string _section = sectionDisplayText.Text;
            string _contact = contactDisplayText.Text;
            string _address = addressDisplayText.Text;

            if (
                student.Name == _name &&
                student.Class == _class &&
                student.Section == _section &&
                student.Contact == _contact &&
                student.Address == _address
                )
            {
                return false;
            }
            return true;
        }
    }
}
