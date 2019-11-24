namespace BookingOffice.Forms
{
	partial class FindTicketsForm
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
			this.dateToBox = new System.Windows.Forms.DateTimePicker();
			this.dateFromBox = new System.Windows.Forms.DateTimePicker();
			this.dateToLabel = new System.Windows.Forms.Label();
			this.dateFromLabel = new System.Windows.Forms.Label();
			this.toLabel = new System.Windows.Forms.Label();
			this.fromLabel = new System.Windows.Forms.Label();
			this.addNewFlightLabel = new System.Windows.Forms.Label();
			this.textBoxTo = new System.Windows.Forms.TextBox();
			this.textBoxFrom = new System.Windows.Forms.TextBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.radioButton5 = new System.Windows.Forms.RadioButton();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.radioButton6 = new System.Windows.Forms.RadioButton();
			this.radioButton7 = new System.Windows.Forms.RadioButton();
			this.radioButton8 = new System.Windows.Forms.RadioButton();
			this.button1 = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// dateToBox
			// 
			this.dateToBox.Location = new System.Drawing.Point(329, 165);
			this.dateToBox.Name = "dateToBox";
			this.dateToBox.Size = new System.Drawing.Size(200, 20);
			this.dateToBox.TabIndex = 35;
			// 
			// dateFromBox
			// 
			this.dateFromBox.Location = new System.Drawing.Point(329, 129);
			this.dateFromBox.Name = "dateFromBox";
			this.dateFromBox.Size = new System.Drawing.Size(200, 20);
			this.dateFromBox.TabIndex = 34;
			// 
			// dateToLabel
			// 
			this.dateToLabel.AutoSize = true;
			this.dateToLabel.Location = new System.Drawing.Point(225, 171);
			this.dateToLabel.Name = "dateToLabel";
			this.dateToLabel.Size = new System.Drawing.Size(77, 13);
			this.dateToLabel.TabIndex = 31;
			this.dateToLabel.Text = "Дата прилета";
			// 
			// dateFromLabel
			// 
			this.dateFromLabel.AutoSize = true;
			this.dateFromLabel.Location = new System.Drawing.Point(225, 135);
			this.dateFromLabel.Name = "dateFromLabel";
			this.dateFromLabel.Size = new System.Drawing.Size(73, 13);
			this.dateFromLabel.TabIndex = 30;
			this.dateFromLabel.Text = "Дата вылета";
			// 
			// toLabel
			// 
			this.toLabel.AutoSize = true;
			this.toLabel.Location = new System.Drawing.Point(223, 96);
			this.toLabel.Name = "toLabel";
			this.toLabel.Size = new System.Drawing.Size(31, 13);
			this.toLabel.TabIndex = 29;
			this.toLabel.Text = "Куда";
			// 
			// fromLabel
			// 
			this.fromLabel.AutoSize = true;
			this.fromLabel.Location = new System.Drawing.Point(223, 59);
			this.fromLabel.Name = "fromLabel";
			this.fromLabel.Size = new System.Drawing.Size(43, 13);
			this.fromLabel.TabIndex = 28;
			this.fromLabel.Text = "Откуда";
			// 
			// addNewFlightLabel
			// 
			this.addNewFlightLabel.AutoSize = true;
			this.addNewFlightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.addNewFlightLabel.Location = new System.Drawing.Point(174, 22);
			this.addNewFlightLabel.Name = "addNewFlightLabel";
			this.addNewFlightLabel.Size = new System.Drawing.Size(213, 20);
			this.addNewFlightLabel.TabIndex = 27;
			this.addNewFlightLabel.Text = "Введите параметры рейса";
			// 
			// textBoxTo
			// 
			this.textBoxTo.Location = new System.Drawing.Point(329, 93);
			this.textBoxTo.Name = "textBoxTo";
			this.textBoxTo.Size = new System.Drawing.Size(200, 20);
			this.textBoxTo.TabIndex = 24;
			// 
			// textBoxFrom
			// 
			this.textBoxFrom.Location = new System.Drawing.Point(329, 58);
			this.textBoxFrom.Name = "textBoxFrom";
			this.textBoxFrom.Size = new System.Drawing.Size(200, 20);
			this.textBoxFrom.TabIndex = 23;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(329, 207);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(200, 76);
			this.groupBox1.TabIndex = 36;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Тип билета";
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(17, 42);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(99, 17);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "В обе стороны";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(17, 19);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(101, 17);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "В одну сторону";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.radioButton5);
			this.groupBox2.Controls.Add(this.radioButton3);
			this.groupBox2.Controls.Add(this.radioButton4);
			this.groupBox2.Location = new System.Drawing.Point(329, 289);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(200, 98);
			this.groupBox2.TabIndex = 37;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Класс полета";
			// 
			// radioButton5
			// 
			this.radioButton5.AutoSize = true;
			this.radioButton5.Location = new System.Drawing.Point(17, 65);
			this.radioButton5.Name = "radioButton5";
			this.radioButton5.Size = new System.Drawing.Size(98, 17);
			this.radioButton5.TabIndex = 2;
			this.radioButton5.TabStop = true;
			this.radioButton5.Text = "Первый класс";
			this.radioButton5.UseVisualStyleBackColor = true;
			// 
			// radioButton3
			// 
			this.radioButton3.AutoSize = true;
			this.radioButton3.Location = new System.Drawing.Point(17, 42);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(97, 17);
			this.radioButton3.TabIndex = 1;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Эконом-класс";
			this.radioButton3.UseVisualStyleBackColor = true;
			// 
			// radioButton4
			// 
			this.radioButton4.AutoSize = true;
			this.radioButton4.Location = new System.Drawing.Point(17, 19);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(95, 17);
			this.radioButton4.TabIndex = 0;
			this.radioButton4.TabStop = true;
			this.radioButton4.Text = "Бизнес-класс";
			this.radioButton4.UseVisualStyleBackColor = true;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.radioButton6);
			this.groupBox3.Controls.Add(this.radioButton7);
			this.groupBox3.Controls.Add(this.radioButton8);
			this.groupBox3.Location = new System.Drawing.Point(329, 393);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(200, 98);
			this.groupBox3.TabIndex = 38;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Пассажир";
			// 
			// radioButton6
			// 
			this.radioButton6.AutoSize = true;
			this.radioButton6.Location = new System.Drawing.Point(17, 65);
			this.radioButton6.Name = "radioButton6";
			this.radioButton6.Size = new System.Drawing.Size(126, 17);
			this.radioButton6.TabIndex = 2;
			this.radioButton6.TabStop = true;
			this.radioButton6.Text = "Младенец (0-2 года)";
			this.radioButton6.UseVisualStyleBackColor = true;
			// 
			// radioButton7
			// 
			this.radioButton7.AutoSize = true;
			this.radioButton7.Location = new System.Drawing.Point(17, 42);
			this.radioButton7.Name = "radioButton7";
			this.radioButton7.Size = new System.Drawing.Size(118, 17);
			this.radioButton7.TabIndex = 1;
			this.radioButton7.TabStop = true;
			this.radioButton7.Text = "Ребенок (2-10 лет)";
			this.radioButton7.UseVisualStyleBackColor = true;
			// 
			// radioButton8
			// 
			this.radioButton8.AutoSize = true;
			this.radioButton8.Location = new System.Drawing.Point(17, 19);
			this.radioButton8.Name = "radioButton8";
			this.radioButton8.Size = new System.Drawing.Size(157, 17);
			this.radioButton8.TabIndex = 0;
			this.radioButton8.TabStop = true;
			this.radioButton8.Text = "Взрослый (старше 18 лет)";
			this.radioButton8.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.button1.Location = new System.Drawing.Point(547, 522);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 39;
			this.button1.Text = "Найти";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FindTicketsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(788, 564);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dateToBox);
			this.Controls.Add(this.dateFromBox);
			this.Controls.Add(this.dateToLabel);
			this.Controls.Add(this.dateFromLabel);
			this.Controls.Add(this.toLabel);
			this.Controls.Add(this.fromLabel);
			this.Controls.Add(this.addNewFlightLabel);
			this.Controls.Add(this.textBoxTo);
			this.Controls.Add(this.textBoxFrom);
			this.Name = "FindTicketsForm";
			this.Text = "Купить билет";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.DateTimePicker dateToBox;
		private System.Windows.Forms.DateTimePicker dateFromBox;
		private System.Windows.Forms.Label dateToLabel;
		private System.Windows.Forms.Label dateFromLabel;
		private System.Windows.Forms.Label toLabel;
		private System.Windows.Forms.Label fromLabel;
		private System.Windows.Forms.Label addNewFlightLabel;
		private System.Windows.Forms.TextBox textBoxTo;
		private System.Windows.Forms.TextBox textBoxFrom;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.RadioButton radioButton5;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton radioButton6;
		private System.Windows.Forms.RadioButton radioButton7;
		private System.Windows.Forms.RadioButton radioButton8;
		private System.Windows.Forms.Button button1;
	}
}