namespace Airline14
{
    partial class ManagerAllFlightForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerAllFlightForm));
            this.NameLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateFlightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeFlightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soldCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivialTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDBDataSet2 = new Airline14.AirlineDBDataSet2();
            this.ManagerMenuStrip = new System.Windows.Forms.MenuStrip();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяНаГлавнуюСтраницуМенеджераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьАвирейсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьВыбранныйАвиарейсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыбранныйРейсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пунктНазначенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеПунктаНазначенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеПToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.flightsTableAdapter = new Airline14.AirlineDBDataSet2TableAdapters.FlightsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.FlightDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.NuberFlightLabel = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.AerotechnicLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AddFlightBtn = new System.Windows.Forms.Button();
            this.WeekdayLabel = new System.Windows.Forms.Label();
            this.NumberFlightTB = new System.Windows.Forms.TextBox();
            this.TimeInFlightTB = new System.Windows.Forms.TextBox();
            this.AerotechnicCB = new System.Windows.Forms.ComboBox();
            this.TimeInFlightLabel = new System.Windows.Forms.Label();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.ArrivialTimeLabel = new System.Windows.Forms.Label();
            this.DestinationCB = new System.Windows.Forms.ComboBox();
            this.DepartureTimeLabel = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.createToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.removeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UnDoToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDBDataSet2)).BeginInit();
            this.ManagerMenuStrip.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Ubuntu", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(244, 56);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLabel.Size = new System.Drawing.Size(420, 41);
            this.NameLabel.TabIndex = 16;
            this.NameLabel.Text = "Список всех авиарейсов";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.expr1DataGridViewTextBoxColumn,
            this.dateFlightDataGridViewTextBoxColumn,
            this.departureTimeDataGridViewTextBoxColumn,
            this.timeFlightDataGridViewTextBoxColumn,
            this.soldCountDataGridViewTextBoxColumn,
            this.arrivialTimeDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.flightsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 399);
            this.dataGridView1.TabIndex = 17;
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Номер авиарейса";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn1.HeaderText = "Самолет";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Пункт назначения";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateFlightDataGridViewTextBoxColumn
            // 
            this.dateFlightDataGridViewTextBoxColumn.DataPropertyName = "Date flight";
            this.dateFlightDataGridViewTextBoxColumn.HeaderText = "Дата авиарейса";
            this.dateFlightDataGridViewTextBoxColumn.Name = "dateFlightDataGridViewTextBoxColumn";
            this.dateFlightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // departureTimeDataGridViewTextBoxColumn
            // 
            this.departureTimeDataGridViewTextBoxColumn.DataPropertyName = "Departure time";
            this.departureTimeDataGridViewTextBoxColumn.HeaderText = "Время отправления";
            this.departureTimeDataGridViewTextBoxColumn.Name = "departureTimeDataGridViewTextBoxColumn";
            this.departureTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeFlightDataGridViewTextBoxColumn
            // 
            this.timeFlightDataGridViewTextBoxColumn.DataPropertyName = "Time flight";
            this.timeFlightDataGridViewTextBoxColumn.HeaderText = "Время в полете";
            this.timeFlightDataGridViewTextBoxColumn.Name = "timeFlightDataGridViewTextBoxColumn";
            this.timeFlightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soldCountDataGridViewTextBoxColumn
            // 
            this.soldCountDataGridViewTextBoxColumn.DataPropertyName = "Sold count";
            this.soldCountDataGridViewTextBoxColumn.HeaderText = "Количество проданных билетов";
            this.soldCountDataGridViewTextBoxColumn.Name = "soldCountDataGridViewTextBoxColumn";
            this.soldCountDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // arrivialTimeDataGridViewTextBoxColumn
            // 
            this.arrivialTimeDataGridViewTextBoxColumn.DataPropertyName = "Arrivial time";
            this.arrivialTimeDataGridViewTextBoxColumn.HeaderText = "Время прибытия";
            this.arrivialTimeDataGridViewTextBoxColumn.Name = "arrivialTimeDataGridViewTextBoxColumn";
            this.arrivialTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Менеджер";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // flightsBindingSource
            // 
            this.flightsBindingSource.DataMember = "Flights";
            this.flightsBindingSource.DataSource = this.airlineDBDataSet2;
            // 
            // airlineDBDataSet2
            // 
            this.airlineDBDataSet2.DataSetName = "AirlineDBDataSet2";
            this.airlineDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ManagerMenuStrip
            // 
            this.ManagerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаToolStripMenuItem,
            this.пользователиToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.пунктНазначенияToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.ManagerMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ManagerMenuStrip.Name = "ManagerMenuStrip";
            this.ManagerMenuStrip.Size = new System.Drawing.Size(942, 24);
            this.ManagerMenuStrip.TabIndex = 24;
            this.ManagerMenuStrip.Text = "menuStrip1";
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вернутьсяНаГлавнуюСтраницуМенеджераToolStripMenuItem,
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
            this.вернутьсяНаГлавнуюСтраницуМенеджераToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяНаГлавнуюСтраницуМенеджераToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьАвирейсToolStripMenuItem,
            this.редактироватьВыбранныйАвиарейсToolStripMenuItem,
            this.удалитьВыбранныйРейсToolStripMenuItem});
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.пользователиToolStripMenuItem.Text = "Авиарейсы";
            // 
            // создатьАвирейсToolStripMenuItem
            // 
            this.создатьАвирейсToolStripMenuItem.Name = "создатьАвирейсToolStripMenuItem";
            this.создатьАвирейсToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.создатьАвирейсToolStripMenuItem.Text = "Добавить авиарейс";
            this.создатьАвирейсToolStripMenuItem.Click += new System.EventHandler(this.создатьАвирейсToolStripMenuItem_Click);
            // 
            // редактироватьВыбранныйАвиарейсToolStripMenuItem
            // 
            this.редактироватьВыбранныйАвиарейсToolStripMenuItem.Name = "редактироватьВыбранныйАвиарейсToolStripMenuItem";
            this.редактироватьВыбранныйАвиарейсToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.редактироватьВыбранныйАвиарейсToolStripMenuItem.Text = "Редактировать выбранный авиарейс";
            // 
            // удалитьВыбранныйРейсToolStripMenuItem
            // 
            this.удалитьВыбранныйРейсToolStripMenuItem.Name = "удалитьВыбранныйРейсToolStripMenuItem";
            this.удалитьВыбранныйРейсToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.удалитьВыбранныйРейсToolStripMenuItem.Text = "Удалить выбранный рейс";
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
            this.сформироватьОтчетToolStripMenuItem.Click += new System.EventHandler(this.сформироватьОтчетToolStripMenuItem_Click);
            // 
            // пунктНазначенияToolStripMenuItem
            // 
            this.пунктНазначенияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавлениеПунктаНазначенияToolStripMenuItem,
            this.всеПToolStripMenuItem});
            this.пунктНазначенияToolStripMenuItem.Name = "пунктНазначенияToolStripMenuItem";
            this.пунктНазначенияToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.пунктНазначенияToolStripMenuItem.Text = "Пункты назначения";
            // 
            // добавлениеПунктаНазначенияToolStripMenuItem
            // 
            this.добавлениеПунктаНазначенияToolStripMenuItem.Name = "добавлениеПунктаНазначенияToolStripMenuItem";
            this.добавлениеПунктаНазначенияToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.добавлениеПунктаНазначенияToolStripMenuItem.Text = "Добавление пункта назначения";
            this.добавлениеПунктаНазначенияToolStripMenuItem.Click += new System.EventHandler(this.добавлениеПунктаНазначенияToolStripMenuItem_Click);
            // 
            // всеПToolStripMenuItem
            // 
            this.всеПToolStripMenuItem.Name = "всеПToolStripMenuItem";
            this.всеПToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.всеПToolStripMenuItem.Text = "Просмотр всех пунктов назначения";
            this.всеПToolStripMenuItem.Click += new System.EventHandler(this.всеПToolStripMenuItem_Click);
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
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click_1);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 70);
            // 
            // flightsTableAdapter
            // 
            this.flightsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FlightDateTimePicker);
            this.panel1.Controls.Add(this.NuberFlightLabel);
            this.panel1.Controls.Add(this.dateTimePicker2);
            this.panel1.Controls.Add(this.AerotechnicLabel);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.AddFlightBtn);
            this.panel1.Controls.Add(this.WeekdayLabel);
            this.panel1.Controls.Add(this.NumberFlightTB);
            this.panel1.Controls.Add(this.TimeInFlightTB);
            this.panel1.Controls.Add(this.AerotechnicCB);
            this.panel1.Controls.Add(this.TimeInFlightLabel);
            this.panel1.Controls.Add(this.DestinationLabel);
            this.panel1.Controls.Add(this.ArrivialTimeLabel);
            this.panel1.Controls.Add(this.DestinationCB);
            this.panel1.Controls.Add(this.DepartureTimeLabel);
            this.panel1.Location = new System.Drawing.Point(493, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 399);
            this.panel1.TabIndex = 26;
            // 
            // FlightDateTimePicker
            // 
            this.FlightDateTimePicker.Location = new System.Drawing.Point(8, 286);
            this.FlightDateTimePicker.Name = "FlightDateTimePicker";
            this.FlightDateTimePicker.Size = new System.Drawing.Size(406, 21);
            this.FlightDateTimePicker.TabIndex = 54;
            // 
            // NuberFlightLabel
            // 
            this.NuberFlightLabel.AutoSize = true;
            this.NuberFlightLabel.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.NuberFlightLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NuberFlightLabel.Location = new System.Drawing.Point(4, 12);
            this.NuberFlightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NuberFlightLabel.Name = "NuberFlightLabel";
            this.NuberFlightLabel.Size = new System.Drawing.Size(142, 20);
            this.NuberFlightLabel.TabIndex = 42;
            this.NuberFlightLabel.Text = "Номер авиарейса";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(8, 239);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(236, 21);
            this.dateTimePicker2.TabIndex = 53;
            // 
            // AerotechnicLabel
            // 
            this.AerotechnicLabel.AutoSize = true;
            this.AerotechnicLabel.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.AerotechnicLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.AerotechnicLabel.Location = new System.Drawing.Point(4, 63);
            this.AerotechnicLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AerotechnicLabel.Name = "AerotechnicLabel";
            this.AerotechnicLabel.Size = new System.Drawing.Size(75, 20);
            this.AerotechnicLabel.TabIndex = 40;
            this.AerotechnicLabel.Text = "Самолет";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(8, 189);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(236, 21);
            this.dateTimePicker1.TabIndex = 52;
            // 
            // AddFlightBtn
            // 
            this.AddFlightBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.AddFlightBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.AddFlightBtn.FlatAppearance.BorderSize = 0;
            this.AddFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFlightBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.AddFlightBtn.Location = new System.Drawing.Point(113, 318);
            this.AddFlightBtn.Name = "AddFlightBtn";
            this.AddFlightBtn.Size = new System.Drawing.Size(176, 32);
            this.AddFlightBtn.TabIndex = 41;
            this.AddFlightBtn.Text = "Добавить авиарейс";
            this.AddFlightBtn.UseVisualStyleBackColor = false;
            // 
            // WeekdayLabel
            // 
            this.WeekdayLabel.AutoSize = true;
            this.WeekdayLabel.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.WeekdayLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WeekdayLabel.Location = new System.Drawing.Point(4, 263);
            this.WeekdayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WeekdayLabel.Name = "WeekdayLabel";
            this.WeekdayLabel.Size = new System.Drawing.Size(127, 20);
            this.WeekdayLabel.TabIndex = 51;
            this.WeekdayLabel.Text = "Дата авиарейса";
            // 
            // NumberFlightTB
            // 
            this.NumberFlightTB.Location = new System.Drawing.Point(8, 35);
            this.NumberFlightTB.Name = "NumberFlightTB";
            this.NumberFlightTB.ReadOnly = true;
            this.NumberFlightTB.Size = new System.Drawing.Size(406, 21);
            this.NumberFlightTB.TabIndex = 43;
            // 
            // TimeInFlightTB
            // 
            this.TimeInFlightTB.Location = new System.Drawing.Point(260, 212);
            this.TimeInFlightTB.Name = "TimeInFlightTB";
            this.TimeInFlightTB.ReadOnly = true;
            this.TimeInFlightTB.Size = new System.Drawing.Size(154, 21);
            this.TimeInFlightTB.TabIndex = 50;
            // 
            // AerotechnicCB
            // 
            this.AerotechnicCB.FormattingEnabled = true;
            this.AerotechnicCB.Location = new System.Drawing.Point(8, 86);
            this.AerotechnicCB.Name = "AerotechnicCB";
            this.AerotechnicCB.Size = new System.Drawing.Size(406, 24);
            this.AerotechnicCB.TabIndex = 44;
            // 
            // TimeInFlightLabel
            // 
            this.TimeInFlightLabel.AutoSize = true;
            this.TimeInFlightLabel.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.TimeInFlightLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TimeInFlightLabel.Location = new System.Drawing.Point(286, 189);
            this.TimeInFlightLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TimeInFlightLabel.Name = "TimeInFlightLabel";
            this.TimeInFlightLabel.Size = new System.Drawing.Size(107, 20);
            this.TimeInFlightLabel.TabIndex = 49;
            this.TimeInFlightLabel.Text = "Время в пути";
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.DestinationLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DestinationLabel.Location = new System.Drawing.Point(4, 113);
            this.DestinationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(146, 20);
            this.DestinationLabel.TabIndex = 45;
            this.DestinationLabel.Text = "Пункт Назначения";
            // 
            // ArrivialTimeLabel
            // 
            this.ArrivialTimeLabel.AutoSize = true;
            this.ArrivialTimeLabel.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.ArrivialTimeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ArrivialTimeLabel.Location = new System.Drawing.Point(4, 213);
            this.ArrivialTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ArrivialTimeLabel.Name = "ArrivialTimeLabel";
            this.ArrivialTimeLabel.Size = new System.Drawing.Size(137, 20);
            this.ArrivialTimeLabel.TabIndex = 48;
            this.ArrivialTimeLabel.Text = "Время прибытия";
            // 
            // DestinationCB
            // 
            this.DestinationCB.FormattingEnabled = true;
            this.DestinationCB.Location = new System.Drawing.Point(8, 136);
            this.DestinationCB.Name = "DestinationCB";
            this.DestinationCB.Size = new System.Drawing.Size(406, 24);
            this.DestinationCB.TabIndex = 46;
            // 
            // DepartureTimeLabel
            // 
            this.DepartureTimeLabel.AutoSize = true;
            this.DepartureTimeLabel.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.DepartureTimeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DepartureTimeLabel.Location = new System.Drawing.Point(4, 163);
            this.DepartureTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DepartureTimeLabel.Name = "DepartureTimeLabel";
            this.DepartureTimeLabel.Size = new System.Drawing.Size(117, 20);
            this.DepartureTimeLabel.TabIndex = 47;
            this.DepartureTimeLabel.Text = "Время Вылета";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripButton,
            this.saveToolStripButton,
            this.editToolStripButton,
            this.removeToolStripButton,
            this.UnDoToolStripButton});
            this.toolStrip2.Location = new System.Drawing.Point(0, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(942, 25);
            this.toolStrip2.TabIndex = 27;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // createToolStripButton
            // 
            this.createToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.createToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("createToolStripButton.Image")));
            this.createToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.createToolStripButton.Name = "createToolStripButton";
            this.createToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.createToolStripButton.Text = "Создать";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "toolStripButton1";
            // 
            // editToolStripButton
            // 
            this.editToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripButton.Image")));
            this.editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolStripButton.Name = "editToolStripButton";
            this.editToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.editToolStripButton.Text = "Редактировать";
            // 
            // removeToolStripButton
            // 
            this.removeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("removeToolStripButton.Image")));
            this.removeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeToolStripButton.Name = "removeToolStripButton";
            this.removeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.removeToolStripButton.Text = "Удалить";
            // 
            // UnDoToolStripButton
            // 
            this.UnDoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnDoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("UnDoToolStripButton.Image")));
            this.UnDoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnDoToolStripButton.Name = "UnDoToolStripButton";
            this.UnDoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.UnDoToolStripButton.Text = "Назад";
            // 
            // ManagerAllFlightForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 561);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ManagerMenuStrip);
            this.Name = "ManagerAllFlightForm";
            this.Text = "Список всех авиарейсов";
            this.Load += new System.EventHandler(this.ManagerAllFlightForm_Load);
            this.Controls.SetChildIndex(this.ManagerMenuStrip, 0);
            this.Controls.SetChildIndex(this.ExitBtn, 0);
            this.Controls.SetChildIndex(this.NameLabel, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.toolStrip2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flightsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDBDataSet2)).EndInit();
            this.ManagerMenuStrip.ResumeLayout(false);
            this.ManagerMenuStrip.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip ManagerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяНаГлавнуюСтраницуМенеджераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьАвирейсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сформироватьОтчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьВыбранныйАвиарейсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбранныйРейсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пунктНазначенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеПToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеПунктаНазначенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameAerotechnicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKAeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKDestDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fKManagerDataGridViewTextBoxColumn;
        private AirlineDBDataSet2 airlineDBDataSet2;
        private System.Windows.Forms.BindingSource flightsBindingSource;
        private AirlineDBDataSet2TableAdapters.FlightsTableAdapter flightsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateFlightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeFlightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soldCountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivialTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker FlightDateTimePicker;
        private System.Windows.Forms.Label NuberFlightLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label AerotechnicLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button AddFlightBtn;
        private System.Windows.Forms.Label WeekdayLabel;
        private System.Windows.Forms.TextBox NumberFlightTB;
        private System.Windows.Forms.TextBox TimeInFlightTB;
        private System.Windows.Forms.ComboBox AerotechnicCB;
        private System.Windows.Forms.Label TimeInFlightLabel;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.Label ArrivialTimeLabel;
        private System.Windows.Forms.ComboBox DestinationCB;
        private System.Windows.Forms.Label DepartureTimeLabel;
        public System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton createToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton editToolStripButton;
        private System.Windows.Forms.ToolStripButton removeToolStripButton;
        private System.Windows.Forms.ToolStripButton UnDoToolStripButton;
    }
}