namespace BookingOffice
{
    partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.listOfFlightsButton = new System.Windows.Forms.Button();
			this.myFlightsButton = new System.Windows.Forms.Button();
			this.findFlightButton = new System.Windows.Forms.Button();
			this.startPageLabel = new System.Windows.Forms.Label();
			this.choiseActionLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listOfFlightsButton
			// 
			this.listOfFlightsButton.BackColor = System.Drawing.Color.Transparent;
			this.listOfFlightsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listOfFlightsButton.Location = new System.Drawing.Point(235, 150);
			this.listOfFlightsButton.Name = "listOfFlightsButton";
			this.listOfFlightsButton.Size = new System.Drawing.Size(150, 50);
			this.listOfFlightsButton.TabIndex = 0;
			this.listOfFlightsButton.Text = "Список рейсов";
			this.listOfFlightsButton.UseVisualStyleBackColor = false;
			// 
			// myFlightsButton
			// 
			this.myFlightsButton.BackColor = System.Drawing.Color.Transparent;
			this.myFlightsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.myFlightsButton.Location = new System.Drawing.Point(235, 220);
			this.myFlightsButton.Name = "myFlightsButton";
			this.myFlightsButton.Size = new System.Drawing.Size(150, 50);
			this.myFlightsButton.TabIndex = 1;
			this.myFlightsButton.Text = "Мои заказы";
			this.myFlightsButton.UseVisualStyleBackColor = false;
			// 
			// findFlightButton
			// 
			this.findFlightButton.BackColor = System.Drawing.Color.Transparent;
			this.findFlightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.findFlightButton.Location = new System.Drawing.Point(235, 290);
			this.findFlightButton.Name = "findFlightButton";
			this.findFlightButton.Size = new System.Drawing.Size(150, 50);
			this.findFlightButton.TabIndex = 2;
			this.findFlightButton.Text = "Поиск билетов";
			this.findFlightButton.UseVisualStyleBackColor = false;
			this.findFlightButton.Click += new System.EventHandler(this.findFlightButton_Click);
			// 
			// startPageLabel
			// 
			this.startPageLabel.AutoSize = true;
			this.startPageLabel.BackColor = System.Drawing.Color.Transparent;
			this.startPageLabel.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startPageLabel.Location = new System.Drawing.Point(32, 28);
			this.startPageLabel.Name = "startPageLabel";
			this.startPageLabel.Size = new System.Drawing.Size(361, 48);
			this.startPageLabel.TabIndex = 3;
			this.startPageLabel.Text = "Стартовая страница";
			// 
			// choiseActionLabel
			// 
			this.choiseActionLabel.AutoSize = true;
			this.choiseActionLabel.BackColor = System.Drawing.Color.Transparent;
			this.choiseActionLabel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.choiseActionLabel.Location = new System.Drawing.Point(216, 108);
			this.choiseActionLabel.Name = "choiseActionLabel";
			this.choiseActionLabel.Size = new System.Drawing.Size(201, 18);
			this.choiseActionLabel.TabIndex = 4;
			this.choiseActionLabel.Text = "Выберите нужное действие";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(600, 440);
			this.Controls.Add(this.choiseActionLabel);
			this.Controls.Add(this.startPageLabel);
			this.Controls.Add(this.findFlightButton);
			this.Controls.Add(this.myFlightsButton);
			this.Controls.Add(this.listOfFlightsButton);
			this.Name = "MainForm";
			this.Text = "Booking Fly";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button listOfFlightsButton;
        private System.Windows.Forms.Button myFlightsButton;
        private System.Windows.Forms.Button findFlightButton;
        private System.Windows.Forms.Label startPageLabel;
        private System.Windows.Forms.Label choiseActionLabel;
    }
}

