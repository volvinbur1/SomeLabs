using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class SearchForm : Form
    {
        private LoginForm loginForm;
        public SearchForm(LoginForm form)
        {
            InitializeComponent();

            loginForm = form;
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            List<object> AirplaneTimetableSpech = new List<object>()
            {
                "Race Number",
                "Aircraft Type",
                "TravelDirection",
                "Depature time"
            };

            Timetable_comboBox.Items.AddRange(AirplaneTimetableSpech.ToArray());
            Timetable_comboBox.SelectedIndex = 0;

            SearchResult_dataGridView.Columns.Add("raceNumber", @"Race number");
            SearchResult_dataGridView.Columns.Add("aircraftType", @"Aircraft type");
            SearchResult_dataGridView.Columns.Add("travelDirection", @"Travel direction");
            SearchResult_dataGridView.Columns.Add("depaturePeriod", @"Depature period");
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            if (Search_textBox.Text != "")
            {
                SearchResult_dataGridView.Rows.Clear();
                SearchInfo(Timetable_comboBox.SelectedIndex, Search_textBox.Text);
            }
            else
            {
                MessageBox.Show(@"Enter key word to search by.");
            }
        }

        private void SearchInfo(int comboboxIndex, string searchKeyWord)
        {
            switch (comboboxIndex)
            {
                case 0:
                    foreach (var airplane in loginForm.Timetable)
                    {
                        if (airplane.RaceNumber.Contains(searchKeyWord))
                            SearchResult_dataGridView.Rows.Add(airplane.RaceNumber, airplane.AircraftType,
                                airplane.TravelDirection, airplane.DepaturePeriod);
                    }
                    break;
                case 1:
                    foreach (var airplane in loginForm.Timetable)
                    {
                        if (airplane.AircraftType.Contains(searchKeyWord))
                            SearchResult_dataGridView.Rows.Add(airplane.RaceNumber, airplane.AircraftType,
                                airplane.TravelDirection, airplane.DepaturePeriod);
                    }
                    break;
                case 2:
                    foreach (var airplane in loginForm.Timetable)
                    {
                        if (airplane.TravelDirection.Contains(searchKeyWord))
                            SearchResult_dataGridView.Rows.Add(airplane.RaceNumber, airplane.AircraftType,
                                airplane.TravelDirection, airplane.DepaturePeriod);
                    }
                    break;
                case 3:
                    foreach (var airplane in loginForm.Timetable)
                    {
                        if (airplane.DepaturePeriod.Contains(searchKeyWord))
                            SearchResult_dataGridView.Rows.Add(airplane.RaceNumber, airplane.AircraftType,
                                airplane.TravelDirection, airplane.DepaturePeriod);
                    }
                    break;
            }
        }
    }
}
