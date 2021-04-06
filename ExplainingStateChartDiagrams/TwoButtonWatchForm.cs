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
    public partial class TwoButtonWatchForm : Form
    {
        public TwoButtonWatchForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox3.Text) + 1).ToString();
        }

        private void TwoButtonWatchForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = "10";
            textBox2.Text = "40";
            textBox3.Text = "1";
        }
    }
}
