using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        const string TIME1 = "8:30";                            // Variable to hold first time
        const string TIME2 = "10:00";                           // Variable to hold second time
        const string TIME3 = "11:30";                           // Variable to hold third time
        const string TIME4 = "2:00";                            // Variable to hold fourth time
        const string TIME5 = "4:00";                            // Variable to hold fifth time

        const string SENIOR_DATE = "Wednesday, March 29th";     // Variable to hold the first date for seniors
        const string JUNIOR_DATE = "Thursday, March 30th";      // Variable to hold the first date for juniors
        const string SOPHOMORE_DATE_1 = "Friday, March 31st";   // Variable to hold the first possible date for sophomores
        const string SOPHOMORE_DATE_2 = "Monday, April 3rd";    // Variable to hold the second possible date for sophomores
        const string FRESHMAN_DATE_1 = "Tuesday, April 4th";    // Variable to hold the first possible date for freshman
        const string FRESHMAN_DATE_2 = "Wednesday, April 5th";  // Variable to hold the second possible date for freshman

        private void showDateButton_Click(object sender, EventArgs e)
        {
            string lastName = lastNameTextBox.Text;             // Variable to hold the last name
            char lastNameLetter = char.ToLower(lastName[0]);    // Variable to hold the first letter of the last name and changes it to lowercase
 
            // Tests if the lastNameLetter variable is a letter
            if (char.IsLetter(lastNameLetter))
            {
                // Tests whether the senior or junior radio buttons are checked
                if (seniorButton.Checked || juniorButton.Checked)
                {
                    if (seniorButton.Checked)
                    {
                        dateOutputLabel.Text = SENIOR_DATE;
                    }
                    else if (juniorButton.Checked)
                    {
                        dateOutputLabel.Text = JUNIOR_DATE;
                    }
                    if (lastNameLetter <= 'd')
                    {
                        timeOutputLabel.Text = TIME3;
                    }
                    else if (lastNameLetter <= 'i')
                    {
                        timeOutputLabel.Text = TIME4;
                    }
                    else if (lastNameLetter <= 'o')
                    {
                        timeOutputLabel.Text = TIME5;
                    }
                    else if (lastNameLetter <= 's')
                    {
                        timeOutputLabel.Text = TIME1;
                    }
                    else
                    {
                        timeOutputLabel.Text = TIME2;
                    }
                }
                // Tests whether the sophomore or freshman radio buttons are checked
                else if (sophomoreButton.Checked || freshmanButton.Checked)
                    {
                        if (lastNameLetter >= 'p' || lastNameLetter <= 'b')
                        {
                            if (sophomoreButton.Checked)
                            {
                            dateOutputLabel.Text = SOPHOMORE_DATE_1;
                            }   
                            else
                            {
                            dateOutputLabel.Text = FRESHMAN_DATE_1;
                            }
                        }
                        else
                        {
                            if (sophomoreButton.Checked)
                            {
                            dateOutputLabel.Text = SOPHOMORE_DATE_2;
                            }
                            else
                            {
                            dateOutputLabel.Text = FRESHMAN_DATE_2;    
                            }
                        }
                        if (lastNameLetter <= 'b')
                        {
                        timeOutputLabel.Text = TIME5;
                        }
                        else if (lastNameLetter <= 'd')
                        {
                        timeOutputLabel.Text = TIME1;
                        }
                        else if (lastNameLetter <= 'f')
                        {
                        timeOutputLabel.Text = TIME2;
                        }
                        else if (lastNameLetter <= 'i')
                        {
                        timeOutputLabel.Text = TIME3;
                        }
                        else if (lastNameLetter <= 'l')
                        {
                        timeOutputLabel.Text = TIME4;
                         }
                        else if (lastNameLetter <= 'o')
                        {
                        timeOutputLabel.Text = TIME5;
                        }
                        else if (lastNameLetter <= 'q')
                        {
                        timeOutputLabel.Text = TIME1;
                        }
                        else if (lastNameLetter <= 's')
                        {
                        timeOutputLabel.Text = TIME2;
                        }   
                        else if (lastNameLetter <= 'v')
                        {
                        timeOutputLabel.Text = TIME3;
                        }
                        else
                        {
                        timeOutputLabel.Text = TIME4;
                        }
                    }
            }
            // Displays a message if they didn't enter a string in the textBox
            else
            {
                MessageBox.Show("Please enter your last name.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lastNameTextBox.Focus();
        }
    }
}
