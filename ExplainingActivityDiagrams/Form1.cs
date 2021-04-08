using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExplainingActivityDiagrams
{
    public partial class Form1 : Form
    {
        Incident incident;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            // This is where the resource allocation algorithm executes
            OpenIncident();
            // Fork

            if (incident.IncidentPriority == IncidentPriority.low)
                AllocateResources();
            else if (incident.IncidentPriority == IncidentPriority.high_fire)
            {
                NotifyFireChief();
                AllocateResources();
            }   
            else if (incident.IncidentPriority == IncidentPriority.high_no_fire)
            {
                NotifyPolicChief();
                AllocateResources();
            }

            // Join
            ArchiveIncident();

        }

        private void OpenIncident()
        {
            incident = new Incident();
            incident.IncidentId = 1;
            incident.IncidentDesc = textBox1.Text;

            if (comboBox1.SelectedIndex == 0)
            {
                incident.IncidentPriority = IncidentPriority.low;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                incident.IncidentPriority = IncidentPriority.high_fire;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                incident.IncidentPriority = IncidentPriority.high_no_fire;
            }
        }

        private void NotifyPolicChief()
        {
            MessageBox.Show("Notify Police Chief");
        }

        private void NotifyFireChief()
        {
            MessageBox.Show("Notify Fire Chief");
        }

        private void AllocateResources()
        {
            MessageBox.Show("Allocate Resources");
        }

        private void ArchiveIncident()
        {
        }
    }
}
