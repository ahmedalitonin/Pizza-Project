using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project_Cource_14
{
    public partial class PizzaCander : Form
    {
        public PizzaCander()
        {
            InitializeComponent();
        }
       
        void UpdateSize()
        {
            UpdateTotalPrice();
            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }
            if (rbMedum.Checked)
            {
                lblSize.Text = "Medum";
                return;
            }
            if (rbLarg.Checked)
            {
                lblSize.Text = "Large";
                return;
            }

        }
        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void PizzaCander_Load(object sender, EventArgs e)
        {
             UpdateOrderSummary();
        }

 
        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);

            else if (rbMedum.Checked)
                return Convert.ToSingle(rbMedum.Tag);

            else if (rbLarg.Checked)
                return Convert.ToSingle(rbLarg.Tag);
            else
                return 0;
        }
        float CalculateToppingsPrice()
        {
            float ToppingsTotalPrice = 0;
            
            if(chkExtraChesse.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkExtraChesse.Tag);
            }

            if (chkOnian.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOnian.Tag);
            }

            if (chkMushrooms.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkOlives.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkTomatos.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkTomatos.Tag);
            }

            if (chkGreenPeppers.Checked)
            {
                ToppingsTotalPrice += Convert.ToSingle(chkGreenPeppers.Tag);
            }

            return ToppingsTotalPrice;
        }
        float GetSelectedCrustPrice()
        {
            if (rbThin.Checked)
                return Convert.ToSingle(rbThin.Tag);
            else
                return Convert.ToSingle(rbThick.Tag);
        }
        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrustPrice();
        }

        void UpdateTotalPrice()
        {
            lblTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }
        

        void UpdateCrust()
        {
            UpdateTotalPrice();
            if(rbThin.Checked)
            {
                lblCrustType.Text = "Thin Crust";
                return;
            }

            if (rbThick.Checked)
            {
                lblCrustType.Text = "Thick Crust";
                return;
            }
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();
            string sToppings = "";

            if(chkExtraChesse.Checked)
            {
                sToppings += "Extra Chees";

            }

            if (chkOnian.Checked)
            {
                sToppings += ", Onion";
            }

            if (chkMushrooms.Checked)
            {
                sToppings += ", Mushrooms";
            }
            if (chkOlives.Checked)
            {
                sToppings += ", Olives";
            }
            if (chkTomatos.Checked)
            {
                sToppings += ", Tomatos";
            }
            if (chkGreenPeppers.Checked)
            {
                sToppings += ", Green Peppers";
            }
            if(sToppings.StartsWith(","))
            {
                sToppings= sToppings.Substring(1,sToppings.Length - 1).Trim();
            }

            if (sToppings == "")
                sToppings = "No Toppings";

            TxToppings.Text = sToppings;

        }

        void UpdateWhereToEat()
        {
            if (rbEatIn.Checked)
            {
                lblWhereToEat.Text = "Eat In";
                return;
            }
            else
                lblWhereToEat.Text = "Take Out";
        }

        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }
        void ResetForm()
        {
            btnOrderPizza.Enabled = true;
            gbSize.Enabled = true;
            gbToppingsCheck.Enabled = true;
            gbCrustType.Enabled = true;
            gbWhereToEat.Enabled = true;

            // reset size
            rbMedum.Checked = true;

            // reset Toppings 

            chkExtraChesse.Checked = false;
            chkOnian.Checked = false;
            chkMushrooms.Checked = false;
            chkOlives.Checked = false;
            chkTomatos.Checked = false;
            chkGreenPeppers.Checked = false;

            // reset Crust Type
            rbThin.Checked = true;

            // reset Where to eat
            rbEatIn.Checked = true;

            // reset Order Pizza
            btnOrderPizza.Enabled= true;


        }
        private void btnOrderPizza_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Order","Confirm",
                MessageBoxButtons.OKCancel,MessageBoxIcon.Question)==DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnOrderPizza.Enabled = false;
                gbSize.Enabled = false;
                gbToppingsCheck.Enabled = false;
                gbCrustType.Enabled = false;    
                gbWhereToEat.Enabled = false;
            }
            else
            {

            }
        }

        private void chkGreenPeppers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbMedum_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

       
        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }


        private void chkExtraChesse_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnian_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatos_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        

        private void TxToppings_TextChanged(object sender, EventArgs e)
        {
            UpdateToppings();
            
        }

        private void bnResetForm_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        
    }
}
