namespace Airline14
{
    partial class EngineerAllReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EngineerAllReportsForm));
            this.NameLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlineDBDataSet2 = new Airline14.AirlineDBDataSet2();
            this.EngineerMenuStrip = new System.Windows.Forms.MenuStrip();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяНаГлавнуюСтраницуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRepoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аэротехникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокВсейАэротехнкикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsTableAdapter = new Airline14.AirlineDBDataSet2TableAdapters.ReportsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DateTimeTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IDReportTB = new System.Windows.Forms.TextBox();
            this.ContentReportTB = new System.Windows.Forms.TextBox();
            this.DateReport = new System.Windows.Forms.Label();
            this.ContentReportLabel = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.UnDoToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsBindingSource)).BeginInit();
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
            this.NameLabel.Location = new System.Drawing.Point(152, 56);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLabel.Size = new System.Drawing.Size(639, 41);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Все отчеты о состоянии аэротехники";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dateDataGridViewTextBoxColumn,
            this.contentDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reportsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(72, 100);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(343, 404);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contentDataGridViewTextBoxColumn
            // 
            this.contentDataGridViewTextBoxColumn.DataPropertyName = "Content";
            this.contentDataGridViewTextBoxColumn.HeaderText = "Содержание";
            this.contentDataGridViewTextBoxColumn.Name = "contentDataGridViewTextBoxColumn";
            this.contentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Инженер";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // reportsBindingSource
            // 
            this.reportsBindingSource.DataMember = "Reports";
            this.reportsBindingSource.DataSource = this.airlineDBDataSet2;
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
            this.аэротехникаToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.EngineerMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.EngineerMenuStrip.Name = "EngineerMenuStrip";
            this.EngineerMenuStrip.Size = new System.Drawing.Size(934, 24);
            this.EngineerMenuStrip.TabIndex = 15;
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
            this.editRepoToolStripMenuItem});
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.пользователиToolStripMenuItem.Text = "Отчеты";
            // 
            // editRepoToolStripMenuItem
            // 
            this.editRepoToolStripMenuItem.Name = "editRepoToolStripMenuItem";
            this.editRepoToolStripMenuItem.Size = new System.Drawing.Size(273, 22);
            this.editRepoToolStripMenuItem.Text = "Редактирование выбранного отчета";
            this.editRepoToolStripMenuItem.Click += new System.EventHandler(this.editRepoToolStripMenuItem_Click);
            // 
            // аэротехникаToolStripMenuItem
            // 
            this.аэротехникаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокВсейАэротехнкикиToolStripMenuItem});
            this.аэротехникаToolStripMenuItem.Name = "аэротехникаToolStripMenuItem";
            this.аэротехникаToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.аэротехникаToolStripMenuItem.Text = "Аэротехника";
            // 
            // списокВсейАэротехнкикиToolStripMenuItem
            // 
            this.списокВсейАэротехнкикиToolStripMenuItem.Name = "списокВсейАэротехнкикиToolStripMenuItem";
            this.списокВсейАэротехнкикиToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.списокВсейАэротехнкикиToolStripMenuItem.Text = "Список всей аэротехнкики";
            this.списокВсейАэротехнкикиToolStripMenuItem.Click += new System.EventHandler(this.списокВсейАэротехнкикиToolStripMenuItem_Click);
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
            this.editReportToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(155, 26);
            // 
            // editReportToolStripMenuItem
            // 
            this.editReportToolStripMenuItem.Name = "editReportToolStripMenuItem";
            this.editReportToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.editReportToolStripMenuItem.Text = "Редактировать";
            // 
            // reportsTableAdapter
            // 
            this.reportsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DateTimeTB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.IDReportTB);
            this.panel1.Controls.Add(this.ContentReportTB);
            this.panel1.Controls.Add(this.DateReport);
            this.panel1.Controls.Add(this.ContentReportLabel);
            this.panel1.Location = new System.Drawing.Point(438, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 404);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // DateTimeTB
            // 
            this.DateTimeTB.Location = new System.Drawing.Point(137, 99);
            this.DateTimeTB.Name = "DateTimeTB";
            this.DateTimeTB.ReadOnly = true;
            this.DateTimeTB.Size = new System.Drawing.Size(256, 21);
            this.DateTimeTB.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(134, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Идентификатор отчета";
            // 
            // IDReportTB
            // 
            this.IDReportTB.Location = new System.Drawing.Point(137, 44);
            this.IDReportTB.Name = "IDReportTB";
            this.IDReportTB.ReadOnly = true;
            this.IDReportTB.Size = new System.Drawing.Size(256, 21);
            this.IDReportTB.TabIndex = 34;
            // 
            // ContentReportTB
            // 
            this.ContentReportTB.Location = new System.Drawing.Point(137, 156);
            this.ContentReportTB.Name = "ContentReportTB";
            this.ContentReportTB.Size = new System.Drawing.Size(256, 21);
            this.ContentReportTB.TabIndex = 37;
            // 
            // DateReport
            // 
            this.DateReport.AutoSize = true;
            this.DateReport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DateReport.Location = new System.Drawing.Point(134, 80);
            this.DateReport.Name = "DateReport";
            this.DateReport.Size = new System.Drawing.Size(75, 16);
            this.DateReport.TabIndex = 35;
            this.DateReport.Text = "Дата Отчета";
            // 
            // ContentReportLabel
            // 
            this.ContentReportLabel.AutoSize = true;
            this.ContentReportLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ContentReportLabel.Location = new System.Drawing.Point(134, 137);
            this.ContentReportLabel.Name = "ContentReportLabel";
            this.ContentReportLabel.Size = new System.Drawing.Size(119, 16);
            this.ContentReportLabel.TabIndex = 36;
            this.ContentReportLabel.Text = "Содержание отчета";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripButton,
            this.editToolStripButton,
            this.UnDoToolStripButton});
            this.toolStrip2.Location = new System.Drawing.Point(0, 24);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(934, 25);
            this.toolStrip2.TabIndex = 20;
            this.toolStrip2.Text = "toolStrip2";
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
            // EngineerAllReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.EngineerMenuStrip);
            this.Name = "EngineerAllReportsForm";
            this.Text = "Все отчеты о состоянии авиатехники";
            this.Load += new System.EventHandler(this.EngineerAllReportsForm_Load);
            this.Controls.SetChildIndex(this.EngineerMenuStrip, 0);
            this.Controls.SetChildIndex(this.NameLabel, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.ExitBtn, 0);
            this.Controls.SetChildIndex(this.toolStrip2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportsBindingSource)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem вернутьсяНаГлавнуюСтраницуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRepoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аэротехникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокВсейАэротехнкикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editReportToolStripMenuItem;
        private AirlineDBDataSet2 airlineDBDataSet2;
        private System.Windows.Forms.BindingSource reportsBindingSource;
        private AirlineDBDataSet2TableAdapters.ReportsTableAdapter reportsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox DateTimeTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDReportTB;
        private System.Windows.Forms.TextBox ContentReportTB;
        private System.Windows.Forms.Label DateReport;
        private System.Windows.Forms.Label ContentReportLabel;
        public System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton editToolStripButton;
        private System.Windows.Forms.ToolStripButton UnDoToolStripButton;
    }
}