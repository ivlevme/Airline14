﻿namespace Airline14
{
    partial class ManagerDoneReportForm
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
            this.UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.AirlineDBDataSet2 = new Airline14.AirlineDBDataSet2();
            this.NameLabel = new System.Windows.Forms.Label();
            this.FirstDateLabel = new System.Windows.Forms.Label();
            this.LastDateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NumberFlight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountSoldTicket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResumeCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ManagerMenuStrip = new System.Windows.Forms.MenuStrip();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяНаГлавнуюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьАвирейсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрВсехАвиарейсовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пунктНазначенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеПToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавлениеПунктаНазначенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsTableAdapter1 = new Airline14.AirlineDBDataSet2TableAdapters.ReportsTableAdapter();
            this.TicketsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TicketsTableAdapter = new Airline14.AirlineDBDataSet2TableAdapters.TicketsTableAdapter();
            this.airlineDBDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.UsersTableAdapter = new Airline14.AirlineDBDataSet2TableAdapters.UsersTableAdapter();
            this.ticketsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirlineDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ManagerMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDBDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            // 
            // UsersBindingSource
            // 
            this.UsersBindingSource.DataMember = "Users";
            this.UsersBindingSource.DataSource = this.AirlineDBDataSet2;
            // 
            // AirlineDBDataSet2
            // 
            this.AirlineDBDataSet2.DataSetName = "AirlineDBDataSet2";
            this.AirlineDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Ubuntu", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(22, 52);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLabel.Size = new System.Drawing.Size(449, 41);
            this.NameLabel.TabIndex = 18;
            this.NameLabel.Text = "Сформированный отчет с";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FirstDateLabel
            // 
            this.FirstDateLabel.AutoSize = true;
            this.FirstDateLabel.Font = new System.Drawing.Font("Ubuntu", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstDateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FirstDateLabel.Location = new System.Drawing.Point(469, 52);
            this.FirstDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstDateLabel.Name = "FirstDateLabel";
            this.FirstDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FirstDateLabel.Size = new System.Drawing.Size(196, 41);
            this.FirstDateLabel.TabIndex = 19;
            this.FirstDateLabel.Text = "15.03.2020";
            this.FirstDateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LastDateLabel
            // 
            this.LastDateLabel.AutoSize = true;
            this.LastDateLabel.Font = new System.Drawing.Font("Ubuntu", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LastDateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LastDateLabel.Location = new System.Drawing.Point(712, 52);
            this.LastDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastDateLabel.Name = "LastDateLabel";
            this.LastDateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LastDateLabel.Size = new System.Drawing.Size(196, 41);
            this.LastDateLabel.TabIndex = 20;
            this.LastDateLabel.Text = "16.03.2020";
            this.LastDateLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Ubuntu", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(661, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(59, 41);
            this.label3.TabIndex = 21;
            this.label3.Text = "по";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumberFlight,
            this.CountSoldTicket,
            this.ResumeCost,
            this.Date});
            this.dataGridView1.Location = new System.Drawing.Point(29, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(890, 407);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // NumberFlight
            // 
            this.NumberFlight.HeaderText = "Номер рейса";
            this.NumberFlight.Name = "NumberFlight";
            this.NumberFlight.ReadOnly = true;
            // 
            // CountSoldTicket
            // 
            this.CountSoldTicket.HeaderText = "Количество проданных билетов";
            this.CountSoldTicket.Name = "CountSoldTicket";
            this.CountSoldTicket.ReadOnly = true;
            // 
            // ResumeCost
            // 
            this.ResumeCost.HeaderText = "Итоговая выручка";
            this.ResumeCost.Name = "ResumeCost";
            this.ResumeCost.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Дата продажи билетов";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // ManagerMenuStrip
            // 
            this.ManagerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаToolStripMenuItem,
            this.пользователиToolStripMenuItem,
            this.пунктНазначенияToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.ManagerMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ManagerMenuStrip.Name = "ManagerMenuStrip";
            this.ManagerMenuStrip.Size = new System.Drawing.Size(934, 24);
            this.ManagerMenuStrip.TabIndex = 23;
            this.ManagerMenuStrip.Text = "menuStrip1";
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вернутьсяНаГлавнуюToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.программаToolStripMenuItem.Text = "Программа";
            // 
            // вернутьсяНаГлавнуюToolStripMenuItem
            // 
            this.вернутьсяНаГлавнуюToolStripMenuItem.Name = "вернутьсяНаГлавнуюToolStripMenuItem";
            this.вернутьсяНаГлавнуюToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.вернутьсяНаГлавнуюToolStripMenuItem.Text = "Вернуться на главную страницу";
            this.вернутьсяНаГлавнуюToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяНаГлавнуюToolStripMenuItem_Click);
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
            this.просмотрВсехАвиарейсовToolStripMenuItem});
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.пользователиToolStripMenuItem.Text = "Авиарейсы";
            // 
            // создатьАвирейсToolStripMenuItem
            // 
            this.создатьАвирейсToolStripMenuItem.Name = "создатьАвирейсToolStripMenuItem";
            this.создатьАвирейсToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.создатьАвирейсToolStripMenuItem.Text = "Добавить авиарейс";
            this.создатьАвирейсToolStripMenuItem.Click += new System.EventHandler(this.создатьАвирейсToolStripMenuItem_Click);
            // 
            // просмотрВсехАвиарейсовToolStripMenuItem
            // 
            this.просмотрВсехАвиарейсовToolStripMenuItem.Name = "просмотрВсехАвиарейсовToolStripMenuItem";
            this.просмотрВсехАвиарейсовToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.просмотрВсехАвиарейсовToolStripMenuItem.Text = "Просмотреть все авиарейсы";
            this.просмотрВсехАвиарейсовToolStripMenuItem.Click += new System.EventHandler(this.просмотрВсехАвиарейсовToolStripMenuItem_Click);
            // 
            // пунктНазначенияToolStripMenuItem
            // 
            this.пунктНазначенияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.всеПToolStripMenuItem,
            this.добавлениеПунктаНазначенияToolStripMenuItem});
            this.пунктНазначенияToolStripMenuItem.Name = "пунктНазначенияToolStripMenuItem";
            this.пунктНазначенияToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.пунктНазначенияToolStripMenuItem.Text = "Пункты назначения";
            // 
            // всеПToolStripMenuItem
            // 
            this.всеПToolStripMenuItem.Name = "всеПToolStripMenuItem";
            this.всеПToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.всеПToolStripMenuItem.Text = "Просмотр всех пунктов назначения";
            this.всеПToolStripMenuItem.Click += new System.EventHandler(this.всеПToolStripMenuItem_Click);
            // 
            // добавлениеПунктаНазначенияToolStripMenuItem
            // 
            this.добавлениеПунктаНазначенияToolStripMenuItem.Name = "добавлениеПунктаНазначенияToolStripMenuItem";
            this.добавлениеПунктаНазначенияToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.добавлениеПунктаНазначенияToolStripMenuItem.Text = "Добавление пункта назначения";
            this.добавлениеПунктаНазначенияToolStripMenuItem.Click += new System.EventHandler(this.добавлениеПунктаНазначенияToolStripMenuItem_Click);
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
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // reportsTableAdapter1
            // 
            this.reportsTableAdapter1.ClearBeforeFill = true;
            // 
            // TicketsBindingSource
            // 
            this.TicketsBindingSource.DataMember = "Tickets";
            this.TicketsBindingSource.DataSource = this.AirlineDBDataSet2;
            // 
            // TicketsTableAdapter
            // 
            this.TicketsTableAdapter.ClearBeforeFill = true;
            // 
            // airlineDBDataSet2BindingSource
            // 
            this.airlineDBDataSet2BindingSource.DataSource = this.AirlineDBDataSet2;
            this.airlineDBDataSet2BindingSource.Position = 0;
            // 
            // ticketsBindingSource1
            // 
            this.ticketsBindingSource1.DataMember = "Tickets";
            this.ticketsBindingSource1.DataSource = this.AirlineDBDataSet2;
            // 
            // UsersTableAdapter
            // 
            this.UsersTableAdapter.ClearBeforeFill = true;
            // 
            // ticketsBindingSource2
            // 
            this.ticketsBindingSource2.DataMember = "Tickets";
            this.ticketsBindingSource2.DataSource = this.AirlineDBDataSet2;
            // 
            // ManagerDoneReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastDateLabel);
            this.Controls.Add(this.FirstDateLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ManagerMenuStrip);
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "ManagerDoneReportForm";
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.ManagerDoneReportForm_Load_1);
            this.Controls.SetChildIndex(this.ManagerMenuStrip, 0);
            this.Controls.SetChildIndex(this.ExitBtn, 0);
            this.Controls.SetChildIndex(this.NameLabel, 0);
            this.Controls.SetChildIndex(this.FirstDateLabel, 0);
            this.Controls.SetChildIndex(this.LastDateLabel, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AirlineDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ManagerMenuStrip.ResumeLayout(false);
            this.ManagerMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TicketsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineDBDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketsBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip ManagerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяНаГлавнуюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьАвирейсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрВсехАвиарейсовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пунктНазначенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеПToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавлениеПунктаНазначенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.Label FirstDateLabel;
        public System.Windows.Forms.Label LastDateLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberFlight;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountSoldTicket;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResumeCost;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private AirlineDBDataSet2TableAdapters.ReportsTableAdapter reportsTableAdapter1;
        private System.Windows.Forms.BindingSource TicketsBindingSource;
        private AirlineDBDataSet2 AirlineDBDataSet2;
        private AirlineDBDataSet2TableAdapters.TicketsTableAdapter TicketsTableAdapter;
        private System.Windows.Forms.BindingSource airlineDBDataSet2BindingSource;
        private System.Windows.Forms.BindingSource ticketsBindingSource1;
        private System.Windows.Forms.BindingSource UsersBindingSource;
        private AirlineDBDataSet2TableAdapters.UsersTableAdapter UsersTableAdapter;
        private System.Windows.Forms.BindingSource ticketsBindingSource2;
    }
}