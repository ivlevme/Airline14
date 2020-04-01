namespace Airline14
{
    partial class EngineerAddAerotechnicsForm
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
            this.AddReportBtn = new System.Windows.Forms.Button();
            this.NameAerotechnicTB = new System.Windows.Forms.TextBox();
            this.NameAerotechnicLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.AirplaneTypeCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CapacityTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CrewTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EngineerMenuStrip = new System.Windows.Forms.MenuStrip();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяНаГлавнуюСтраницуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрВсехПользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьНовогоПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аэротехникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокВсейАэротехнкикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EngineerMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            // 
            // AddReportBtn
            // 
            this.AddReportBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.AddReportBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.AddReportBtn.FlatAppearance.BorderSize = 0;
            this.AddReportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddReportBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.AddReportBtn.Location = new System.Drawing.Point(392, 292);
            this.AddReportBtn.Name = "AddReportBtn";
            this.AddReportBtn.Size = new System.Drawing.Size(176, 32);
            this.AddReportBtn.TabIndex = 19;
            this.AddReportBtn.Text = "Добавить аэротехнику";
            this.AddReportBtn.UseVisualStyleBackColor = false;
            this.AddReportBtn.Click += new System.EventHandler(this.AddReportBtn_Click);
            // 
            // NameAerotechnicTB
            // 
            this.NameAerotechnicTB.Location = new System.Drawing.Point(361, 116);
            this.NameAerotechnicTB.Name = "NameAerotechnicTB";
            this.NameAerotechnicTB.Size = new System.Drawing.Size(256, 21);
            this.NameAerotechnicTB.TabIndex = 14;
            // 
            // NameAerotechnicLabel
            // 
            this.NameAerotechnicLabel.AutoSize = true;
            this.NameAerotechnicLabel.Location = new System.Drawing.Point(358, 97);
            this.NameAerotechnicLabel.Name = "NameAerotechnicLabel";
            this.NameAerotechnicLabel.Size = new System.Drawing.Size(62, 16);
            this.NameAerotechnicLabel.TabIndex = 13;
            this.NameAerotechnicLabel.Text = "Название";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Ubuntu", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(278, 53);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLabel.Size = new System.Drawing.Size(447, 41);
            this.NameLabel.TabIndex = 12;
            this.NameLabel.Text = "Добавление аэротехники";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AirplaneTypeCB
            // 
            this.AirplaneTypeCB.FormattingEnabled = true;
            this.AirplaneTypeCB.Location = new System.Drawing.Point(361, 160);
            this.AirplaneTypeCB.Name = "AirplaneTypeCB";
            this.AirplaneTypeCB.Size = new System.Drawing.Size(256, 24);
            this.AirplaneTypeCB.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Тип";
            // 
            // CapacityTB
            // 
            this.CapacityTB.Location = new System.Drawing.Point(361, 206);
            this.CapacityTB.Name = "CapacityTB";
            this.CapacityTB.Size = new System.Drawing.Size(256, 21);
            this.CapacityTB.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(358, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Вместимость";
            // 
            // CrewTB
            // 
            this.CrewTB.Location = new System.Drawing.Point(361, 249);
            this.CrewTB.Name = "CrewTB";
            this.CrewTB.Size = new System.Drawing.Size(256, 21);
            this.CrewTB.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Количество экипажа";
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
            this.EngineerMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.EngineerMenuStrip.Size = new System.Drawing.Size(934, 24);
            this.EngineerMenuStrip.TabIndex = 31;
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
            this.просмотрВсехПользователейToolStripMenuItem,
            this.добавитьНовогоПользователяToolStripMenuItem});
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.пользователиToolStripMenuItem.Text = "Отчеты";
            // 
            // просмотрВсехПользователейToolStripMenuItem
            // 
            this.просмотрВсехПользователейToolStripMenuItem.Name = "просмотрВсехПользователейToolStripMenuItem";
            this.просмотрВсехПользователейToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.просмотрВсехПользователейToolStripMenuItem.Text = "Просмотр всех отчетов";
            this.просмотрВсехПользователейToolStripMenuItem.Click += new System.EventHandler(this.просмотрВсехПользователейToolStripMenuItem_Click);
            // 
            // добавитьНовогоПользователяToolStripMenuItem
            // 
            this.добавитьНовогоПользователяToolStripMenuItem.Name = "добавитьНовогоПользователяToolStripMenuItem";
            this.добавитьНовогоПользователяToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.добавитьНовогоПользователяToolStripMenuItem.Text = "Добавить новый отчет";
            this.добавитьНовогоПользователяToolStripMenuItem.Click += new System.EventHandler(this.добавитьНовогоПользователяToolStripMenuItem_Click);
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
            // EngineerAddAerotechnicsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.CrewTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CapacityTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AirplaneTypeCB);
            this.Controls.Add(this.AddReportBtn);
            this.Controls.Add(this.NameAerotechnicTB);
            this.Controls.Add(this.NameAerotechnicLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.EngineerMenuStrip);
            this.Name = "EngineerAddAerotechnicsForm";
            this.Text = "Добавление аэротехники";
            this.Controls.SetChildIndex(this.EngineerMenuStrip, 0);
            this.Controls.SetChildIndex(this.ExitBtn, 0);
            this.Controls.SetChildIndex(this.NameLabel, 0);
            this.Controls.SetChildIndex(this.NameAerotechnicLabel, 0);
            this.Controls.SetChildIndex(this.NameAerotechnicTB, 0);
            this.Controls.SetChildIndex(this.AddReportBtn, 0);
            this.Controls.SetChildIndex(this.AirplaneTypeCB, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.CapacityTB, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.CrewTB, 0);
            this.EngineerMenuStrip.ResumeLayout(false);
            this.EngineerMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddReportBtn;
        private System.Windows.Forms.TextBox NameAerotechnicTB;
        private System.Windows.Forms.Label NameAerotechnicLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ComboBox AirplaneTypeCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CapacityTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CrewTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip EngineerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрВсехПользователейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьНовогоПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem аэротехникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокВсейАэротехнкикиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяНаГлавнуюСтраницуToolStripMenuItem;
    }
}