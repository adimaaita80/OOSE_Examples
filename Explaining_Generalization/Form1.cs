using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Explaining_Generalization
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Student student = new Student();
            student.Id = 1;
            student.Name = "Ahmad";
            student.DateOfBirth = DateTime.Now;

            Employee employee = new Employee();
            employee.Id = 1;
            employee.Name = "Ahmad";
            employee.DateOfBirth = DateTime.Now;

            Person person = employee;

            textBox1.Text = person.Information();
        

        }
    }
}
