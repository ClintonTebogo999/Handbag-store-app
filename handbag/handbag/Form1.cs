using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace handbag
{
    public partial class Form1 : Form
    {
        public double price ,quantity;
        public double shippingCharges ,shippingChargePerc;

        public double calculateQuantity(double Price, double Quantity)
        {
            return quantity * Price;
        }
        public double calculateShippingCharges()
        {

            return 0;
        }

        
        public Form1()
        {
            InitializeComponent();
           
        
        }
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            if( listBox1.SelectedIndex == 0)
            {
                price = 450;
                MessageBox.Show($"price for { listBox1.SelectedItem.ToString()} is  R{price}");

            }
            else if (listBox1.SelectedIndex == 1)
            {
                price = 545;
                MessageBox.Show($"price for { listBox1.SelectedItem.ToString()} is  R{price}");
            }
            else if (listBox1.SelectedIndex == 2)
            {
                price = 240;
                MessageBox.Show($"price for { listBox1.SelectedItem.ToString()} is  R{price}");
            }
            else if (listBox1.SelectedIndex == 3)
            {
                price = 630;
                MessageBox.Show($"price for { listBox1.SelectedItem.ToString()} is  R{price}");
            }
            else if (listBox1.SelectedIndex == 4)
            {
                price = 120;
                MessageBox.Show($"price for { listBox1.SelectedItem.ToString()} is  R{price}");
            }
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            shippingCharges = 0.10;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            shippingCharges = 0.07;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            shippingCharges = 0.05;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                price = 450;
                shippingChargePerc = calculateQuantity(price, quantity)*shippingCharges;
                quantity = Convert.ToDouble(Quantity.Text);
                MessageBox.Show($"Price : {price}" +
                                $"\nQuantity : {Quantity.Text}" +
                                $"\nShipping Charges at % : {shippingChargePerc }" + 
                                $"\nTotal : {shippingChargePerc + calculateQuantity(price, quantity)}");


            }
            else if (listBox1.SelectedIndex == 1)
            {
                price = 545;
                shippingChargePerc = calculateQuantity(price, quantity) * shippingCharges;
                quantity = Convert.ToDouble(Quantity.Text);
                MessageBox.Show($"Price : {price}" +
                                $"\nQuantity : {Quantity.Text}" +
                                $"\nShipping Charges at % : {shippingChargePerc }" +
                                $"\nTotal : {shippingChargePerc + calculateQuantity(price, quantity)}");

            }
            else if (listBox1.SelectedIndex == 2)
            {
                price = 240;
                shippingChargePerc = calculateQuantity(price, quantity) * shippingCharges;
                quantity = Convert.ToDouble(Quantity.Text);
                MessageBox.Show($"Price : {price}" +
                                $"\nQuantity : {Quantity.Text}" +
                                $"\nShipping Charges at % : {shippingChargePerc }" +
                                $"\nTotal : {shippingChargePerc + calculateQuantity(price, quantity)}");

            }
            else if (listBox1.SelectedIndex == 3)
            {
                price = 630;
                shippingChargePerc = calculateQuantity(price, quantity) * shippingCharges;
                quantity = Convert.ToDouble(Quantity.Text);
                MessageBox.Show($"Price : {price}" +
                                $"\nQuantity : {Quantity.Text}" +
                                $"\nShipping Charges at % : {shippingChargePerc }" +
                                $"\nTotal : {shippingChargePerc + calculateQuantity(price, quantity)}");

            }
            else if (listBox1.SelectedIndex == 4)
            {
                price = 120;
                shippingChargePerc = calculateQuantity(price, quantity) * shippingCharges;
                quantity = Convert.ToDouble(Quantity.Text);
                MessageBox.Show($"Price : {price}" +
                                $"\nQuantity : {Quantity.Text}" +
                                $"\nShipping Charges at % : {shippingChargePerc }" +
                                $"\nTotal : {shippingChargePerc + calculateQuantity(price, quantity)}");

            }
        }
    }
}
