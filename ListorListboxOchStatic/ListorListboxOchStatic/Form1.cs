using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListorListboxOchStatic
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student s = new Student("Stefan");
            Student.studentList.Add(s);
            Student.studentList.Add(new Student("Arne"));
            Student.studentList.Add(new Student("Berit"));
            

            Student.addStudent(new Student("Jenna"));

            updateStudentListBox();

            Random myRandom = new Random(12);
            int a = myRandom.Next();


            double aa = Math.PI;

        }

        private void updateStudentListBox()
        {
            listBox1.Items.Clear();
            foreach (Student s in Student.studentList)
            {
                listBox1.Items.Add(s);
                Student.studentList.Add(s);
            }

            
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Student s = listBox1.SelectedItem as Student;
            MessageBox.Show("Du valde " + s._firstname);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Student s = listBox1.SelectedItem as Student;
            Student.studentList.Remove(s);
            updateStudentListBox();
            
        }
    }
}
