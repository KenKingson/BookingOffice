namespace BookingOffice
{
    partial class ListOfFlights
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.dataGridViewFlights = new System.Windows.Forms.DataGridView();
			this.contextDataGridServiceStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridViewFlights
			// 
			this.dataGridViewFlights.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewFlights.Cursor = System.Windows.Forms.Cursors.Hand;
			this.dataGridViewFlights.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewFlights.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
			this.dataGridViewFlights.Location = new System.Drawing.Point(0, 0);
			this.dataGridViewFlights.Name = "dataGridViewFlights";
			this.dataGridViewFlights.Size = new System.Drawing.Size(889, 443);
			this.dataGridViewFlights.TabIndex = 0;
			// 
			// contextDataGridServiceStrip
			// 
			this.contextDataGridServiceStrip.Name = "contextMenuStrip1";
			this.contextDataGridServiceStrip.Size = new System.Drawing.Size(61, 4);
			// 
			// ListOfFlights
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(889, 443);
			this.Controls.Add(this.dataGridViewFlights);
			this.Name = "ListOfFlights";
			this.Text = "Список рейсов";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridViewFlights;
		private System.Windows.Forms.ContextMenuStrip contextDataGridServiceStrip;
	}
}