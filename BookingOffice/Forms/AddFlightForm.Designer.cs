namespace BookingOffice
{
    partial class AddFlightForm
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
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxAircraft = new System.Windows.Forms.TextBox();
            this.textBoxTimeZone = new System.Windows.Forms.TextBox();
            this.addNewFlightLabel = new System.Windows.Forms.Label();
            this.addNewFlightButton = new System.Windows.Forms.Button();
            this.fromLabel = new System.Windows.Forms.Label();
            this.toLabel = new System.Windows.Forms.Label();
            this.dateFromLabel = new System.Windows.Forms.Label();
            this.dateToLabel = new System.Windows.Forms.Label();
            this.aircraftTypeLabel = new System.Windows.Forms.Label();
            this.timezoneLabel = new System.Windows.Forms.Label();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.clearButton = new System.Windows.Forms.Button();
            this.timeFrom = new System.Windows.Forms.DateTimePicker();
            this.timeFromLabel = new System.Windows.Forms.Label();
            this.timeToLabel = new System.Windows.Forms.Label();
            this.timeTo = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(240, 55);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(200, 20);
            this.textBoxFrom.TabIndex = 1;
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(240, 90);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(200, 20);
            this.textBoxTo.TabIndex = 2;
            // 
            // textBoxAircraft
            // 
            this.textBoxAircraft.Location = new System.Drawing.Point(240, 296);
            this.textBoxAircraft.Name = "textBoxAircraft";
            this.textBoxAircraft.Size = new System.Drawing.Size(200, 20);
            this.textBoxAircraft.TabIndex = 5;
            // 
            // textBoxTimeZone
            // 
            this.textBoxTimeZone.Location = new System.Drawing.Point(240, 339);
            this.textBoxTimeZone.Name = "textBoxTimeZone";
            this.textBoxTimeZone.Size = new System.Drawing.Size(200, 20);
            this.textBoxTimeZone.TabIndex = 6;
            // 
            // addNewFlightLabel
            // 
            this.addNewFlightLabel.AutoSize = true;
            this.addNewFlightLabel.Font = new System.Drawing.Font("JasmineUPC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addNewFlightLabel.Location = new System.Drawing.Point(85, 19);
            this.addNewFlightLabel.Name = "addNewFlightLabel";
            this.addNewFlightLabel.Size = new System.Drawing.Size(203, 18);
            this.addNewFlightLabel.TabIndex = 7;
            this.addNewFlightLabel.Text = "Введите параметры рейса";
            // 
            // addNewFlightButton
            // 
            this.addNewFlightButton.Location = new System.Drawing.Point(339, 388);
            this.addNewFlightButton.Name = "addNewFlightButton";
            this.addNewFlightButton.Size = new System.Drawing.Size(99, 23);
            this.addNewFlightButton.TabIndex = 8;
            this.addNewFlightButton.Text = "Добавить запись";
            this.addNewFlightButton.UseVisualStyleBackColor = true;
            // 
            // fromLabel
            // 
            this.fromLabel.AutoSize = true;
            this.fromLabel.Location = new System.Drawing.Point(134, 56);
            this.fromLabel.Name = "fromLabel";
            this.fromLabel.Size = new System.Drawing.Size(43, 13);
            this.fromLabel.TabIndex = 10;
            this.fromLabel.Text = "Откуда";
            // 
            // toLabel
            // 
            this.toLabel.AutoSize = true;
            this.toLabel.Location = new System.Drawing.Point(134, 93);
            this.toLabel.Name = "toLabel";
            this.toLabel.Size = new System.Drawing.Size(31, 13);
            this.toLabel.TabIndex = 11;
            this.toLabel.Text = "Куда";
            // 
            // dateFromLabel
            // 
            this.dateFromLabel.AutoSize = true;
            this.dateFromLabel.Location = new System.Drawing.Point(134, 138);
            this.dateFromLabel.Name = "dateFromLabel";
            this.dateFromLabel.Size = new System.Drawing.Size(73, 13);
            this.dateFromLabel.TabIndex = 12;
            this.dateFromLabel.Text = "Дата вылета";
            // 
            // dateToLabel
            // 
            this.dateToLabel.AutoSize = true;
            this.dateToLabel.Location = new System.Drawing.Point(134, 210);
            this.dateToLabel.Name = "dateToLabel";
            this.dateToLabel.Size = new System.Drawing.Size(77, 13);
            this.dateToLabel.TabIndex = 13;
            this.dateToLabel.Text = "Дата прилета";
            // 
            // aircraftTypeLabel
            // 
            this.aircraftTypeLabel.AutoSize = true;
            this.aircraftTypeLabel.Location = new System.Drawing.Point(134, 299);
            this.aircraftTypeLabel.Name = "aircraftTypeLabel";
            this.aircraftTypeLabel.Size = new System.Drawing.Size(78, 13);
            this.aircraftTypeLabel.TabIndex = 14;
            this.aircraftTypeLabel.Text = "Вид самолета";
            // 
            // timezoneLabel
            // 
            this.timezoneLabel.AutoSize = true;
            this.timezoneLabel.Location = new System.Drawing.Point(134, 342);
            this.timezoneLabel.Name = "timezoneLabel";
            this.timezoneLabel.Size = new System.Drawing.Size(78, 13);
            this.timezoneLabel.TabIndex = 15;
            this.timezoneLabel.Text = "Часовой пояс";
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(238, 132);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(200, 20);
            this.dateFrom.TabIndex = 16;
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(238, 204);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(200, 20);
            this.dateTo.TabIndex = 17;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(444, 388);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(99, 23);
            this.clearButton.TabIndex = 18;
            this.clearButton.Text = "Очистить поля";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // timeFrom
            // 
            this.timeFrom.CustomFormat = "HH:mm";
            this.timeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeFrom.Location = new System.Drawing.Point(238, 167);
            this.timeFrom.Name = "timeFrom";
            this.timeFrom.Size = new System.Drawing.Size(200, 20);
            this.timeFrom.TabIndex = 19;
            this.timeFrom.Value = new System.DateTime(2019, 10, 13, 0, 0, 0, 0);
            // 
            // timeFromLabel
            // 
            this.timeFromLabel.AutoSize = true;
            this.timeFromLabel.Location = new System.Drawing.Point(134, 167);
            this.timeFromLabel.Name = "timeFromLabel";
            this.timeFromLabel.Size = new System.Drawing.Size(80, 13);
            this.timeFromLabel.TabIndex = 20;
            this.timeFromLabel.Text = "Время вылета";
            // 
            // timeToLabel
            // 
            this.timeToLabel.AutoSize = true;
            this.timeToLabel.Location = new System.Drawing.Point(134, 254);
            this.timeToLabel.Name = "timeToLabel";
            this.timeToLabel.Size = new System.Drawing.Size(84, 13);
            this.timeToLabel.TabIndex = 21;
            this.timeToLabel.Text = "Время прилета";
            // 
            // timeTo
            // 
            this.timeTo.CustomFormat = "HH:mm";
            this.timeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timeTo.Location = new System.Drawing.Point(238, 247);
            this.timeTo.Name = "timeTo";
            this.timeTo.Size = new System.Drawing.Size(200, 20);
            this.timeTo.TabIndex = 22;
            this.timeTo.Value = new System.DateTime(2019, 10, 13, 0, 0, 0, 0);
            // 
            // AddFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 440);
            this.Controls.Add(this.timeTo);
            this.Controls.Add(this.timeToLabel);
            this.Controls.Add(this.timeFromLabel);
            this.Controls.Add(this.timeFrom);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.timezoneLabel);
            this.Controls.Add(this.aircraftTypeLabel);
            this.Controls.Add(this.dateToLabel);
            this.Controls.Add(this.dateFromLabel);
            this.Controls.Add(this.toLabel);
            this.Controls.Add(this.fromLabel);
            this.Controls.Add(this.addNewFlightButton);
            this.Controls.Add(this.addNewFlightLabel);
            this.Controls.Add(this.textBoxTimeZone);
            this.Controls.Add(this.textBoxAircraft);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxFrom);
            this.Name = "AddFlightForm";
            this.Text = "Добавление нового рейса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxAircraft;
        private System.Windows.Forms.TextBox textBoxTimeZone;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label addNewFlightLabel;
        private System.Windows.Forms.Button addNewFlightButton;
        private System.Windows.Forms.Label fromLabel;
        private System.Windows.Forms.Label toLabel;
        private System.Windows.Forms.Label dateFromLabel;
        private System.Windows.Forms.Label dateToLabel;
        private System.Windows.Forms.Label aircraftTypeLabel;
        private System.Windows.Forms.Label timezoneLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DateTimePicker timeFrom;
        private System.Windows.Forms.Label timeFromLabel;
        private System.Windows.Forms.Label timeToLabel;
        private System.Windows.Forms.DateTimePicker timeTo;
    }
}