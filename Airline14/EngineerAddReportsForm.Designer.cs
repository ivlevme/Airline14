namespace Airline14
{
    partial class EngineerAddReportsForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDReportTB = new System.Windows.Forms.TextBox();
            this.DateReport = new System.Windows.Forms.Label();
            this.ReportDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ContentReportTB = new System.Windows.Forms.TextBox();
            this.ContentReportLabel = new System.Windows.Forms.Label();
            this.AddReportBtn = new System.Windows.Forms.Button();
            this.EngineerMenuStrip = new System.Windows.Forms.MenuStrip();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяНаГлавнуюСтраницуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрВсехПользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аэротехникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокВсейАэротехнкикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыАэротехнкикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТипАэротехнкикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокВсехТиповАэротехникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EngineerMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Ubuntu", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(90, 21);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLabel.Size = new System.Drawing.Size(777, 41);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "Добавление отчета о состоянии авиатехники";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Идентификатор отчета";
            // 
            // IDReportTB
            // 
            this.IDReportTB.Location = new System.Drawing.Point(341, 107);
            this.IDReportTB.Name = "IDReportTB";
            this.IDReportTB.ReadOnly = true;
            this.IDReportTB.Size = new System.Drawing.Size(256, 21);
            this.IDReportTB.TabIndex = 5;
            // 
            // DateReport
            // 
            this.DateReport.AutoSize = true;
            this.DateReport.Location = new System.Drawing.Point(338, 143);
            this.DateReport.Name = "DateReport";
            this.DateReport.Size = new System.Drawing.Size(75, 16);
            this.DateReport.TabIndex = 6;
            this.DateReport.Text = "Дата Отчета";
            // 
            // ReportDateTimePicker
            // 
            this.ReportDateTimePicker.Location = new System.Drawing.Point(341, 162);
            this.ReportDateTimePicker.Name = "ReportDateTimePicker";
            this.ReportDateTimePicker.Size = new System.Drawing.Size(256, 21);
            this.ReportDateTimePicker.TabIndex = 7;
            // 
            // ContentReportTB
            // 
            this.ContentReportTB.Location = new System.Drawing.Point(341, 219);
            this.ContentReportTB.Name = "ContentReportTB";
            this.ContentReportTB.ReadOnly = true;
            this.ContentReportTB.Size = new System.Drawing.Size(256, 21);
            this.ContentReportTB.TabIndex = 9;
            // 
            // ContentReportLabel
            // 
            this.ContentReportLabel.AutoSize = true;
            this.ContentReportLabel.Location = new System.Drawing.Point(338, 200);
            this.ContentReportLabel.Name = "ContentReportLabel";
            this.ContentReportLabel.Size = new System.Drawing.Size(119, 16);
            this.ContentReportLabel.TabIndex = 8;
            this.ContentReportLabel.Text = "Содержание отчета";
            // 
            // AddReportBtn
            // 
            this.AddReportBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.AddReportBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.AddReportBtn.FlatAppearance.BorderSize = 0;
            this.AddReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddReportBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.AddReportBtn.Location = new System.Drawing.Point(373, 264);
            this.AddReportBtn.Name = "AddReportBtn";
            this.AddReportBtn.Size = new System.Drawing.Size(176, 32);
            this.AddReportBtn.TabIndex = 11;
            this.AddReportBtn.Text = "Добавить отчет";
            this.AddReportBtn.UseVisualStyleBackColor = false;
            // 
            // EngineerMenuStrip
            // 
            this.EngineerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаToolStripMenuItem,
            this.пользователиToolStripMenuItem,
            this.аэротехникаToolStripMenuItem,
            this.типыАэротехнкикиToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.EngineerMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.EngineerMenuStrip.Name = "EngineerMenuStrip";
            this.EngineerMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.EngineerMenuStrip.Size = new System.Drawing.Size(934, 24);
            this.EngineerMenuStrip.TabIndex = 31;
            this.EngineerMenuStrip.Text = "menuStrip1";
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вернутьсяНаГлавнуюСтраницуToolStripMenuItem,
            this.обновитьToolStripMenuItem,
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
            this.просмотрВсехПользователейToolStripMenuItem});
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.пользователиToolStripMenuItem.Text = "Отчеты";
            // 
            // просмотрВсехПользователейToolStripMenuItem
            // 
            this.просмотрВсехПользователейToolStripMenuItem.Name = "просмотрВсехПользователейToolStripMenuItem";
            this.просмотрВсехПользователейToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.просмотрВсехПользователейToolStripMenuItem.Text = "Просмотр всех отчетов";
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
            // 
            // типыАэротехнкикиToolStripMenuItem
            // 
            this.типыАэротехнкикиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьТипАэротехнкикиToolStripMenuItem,
            this.списокВсехТиповАэротехникиToolStripMenuItem});
            this.типыАэротехнкикиToolStripMenuItem.Name = "типыАэротехнкикиToolStripMenuItem";
            this.типыАэротехнкикиToolStripMenuItem.Size = new System.Drawing.Size(129, 20);
            this.типыАэротехнкикиToolStripMenuItem.Text = "Типы Аэротехнкики";
            // 
            // добавитьТипАэротехнкикиToolStripMenuItem
            // 
            this.добавитьТипАэротехнкикиToolStripMenuItem.Name = "добавитьТипАэротехнкикиToolStripMenuItem";
            this.добавитьТипАэротехнкикиToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.добавитьТипАэротехнкикиToolStripMenuItem.Text = "Добавить тип аэротехнкики";
            // 
            // списокВсехТиповАэротехникиToolStripMenuItem
            // 
            this.списокВсехТиповАэротехникиToolStripMenuItem.Name = "списокВсехТиповАэротехникиToolStripMenuItem";
            this.списокВсехТиповАэротехникиToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.списокВсехТиповАэротехникиToolStripMenuItem.Text = "Список всех типов аэротехники";
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
            // EngineerAddReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.EngineerMenuStrip);
            this.Controls.Add(this.AddReportBtn);
            this.Controls.Add(this.ContentReportTB);
            this.Controls.Add(this.ContentReportLabel);
            this.Controls.Add(this.ReportDateTimePicker);
            this.Controls.Add(this.DateReport);
            this.Controls.Add(this.IDReportTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameLabel);
            this.Name = "EngineerAddReportsForm";
            this.Text = "Добавление отчета";
            this.Controls.SetChildIndex(this.NameLabel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.IDReportTB, 0);
            this.Controls.SetChildIndex(this.DateReport, 0);
            this.Controls.SetChildIndex(this.ReportDateTimePicker, 0);
            this.Controls.SetChildIndex(this.ContentReportLabel, 0);
            this.Controls.SetChildIndex(this.ContentReportTB, 0);
            this.Controls.SetChildIndex(this.AddReportBtn, 0);
            this.Controls.SetChildIndex(this.EngineerMenuStrip, 0);
            this.EngineerMenuStrip.ResumeLayout(false);
            this.EngineerMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IDReportTB;
        private System.Windows.Forms.Label DateReport;
        private System.Windows.Forms.DateTimePicker ReportDateTimePicker;
        private System.Windows.Forms.TextBox ContentReportTB;
        private System.Windows.Forms.Label ContentReportLabel;
        private System.Windows.Forms.Button AddReportBtn;
        private System.Windows.Forms.MenuStrip EngineerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяНаГлавнуюСтраницуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрВсехПользователейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аэротехникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокВсейАэротехнкикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыАэротехнкикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьТипАэротехнкикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокВсехТиповАэротехникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
    }
}