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
		private bool isEditModeEnabled = false;
		private Context context;

		public ListOfFlights()
		{
			InitializeComponent();
			context = new Context();
			UpdatePage();
			dataGridViewFlights.ReadOnly = true;
			dataGridViewFlights.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

			var createFlightToolStripMenuItem = new ToolStripMenuItem(StringConstants.CreateFlightToolStripMenuItemName);
			createFlightToolStripMenuItem.Click += CreateFlightToolStripMenuItem_Click;
			var updatePageMenuItem = new ToolStripMenuItem(StringConstants.UpdatePageString);
			var deleteFlightMenuItem = new ToolStripMenuItem(StringConstants.DeleteFlightString);
			var editMode = new ToolStripMenuItem(StringConstants.EditModeString);
			var saveChanges = new ToolStripMenuItem(StringConstants.SaveChangesString);

			contextDataGridServiceStrip.Items.AddRange(new[]
			{
				createFlightToolStripMenuItem,
				updatePageMenuItem,
				deleteFlightMenuItem,
				editMode,
				saveChanges
			});

			dataGridViewFlights.ContextMenuStrip = contextDataGridServiceStrip;
			saveChanges.Click += SaveChanges_Click;
			updatePageMenuItem.Click += UpdatePage_Click;
			deleteFlightMenuItem.Click += DeleteFlightMenuItem_Click;
			editMode.Click += EditMode_Click;
			this.dataGridViewFlights.KeyDown += DataGridViewFlights_KeyDown;
			this.dataGridViewFlights.DataError += DataGridViewFlights_DataError;
			this.dataGridViewFlights.UserDeletingRow += DataGridViewFlights_UserDeletingRow;
			SetCustomNamesOfColumns();
		}

		private void DataGridViewFlights_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
		{
			{
				DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
				if (dr == DialogResult.Cancel)
				{
					e.Cancel = true;
				}
			}
		}

		private void SaveChanges_Click(object sender, EventArgs e)
		{
			context.SaveChanges();
		}

		private void EditMode_Click(object sender, EventArgs e)
		{
			if (isEditModeEnabled)
			{
				isEditModeEnabled = false;
			}
			else
			{
				isEditModeEnabled = true;
			}
			dataGridViewFlights.ReadOnly = !isEditModeEnabled;
			dataGridViewFlights.Columns[0].ReadOnly = true;
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
			if (dataGridViewFlights?.SelectedRows.Count > 0)
			{
				DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
				if (dr == DialogResult.Cancel)
				{
					return;
				}
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

		private void UpdatePage()
		{
			context.Flight?.Load();
			dataGridViewFlights.DataSource = context.Flight.Local.ToBindingList();
			dataGridViewFlights.AutoSize = true;
			dataGridViewFlights.AutoGenerateColumns = true;
			dataGridViewFlights.ColumnHeadersVisible = true;
		}
	}
}

