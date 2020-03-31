namespace Airline14
{
    partial class ManagerAddFlightForm
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
            this.NumberFlightTB = new System.Windows.Forms.TextBox();
            this.NuberFlightLabel = new System.Windows.Forms.Label();
            this.AddFlightBtn = new System.Windows.Forms.Button();
            this.AerotechnicLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AerotechnicCB = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.DepartureTimeLabel = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.ArrivialTimeLabel = new System.Windows.Forms.Label();
            this.TimeInFlightTB = new System.Windows.Forms.TextBox();
            this.TimeInFlightLabel = new System.Windows.Forms.Label();
            this.WeekdayCB = new System.Windows.Forms.ComboBox();
            this.WeekdayLabel = new System.Windows.Forms.Label();
            this.ManagerMenuStrip = new System.Windows.Forms.MenuStrip();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяНаГлавнуюСтраницуМенеджераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьАвирейсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрВсехАвиарейсовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ManagerMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumberFlightTB
            // 
            this.NumberFlightTB.Location = new System.Drawing.Point(286, 102);
            this.NumberFlightTB.Name = "NumberFlightTB";
            this.NumberFlightTB.ReadOnly = true;
            this.NumberFlightTB.Size = new System.Drawing.Size(406, 21);
            this.NumberFlightTB.TabIndex = 24;
            // 
            // NuberFlightLabel
            // 
            this.NuberFlightLabel.AutoSize = true;
            this.NuberFlightLabel.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.NuberFlightLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NuberFlightLabel.Location = new System.Drawing.Point(282, 79);
            this.NuberFlightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NuberFlightLabel.Name = "NuberFlightLabel";
            this.NuberFlightLabel.Size = new System.Drawing.Size(142, 20);
            this.NuberFlightLabel.TabIndex = 23;
            this.NuberFlightLabel.Text = "Номер авиарейса";
            // 
            // AddFlightBtn
            // 
            this.AddFlightBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.AddFlightBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.AddFlightBtn.FlatAppearance.BorderSize = 0;
            this.AddFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFlightBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.AddFlightBtn.Location = new System.Drawing.Point(392, 398);
            this.AddFlightBtn.Name = "AddFlightBtn";
            this.AddFlightBtn.Size = new System.Drawing.Size(176, 32);
            this.AddFlightBtn.TabIndex = 20;
            this.AddFlightBtn.Text = "Добавить авиарейс";
            this.AddFlightBtn.UseVisualStyleBackColor = false;
            // 
            // AerotechnicLabel
            // 
            this.AerotechnicLabel.AutoSize = true;
            this.AerotechnicLabel.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.AerotechnicLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AerotechnicLabel.Location = new System.Drawing.Point(282, 130);
            this.AerotechnicLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AerotechnicLabel.Name = "AerotechnicLabel";
            this.AerotechnicLabel.Size = new System.Drawing.Size(75, 20);
            this.AerotechnicLabel.TabIndex = 16;
            this.AerotechnicLabel.Text = "Самолет";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Ubuntu", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(224, 24);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLabel.Size = new System.Drawing.Size(541, 41);
            this.NameLabel.TabIndex = 15;
            this.NameLabel.Text = "Добавление новых авиарейсов";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AerotechnicCB
            // 
            this.AerotechnicCB.FormattingEnabled = true;
            this.AerotechnicCB.Location = new System.Drawing.Point(286, 153);
            this.AerotechnicCB.Name = "AerotechnicCB";
            this.AerotechnicCB.Size = new System.Drawing.Size(406, 24);
            this.AerotechnicCB.TabIndex = 25;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(286, 203);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(406, 24);
            this.comboBox1.TabIndex = 27;
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.DestinationLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DestinationLabel.Location = new System.Drawing.Point(282, 180);
            this.DestinationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(146, 20);
            this.DestinationLabel.TabIndex = 26;
            this.DestinationLabel.Text = "Пункт Назначения";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(286, 253);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(406, 24);
            this.comboBox2.TabIndex = 29;
            // 
            // DepartureTimeLabel
            // 
            this.DepartureTimeLabel.AutoSize = true;
            this.DepartureTimeLabel.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.DepartureTimeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DepartureTimeLabel.Location = new System.Drawing.Point(282, 230);
            this.DepartureTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DepartureTimeLabel.Name = "DepartureTimeLabel";
            this.DepartureTimeLabel.Size = new System.Drawing.Size(117, 20);
            this.DepartureTimeLabel.TabIndex = 28;
            this.DepartureTimeLabel.Text = "Время Вылета";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(286, 303);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(406, 24);
            this.comboBox3.TabIndex = 31;
            // 
            // ArrivialTimeLabel
            // 
            this.ArrivialTimeLabel.AutoSize = true;
            this.ArrivialTimeLabel.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.ArrivialTimeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ArrivialTimeLabel.Location = new System.Drawing.Point(282, 280);
            this.ArrivialTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArrivialTimeLabel.Name = "ArrivialTimeLabel";
            this.ArrivialTimeLabel.Size = new System.Drawing.Size(137, 20);
            this.ArrivialTimeLabel.TabIndex = 30;
            this.ArrivialTimeLabel.Text = "Время прибытия";
            // 
            // TimeInFlightTB
            // 
            this.TimeInFlightTB.Location = new System.Drawing.Point(710, 279);
            this.TimeInFlightTB.Name = "TimeInFlightTB";
            this.TimeInFlightTB.ReadOnly = true;
            this.TimeInFlightTB.Size = new System.Drawing.Size(154, 21);
            this.TimeInFlightTB.TabIndex = 33;
            // 
            // TimeInFlightLabel
            // 
            this.TimeInFlightLabel.AutoSize = true;
            this.TimeInFlightLabel.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.TimeInFlightLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TimeInFlightLabel.Location = new System.Drawing.Point(727, 252);
            this.TimeInFlightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeInFlightLabel.Name = "TimeInFlightLabel";
            this.TimeInFlightLabel.Size = new System.Drawing.Size(107, 20);
            this.TimeInFlightLabel.TabIndex = 32;
            this.TimeInFlightLabel.Text = "Время в пути";
            // 
            // WeekdayCB
            // 
            this.WeekdayCB.FormattingEnabled = true;
            this.WeekdayCB.Location = new System.Drawing.Point(286, 353);
            this.WeekdayCB.Name = "WeekdayCB";
            this.WeekdayCB.Size = new System.Drawing.Size(406, 24);
            this.WeekdayCB.TabIndex = 35;
            // 
            // WeekdayLabel
            // 
            this.WeekdayLabel.AutoSize = true;
            this.WeekdayLabel.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.WeekdayLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WeekdayLabel.Location = new System.Drawing.Point(282, 330);
            this.WeekdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WeekdayLabel.Name = "WeekdayLabel";
            this.WeekdayLabel.Size = new System.Drawing.Size(137, 20);
            this.WeekdayLabel.TabIndex = 34;
            this.WeekdayLabel.Text = "Время прибытия";
            // 
            // ManagerMenuStrip
            // 
            this.ManagerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаToolStripMenuItem,
            this.пользователиToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.ManagerMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ManagerMenuStrip.Name = "ManagerMenuStrip";
            this.ManagerMenuStrip.Size = new System.Drawing.Size(934, 24);
            this.ManagerMenuStrip.TabIndex = 36;
            this.ManagerMenuStrip.Text = "menuStrip1";
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вернутьсяНаГлавнуюСтраницуМенеджераToolStripMenuItem,
            this.обновитьToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.программаToolStripMenuItem.Text = "Программа";
            // 
            // вернутьсяНаГлавнуюСтраницуМенеджераToolStripMenuItem
            // 
            this.вернутьсяНаГлавнуюСтраницуМенеджераToolStripMenuItem.Name = "вернутьсяНаГлавнуюСтраницуМенеджераToolStripMenuItem";
            this.вернутьсяНаГлавнуюСтраницуМенеджераToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.вернутьсяНаГлавнуюСтраницуМенеджераToolStripMenuItem.Text = "Вернуться на главную страницу";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьАвирейсToolStripMenuItem,
            this.просмотрВсехАвиарейсовToolStripMenuItem});
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.пользователиToolStripMenuItem.Text = "Авиарейсы";
            // 
            // создатьАвирейсToolStripMenuItem
            // 
            this.создатьАвирейсToolStripMenuItem.Name = "создатьАвирейсToolStripMenuItem";
            this.создатьАвирейсToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.создатьАвирейсToolStripMenuItem.Text = "Создать авиарейс";
            // 
            // просмотрВсехАвиарейсовToolStripMenuItem
            // 
            this.просмотрВсехАвиарейсовToolStripMenuItem.Name = "просмотрВсехАвиарейсовToolStripMenuItem";
            this.просмотрВсехАвиарейсовToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.просмотрВсехАвиарейсовToolStripMenuItem.Text = "Просмотреть все авиарейсы";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сформироватьОтчетToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.отчетыToolStripMenuItem.Text = "Отчет";
            // 
            // сформироватьОтчетToolStripMenuItem
            // 
            this.сформироватьОтчетToolStripMenuItem.Name = "сформироватьОтчетToolStripMenuItem";
            this.сформироватьОтчетToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.сформироватьОтчетToolStripMenuItem.Text = "Сформировать отчет";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // ManagerAddFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.ManagerMenuStrip);
            this.Controls.Add(this.WeekdayCB);
            this.Controls.Add(this.WeekdayLabel);
            this.Controls.Add(this.TimeInFlightTB);
            this.Controls.Add(this.TimeInFlightLabel);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.ArrivialTimeLabel);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.DepartureTimeLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.DestinationLabel);
            this.Controls.Add(this.AerotechnicCB);
            this.Controls.Add(this.NumberFlightTB);
            this.Controls.Add(this.NuberFlightLabel);
            this.Controls.Add(this.AddFlightBtn);
            this.Controls.Add(this.AerotechnicLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "ManagerAddFlight";
            this.Text = "Добавление новых авиарейсов";
            this.Controls.SetChildIndex(this.NameLabel, 0);
            this.Controls.SetChildIndex(this.AerotechnicLabel, 0);
            this.Controls.SetChildIndex(this.AddFlightBtn, 0);
            this.Controls.SetChildIndex(this.NuberFlightLabel, 0);
            this.Controls.SetChildIndex(this.NumberFlightTB, 0);
            this.Controls.SetChildIndex(this.AerotechnicCB, 0);
            this.Controls.SetChildIndex(this.DestinationLabel, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.DepartureTimeLabel, 0);
            this.Controls.SetChildIndex(this.comboBox2, 0);
            this.Controls.SetChildIndex(this.ArrivialTimeLabel, 0);
            this.Controls.SetChildIndex(this.comboBox3, 0);
            this.Controls.SetChildIndex(this.TimeInFlightLabel, 0);
            this.Controls.SetChildIndex(this.TimeInFlightTB, 0);
            this.Controls.SetChildIndex(this.WeekdayLabel, 0);
            this.Controls.SetChildIndex(this.WeekdayCB, 0);
            this.Controls.SetChildIndex(this.ManagerMenuStrip, 0);
            this.ManagerMenuStrip.ResumeLayout(false);
            this.ManagerMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NumberFlightTB;
        private System.Windows.Forms.Label NuberFlightLabel;
        private System.Windows.Forms.Button AddFlightBtn;
        private System.Windows.Forms.Label AerotechnicLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ComboBox AerotechnicCB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label DepartureTimeLabel;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label ArrivialTimeLabel;
        private System.Windows.Forms.TextBox TimeInFlightTB;
        private System.Windows.Forms.Label TimeInFlightLabel;
        private System.Windows.Forms.ComboBox WeekdayCB;
        private System.Windows.Forms.Label WeekdayLabel;
        private System.Windows.Forms.MenuStrip ManagerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяНаГлавнуюСтраницуМенеджераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьАвирейсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрВсехАвиарейсовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сформироватьОтчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}