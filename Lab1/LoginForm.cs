using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lab1
{
    public partial class LoginForm : Form
    {
        private User[] UserArray;

        internal List<Airplane> Timetable = new List<Airplane>()
        {
            new Airplane("CB485","short", "TALLINN-KYIV", "6h"),
            new Airplane("RT876", "medium", "BERLIN-DUBAI", "14h"),
            new Airplane("HT341", "large", "BOSTON-NEW-YORK", "2h")
        };

        public LoginForm()
        {
            UserArray = new[] {new User("admin", "admin"), new User("dispatcher", "1111") }; 
            InitializeComponent();
        }

        private void Enter_button_Click(object sender, EventArgs e)
        {
            bool correct = false;
            foreach (User user in UserArray)
            {
                if (user.Login == Login_textBox.Text && user.Password == Password_textBox.Text)
                {
                    Hide();
                    if (user.Login == "admin")
                    {
                        MainFormAdmin form = new MainFormAdmin(this);
                        form.Show();
                    }
                    else
                    {
                        MainForm form = new MainForm(this);
                        form.Show();
                    }

                    correct = true;
                    Login_textBox.Clear();
                    Password_textBox.Clear();

                    break;
                }
            }

            if (!correct)
            {
                MessageBox.Show(@"Login and password doesn't match.");
                Password_textBox.Clear();
            }
        }
    }

    internal class User
    {
        public User(string login, string password)
        {
            userLoginName = login;
            userPassword = password;
        }

        private string userLoginName;
        private string userPassword;

        public string Login { get => userLoginName; }
        public string Password { get => userPassword; }
    }
}
