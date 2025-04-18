using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizza_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float GetWhereToEatPrice()
        {
            if (rbEatIn.Checked)
                return Convert.ToSingle(rbEatIn.Tag);

            else if (rbTakeOut.Checked)
                return Convert.ToSingle(rbTakeOut.Tag);

            else
                return 0;
        }

        float GetSelectedCrustTypePrice()
        {
            if (rbThinCrust.Checked)
                return Convert.ToSingle(rbThinCrust.Tag);

            else if(rbThickCrust.Checked)
                return Convert.ToSingle(rbThickCrust.Tag);

            else
                return 0;
        }

        float CalculateToppingsPrice()
        {
            float ToppingsPrice = 0;

            if (chkExtraCheese.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkExtraCheese.Tag);
            }

            if (chkMushrooms.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkMushrooms.Tag);
            }

            if (chkTomatos.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkTomatos.Tag);
            }

            if (chkOnion.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkOnion.Tag);
            }

            if (chkOlives.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkOlives.Tag);
            }

            if (chkGreenPapers.Checked)
            {
                ToppingsPrice += Convert.ToSingle(chkGreenPapers.Tag);
            }

            return ToppingsPrice;
        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            string Toppings = "";

            if(chkExtraCheese.Checked)
            {
                Toppings += ", Extra Cheese";
            }

            if (chkMushrooms.Checked)
            {
                Toppings += ", Mushrooms";
            }

            if (chkTomatos.Checked)
            {
                Toppings += ", Tomatos";
            }

            if (chkOnion.Checked)
            {
                Toppings += ", Onion";
            }


            if (chkOlives.Checked)
            {
                Toppings += ", Olivse";
            }


            if (chkGreenPapers.Checked)
            {
                Toppings += ", GreenPapers";
            }

            if(Toppings.StartsWith(","))
            {
                Toppings = Toppings.Substring(1, Toppings.Length - 1).Trim();
            }

            if (Toppings == "")
                lblToppings.Text = "No Toppings";

            lblToppings.Text = Toppings;
        }

        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);

            else if (rbMedium.Checked)
                return Convert.ToSingle(rbMedium.Tag);

            else if (rbLarge.Checked)
                return Convert.ToSingle(rbLarge.Tag);

            else
                return 0;
        }

        float CalculateTotalPrice()
        {
            return (GetSelectedSizePrice() + CalculateToppingsPrice() + GetSelectedCrustTypePrice() + GetWhereToEatPrice()) * (float)numericUpDown1.Value;
        }

        void UpdateTotalPrice()
        {
            lblPrice.Text = "$" + Convert.ToString(CalculateTotalPrice());
        }

        void UpdateSize()
        {
            UpdateTotalPrice();

            if (rbSmall.Checked)
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
                return;
            }
        }

        void UpdateCrust()
        {
            UpdateTotalPrice();

            if (rbThinCrust.Checked)
                lblCrustType.Text = "Thin Crust";

            if (rbThickCrust.Checked)
                lblCrustType.Text = "Thick Crust";
        }

        void UpdateWhereToEat()
        {
            UpdateTotalPrice();

            if (rbEatIn.Checked)
                lblWhereToEat.Text = "Eat In";

            if (rbTakeOut.Checked)
                lblWhereToEat.Text = "Take Out";
        }


        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void chkExtraCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkTomatos_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chkGreenPapers_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbThinCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThickCrust_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbTakeOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        void Reset()
        {
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbCrustType.Enabled = true;
            gbWhereToEat.Enabled = true;
            btnOrderPizza.Enabled = true;

            rbSmall.Checked = false;
            rbMedium.Checked = false;
            rbLarge.Checked = false;

            rbThinCrust.Checked = false;
            rbThickCrust.Checked = false;

            rbEatIn.Checked = false;
            rbTakeOut.Checked = false;
            label2.Enabled = true;

            chkExtraCheese.Checked = false;
            chkMushrooms.Checked = false;
            chkTomatos.Checked = false;
            chkOnion.Checked = false;
            chkOlives.Checked = false;
            chkGreenPapers.Checked = false;

            numericUpDown1.Enabled = true;

            lblSize.Text = "";
            lblToppings.Text = "";
            lblCrustType.Text = "";
            lblWhereToEat.Text = "";
            numericUpDown1.Value = 1;

            UpdateTotalPrice();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblPrice.Text == "$0")
            {
                MessageBox.Show("Your Order is Empty!", "Empty Order", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Do You Want To Confirm Your order?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Your Order Has Been Ordered Successfully!", "Confirm");

                label2.Enabled = false;
                gbSize.Enabled = false;
                gbToppings.Enabled = false;
                gbCrustType.Enabled = false;
                gbWhereToEat.Enabled = false;
                btnOrderPizza.Enabled = false;
                numericUpDown1.Enabled = false;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalPrice();
        }
    }
}
