using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringEqualityLeoK
{
    public partial class frmStringEqualityLeoK : Form
    {
        public frmStringEqualityLeoK()
        {
            InitializeComponent();
        }

        private bool StringsAreEqual(string stringOne, string stringTwo)
        {
            //variable
            bool bothEqual;

            //make both the string uppercase
            stringOne = stringOne.ToUpper();
            stringTwo = stringTwo.ToUpper();
            
            //check to see if the strings are equal
            if (stringOne == stringTwo)
            {
                bothEqual = true;
            }
            else
            {
                bothEqual = false;
            }

            return bothEqual;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //variables
            string userStringOne;
            string userStringTwo;
            bool isEqual;

            //set the strings to the variables
            userStringOne = txtStringOne.Text;
            userStringTwo = txtStringTwo.Text;

            //call the function that compares the two strings
            isEqual = StringsAreEqual(userStringOne, userStringTwo);

            if (isEqual == true)
            {
                lblAnswer.Text = "The strings are equal.";
            }
            else
            {
                lblAnswer.Text = "The strings are NOT equal.";
            }
        }
    }
}
