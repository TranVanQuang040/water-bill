using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.VisualBasic.Logging;

namespace App_tiennuoc
{
    public partial class Input1 : Form
    {
        public Input1()
        {
            InitializeComponent();
        }


        private void login_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("STT", 60);
            listView1.Columns.Add("Name", 200);
            listView1.Columns.Add("Phone", 200);
            listView1.Columns.Add("Customer Types", 100);
            listView1.Columns.Add("Water Last Month", 200);
            listView1.Columns.Add("Water This Month", 200);

            listView1.FullRowSelect = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = txbName.Text;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Please enter your name", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string stt = txbSTT.Text;
            if (string.IsNullOrEmpty(stt))
            {
                MessageBox.Show("Please enter your number", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string phone = txbPhone.Text;
            if (!int.TryParse(phone, out _))
            {
                MessageBox.Show("Please enter your phone", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string Last = txbLast.Text;
            if (!int.TryParse(Last, out _))
            {
                MessageBox.Show("Please enter your Last month", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string This = txbThis.Text;
            if (!int.TryParse(This, out _))
            {
                MessageBox.Show("Please enter your this month", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string Customer = txbcus.Text;
            if (string.IsNullOrEmpty(Customer))
            {
                MessageBox.Show("Please enter your group", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string Total = tbAmount.Text;
            if (string.IsNullOrEmpty(Total))
            {
                MessageBox.Show("", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string WaterFee = txbFee.Text;
            if (string.IsNullOrEmpty(WaterFee))
            {
                MessageBox.Show("", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem item = new ListViewItem();
            item.Text = stt;
            item.SubItems.Add(name);
            item.SubItems.Add(phone);
            item.SubItems.Add(Customer);
            item.SubItems.Add(Last);
            item.SubItems.Add(This);
            item.SubItems.Add(Total);
            item.SubItems.Add(WaterFee);
            listView1.Items.Add(item);

            //delete dato in txb, cbb
            txbSTT.Text = null;
            txbName.Text = null;
            txbPhone.Text = null;
            txbcus.Text = null;
            txbLast.Text = null;
            txbThis.Text = null;
            /*cbbSubject*//*.SelectedIndex = -1;*/
            txbName.Focus();
        }
        ListViewItem item = new ListViewItem();


        private void TxtSTT_TextChanged(object sender, EventArgs e)
        {

        }
        private void InitializeCustomerTypes()
        {
            txbcus.Items.Add("Household customer");
            txbcus.Items.Add("Services public");
            txbcus.Items.Add("Busniness services");
            txbcus.Items.Add("Production units");
            txbcus.SelectedIndex = 0;
        }
        private double CalculateWaterBill(string customerType, double waterConsumption)
        {
            double unitPrice = 0;
            double tongbill = 0;


            switch (customerType)
            {
                case "Household customer":
                    if (waterConsumption <= 10)
                    {
                        unitPrice = 5.973;
                    }
                    else if (waterConsumption <= 20)
                    {
                        unitPrice = 7.052;
                    }
                    else if (waterConsumption <= 30)
                    {
                        unitPrice = 8.699;
                    }
                    else
                    {
                        unitPrice = 15.929;
                    }
                    break;

                case "Services public":
                    unitPrice = 9.955;
                    break;

                case "Production units":
                    unitPrice = 11.615;
                    break;

                case "Business services":
                    unitPrice = 22.068;
                    break;

                default:
                    MessageBox.Show("Invalid customer type.");
                    return 0;
            }


            double totalBill = waterConsumption * unitPrice;
            double environmentalProtectionFee = totalBill * 0.1;
            double vta = totalBill * 0.1;
            // totalBill += environmentalProtectionFee + vta;
            tongbill = totalBill + environmentalProtectionFee + vta;

            // return totalBill;
            return tongbill;

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                var item = listView1.SelectedItems[0];

                string stt = item.SubItems[0].Text;
                string name = item.SubItems[1].Text;
                string phone = item.SubItems[2].Text;
                string customer = item.SubItems[4].Text;
                string Last = item.SubItems[5].Text;
                string This = item.SubItems[6].Text;
                string Total = item.SubItems[7].Text;

                txbName.Text = name;
                txbSTT.Text = stt;
                txbPhone.Text = phone;
                txbcus.Text = customer;
                txbLast.Text = Last;
                txbThis.Text = This;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {

                listView1.SelectedItems[0].SubItems[0].Text = txbSTT.Text;
                listView1.SelectedItems[0].SubItems[1].Text = txbName.Text;
                listView1.SelectedItems[0].SubItems[2].Text = txbPhone.Text;
                listView1.SelectedItems[0].SubItems[4].Text = txbcus.Text;
                listView1.SelectedItems[0].SubItems[5].Text = txbLast.Text;
                listView1.SelectedItems[0].SubItems[6].Text = txbThis.Text;
                listView1.SelectedItems[0].SubItems[7].Text = tbAmount.Text;
                listView1.SelectedItems[0].SubItems[8].Text = txbFee.Text;

            }
            else
            {
                MessageBox.Show("Are you sure about this choice?");
            }
            txbSTT.Text = "";
            txbName.Text = "";
            txbPhone.Text = "";
            txbcus.Text = "";
            txbLast.Text = "";
            txbThis.Text = "";
            tbAmount.Text = "";
            txbFee.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n1, n2;
            int thangtrc = int.Parse(txbLast.Text);
            int thangnay = int.Parse(txbThis.Text);
            if (thangnay < thangtrc)
            {
                MessageBox.Show("Error !!!");
            }
            else
            {
                if (int.TryParse(txbLast.Text, out n1) && int.TryParse(txbThis.Text, out n2))
                {
                    int consumedWater = n2 - n1;
                    tbAmount.Text = consumedWater.ToString();
                }



                double waterConsumption;
                if (!double.TryParse(tbAmount.Text, out waterConsumption))
                {
                    MessageBox.Show("Please enter a valid water consumption value.");
                    return;
                }

                string customerType = txbcus.SelectedItem.ToString();


                double tinhtoan = CalculateWaterBill(customerType, waterConsumption);


                txbFee.Text = tinhtoan.ToString();

            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult cc = MessageBox.Show("....", "", MessageBoxButtons.YesNo);
            if (cc == DialogResult.Yes)
                if (listView1.SelectedItems.Count > 0)
                    listView1.Items.RemoveAt(listView1.SelectedItems[0].Index);
                else if (cc == DialogResult.No)

                    txbSTT.Text = "";
            txbName.Text = "";
            txbPhone.Text = "";
            txbcus.Text = "";
            txbLast.Text = "";
            txbThis.Text = "";
            tbAmount.Text = "";
            txbFee.Text = "";
        }

        private void txbAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbFee_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAmount_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
