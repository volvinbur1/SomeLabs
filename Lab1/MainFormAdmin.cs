using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Lab1
{
    public partial class MainFormAdmin : Form
    {
        private LoginForm loginForm;
        public MainFormAdmin(object obj)
        {
            InitializeComponent();
            loginForm = (LoginForm) obj;
        }

        private void Add_button_Click(object sender, EventArgs e)
        {
            if (RaceNumber_textBox.Text != "" && AirplaneType_textBox.Text != "" &&
                TravelDirection_textBox.Text != "" && DepaturePeriod_textBox.Text != "")
            {
                loginForm.Timetable.Add(new Airplane(RaceNumber_textBox.Text, AirplaneType_textBox.Text,
                    TravelDirection_textBox.Text, DepaturePeriod_textBox.Text));
                PrintTimetable();

                RaceNumber_textBox.Clear();
                AirplaneType_textBox.Clear();
                TravelDirection_textBox.Clear();
                DepaturePeriod_textBox.Clear();
            }
            else
            {
                MessageBox.Show(@"Some fields are empty.");
            }
        }

        private void MainFormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!loginForm.Visible)
                loginForm.Dispose();
        }

        private void PrintTimetable()
        {
            AirplaneTimetable_dataGridView.DataSource = (from t in loginForm.Timetable
                select new
                {
                    raceNumber = t.RaceNumber, aircraftType = t.AircraftType, travelDirection = t.TravelDirection,
                    depaturePeriod = t.DepaturePeriod
                }).ToList();

            AirplaneTimetable_dataGridView.Columns["raceNumber"].HeaderText = @"Race number";
            AirplaneTimetable_dataGridView.Columns["aircraftType"].HeaderText = @"Aircraft type";
            AirplaneTimetable_dataGridView.Columns["travelDirection"].HeaderText = @"Travel direction";
            AirplaneTimetable_dataGridView.Columns["depaturePeriod"].HeaderText = @"Depature period";

            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                Name = "remove_column",
                Text = "remove",
                UseColumnTextForButtonValue = true
            };

            if (AirplaneTimetable_dataGridView.Columns["remove_column"] == null)
                AirplaneTimetable_dataGridView.Columns.Add(buttonColumn);

            AirplaneTimetable_dataGridView.Columns["remove_column"].HeaderText = @"Remove";

            AirplaneTimetable_dataGridView.AutoResizeColumns();
        }

        private void MainFormAdmin_Load(object sender, EventArgs e)
        {
            PrintTimetable();
        }

        private void Back_button_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            Close();
        }

        private void AirplaneTimetable_dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (AirplaneTimetable_dataGridView.Columns["remove_column"] != null &&
                e.ColumnIndex == AirplaneTimetable_dataGridView.Columns["remove_column"].Index && e.RowIndex >= 0)
            {
                loginForm.Timetable.RemoveAt(e.RowIndex);
                PrintTimetable();
            }
        }

        private int columnIndex, rowIndex;
        public string NewValue;

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (columnIndex >= 0 && columnIndex <= 3 && rowIndex >= 0 && rowIndex <= AirplaneTimetable_dataGridView.RowCount - 1)
            {
                CustomDialog cd = new CustomDialog(this,
                    AirplaneTimetable_dataGridView.Rows[rowIndex].Cells[columnIndex].Value.ToString());
                cd.ShowDialog();

                if (cd.DialogResult.Equals(DialogResult.OK))
                {
                    Airplane airplane = loginForm.Timetable[rowIndex];

                    switch (columnIndex)
                    {
                        case 0:
                            airplane.RaceNumber = NewValue;
                            break;
                        case 1:
                            airplane.AircraftType = NewValue;
                            break;
                        case 2:
                            airplane.TravelDirection = NewValue;
                            break;
                        case 3:
                            airplane.DepaturePeriod = NewValue;
                            break;
                    }

                    loginForm.Timetable[rowIndex] = airplane;

                    PrintTimetable();
                }
            }
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            SearchForm form = new SearchForm(loginForm);
            form.Show();
        }

        private void AirplaneTimetable_dataGridView_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Edit_contextMenuStrip.Show(AirplaneTimetable_dataGridView, new Point(e.X, e.Y));
                columnIndex = AirplaneTimetable_dataGridView.HitTest(e.X, e.Y).ColumnIndex;
                rowIndex = AirplaneTimetable_dataGridView.HitTest(e.X, e.Y).RowIndex;
            }
        }
    }
}
