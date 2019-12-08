using BookingOffice.Entities;
using BookingOffice.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingOffice.Forms
{
	public partial class MyOrdersForm : Form
	{
		private Context context;

		public MyOrdersForm()
		{
			InitializeComponent();
			context = new Context();
			context.Ticket.Load();
			context.Customers.Load();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var passNumber = this.passNumber.Text;
			var customer = context.Customers.Where(x => x.PassportCode == passNumber).FirstOrDefault() as Customer;
			var flights = context.Ticket.Where(x => x.CustomerId == customer.Id);
			dataGridView1.DataSource = flights.ToArray();
		}
	}
}
