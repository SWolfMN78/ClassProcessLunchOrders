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
            CalculateSelectionSubTotal();
        }

        private void chkAddOnHam1_CheckedChanged(object sender, EventArgs e)
        {
            CalculateSelectionSubTotal();
        }

        private void chkAddOnHam2_CheckedChanged(object sender, EventArgs e)
        {
            CalculateSelectionSubTotal();
        }

        private void chkAddOnHam3_CheckedChanged(object sender, EventArgs e)
        {
            CalculateSelectionSubTotal();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            //when this is checked it will make the addons selectable
            ToggleCheckOptions(chkPizza, chkAddOnPiz1, chkAddOnPiz2, chkAddOnPiz3);
            CalculateSelectionSubTotal();
        }

        private void chkAddOnPiz1_CheckedChanged(object sender, EventArgs e)
        {
            CalculateSelectionSubTotal();
        }

        private void chkAddOnPiz2_CheckedChanged(object sender, EventArgs e)
        {
            CalculateSelectionSubTotal();
        }

        private void chkAddOnPiz3_CheckedChanged(object sender, EventArgs e)
        {
            CalculateSelectionSubTotal();
        }

        private void chkSalad_CheckedChanged(object sender, EventArgs e)
        {
            //when this is checked it will make the addons selectable
            ToggleCheckOptions(chkSalad, chkAddOnSal1, chkAddOnSal2, chkAddOnSal3);
            CalculateSelectionSubTotal();
        }

        private void chkAddOnSal1_CheckedChanged(object sender, EventArgs e)
        {
            CalculateSelectionSubTotal();
        }

        private void chkAddOnSal2_CheckedChanged(object sender, EventArgs e)
        {
            CalculateSelectionSubTotal();
        }

        private void chkAddOnSal3_CheckedChanged(object sender, EventArgs e)
        {
            CalculateSelectionSubTotal();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //close form.
            Close();
        }

        private void btnFinalizeOrder_Click(object sender, EventArgs e)
        {
            //display exit info.
            MessageBox.Show("Your order has been placed, please go to the counter for pick up!");
            Close();
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            //reset the entire form.
            ClearSelection();
            lstOrderForm.Items.Clear();
            TotalCalculator.ResetAmount();
            lblTaxAmount.Text = "";
            lblGrandTotal.Text = "";
        }

        private void btnAddToOrder_Click(object sender, EventArgs e)
        {
            //add the information to the listview box for the customer to see their order.
            lstOrderForm.Items.Add(currentSelectionText);
            TotalCalculator.AddAmount(currentSelectionSubTotal);
            lblTaxAmount.Text = TotalCalculator.CalculateTax();
            lblGrandTotal.Text = TotalCalculator.GrandTotal();
            ClearSelection();
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
            //Given the unique nature of the different values entered the information by hand.
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
            
            if (chkPizza.Checked)
            {
                currentSelectionText += "Pizza ";
                currentSelectionSubTotal += 8.50M;
                if (chkAddOnPiz1.Checked)
                {
                    currentSelectionText += "with Pepperoni ";
                    currentSelectionSubTotal += .50M;
                }
                if (chkAddOnPiz2.Checked)
                {
                    currentSelectionText += "with Sausage ";
                    currentSelectionSubTotal += .50M;
                }
                if (chkAddOnPiz3.Checked)
                {
                    currentSelectionText += "and Olives.";
                    currentSelectionSubTotal += .50M;
                }
            }

            if (chkSalad.Checked)
            {
                currentSelectionText += "Salad ";
                currentSelectionSubTotal += 5.75M;
                if (chkAddOnSal1.Checked)
                {
                    currentSelectionText += "with croutons ";
                    currentSelectionSubTotal += .25M;
                }
                if (chkAddOnSal2.Checked)
                {
                    currentSelectionText += "with bacon bits ";
                    currentSelectionSubTotal += .25M;
                }
                if (chkAddOnSal3.Checked)
                {
                    currentSelectionText += "and bread sticks.";
                    currentSelectionSubTotal += .25M;
                }
            }
            //show the running amount.
            lblRunningTotal.Text = currentSelectionSubTotal.ToString("c");
            
        }

        private void ClearSelection()
        {
            chkHamburger.Checked = false;
            chkPizza.Checked = false;
            chkSalad.Checked = false;
        }

        #endregion

    }
}
