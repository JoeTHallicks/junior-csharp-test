using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ui
{
    public partial class Form1 : Form
    {
        static readonly Database db = new Database();

        public Form1()
        {
            InitializeComponent();
            var orderNumbersLength = Form1.db.FetchOrdersCount();   // Select from existing numbers.
            var orderNumbers = Enumerable.Range(1, orderNumbersLength).Select(n => n.ToString()).ToArray();
            orderSearchBox.Items.AddRange(orderNumbers);
            customerDetailsBox.AutoGenerateColumns = false;         // keep to single customer details box
            HideDatePicker();                                       // default date checkbox is false
            DateFiltercheckBox.Checked = false;
        }

        private void DateFilterCheckBox_CheckedChanged_1(object sender, EventArgs e)
        {
            if (DateFiltercheckBox.Checked)
            {
                ShowDatePicker();               // start from date picked
            }
            else
            {
                HideDatePicker();               // no start from date selected
            }
        }

        private void HideDatePicker()
        {
            DatePicker.Hide();
            startDateLabel.Hide();
        }

        private void ShowDatePicker()
        {
            DatePicker.Show();
            startDateLabel.Show();
        }

        private void ReloadOrderButton_Click(object sender, EventArgs e)
        {
            customerDetailsBox.DataSource = null;           // Clear current values in datagrid box
            if (orderSearchBox.SelectedIndex == -1)  // Check whether the Order number has been inputted into the combo box
            {
                searchLabel.Text = "select an Order Number";
                return;
            }

            var orderNumber = orderSearchBox.SelectedIndex + 1;
            searchLabel.Text = "Searching" + orderNumber.ToString();
            string startDate = DatePicker.Value.ToString("yyyy-MM-dd");
            IEnumerable<dynamic> orderDetails = DateFiltercheckBox.Checked ?
                Form1.db.FetchDateFilteredOrderDetails(orderNumber, startDate) :
                Form1.db.FetchOrderDetails(orderNumber);

            if (orderDetails.Count() > 0)
            {
                customerDetailsBox.DataSource = orderDetails.ToList();
                searchLabel.Text = "Order Number details found " + orderNumber.ToString();
            }
            else
            {
                searchLabel.Text = "Error - Invalid Order Number " + orderNumber.ToString();
                searchLabel.Text += DateFiltercheckBox.Checked ? " after " + startDate : "";
            }
        }

      
    }
}
