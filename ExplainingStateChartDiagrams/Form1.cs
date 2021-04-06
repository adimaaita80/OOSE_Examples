using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExplainingStateChartDiagrams
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OperatingSystemProcess operatingSystemProcess = new OperatingSystemProcess();

            operatingSystemProcess.ProcessId = 1;
            operatingSystemProcess.ProcessName = "PowerPoint Process";
            operatingSystemProcess.ProcessMemory = 128000000;
            operatingSystemProcess.ProcessState = ProcessState.Ready;

            textBox1.Text = operatingSystemProcess.ProcessId.ToString();
            textBox2.Text = operatingSystemProcess.ProcessName;
            textBox3.Text = operatingSystemProcess.ProcessMemory.ToString();
            textBox4.Text = operatingSystemProcess.ProcessState.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
