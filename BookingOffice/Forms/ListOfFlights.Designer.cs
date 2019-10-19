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
            this.dataGridViewFlights = new System.Windows.Forms.DataGridView();
            this.serviceMenuStrip = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewFlights
            // 
            this.dataGridViewFlights.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFlights.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFlights.Name = "dataGridViewFlights";
            this.dataGridViewFlights.Size = new System.Drawing.Size(481, 397);
            this.dataGridViewFlights.TabIndex = 0;
            // 
            // serviceMenuStrip
            // 
            this.serviceMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.serviceMenuStrip.Name = "serviceMenuStrip";
            this.serviceMenuStrip.Size = new System.Drawing.Size(600, 24);
            this.serviceMenuStrip.TabIndex = 6;
            this.serviceMenuStrip.Text = "menuStrip1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ListOfFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 440);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.serviceMenuStrip);
            this.Controls.Add(this.dataGridViewFlights);
            this.MainMenuStrip = this.serviceMenuStrip;
            this.Name = "ListOfFlights";
            this.Text = "Список рейсов";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFlights)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewFlights;
        private System.Windows.Forms.MenuStrip serviceMenuStrip;
        private System.Windows.Forms.Button button1;
    }
}