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

			UpdatePage();
			dataGridViewFlights.ReadOnly = true;
			dataGridViewFlights.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

			var createFlightToolStripMenuItem = new ToolStripMenuItem(StringConstants.CreateFlightToolStripMenuItemName);
			createFlightToolStripMenuItem.Click += CreateFlightToolStripMenuItem_Click;
			var updatePageMenuItem = new ToolStripMenuItem(StringConstants.UpdatePage);
			updatePageMenuItem.Click += UpdatePage_Click;
			var deleteFlightMenuItem = new ToolStripMenuItem(StringConstants.DeleteFlight);
			deleteFlightMenuItem.Click += DeleteFlightMenuItem_Click;
			contextDataGridServiceStrip.Items.AddRange(new[]
			{
				createFlightToolStripMenuItem,
				updatePageMenuItem,
				deleteFlightMenuItem
			});

			dataGridViewFlights.ContextMenuStrip = contextDataGridServiceStrip;
			this.dataGridViewFlights.KeyDown += DataGridViewFlights_KeyDown;
			this.dataGridViewFlights.DataError += DataGridViewFlights_DataError;
			SetCustomNamesOfColumns();
		}

		private void DataGridViewFlights_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			//throw new NotImplementedException();
		}

		private void SetCustomNamesOfColumns()
		{
			dataGridViewFlights.Columns[0].HeaderText = "Код рейса";
			dataGridViewFlights.Columns[1].HeaderText = "Откуда";
			dataGridViewFlights.Columns[2].HeaderText = "Куда";
			dataGridViewFlights.Columns[3].HeaderText = "Дата вылета";
			dataGridViewFlights.Columns[4].HeaderText = "Время вылета";
			dataGridViewFlights.Columns[5].HeaderText = "Дата прилета";
			dataGridViewFlights.Columns[6].HeaderText = "Время прилета";
			dataGridViewFlights.Columns[7].HeaderText = "Тип самолета";
			dataGridViewFlights.Columns[8].HeaderText = "Часовой пояс";
		}

		private void DataGridViewFlights_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.Delete)
			{
				DeleteRecords();
			}
		}

		private void CreateFlightToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var addFlightForm = new AddFlightForm();
			addFlightForm.Show();
		}

		private void UpdatePage_Click(object sender, EventArgs e)
		{
			UpdatePage();
		}

		private void DeleteFlightMenuItem_Click(object sender, EventArgs e)
		{
			DeleteRecords();
		}

		private void DeleteRecords()
		{
			using (var context = new Context())
			{
				if (dataGridViewFlights?.SelectedRows.Count > 0)
				{

					foreach (var record in dataGridViewFlights?.SelectedRows)
					{
						var flight = (record as DataGridViewRow).DataBoundItem as Flight;
						if (flight != null)
						{

							context.Flight.Attach(flight);
							context.Flight.Remove(flight);
							context.SaveChanges();
						}
					}
					UpdatePage();
				}
			}
		}

		private void UpdatePage()
		{
			using (var context = new Context())
			{
				context.Flight?.Load();
				dataGridViewFlights.DataSource = context.Flight.Local.ToBindingList();
				dataGridViewFlights.AutoSize = true;
				dataGridViewFlights.AutoGenerateColumns = true;
				dataGridViewFlights.ColumnHeadersVisible = true;
			}
		}
	}
}

