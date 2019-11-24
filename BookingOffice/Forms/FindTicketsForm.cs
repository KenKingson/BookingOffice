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
	public partial class FindTicketsForm : Form
	{
		public FindTicketsForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var from = textBoxFrom.Text;
			var to = textBoxTo.Text;
			var dateFrom = dateFromBox.Value;
			var dateTo = dateToBox.Value;
			var listOfFlights = new ListOfFlights();
			listOfFlights.Show();
			var grid = listOfFlights.dataGridViewFlights;
			for (int i = 0; i < grid.RowCount; i++)
			{
				grid.Rows[i].Selected = false;
				if (grid.Rows[i].Cells[1].Value != null && grid.Rows[i].Cells[2].Value != null)
				{
					if (grid.Rows[i].Cells[1].Value.ToString().Contains(from) && grid.Rows[i].Cells[2].Value.ToString().Contains(to))
					{
						grid.Rows[i].Selected = true;
						break;
					}


				}

			}



		}

		private void findData()
		{

		}
	}
}
