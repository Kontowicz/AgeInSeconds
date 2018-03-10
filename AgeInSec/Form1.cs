using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeInSec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      

        private void date_enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                DateTime date = dateTimePicker1.Value.Date;
                DateTime now = DateTime.Now;
                TimeSpan a = now - date;
                if (a.TotalSeconds < 0)
                {

                    string message = "Somethig gone wrong, do you want try again";
                    string caption = "Nobody can be born in future.";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result;

                    result = MessageBox.Show(message, caption, buttons);

                    if (result == System.Windows.Forms.DialogResult.No)
                    {
                        // Closes the parent form.
                        this.Close();
                    }
                    if (result == System.Windows.Forms.DialogResult.Yes)
                    {
                        seconds_textBox.Text = "";
                    }
                }
                else
                {
                    seconds_textBox.Text = Math.Round(a.TotalSeconds, 0).ToString();
                }
            }
        }
    }
}
