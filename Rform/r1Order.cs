using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using YumYard.DatabaseAccess;
using YumYard.Payment;


namespace YumYard.Rform
{
    public partial class r1Order : Form
    {
        private string uId;
        public string Uid { get; set; }
        private string rId;
        public string Rid { get; set; }

        private string f1;
        private string f2;
        private string f3;
        private string f4;
        private string f5;
        private string f6;
        private double fp1;
        private double fp2;
        private double fp3;
        private double fp4;
        private double fp5;
        private double fp6;

        public r1Order(string uid, string rid)
        {
            InitializeComponent();
            this.Uid = uid;
            this.Rid = rid;
            LoadProductData();
        }

        private void LoadProductData()
        {
            try
            {
                string query = $"SELECT TOP 6 ProductName, ProductPrice FROM RestaurantProducts WHERE RestaurantID = {Rid}";
                string error;
                DataTable productData = DbAccess.GetData(query, out error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Error loading product data: " + error);
                    return;
                }

                if (productData.Rows.Count > 0)
                {
                    if (productData.Rows.Count > 0) { f1 = productData.Rows[0]["ProductName"].ToString(); fp1 = Convert.ToDouble(productData.Rows[0]["ProductPrice"]); }
                    if (productData.Rows.Count > 1) { f2 = productData.Rows[1]["ProductName"].ToString(); fp2 = Convert.ToDouble(productData.Rows[1]["ProductPrice"]); }
                    if (productData.Rows.Count > 2) { f3 = productData.Rows[2]["ProductName"].ToString(); fp3 = Convert.ToDouble(productData.Rows[2]["ProductPrice"]); }
                    if (productData.Rows.Count > 3) { f4 = productData.Rows[3]["ProductName"].ToString(); fp4 = Convert.ToDouble(productData.Rows[3]["ProductPrice"]); }
                    if (productData.Rows.Count > 4) { f5 = productData.Rows[4]["ProductName"].ToString(); fp5 = Convert.ToDouble(productData.Rows[4]["ProductPrice"]); }
                    if (productData.Rows.Count > 5) { f6 = productData.Rows[5]["ProductName"].ToString(); fp6 = Convert.ToDouble(productData.Rows[5]["ProductPrice"]); }

                    cbfood1.Text = f1;
                    cbfood2.Text = f2;
                    cbfood3.Text = f3;
                    cbfood4.Text = f4;
                    cbfood5.Text = f5;
                    cbfood6.Text = f6;
                    tbPrice1.Text = fp1.ToString();
                    tbPrice2.Text = fp2.ToString();
                    tbPrice3.Text = fp3.ToString();
                    tbPrice4.Text = fp4.ToString();
                    tbPrice5.Text = fp5.ToString();
                    tbPrice6.Text = fp6.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading product data: " + ex.Message);
            }
        }

        private void UpdateTotalPrice()
        {
            double totalPrice = 0;

            if (cbfood1.Checked)
            {
                totalPrice += Convert.ToDouble(tbPrice1.Text) * Convert.ToInt32(comboBox1.Text);
            }
            if (cbfood2.Checked)
            {
                totalPrice += Convert.ToDouble(tbPrice2.Text) * Convert.ToInt32(comboBox2.Text);
            }
            if (cbfood3.Checked)
            {
                totalPrice += Convert.ToDouble(tbPrice3.Text) * Convert.ToInt32(comboBox3.Text);
            }
            if (cbfood4.Checked)
            {
                totalPrice += Convert.ToDouble(tbPrice4.Text) * Convert.ToInt32(comboBox4.Text);
            }
            if (cbfood5.Checked)
            {
                totalPrice += Convert.ToDouble(tbPrice5.Text) * Convert.ToInt32(comboBox5.Text);
            }
            if (cbfood6.Checked)
            {
                totalPrice += Convert.ToDouble(tbPrice6.Text) * Convert.ToInt32(comboBox6.Text);
            }

            tbTotal.Text = totalPrice.ToString("F2");
        }

        private void ChkChanged(object sender, EventArgs e)
        {
            if (cbfood1.Checked)
            {
                comboBox1.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
                comboBox1.Text = "1";
            }
            if (cbfood2.Checked)
            {
                comboBox2.Enabled = true;
            }
            else
            {
                comboBox2.Enabled = false;
                comboBox2.Text = "1";
            }
            if (cbfood3.Checked)
            {
                comboBox3.Enabled = true;
            }
            else
            {
                comboBox3.Enabled = false;
                comboBox3.Text = "1";
            }
            if (cbfood4.Checked)
            {
                comboBox4.Enabled = true;
            }
            else
            {
                comboBox4.Enabled = false;
                comboBox4.Text = "1";
            }
            if (cbfood5.Checked)
            {
                comboBox5.Enabled = true;
            }
            else
            {
                comboBox5.Enabled = false;
                comboBox5.Text = "1";
            }
            if (cbfood6.Checked)
            {
                comboBox6.Enabled = true;
            }
            else
            {
                comboBox6.Enabled = false;
                comboBox6.Text = "1";
            }

            UpdateTotalPrice();
        }

        private void cbTextChange(object sender, EventArgs e)
        {
            if (cbfood1.Enabled)
            {
                tbPrice1.Text = (fp1 * Convert.ToInt32(comboBox1.Text)).ToString();
            }
            else
            {
                tbPrice1.Text = fp1.ToString();
            }

            if (cbfood2.Enabled)
            {
                tbPrice2.Text = (fp2 * Convert.ToInt32(comboBox2.Text)).ToString();
            }
            else
            {
                tbPrice2.Text = fp2.ToString();
            }

            if (cbfood3.Enabled)
            {
                tbPrice3.Text = (fp3 * Convert.ToInt32(comboBox3.Text)).ToString();
            }
            else
            {
                tbPrice3.Text = fp3.ToString();
            }

            if (cbfood4.Enabled)
            {
                tbPrice4.Text = (fp4 * Convert.ToInt32(comboBox4.Text)).ToString();
            }
            else
            {
                tbPrice4.Text = fp4.ToString();
            }

            if (cbfood5.Enabled)
            {
                tbPrice5.Text = (fp5 * Convert.ToInt32(comboBox5.Text)).ToString();
            }
            else
            {
                tbPrice5.Text = fp5.ToString();
            }

            if (cbfood6.Enabled)
            {
                tbPrice6.Text = (fp6 * Convert.ToInt32(comboBox6.Text)).ToString();
            }
            else
            {
                tbPrice6.Text = fp6.ToString();
            }

            UpdateTotalPrice();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Check if at least one item is selected
            if (!cbfood1.Checked && !cbfood2.Checked && !cbfood3.Checked && !cbfood4.Checked && !cbfood5.Checked && !cbfood6.Checked)
            {
                MessageBox.Show("Please select at least one item to place an order.");
                return;
            }

            try
            {
                double totalPrice = Convert.ToDouble(tbTotal.Text);

                // Show confirmation dialog with total bill amount
                DialogResult result = MessageBox.Show($"The total bill amount is {totalPrice.ToString("F2")}. Do you want to proceed to payment?", "Confirm Payment", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }

                string orderQuery = $"INSERT INTO [Order] (CustomerID, RestaurantID, TotalPrice, OrderDate) VALUES ('{Uid}', '{Rid}', {totalPrice}, '{DateTime.Now}')";
                string error;
                DbAccess.ExecuteQuery(orderQuery, out error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Error placing order: " + error);
                    return;
                }

                // Get the last inserted OrderID
                string getOrderIdQuery = "SELECT TOP 1 OrderID FROM [Order] ORDER BY OrderID DESC";
                DataTable orderIdData = DbAccess.GetData(getOrderIdQuery, out error);

                if (!string.IsNullOrEmpty(error) || orderIdData.Rows.Count == 0)
                {
                    MessageBox.Show("Error retrieving order ID: " + error);
                    return;
                }

                int orderId = Convert.ToInt32(orderIdData.Rows[0]["OrderID"]);

                // Insert order details
                List<string> orderDetailsQueries = new List<string>();
                List<string> orderDetails = new List<string>();

                if (cbfood1.Checked)
                {
                    orderDetailsQueries.Add($"INSERT INTO OrderDetails (OrderID, ProductID, Quantity, Price) VALUES ({orderId}, (SELECT ProductID FROM RestaurantProducts WHERE ProductName = '{f1}' AND RestaurantID = {Rid}), {comboBox1.Text}, {fp1 * Convert.ToInt32(comboBox1.Text)})");
                    orderDetails.Add($"{f1} - Quantity: {comboBox1.Text}, Price: {fp1 * Convert.ToInt32(comboBox1.Text)}");
                }
                if (cbfood2.Checked)
                {
                    orderDetailsQueries.Add($"INSERT INTO OrderDetails (OrderID, ProductID, Quantity, Price) VALUES ({orderId}, (SELECT ProductID FROM RestaurantProducts WHERE ProductName = '{f2}' AND RestaurantID = {Rid}), {comboBox2.Text}, {fp2 * Convert.ToInt32(comboBox2.Text)})");
                    orderDetails.Add($"{f2} - Quantity: {comboBox2.Text}, Price: {fp2 * Convert.ToInt32(comboBox2.Text)}");
                }
                if (cbfood3.Checked)
                {
                    orderDetailsQueries.Add($"INSERT INTO OrderDetails (OrderID, ProductID, Quantity, Price) VALUES ({orderId}, (SELECT ProductID FROM RestaurantProducts WHERE ProductName = '{f3}' AND RestaurantID = {Rid}), {comboBox3.Text}, {fp3 * Convert.ToInt32(comboBox3.Text)})");
                    orderDetails.Add($"{f3} - Quantity: {comboBox3.Text}, Price: {fp3 * Convert.ToInt32(comboBox3.Text)}");
                }
                if (cbfood4.Checked)
                {
                    orderDetailsQueries.Add($"INSERT INTO OrderDetails (OrderID, ProductID, Quantity, Price) VALUES ({orderId}, (SELECT ProductID FROM RestaurantProducts WHERE ProductName = '{f4}' AND RestaurantID = {Rid}), {comboBox4.Text}, {fp4 * Convert.ToInt32(comboBox4.Text)})");
                    orderDetails.Add($"{f4} - Quantity: {comboBox4.Text}, Price: {fp4 * Convert.ToInt32(comboBox4.Text)}");
                }
                if (cbfood5.Checked)
                {
                    orderDetailsQueries.Add($"INSERT INTO OrderDetails (OrderID, ProductID, Quantity, Price) VALUES ({orderId}, (SELECT ProductID FROM RestaurantProducts WHERE ProductName = '{f5}' AND RestaurantID = {Rid}), {comboBox5.Text}, {fp5 * Convert.ToInt32(comboBox5.Text)})");
                    orderDetails.Add($"{f5} - Quantity: {comboBox5.Text}, Price: {fp5 * Convert.ToInt32(comboBox5.Text)}");
                }
                if (cbfood6.Checked)
                {
                    orderDetailsQueries.Add($"INSERT INTO OrderDetails (OrderID, ProductID, Quantity, Price) VALUES ({orderId}, (SELECT ProductID FROM RestaurantProducts WHERE ProductName = '{f6}' AND RestaurantID = {Rid}), {comboBox6.Text}, {fp6 * Convert.ToInt32(comboBox6.Text)})");
                    orderDetails.Add($"{f6} - Quantity: {comboBox6.Text}, Price: {fp6 * Convert.ToInt32(comboBox6.Text)}");
                }

                foreach (var query in orderDetailsQueries)
                {
                    DbAccess.ExecuteQuery(query, out error);
                    if (!string.IsNullOrEmpty(error))
                    {
                        MessageBox.Show("Error inserting order details: " + error);
                        return;
                    }
                }

                // Proceed to payment
                ProceedToPayment(totalPrice, orderId, orderDetails);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while placing the order: " + ex.Message);
            }
        }

        private void ProceedToPayment(double totalPrice, int orderId, List<string> orderDetails)
        {
            CardPayment paymentForm = new CardPayment(totalPrice, orderId, orderDetails);
            if (paymentForm.ShowDialog() == DialogResult.OK && paymentForm.PaymentSuccessful)
            {
                // Update order status to 'Paid'
                string updateOrderStatusQuery = $"UPDATE [Order] SET OrderStatus = 'Paid' WHERE OrderID = {orderId}";
                string error;
                DbAccess.ExecuteQuery(updateOrderStatusQuery, out error);

                if (!string.IsNullOrEmpty(error))
                {
                    MessageBox.Show("Error updating order status: " + error);
                    return;
                }

                // Generate receipt
                GenerateReceipt(orderId, orderDetails, totalPrice);

                MessageBox.Show("Order placed and payment processed successfully!");

                ResetOrderForm();
            }
            else
            {
                MessageBox.Show("Payment failed or was cancelled.");
            }
        }

        private void ResetOrderForm()
        {
            cbfood1.Checked = false;
            cbfood2.Checked = false;
            cbfood3.Checked = false;
            cbfood4.Checked = false;
            cbfood5.Checked = false;
            cbfood6.Checked = false;

            comboBox1.Text = "1";
            comboBox2.Text = "1";
            comboBox3.Text = "1";
            comboBox4.Text = "1";
            comboBox5.Text = "1";
            comboBox6.Text = "1";

            comboBox1.Enabled = false;
            comboBox2.Enabled = false;
            comboBox3.Enabled = false;
            comboBox4.Enabled = false;
            comboBox5.Enabled = false;
            comboBox6.Enabled = false;

            tbPrice1.Text = fp1.ToString();
            tbPrice2.Text = fp2.ToString();
            tbPrice3.Text = fp3.ToString();
            tbPrice4.Text = fp4.ToString();
            tbPrice5.Text = fp5.ToString();
            tbPrice6.Text = fp6.ToString();

            tbTotal.Text = "0.00";
        }

        private void GenerateReceipt(int orderId, List<string> orderDetails, double totalPrice)
        {
            string receiptsFolderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Receipts");

            // Ensure the Receipts folder exists
            if (!Directory.Exists(receiptsFolderPath))
            {
                Directory.CreateDirectory(receiptsFolderPath);
            }

            string receiptPath = Path.Combine(receiptsFolderPath, $"OrderReceipt_{orderId}.txt");
            using (StreamWriter writer = new StreamWriter(receiptPath))
            {
                writer.WriteLine("Order Receipt");
                writer.WriteLine("-------------");
                writer.WriteLine($"Order ID: {orderId}");
                writer.WriteLine($"Customer ID: {Uid}");
                writer.WriteLine($"Restaurant ID: {Rid}");
                writer.WriteLine($"Order Date: {DateTime.Now}");
                writer.WriteLine("Order Details:");

                foreach (var detail in orderDetails)
                {
                    writer.WriteLine(detail);
                }

                writer.WriteLine($"Total Price: {totalPrice.ToString("F2")}");
                writer.WriteLine("-------------");
                writer.Close();
            }

            MessageBox.Show($"Receipt generated successfully at {receiptPath}");
        }
    }

}