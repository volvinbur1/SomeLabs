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
    public partial class CustomDialog : Form
    {
        private MainFormAdmin parentForm;
        private string preValue;
        public CustomDialog(object formObj, string str)
        {
            InitializeComponent();

            parentForm = formObj as MainFormAdmin;
            preValue = str;
        }

        private void Change_button_Click(object sender, EventArgs e)
        {
            parentForm.NewValue = NewValue_textBox.Text;
        }

        private void CustomDialog_Load(object sender, EventArgs e)
        {
            PreValue_textBox.Text = preValue;
        }
    }
}
