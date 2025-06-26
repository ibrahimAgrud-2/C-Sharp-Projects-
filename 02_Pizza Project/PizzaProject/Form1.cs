using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizzaProject_T
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            orderSummary();
        }

        void updateSize()
        {
            updateTotalPrice();

            if (rbSamll.Checked)
            {
                lblSize.Text = "Small";
                return;
            }
            if (rbMedium.Checked)
            {

                lblSize.Text = "Medium";
                return;
            }
            if (rbLarge.Checked)
            {
                lblSize.Text = "Large";
            }

        }  
        
        float getSelectedSizePrice()
        {
            if (rbSamll.Checked)
            {
                return Convert.ToSingle(rbSamll.Tag);
            }
            if (rbMedium.Checked)
            {

                return Convert.ToSingle(rbMedium.Tag);
            }
            if (rbLarge.Checked)
            {
                return Convert.ToSingle(rbLarge.Tag);
            }
            return 0;
        }
         void updateCrust()
        {
            updateTotalPrice();

            if (rbThickCrust.Checked)
            {
                lblCrustType.Text = "Thick Crust";
                return;
            }
            lblCrustType.Text = "Thin Crust";
            return;

        }

      

        float getSelectedCrustPrice()
        {
            if (rbThickCrust.Checked)
            {
                return Convert.ToSingle(rbThickCrust.Tag);
            }
            if (rbThinCrust.Checked)
            {

                return Convert.ToSingle(rbThinCrust.Tag);
            }
            return 0;
        }

        float getTotalPrice()
        {
            return getSelectedSizePrice() + getSelectedCrustPrice()+ getSelectedToppingPrice();
        }

        void updateTotalPrice()
        {
            lblTotalPrice.Text = "$" + getTotalPrice();
        }

        private void rbSamll_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
           updateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            updateSize();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            updateCrust();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            updateCrust();
        }

        void updateToppings()
        {
            updateTotalPrice();

            string toppings = "";

            if (chkExtraChees.Checked)
            {
                toppings = "Extra Chees";
            }
            if (chkGreenPeppers.Checked)
            {
                toppings += ", Green pepper";
            }
            if (chkMushrooms.Checked)
            {
                toppings += ", Mashroom";
            }
            if (chkOlives.Checked)
            {
                toppings += ", Olives";
            }
            if (chkOnion.Checked)
            {
                toppings += ", Onion";
            }
            if (chkTomatos.Checked)
            {
                toppings += ", Tomatos";
            }
            if (toppings.StartsWith(","))
            {
                toppings = toppings.Substring(1, toppings.Length - 1).Trim();
            }
            if (toppings=="")
            {
                toppings = "No Toppings";
            }

                lblToppings.Text = toppings;
            
            

        }
         float getSelectedToppingPrice()
        {

            float totalPrice=0;
            
            if (chkExtraChees.Checked)
            {
                totalPrice += Convert.ToSingle(chkExtraChees.Tag);
            }
            if (chkGreenPeppers.Checked)
            {
                totalPrice +=Convert.ToSingle(chkGreenPeppers.Tag);
            }
            if (chkMushrooms.Checked)
            {
                totalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }
            if (chkOlives.Checked)
            {
                totalPrice += Convert.ToSingle(chkOlives.Tag);
            }
            if (chkOnion.Checked)
            {
                totalPrice += Convert.ToSingle(chkOnion.Tag);
            }
            if (chkTomatos.Checked)
            {
                totalPrice += Convert.ToSingle(chkTomatos.Tag);
            }

            return totalPrice;
        }

        private void chkExtraChees_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chkTomatos_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            updateToppings();
        }


        void updateWhereToEate()
        {
            updateTotalPrice();

            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eate In";
                return;
            }
                 lblWhereToEat.Text = "Take Out";
                return;
            
        

        }



        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            updateWhereToEate();

        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            updateWhereToEate();
        }

        private void btnResetForm_Click(object sender, EventArgs e)
        {

            resetForm();

        }

        void resetForm()
        {

            btnResetForm.Enabled = true;
            gbSize.Enabled = true;
            gbCrustType.Enabled = true;
            gbToppings.Enabled = true;
            gbWhereToEat.Enabled = true;


            rbMedium.Checked= true;
            rbThinCrust.Checked= true;
            rbEatIn.Checked= true;


            chkTomatos.Checked = false;
            chkOnion.Checked = false;
            chkOlives.Checked = false;
            chkMushrooms.Checked = false;
            chkGreenPeppers.Checked = false;
            chkExtraChees.Checked = false;
        }

        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                MessageBox.Show("Ordered successfuly", "information", MessageBoxButtons.OK,MessageBoxIcon.Information);
            
                btnResetForm.Enabled = false;
                gbSize.Enabled = false;
                gbCrustType.Enabled = false;
                gbToppings.Enabled = false;
                gbWhereToEat.Enabled = false;   
            
            }
            else
            {
                MessageBox.Show("Update your order", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
           
            }
        }


        void orderSummary()
        {
            updateSize();
            updateCrust();
            updateToppings();
            updateWhereToEate();
            updateTotalPrice();
         }

    }



}
