using BookingOffice.Entities;
using BookingOffice.Utils;
using ClosedXML.Excel;
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
		private Ticket[] arrayFlights;
		public MyOrdersForm()
		{
			InitializeComponent();
			context = new Context();
			context.Ticket.Load();
			context.Customers.Load();
			button2.Enabled = false;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var passNumber = this.passNumber.Text;
			var customer = context.Customers.Where(x => x.PassportCode == passNumber).FirstOrDefault() as Customer;
			var tickets = context.Ticket.Where(x => x.CustomerId == customer.Id);
			arrayFlights = tickets.ToArray();
			dataGridView1.DataSource = arrayFlights;
			if (dataGridView1.DataSource != null)
			{
				button2.Enabled = true;
			}
		}
		private void button2_Click(object sender, EventArgs e)
		{
				XLWorkbook workbook = new XLWorkbook();
				var worksheet = workbook.Worksheets.Add("Билет");
				worksheet.Cell("A" + 1).Value = "ID БИЛЕТА";
				worksheet.Cell("B" + 1).Value = "ID ПОЛЕТА";
				worksheet.Cell("C" + 1).Value = "ID ПАССАЖИРА";
				worksheet.Cell("D" + 1).Value = "Стоимость";
				worksheet.Cell("E" + 1).Value = "Дата покупки";
				worksheet.Cell("F" + 1).Value = "Класс полета";
				worksheet.ColumnWidth = 40;
				for (int i = 0; i < arrayFlights.Length; i++)
				{
					worksheet.Cell("A" + $"{i + 2}").Value = arrayFlights[i].Id;
					worksheet.Cell("B" + $"{i + 2}").Value = arrayFlights[i].FlightId;
					worksheet.Cell("C" + $"{i + 2}").Value = arrayFlights[i].CustomerId;
					worksheet.Cell("D" + $"{i + 2}").Value = arrayFlights[i].Price;
					worksheet.Cell("E" + $"{i + 2}").Value = arrayFlights[i].DateOfPushcare;
					worksheet.Cell("F" + $"{i + 2}").Value = arrayFlights[i].FlightClass;
				}
				workbook.SaveAs(@"Ticket.xlsx");
		}
	}
}
