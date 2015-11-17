using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch10_2ProcessLunchOrders
{
    public partial class Form1 : Form
    {
        //basic variables to store the text and value amounts.
        string currentSelectionText;
        decimal currentSelectionSubTotal;
        
        public Form1()
        {
            InitializeComponent();
        }


        #region Buttons
        private void chkHamburger_CheckedChanged(object sender, EventArgs e)
        {
            //when this is checked it will make the addons selectable
            ToggleCheckOptions(chkHamburger, chkAddOnHam1, chkAddOnHam2, chkAddOnHam3);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            //when this is checked it will make the addons selectable
            ToggleCheckOptions(chkPizza, chkAddOnPiz1, chkAddOnPiz2, chkAddOnPiz3); 
        }

        private void chkSalad_CheckedChanged(object sender, EventArgs e)
        {
            //when this is checked it will make the addons selectable
            ToggleCheckOptions(chkSalad, chkAddOnSal1, chkAddOnSal2, chkAddOnSal3); 
        }
        #endregion

        #region Methods

        private void ToggleCheckOptions(CheckBox Item, CheckBox Addon1, CheckBox Addon2, CheckBox Addon3)
        {
            //this is going to handle checking if the checkboxes are checked then setting them to uncheck.
            Addon1.Enabled = Item.Checked;
            Addon2.Enabled = Item.Checked;
            Addon3.Enabled = Item.Checked;

            //if the item is not checked then unselect the item
            if (Item.Checked == false)
            {
                Addon1.Checked = false;
                Addon2.Checked = false;
                Addon3.Checked = false;
            }
        }

        private void CalculateSelectionSubTotal()
        {
            //Set the variables to a blank string or 0.  This is used to control the information.
            //We'll tack on to the string and total as we go with +=
            currentSelectionSubTotal = 0;
            currentSelectionText = "";

            if (chkHamburger.Checked)
            {
                currentSelectionText += "Hamburger ";
                currentSelectionSubTotal += 6.50M;
                if (chkAddOnHam1.Checked)
                {
                    currentSelectionText += "with lettuce, tomato, and onions.";
                    currentSelectionSubTotal += .75M;
                }
                if (chkAddOnHam2.Checked)
                {
                    currentSelectionText += "topped with Mayonnaise and mustard.";
                    currentSelectionSubTotal += .75M;
                }
                if (chkAddOnHam3.Checked)
                {
                    currentSelectionText += "And Fries!";
                    currentSelectionSubTotal += .75M;
                }
            }
        }

        #endregion
    }
}
