using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YumYard.Payment
{
    public partial class CardPayment : Form
    {
        private double totalPrice;
        private int orderId;
        private List<string> orderDetails;

        public bool PaymentSuccessful { get; private set; }

        public CardPayment(double totalPrice, int orderId, List<string> orderDetails)
        {
            InitializeComponent();
            this.totalPrice = totalPrice;
            this.orderId = orderId;
            this.orderDetails = orderDetails;
            PaymentSuccessful = false;

            lblWcardholder.Hide();
            lblWcardNumber.Hide();
            lblWexpdate.Hide();
            lblWcvv.Hide();

        }

        private bool ValidateCardNumber(string cardNumber)
        {
            var regex = new Regex(@"^\d{16}$");
            return regex.IsMatch(cardNumber);
        }

        private bool ValidateExpirationDate(string expirationDate)
        {
            if (DateTime.TryParseExact(expirationDate, "MM/yy", null, System.Globalization.DateTimeStyles.None, out DateTime expDate))
            {
                return expDate > DateTime.Now;
            }
            return false;
        }

        private bool ValidateCVV(string cvv)
        {
            var regex = new Regex(@"^\d{3,4}$");
            return regex.IsMatch(cvv);
        }

        private bool ValidateCardholderName(string cardholderName)
        {
            return !string.IsNullOrWhiteSpace(cardholderName);
        }

        private void ProcessPayment(string cardNumber, string expirationDate, string cvv, string cardholderName)
        {
            if (!ValidateCardholderName(cardholderName))
            {
                lblWcardholder.Text = "Invalid cardholder name.";
                lblWcardholder.Show();
                return;
            }

            if (!ValidateCardNumber(cardNumber))
            {
                lblWcardNumber.Text = "Invalid card number.";
                lblWcardNumber.Show();
                lblWcardholder.Hide();
                return;
            }

            if (!ValidateExpirationDate(expirationDate))
            {
                lblWexpdate.Text = "Invalid expiration date.";
                lblWexpdate.Show();
                lblWcardholder.Hide();
                lblWcardNumber.Hide();
                return;
            }

            if (!ValidateCVV(cvv))
            {
                lblWcvv.Text = "Invalid CVV.";
                lblWcvv.Show();
                lblWcardholder.Hide();
                lblWcardNumber.Hide();
                lblWexpdate.Hide();
                return;
            }

            // Process the payment (this is a placeholder, replace with actual payment processing logic)
            MessageBox.Show("Payment processed successfully.");
            PaymentSuccessful = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            string cardNumber = tbCardNumber.Text;
            string expirationDate = tbExpDate.Text;
            string cvv = tbCVV.Text;
            string cardholderName = tbCardHolder.Text;

            ProcessPayment(cardNumber, expirationDate, cvv, cardholderName);
        }
    }
}