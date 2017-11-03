using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVCable_manager
{
    public partial class edit : Form
    {
        public ServiceReference.tvOffer selectedOffer = null;

        public Boolean editMode = false;

        public mainForm parentForm;

        public edit()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void edit_FormClosing(object sender, EventArgs e)
        {
            selectedOffer = null;
            editMode = false;
            parentForm.reloadGridView();
 
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
        
            if(editMode)
            {
                try
                {

                    ServiceReference.tvOffer newOffer = new ServiceReference.tvOffer();
                    newOffer.offerName = offerNameTextBox.Text;
                    newOffer.offerDescription = offerDescriptionTextBox.Text;
                    newOffer.offerCurrency = offerCurrencyTextBox.Text.ToUpper();
                    newOffer.offerActivationPrice = Math.Round(double.Parse(offerActivationPriceTextBox.Text, System.Globalization.CultureInfo.InvariantCulture), 2);
                    newOffer.offerMonthlyLength = Convert.ToInt16(offerMonthlyLengthNumericUpDown.Value);
                    newOffer.offerMonthlyPrice = Math.Round(double.Parse(offerMonthlyPriceTextBox.Text, System.Globalization.CultureInfo.InvariantCulture), 2);
                    newOffer.id = selectedOffer.id;
                    bool result = parentForm.service.updateOffer(newOffer);
                    if (result)
                    {
                        MessageBox.Show("Zapisano");
                    }
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Błąd zapisu");
                }
            }
            else
            {
                try
                {
                    ServiceReference.tvOffer newOffer = new ServiceReference.tvOffer();
                    newOffer.offerName = offerNameTextBox.Text;
                    newOffer.offerDescription = offerDescriptionTextBox.Text;
                    newOffer.offerCurrency = offerCurrencyTextBox.Text.ToUpper();
                    newOffer.offerActivationPrice = Math.Round(double.Parse(offerActivationPriceTextBox.Text, System.Globalization.CultureInfo.InvariantCulture),2);
                    newOffer.offerMonthlyLength = Convert.ToInt16(offerMonthlyLengthNumericUpDown.Value);
                    newOffer.offerMonthlyPrice = Math.Round(double.Parse(offerMonthlyPriceTextBox.Text, System.Globalization.CultureInfo.InvariantCulture),2);

                    bool result = parentForm.service.addOffer(newOffer);
                    if(result)
                    {
                        MessageBox.Show("Zapisano");
                    }
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("Błąd zapisu");
                }
            }
        }

        private void edit_Load(object sender, EventArgs e)
        {
            if(selectedOffer != null && editMode)
            {
                offerNameTextBox.Text = selectedOffer.offerName;
                offerDescriptionTextBox.Text = selectedOffer.offerDescription;
                offerCurrencyTextBox.Text = selectedOffer.offerCurrency;
                offerMonthlyLengthNumericUpDown.Value = (decimal)selectedOffer.offerMonthlyLength;
                offerActivationPriceTextBox.Text = selectedOffer.offerActivationPrice.ToString();
                offerMonthlyPriceTextBox.Text = selectedOffer.offerMonthlyPrice.ToString();
            }
        }

        

        private void offerActivationPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        

        private void offerMonthlyPriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
