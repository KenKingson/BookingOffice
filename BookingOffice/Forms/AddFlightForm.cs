using BookingOffice.Constants;
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

namespace BookingOffice
{
    public partial class AddFlightForm : Form, IDisposable
    {
        public AddFlightForm()
        {
            InitializeComponent();
            addNewFlightLabel.Text = StringConstants.AddNewFlightLabelName;
            addNewFlightButton.Text = StringConstants.AddNewFlightButtonName;
            addNewFlightButton.Click += AddNewFlightButton_Click;
            clearButton.Click += ClearButton_Click;
        }

		private void ClearButton_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void AddNewFlightButton_Click(object sender, EventArgs e)
        {
            try
            {
                var flight = new Flight(
					Guid.NewGuid(),
				    textBoxFrom.Text, 
                    textBoxTo.Text, 
                    dateFrom.Value, 
                    timeFrom.Value,
                    dateTo.Value,
                    timeTo.Value,
                    textBoxAircraft.Text, 
                    textBoxTimeZone.Text);

                var context = new Context();
                context.Flight.Add(flight);
                context.SaveChanges();
                MessageBox.Show("Запись добавлена.");
                Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Clear()
        {
            textBoxFrom.Clear();
            textBoxTo.Clear();
            textBoxAircraft.Clear();
            textBoxTimeZone.Clear();
            dateFrom.Value = DateTime.Now;
            dateTo.Value = DateTime.Now;
            timeFrom.Value = DateTime.MinValue;
			timeTo.Value = DateTime.MinValue;
		}
    }
}
