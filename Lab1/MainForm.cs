using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab1
{
    public partial class MainForm : Form
    {
        private LoginForm loginForm;
        public MainForm(object obj)
        {
            InitializeComponent();
            loginForm = (LoginForm) obj;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            PrintTimetable();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Show();
            //if (!loginForm.Visible)
            //    loginForm.Dispose();
        }

        private void PrintTimetable()
        {
            AirplaneTimetable_dataGridView.DataSource = (from t in loginForm.Timetable
                select new
                {
                    raceNumber = t.RaceNumber,
                    aircraftType = t.AircraftType,
                    travelDirection = t.TravelDirection,
                    depaturePeriod = t.DepaturePeriod
                }).ToList();

            AirplaneTimetable_dataGridView.Columns[0].HeaderText = @"Race number";
            AirplaneTimetable_dataGridView.Columns[1].HeaderText = @"Aircraft type";
            AirplaneTimetable_dataGridView.Columns[2].HeaderText = @"Travel direction";
            AirplaneTimetable_dataGridView.Columns[3].HeaderText = @"Depature period";

            AirplaneTimetable_dataGridView.AutoResizeColumns();
        }
    }
}
