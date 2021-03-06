﻿using BookingOffice.Constants;
using BookingOffice.Forms;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.myFlightsButton.Text = StringConstants.MyFlightsButtonName;
            this.listOfFlightsButton.Text = StringConstants.ListOfFlightsButtonName;
            this.findFlightButton.Text = StringConstants.FindFlightButtonName;
            this.startPageLabel.Text = StringConstants.StartPageLabelName;
            this.choiseActionLabel.Text = StringConstants.ChoiseActionLabelName;
            this.Text = StringConstants.MainFormName;
            listOfFlightsButton.Click += ListOfFlightsButton_Click;
            
        }

        private void ListOfFlightsButton_Click(object sender, EventArgs e)
        {
            var listOfFlightsForm = new ListOfFlights();
            listOfFlightsForm.Show();
        }

		private void findFlightButton_Click(object sender, EventArgs e)
		{
			var findTicketsForm = new FindTicketsForm();
			findTicketsForm.Show();
		}

		private void myFlightsButton_Click(object sender, EventArgs e)
		{
			var myOrdersForm = new MyOrdersForm();
			myOrdersForm.Show();
		}
	}
}
