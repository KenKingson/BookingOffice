using BookingOffice.Constants;
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

namespace BookingOffice
{
    public partial class ListOfFlights : Form
    {
        private BindingSource bindingSource = new BindingSource();
        public ListOfFlights()
        {
            InitializeComponent();
            dataGridViewFlights.Dock = DockStyle.Fill;
            var context = new Context();
            context.Flight.Load();
            dataGridViewFlights.DataSource = context.Flight.Local.ToBindingList();
            dataGridViewFlights.ReadOnly = true;
            dataGridViewFlights.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            var serviceMenuStripItem = new ToolStripMenuItem(StringConstants.ServiceMenuStripItemName);
            var createFlightToolStripMenuItem = new ToolStripMenuItem(StringConstants.CreateFlightToolStripMenuItemName);
            serviceMenuStrip.Items.Add(serviceMenuStripItem);
            serviceMenuStripItem.DropDownItems.Add(createFlightToolStripMenuItem);
            createFlightToolStripMenuItem.Click += CreateFlightToolStripMenuItem_Click;
			this.dataGridViewFlights.KeyDown += DataGridViewFlights_KeyDown;
		}

		private void DataGridViewFlights_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Delete)
			{
				using (var context = new Context())
					foreach (var record in dataGridViewFlights.SelectedRows)
					{
						var flight = (record as DataGridViewRow).DataBoundItem as Flight;
						context.Flight.Attach(flight);
						context.Flight.Remove(flight);
						context.SaveChanges();
					}
			}
		}
		
        private void CreateFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addFlightForm = new AddFlightForm();
            addFlightForm.Show();
        }

    }
}

