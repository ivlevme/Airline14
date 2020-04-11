namespace Airline14
{
    partial class SalesmanAllTicketsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesmanAllTicketsForm));
            this.NameLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personalInformationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ticketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDBDataSet2 = new Airline14.AirlineDBDataSet2();
            this.EngineerMenuStrip = new System.Windows.Forms.MenuStrip();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяНаГлавнуюСтраницуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыбранныйБилетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авиарейсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьВсеАвиарейсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.currentIDrecord = new System.Windows.Forms.TextBox();
            this.FlightCB = new System.Windows.Forms.ComboBox();
            this.FlightLabel = new System.Windows.Forms.Label();
            this.AddNewClient = new System.Windows.Forms.Button();
            this.ClientCB = new System.Windows.Forms.ComboBox();
            this.ClientLabel = new System.Windows.Forms.Label();
            this.AddTicketBtn = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.createToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.removeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UnDoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.ticketsTableAdapter = new Airline14.AirlineDBDataSet2TableAdapters.TicketsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDBDataSet2)).BeginInit();
            this.EngineerMenuStrip.SuspendLayout();
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
            this.NameLabel.Location = new System.Drawing.Point(268, 59);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLabel.Size = new System.Drawing.Size(366, 41);
            this.NameLabel.TabIndex = 25;
            this.NameLabel.Text = "Список всех билетов";
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
            this.personalInformationDataGridViewTextBoxColumn,
            this.Date});
            this.dataGridView1.DataSource = this.ticketsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(494, 401);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // numberDataGridViewTextBoxColumn
            // 
            this.numberDataGridViewTextBoxColumn.DataPropertyName = "Number";
            this.numberDataGridViewTextBoxColumn.HeaderText = "Номер авиарейса";
            this.numberDataGridViewTextBoxColumn.Name = "numberDataGridViewTextBoxColumn";
            this.numberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personalInformationDataGridViewTextBoxColumn
            // 
            this.personalInformationDataGridViewTextBoxColumn.DataPropertyName = "Personal information";
            this.personalInformationDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.personalInformationDataGridViewTextBoxColumn.Name = "personalInformationDataGridViewTextBoxColumn";
            this.personalInformationDataGridViewTextBoxColumn.ReadOnly = true;
            this.personalInformationDataGridViewTextBoxColumn.Width = 250;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "Дата";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // ticketsBindingSource
            // 
            this.ticketsBindingSource.DataMember = "Tickets";
            this.ticketsBindingSource.DataSource = this.airlineDBDataSet2;
            // 
            // airlineDBDataSet2
            // 
            this.airlineDBDataSet2.DataSetName = "AirlineDBDataSet2";
            this.airlineDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EngineerMenuStrip
            // 
            this.EngineerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаToolStripMenuItem,
            this.пользователиToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.авиарейсыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.EngineerMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.EngineerMenuStrip.Name = "EngineerMenuStrip";
            this.EngineerMenuStrip.Size = new System.Drawing.Size(934, 24);
            this.EngineerMenuStrip.TabIndex = 26;
            this.EngineerMenuStrip.Text = "menuStrip1";
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вернутьсяНаГлавнуюСтраницуToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.программаToolStripMenuItem.Text = "Программа";
            // 
            // вернутьсяНаГлавнуюСтраницуToolStripMenuItem
            // 
            this.вернутьсяНаГлавнуюСтраницуToolStripMenuItem.Name = "вернутьсяНаГлавнуюСтраницуToolStripMenuItem";
            this.вернутьсяНаГлавнуюСтраницуToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.вернутьсяНаГлавнуюСтраницуToolStripMenuItem.Text = "Вернуться на главную страницу";
            this.вернутьсяНаГлавнуюСтраницуToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяНаГлавнуюСтраницуToolStripMenuItem_Click);
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
            this.createMenuToolStripMenuItem,
            this.editMenuToolStripMenuItem,
            this.удалитьВыбранныйБилетToolStripMenuItem});
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.пользователиToolStripMenuItem.Text = "Билеты";
            // 
            // createMenuToolStripMenuItem
            // 
            this.createMenuToolStripMenuItem.Name = "createMenuToolStripMenuItem";
            this.createMenuToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.createMenuToolStripMenuItem.Text = "Добавить проданный билет";
            this.createMenuToolStripMenuItem.Click += new System.EventHandler(this.createMenuToolStripMenuItem_Click);
            // 
            // editMenuToolStripMenuItem
            // 
            this.editMenuToolStripMenuItem.Name = "editMenuToolStripMenuItem";
            this.editMenuToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.editMenuToolStripMenuItem.Text = "Редактировать выбранный билет";
            this.editMenuToolStripMenuItem.Click += new System.EventHandler(this.editMenuToolStripMenuItem_Click);
            // 
            // удалитьВыбранныйБилетToolStripMenuItem
            // 
            this.удалитьВыбранныйБилетToolStripMenuItem.Name = "удалитьВыбранныйБилетToolStripMenuItem";
            this.удалитьВыбранныйБилетToolStripMenuItem.Size = new System.Drawing.Size(257, 22);
            this.удалитьВыбранныйБилетToolStripMenuItem.Text = "Удалить выбранный билет";
            this.удалитьВыбранныйБилетToolStripMenuItem.Click += new System.EventHandler(this.удалитьВыбранныйБилетToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списрToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.отчетыToolStripMenuItem.Text = "Клиенты";
            // 
            // списрToolStripMenuItem
            // 
            this.списрToolStripMenuItem.Name = "списрToolStripMenuItem";
            this.списрToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.списрToolStripMenuItem.Text = "Посмотреть всех клиентов";
            this.списрToolStripMenuItem.Click += new System.EventHandler(this.списрToolStripMenuItem_Click);
            // 
            // авиарейсыToolStripMenuItem
            // 
            this.авиарейсыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотретьВсеАвиарейсыToolStripMenuItem});
            this.авиарейсыToolStripMenuItem.Name = "авиарейсыToolStripMenuItem";
            this.авиарейсыToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.авиарейсыToolStripMenuItem.Text = "Авиарейсы";
            // 
            // просмотретьВсеАвиарейсыToolStripMenuItem
            // 
            this.просмотретьВсеАвиарейсыToolStripMenuItem.Name = "просмотретьВсеАвиарейсыToolStripMenuItem";
            this.просмотретьВсеАвиарейсыToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.просмотретьВсеАвиарейсыToolStripMenuItem.Text = "Просмотреть все авиарейсы";
            this.просмотретьВсеАвиарейсыToolStripMenuItem.Click += new System.EventHandler(this.просмотретьВсеАвиарейсыToolStripMenuItem_Click);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.editToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createToolStripMenuItem.Text = "Создать";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItem.Text = "Редактировать";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.currentIDrecord);
            this.panel1.Controls.Add(this.FlightCB);
            this.panel1.Controls.Add(this.FlightLabel);
            this.panel1.Controls.Add(this.AddNewClient);
            this.panel1.Controls.Add(this.ClientCB);
            this.panel1.Controls.Add(this.ClientLabel);
            this.panel1.Controls.Add(this.AddTicketBtn);
            this.panel1.Location = new System.Drawing.Point(512, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 401);
            this.panel1.TabIndex = 28;
            // 
            // currentIDrecord
            // 
            this.currentIDrecord.Location = new System.Drawing.Point(292, 225);
            this.currentIDrecord.Name = "currentIDrecord";
            this.currentIDrecord.Size = new System.Drawing.Size(100, 21);
            this.currentIDrecord.TabIndex = 31;
            this.currentIDrecord.Visible = false;
            // 
            // FlightCB
            // 
            this.FlightCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FlightCB.FormattingEnabled = true;
            this.FlightCB.Location = new System.Drawing.Point(19, 93);
            this.FlightCB.Name = "FlightCB";
            this.FlightCB.Size = new System.Drawing.Size(255, 24);
            this.FlightCB.TabIndex = 30;
            // 
            // FlightLabel
            // 
            this.FlightLabel.AutoSize = true;
            this.FlightLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FlightLabel.Location = new System.Drawing.Point(16, 74);
            this.FlightLabel.Name = "FlightLabel";
            this.FlightLabel.Size = new System.Drawing.Size(36, 16);
            this.FlightLabel.TabIndex = 29;
            this.FlightLabel.Text = "Рейс";
            // 
            // AddNewClient
            // 
            this.AddNewClient.BackColor = System.Drawing.Color.Gold;
            this.AddNewClient.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.AddNewClient.FlatAppearance.BorderSize = 0;
            this.AddNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddNewClient.Location = new System.Drawing.Point(280, 22);
            this.AddNewClient.Name = "AddNewClient";
            this.AddNewClient.Size = new System.Drawing.Size(124, 53);
            this.AddNewClient.TabIndex = 28;
            this.AddNewClient.Text = "Добавить нового клиента";
            this.AddNewClient.UseVisualStyleBackColor = false;
            this.AddNewClient.Click += new System.EventHandler(this.AddNewClient_Click);
            // 
            // ClientCB
            // 
            this.ClientCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClientCB.FormattingEnabled = true;
            this.ClientCB.Location = new System.Drawing.Point(19, 37);
            this.ClientCB.Name = "ClientCB";
            this.ClientCB.Size = new System.Drawing.Size(255, 24);
            this.ClientCB.TabIndex = 27;
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientLabel.Location = new System.Drawing.Point(16, 18);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(49, 16);
            this.ClientLabel.TabIndex = 26;
            this.ClientLabel.Text = "Клиент";
            // 
            // AddTicketBtn
            // 
            this.AddTicketBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.AddTicketBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.AddTicketBtn.FlatAppearance.BorderSize = 0;
            this.AddTicketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTicketBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.AddTicketBtn.Location = new System.Drawing.Point(53, 147);
            this.AddTicketBtn.Name = "AddTicketBtn";
            this.AddTicketBtn.Size = new System.Drawing.Size(176, 32);
            this.AddTicketBtn.TabIndex = 25;
            this.AddTicketBtn.Text = "Добавить билет";
            this.AddTicketBtn.UseVisualStyleBackColor = false;
            this.AddTicketBtn.Click += new System.EventHandler(this.AddTicketBtn_Click);
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
            this.toolStrip2.Size = new System.Drawing.Size(934, 25);
            this.toolStrip2.TabIndex = 29;
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
            this.createToolStripButton.Click += new System.EventHandler(this.createToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "toolStripButton1";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // editToolStripButton
            // 
            this.editToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.editToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripButton.Image")));
            this.editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolStripButton.Name = "editToolStripButton";
            this.editToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.editToolStripButton.Text = "Редактировать";
            this.editToolStripButton.Click += new System.EventHandler(this.editToolStripButton_Click);
            // 
            // removeToolStripButton
            // 
            this.removeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.removeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("removeToolStripButton.Image")));
            this.removeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeToolStripButton.Name = "removeToolStripButton";
            this.removeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.removeToolStripButton.Text = "Удалить";
            this.removeToolStripButton.Click += new System.EventHandler(this.removeToolStripButton_Click);
            // 
            // UnDoToolStripButton
            // 
            this.UnDoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnDoToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("UnDoToolStripButton.Image")));
            this.UnDoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnDoToolStripButton.Name = "UnDoToolStripButton";
            this.UnDoToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.UnDoToolStripButton.Text = "Назад";
            this.UnDoToolStripButton.Click += new System.EventHandler(this.UnDoToolStripButton_Click);
            // 
            // ticketsTableAdapter
            // 
            this.ticketsTableAdapter.ClearBeforeFill = true;
            // 
            // SalesmanAllTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.EngineerMenuStrip);
            this.Name = "SalesmanAllTicketsForm";
            this.Text = "Список всех билетов";
            this.Load += new System.EventHandler(this.SalesmanAllTicketsForm_Load);
            this.Controls.SetChildIndex(this.EngineerMenuStrip, 0);
            this.Controls.SetChildIndex(this.ExitBtn, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.NameLabel, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.toolStrip2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDBDataSet2)).EndInit();
            this.EngineerMenuStrip.ResumeLayout(false);
            this.EngineerMenuStrip.PerformLayout();
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
        private System.Windows.Forms.MenuStrip EngineerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяНаГлавнуюСтраницуToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private AirlineDBDataSet2 airlineDBDataSet2;
        private System.Windows.Forms.BindingSource ticketsBindingSource;
        private AirlineDBDataSet2TableAdapters.TicketsTableAdapter ticketsTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem авиарейсыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьВсеАвиарейсыToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox FlightCB;
        private System.Windows.Forms.Label FlightLabel;
        private System.Windows.Forms.Button AddNewClient;
        private System.Windows.Forms.ComboBox ClientCB;
        private System.Windows.Forms.Label ClientLabel;
        private System.Windows.Forms.Button AddTicketBtn;
        public System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton createToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton editToolStripButton;
        private System.Windows.Forms.ToolStripButton removeToolStripButton;
        private System.Windows.Forms.ToolStripButton UnDoToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalInformationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.ToolStripMenuItem editMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбранныйБилетToolStripMenuItem;
        private System.Windows.Forms.TextBox currentIDrecord;
    }
}