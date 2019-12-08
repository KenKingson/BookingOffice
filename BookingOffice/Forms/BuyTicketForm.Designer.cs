namespace BookingOffice.Forms
{
	partial class BuyTicketForm
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
			this.PriceLabel = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.timeTo = new System.Windows.Forms.DateTimePicker();
			this.timeToLabel = new System.Windows.Forms.Label();
			this.timeFromLabel = new System.Windows.Forms.Label();
			this.timeFrom = new System.Windows.Forms.DateTimePicker();
			this.dateTo = new System.Windows.Forms.DateTimePicker();
			this.dateFrom = new System.Windows.Forms.DateTimePicker();
			this.timezoneLabel = new System.Windows.Forms.Label();
			this.aircraftTypeLabel = new System.Windows.Forms.Label();
			this.dateToLabel = new System.Windows.Forms.Label();
			this.dateFromLabel = new System.Windows.Forms.Label();
			this.toLabel = new System.Windows.Forms.Label();
			this.fromLabel = new System.Windows.Forms.Label();
			this.textBoxTimeZone = new System.Windows.Forms.TextBox();
			this.textBoxAircraft = new System.Windows.Forms.TextBox();
			this.textBoxTo = new System.Windows.Forms.TextBox();
			this.textBoxFrom = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// PriceLabel
			// 
			this.PriceLabel.AutoSize = true;
			this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.PriceLabel.Location = new System.Drawing.Point(485, 371);
			this.PriceLabel.Name = "PriceLabel";
			this.PriceLabel.Size = new System.Drawing.Size(231, 25);
			this.PriceLabel.TabIndex = 69;
			this.PriceLabel.Text = "Итоговая стоимость";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(228, 371);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(231, 25);
			this.label7.TabIndex = 68;
			this.label7.Text = "Итоговая стоимость";
			// 
			// timeTo
			// 
			this.timeTo.CustomFormat = "HH:mm";
			this.timeTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.timeTo.Location = new System.Drawing.Point(490, 237);
			this.timeTo.Name = "timeTo";
			this.timeTo.Size = new System.Drawing.Size(200, 20);
			this.timeTo.TabIndex = 67;
			this.timeTo.Value = new System.DateTime(2019, 10, 13, 0, 0, 0, 0);
			// 
			// timeToLabel
			// 
			this.timeToLabel.AutoSize = true;
			this.timeToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.timeToLabel.Location = new System.Drawing.Point(355, 237);
			this.timeToLabel.Name = "timeToLabel";
			this.timeToLabel.Size = new System.Drawing.Size(126, 20);
			this.timeToLabel.TabIndex = 66;
			this.timeToLabel.Text = "Время прилета";
			// 
			// timeFromLabel
			// 
			this.timeFromLabel.AutoSize = true;
			this.timeFromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.timeFromLabel.Location = new System.Drawing.Point(362, 158);
			this.timeFromLabel.Name = "timeFromLabel";
			this.timeFromLabel.Size = new System.Drawing.Size(119, 20);
			this.timeFromLabel.TabIndex = 65;
			this.timeFromLabel.Text = "Время вылета";
			// 
			// timeFrom
			// 
			this.timeFrom.CustomFormat = "HH:mm";
			this.timeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.timeFrom.Location = new System.Drawing.Point(490, 157);
			this.timeFrom.Name = "timeFrom";
			this.timeFrom.Size = new System.Drawing.Size(200, 20);
			this.timeFrom.TabIndex = 64;
			this.timeFrom.Value = new System.DateTime(2019, 10, 13, 0, 0, 0, 0);
			// 
			// dateTo
			// 
			this.dateTo.Location = new System.Drawing.Point(490, 194);
			this.dateTo.Name = "dateTo";
			this.dateTo.Size = new System.Drawing.Size(200, 20);
			this.dateTo.TabIndex = 63;
			// 
			// dateFrom
			// 
			this.dateFrom.Location = new System.Drawing.Point(490, 122);
			this.dateFrom.Name = "dateFrom";
			this.dateFrom.Size = new System.Drawing.Size(200, 20);
			this.dateFrom.TabIndex = 62;
			// 
			// timezoneLabel
			// 
			this.timezoneLabel.AutoSize = true;
			this.timezoneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.timezoneLabel.Location = new System.Drawing.Point(372, 329);
			this.timezoneLabel.Name = "timezoneLabel";
			this.timezoneLabel.Size = new System.Drawing.Size(113, 20);
			this.timezoneLabel.TabIndex = 61;
			this.timezoneLabel.Text = "Часовой пояс";
			// 
			// aircraftTypeLabel
			// 
			this.aircraftTypeLabel.AutoSize = true;
			this.aircraftTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.aircraftTypeLabel.Location = new System.Drawing.Point(363, 284);
			this.aircraftTypeLabel.Name = "aircraftTypeLabel";
			this.aircraftTypeLabel.Size = new System.Drawing.Size(118, 20);
			this.aircraftTypeLabel.TabIndex = 60;
			this.aircraftTypeLabel.Text = "Вид самолета";
			// 
			// dateToLabel
			// 
			this.dateToLabel.AutoSize = true;
			this.dateToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateToLabel.Location = new System.Drawing.Point(365, 195);
			this.dateToLabel.Name = "dateToLabel";
			this.dateToLabel.Size = new System.Drawing.Size(116, 20);
			this.dateToLabel.TabIndex = 59;
			this.dateToLabel.Text = "Дата прилета";
			// 
			// dateFromLabel
			// 
			this.dateFromLabel.AutoSize = true;
			this.dateFromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dateFromLabel.Location = new System.Drawing.Point(372, 123);
			this.dateFromLabel.Name = "dateFromLabel";
			this.dateFromLabel.Size = new System.Drawing.Size(109, 20);
			this.dateFromLabel.TabIndex = 58;
			this.dateFromLabel.Text = "Дата вылета";
			// 
			// toLabel
			// 
			this.toLabel.AutoSize = true;
			this.toLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.toLabel.Location = new System.Drawing.Point(413, 78);
			this.toLabel.Name = "toLabel";
			this.toLabel.Size = new System.Drawing.Size(46, 20);
			this.toLabel.TabIndex = 57;
			this.toLabel.Text = "Куда";
			// 
			// fromLabel
			// 
			this.fromLabel.AutoSize = true;
			this.fromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.fromLabel.Location = new System.Drawing.Point(394, 45);
			this.fromLabel.Name = "fromLabel";
			this.fromLabel.Size = new System.Drawing.Size(65, 20);
			this.fromLabel.TabIndex = 56;
			this.fromLabel.Text = "Откуда";
			// 
			// textBoxTimeZone
			// 
			this.textBoxTimeZone.Location = new System.Drawing.Point(492, 329);
			this.textBoxTimeZone.Name = "textBoxTimeZone";
			this.textBoxTimeZone.Size = new System.Drawing.Size(200, 20);
			this.textBoxTimeZone.TabIndex = 55;
			// 
			// textBoxAircraft
			// 
			this.textBoxAircraft.Location = new System.Drawing.Point(492, 286);
			this.textBoxAircraft.Name = "textBoxAircraft";
			this.textBoxAircraft.Size = new System.Drawing.Size(200, 20);
			this.textBoxAircraft.TabIndex = 54;
			// 
			// textBoxTo
			// 
			this.textBoxTo.Location = new System.Drawing.Point(492, 80);
			this.textBoxTo.Name = "textBoxTo";
			this.textBoxTo.Size = new System.Drawing.Size(200, 20);
			this.textBoxTo.TabIndex = 53;
			// 
			// textBoxFrom
			// 
			this.textBoxFrom.Location = new System.Drawing.Point(492, 45);
			this.textBoxFrom.Name = "textBoxFrom";
			this.textBoxFrom.Size = new System.Drawing.Size(200, 20);
			this.textBoxFrom.TabIndex = 52;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(83, 303);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(142, 20);
			this.label6.TabIndex = 51;
			this.label6.Text = "Номер телефона";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(87, 326);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(120, 20);
			this.textBox5.TabIndex = 50;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(83, 249);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(195, 20);
			this.label5.TabIndex = 49;
			this.label5.Text = "Номер и серия паспорта";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(87, 272);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(120, 20);
			this.textBox4.TabIndex = 48;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(83, 192);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(83, 20);
			this.label4.TabIndex = 47;
			this.label4.Text = "Отчество";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(87, 215);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(120, 20);
			this.textBox3.TabIndex = 46;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(83, 132);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 20);
			this.label3.TabIndex = 45;
			this.label3.Text = "Имя";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(87, 155);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(120, 20);
			this.textBox2.TabIndex = 44;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(83, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(81, 20);
			this.label2.TabIndex = 43;
			this.label2.Text = "Фамилия";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(99, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(229, 31);
			this.label1.TabIndex = 42;
			this.label1.Text = "Покупка билета";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(87, 108);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(120, 20);
			this.textBox1.TabIndex = 41;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(594, 399);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(122, 39);
			this.button1.TabIndex = 70;
			this.button1.Text = "Забронировать билет";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// BuyTicketForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.PriceLabel);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.timeTo);
			this.Controls.Add(this.timeToLabel);
			this.Controls.Add(this.timeFromLabel);
			this.Controls.Add(this.timeFrom);
			this.Controls.Add(this.dateTo);
			this.Controls.Add(this.dateFrom);
			this.Controls.Add(this.timezoneLabel);
			this.Controls.Add(this.aircraftTypeLabel);
			this.Controls.Add(this.dateToLabel);
			this.Controls.Add(this.dateFromLabel);
			this.Controls.Add(this.toLabel);
			this.Controls.Add(this.fromLabel);
			this.Controls.Add(this.textBoxTimeZone);
			this.Controls.Add(this.textBoxAircraft);
			this.Controls.Add(this.textBoxTo);
			this.Controls.Add(this.textBoxFrom);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Name = "BuyTicketForm";
			this.Text = "BuyTicketForm1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label PriceLabel;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.DateTimePicker timeTo;
		private System.Windows.Forms.Label timeToLabel;
		private System.Windows.Forms.Label timeFromLabel;
		private System.Windows.Forms.DateTimePicker timeFrom;
		private System.Windows.Forms.DateTimePicker dateTo;
		private System.Windows.Forms.DateTimePicker dateFrom;
		private System.Windows.Forms.Label timezoneLabel;
		private System.Windows.Forms.Label aircraftTypeLabel;
		private System.Windows.Forms.Label dateToLabel;
		private System.Windows.Forms.Label dateFromLabel;
		private System.Windows.Forms.Label toLabel;
		private System.Windows.Forms.Label fromLabel;
		private System.Windows.Forms.TextBox textBoxTimeZone;
		private System.Windows.Forms.TextBox textBoxAircraft;
		private System.Windows.Forms.TextBox textBoxTo;
		private System.Windows.Forms.TextBox textBoxFrom;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
	}
}