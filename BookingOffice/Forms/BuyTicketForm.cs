using BookingOffice.Entities;
using BookingOffice.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingOffice.Forms
{
	public partial class BuyTicketForm : Form
	{
		private Context context;
		private Flight flight;

		public BuyTicketForm()
		{
			InitializeComponent();
			context = new Context();
			flight = ListOfFlights.flight;
			textBoxFrom.Text = flight.From;
			textBoxTo.Text = flight.To;
			dateFrom.Value = flight.DateFrom;
			timeFrom.Value = flight.TimeFrom;
			dateTo.Value = flight.DateTo;
			timeTo.Value = flight.TimeTo;
			textBoxAircraft.Text = flight.Aircraft;
			textBoxTimeZone.Text = flight.TimeZone;
			var random = new Random();
			var prices = new int[] { 1000, 2000, 3000, 4000, 5000, 6000, 7000 };
			PriceLabel.Text = prices[random.Next(0, 6)].ToString();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				var currentCustomer = new Customer(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToInt32(textBox5.Text));
				var ticket = new Ticket(flight.Id, currentCustomer.Id, Convert.ToInt32(PriceLabel.Text));
				context.Customers.Add(currentCustomer);
				context.Ticket.Add(ticket);
				context.SaveChanges();
				MessageBox.Show($"Билет успешно забронирован.\nКод билета:{ticket.Id}\nОплата при получении в кассе");
				this.Dispose();
			}
			catch (Exception)
			{
				MessageBox.Show("Билет не забронирован!\nПожалуйста проверьте, все ли поля были заполнены!");
			}
		}
	}
}
