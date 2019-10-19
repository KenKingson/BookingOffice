using BookingOffice.Constants;
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
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
             
        }

        private void CreateFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addFlightForm = new AddFlightForm();
            addFlightForm.Show();
        }

    }
}

