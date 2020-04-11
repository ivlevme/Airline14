namespace Airline14
{

    partial class SalesmanAllUsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesmanAllUsersForm));
            this.EngineerMenuStrip = new System.Windows.Forms.MenuStrip();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяНаГлавнуюСтраницуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрВсехАвиарейсовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыбранногоКлиентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авиарейсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьВсеАвиарейсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NameLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.personalInformationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passportInformationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDBDataSet2 = new Airline14.AirlineDBDataSet2();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.passengersTableAdapter = new Airline14.AirlineDBDataSet2TableAdapters.PassengersTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.currentIDReport = new System.Windows.Forms.TextBox();
            this.PassportTB = new System.Windows.Forms.TextBox();
            this.FioTB = new System.Windows.Forms.TextBox();
            this.PassportLabel = new System.Windows.Forms.Label();
            this.FioLabel = new System.Windows.Forms.Label();
            this.AddClientBtn = new System.Windows.Forms.Button();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.createToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.removeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UnDoToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.EngineerMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDBDataSet2)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
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
            this.EngineerMenuStrip.TabIndex = 21;
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
            this.просмотрВсехАвиарейсовToolStripMenuItem});
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.пользователиToolStripMenuItem.Text = "Билеты";
            // 
            // просмотрВсехАвиарейсовToolStripMenuItem
            // 
            this.просмотрВсехАвиарейсовToolStripMenuItem.Name = "просмотрВсехАвиарейсовToolStripMenuItem";
            this.просмотрВсехАвиарейсовToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.просмотрВсехАвиарейсовToolStripMenuItem.Text = "Просмотреть все билеты";
            this.просмотрВсехАвиарейсовToolStripMenuItem.Click += new System.EventHandler(this.просмотрВсехАвиарейсовToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserMenuToolStripMenuItem,
            this.editUserMenuToolStripMenuItem,
            this.удалитьВыбранногоКлиентаToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.отчетыToolStripMenuItem.Text = "Клиенты";
            // 
            // createUserMenuToolStripMenuItem
            // 
            this.createUserMenuToolStripMenuItem.Name = "createUserMenuToolStripMenuItem";
            this.createUserMenuToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.createUserMenuToolStripMenuItem.Text = "Добавить нового клиента";
            this.createUserMenuToolStripMenuItem.Click += new System.EventHandler(this.createUserMenuToolStripMenuItem_Click);
            // 
            // editUserMenuToolStripMenuItem
            // 
            this.editUserMenuToolStripMenuItem.Name = "editUserMenuToolStripMenuItem";
            this.editUserMenuToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.editUserMenuToolStripMenuItem.Text = "Редактировать выбранного клиента";
            this.editUserMenuToolStripMenuItem.Click += new System.EventHandler(this.editUserMenuToolStripMenuItem_Click);
            // 
            // удалитьВыбранногоКлиентаToolStripMenuItem
            // 
            this.удалитьВыбранногоКлиентаToolStripMenuItem.Name = "удалитьВыбранногоКлиентаToolStripMenuItem";
            this.удалитьВыбранногоКлиентаToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.удалитьВыбранногоКлиентаToolStripMenuItem.Text = "Удалить выбранного клиента";
            this.удалитьВыбранногоКлиентаToolStripMenuItem.Click += new System.EventHandler(this.удалитьВыбранногоКлиентаToolStripMenuItem_Click);
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
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Ubuntu", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(268, 55);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLabel.Size = new System.Drawing.Size(386, 41);
            this.NameLabel.TabIndex = 23;
            this.NameLabel.Text = "Список всех клиентов";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.personalInformationDataGridViewTextBoxColumn,
            this.passportInformationDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.passengersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 99);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(393, 405);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // personalInformationDataGridViewTextBoxColumn
            // 
            this.personalInformationDataGridViewTextBoxColumn.DataPropertyName = "Personal information";
            this.personalInformationDataGridViewTextBoxColumn.HeaderText = "Фамилия Имя Отчество";
            this.personalInformationDataGridViewTextBoxColumn.Name = "personalInformationDataGridViewTextBoxColumn";
            this.personalInformationDataGridViewTextBoxColumn.ReadOnly = true;
            this.personalInformationDataGridViewTextBoxColumn.Width = 250;
            // 
            // passportInformationDataGridViewTextBoxColumn
            // 
            this.passportInformationDataGridViewTextBoxColumn.DataPropertyName = "Passport information";
            this.passportInformationDataGridViewTextBoxColumn.HeaderText = "Паспортные данные";
            this.passportInformationDataGridViewTextBoxColumn.Name = "passportInformationDataGridViewTextBoxColumn";
            this.passportInformationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passengersBindingSource
            // 
            this.passengersBindingSource.DataMember = "Passengers";
            this.passengersBindingSource.DataSource = this.airlineDBDataSet2;
            // 
            // airlineDBDataSet2
            // 
            this.airlineDBDataSet2.DataSetName = "AirlineDBDataSet2";
            this.airlineDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.editUserToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 70);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.createToolStripMenuItem.Text = "Создать";
            this.createToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // editUserToolStripMenuItem
            // 
            this.editUserToolStripMenuItem.Name = "editUserToolStripMenuItem";
            this.editUserToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editUserToolStripMenuItem.Text = "Редактировать";
            this.editUserToolStripMenuItem.Click += new System.EventHandler(this.editUserToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // passengersTableAdapter
            // 
            this.passengersTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.currentIDReport);
            this.panel1.Controls.Add(this.PassportTB);
            this.panel1.Controls.Add(this.FioTB);
            this.panel1.Controls.Add(this.PassportLabel);
            this.panel1.Controls.Add(this.FioLabel);
            this.panel1.Controls.Add(this.AddClientBtn);
            this.panel1.Location = new System.Drawing.Point(411, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 405);
            this.panel1.TabIndex = 25;
            // 
            // currentIDReport
            // 
            this.currentIDReport.Location = new System.Drawing.Point(398, 240);
            this.currentIDReport.Name = "currentIDReport";
            this.currentIDReport.Size = new System.Drawing.Size(100, 21);
            this.currentIDReport.TabIndex = 40;
            this.currentIDReport.Visible = false;
            // 
            // PassportTB
            // 
            this.PassportTB.Location = new System.Drawing.Point(117, 82);
            this.PassportTB.Name = "PassportTB";
            this.PassportTB.Size = new System.Drawing.Size(291, 21);
            this.PassportTB.TabIndex = 39;
            // 
            // FioTB
            // 
            this.FioTB.Location = new System.Drawing.Point(117, 26);
            this.FioTB.Name = "FioTB";
            this.FioTB.Size = new System.Drawing.Size(291, 21);
            this.FioTB.TabIndex = 38;
            // 
            // PassportLabel
            // 
            this.PassportLabel.AutoSize = true;
            this.PassportLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PassportLabel.Location = new System.Drawing.Point(114, 63);
            this.PassportLabel.Name = "PassportLabel";
            this.PassportLabel.Size = new System.Drawing.Size(124, 16);
            this.PassportLabel.TabIndex = 37;
            this.PassportLabel.Text = "Паспортные данные";
            // 
            // FioLabel
            // 
            this.FioLabel.AutoSize = true;
            this.FioLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FioLabel.Location = new System.Drawing.Point(114, 7);
            this.FioLabel.Name = "FioLabel";
            this.FioLabel.Size = new System.Drawing.Size(37, 16);
            this.FioLabel.TabIndex = 36;
            this.FioLabel.Text = "ФИО";
            // 
            // AddClientBtn
            // 
            this.AddClientBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.AddClientBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.AddClientBtn.FlatAppearance.BorderSize = 0;
            this.AddClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddClientBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.AddClientBtn.Location = new System.Drawing.Point(168, 131);
            this.AddClientBtn.Name = "AddClientBtn";
            this.AddClientBtn.Size = new System.Drawing.Size(176, 32);
            this.AddClientBtn.TabIndex = 35;
            this.AddClientBtn.Text = "Добавить клиента";
            this.AddClientBtn.UseVisualStyleBackColor = false;
            this.AddClientBtn.Click += new System.EventHandler(this.AddClientBtn_Click);
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
            this.toolStrip2.TabIndex = 26;
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
            // SalesmanAllUsersForm
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
            this.Name = "SalesmanAllUsersForm";
            this.Text = "Список всех клиентов";
            this.Load += new System.EventHandler(this.SalesmanAllUsersForm_Load);
            this.Controls.SetChildIndex(this.EngineerMenuStrip, 0);
            this.Controls.SetChildIndex(this.ExitBtn, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.NameLabel, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.toolStrip2, 0);
            this.EngineerMenuStrip.ResumeLayout(false);
            this.EngineerMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passengersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDBDataSet2)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip EngineerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрВсехАвиарейсовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createUserMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem editUserMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбранногоКлиентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяНаГлавнуюСтраницуToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private AirlineDBDataSet2 airlineDBDataSet2;
        private System.Windows.Forms.BindingSource passengersBindingSource;
        private AirlineDBDataSet2TableAdapters.PassengersTableAdapter passengersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalInformationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportInformationDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem авиарейсыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьВсеАвиарейсыToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox PassportTB;
        private System.Windows.Forms.TextBox FioTB;
        private System.Windows.Forms.Label PassportLabel;
        private System.Windows.Forms.Label FioLabel;
        private System.Windows.Forms.Button AddClientBtn;
        public System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton createToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton editToolStripButton;
        private System.Windows.Forms.ToolStripButton removeToolStripButton;
        private System.Windows.Forms.ToolStripButton UnDoToolStripButton;
        private System.Windows.Forms.TextBox currentIDReport;
    }
}