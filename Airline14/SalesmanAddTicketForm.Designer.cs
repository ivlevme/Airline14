namespace Airline14
{
    partial class SalesmanAddTicketForm
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
            this.AddTicketBtn = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ClientLabel = new System.Windows.Forms.Label();
            this.ClientCB = new System.Windows.Forms.ComboBox();
            this.AddNewClient = new System.Windows.Forms.Button();
            this.FlightCB = new System.Windows.Forms.ComboBox();
            this.FlightLabel = new System.Windows.Forms.Label();
            this.EngineerMenuStrip = new System.Windows.Forms.MenuStrip();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяНаГлавнуюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрВсехАвиарейсовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авирейсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьВсеАвиарейсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EngineerMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            // 
            // AddTicketBtn
            // 
            this.AddTicketBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.AddTicketBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.AddTicketBtn.FlatAppearance.BorderSize = 0;
            this.AddTicketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTicketBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.AddTicketBtn.Location = new System.Drawing.Point(396, 235);
            this.AddTicketBtn.Name = "AddTicketBtn";
            this.AddTicketBtn.Size = new System.Drawing.Size(176, 32);
            this.AddTicketBtn.TabIndex = 19;
            this.AddTicketBtn.Text = "Добавить билет";
            this.AddTicketBtn.UseVisualStyleBackColor = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Ubuntu", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(222, 59);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLabel.Size = new System.Drawing.Size(559, 41);
            this.NameLabel.TabIndex = 12;
            this.NameLabel.Text = "Добавление проданного билета";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ClientLabel
            // 
            this.ClientLabel.AutoSize = true;
            this.ClientLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientLabel.Location = new System.Drawing.Point(359, 106);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(49, 16);
            this.ClientLabel.TabIndex = 20;
            this.ClientLabel.Text = "Клиент";
            // 
            // ClientCB
            // 
            this.ClientCB.FormattingEnabled = true;
            this.ClientCB.Location = new System.Drawing.Point(362, 125);
            this.ClientCB.Name = "ClientCB";
            this.ClientCB.Size = new System.Drawing.Size(255, 24);
            this.ClientCB.TabIndex = 21;
            // 
            // AddNewClient
            // 
            this.AddNewClient.BackColor = System.Drawing.Color.Gold;
            this.AddNewClient.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.AddNewClient.FlatAppearance.BorderSize = 0;
            this.AddNewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNewClient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddNewClient.Location = new System.Drawing.Point(646, 122);
            this.AddNewClient.Name = "AddNewClient";
            this.AddNewClient.Size = new System.Drawing.Size(176, 29);
            this.AddNewClient.TabIndex = 22;
            this.AddNewClient.Text = "Добавить нового клиента";
            this.AddNewClient.UseVisualStyleBackColor = false;
            // 
            // FlightCB
            // 
            this.FlightCB.FormattingEnabled = true;
            this.FlightCB.Location = new System.Drawing.Point(362, 181);
            this.FlightCB.Name = "FlightCB";
            this.FlightCB.Size = new System.Drawing.Size(255, 24);
            this.FlightCB.TabIndex = 24;
            // 
            // FlightLabel
            // 
            this.FlightLabel.AutoSize = true;
            this.FlightLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FlightLabel.Location = new System.Drawing.Point(359, 162);
            this.FlightLabel.Name = "FlightLabel";
            this.FlightLabel.Size = new System.Drawing.Size(36, 16);
            this.FlightLabel.TabIndex = 23;
            this.FlightLabel.Text = "Рейс";
            // 
            // EngineerMenuStrip
            // 
            this.EngineerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаToolStripMenuItem,
            this.пользователиToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.авирейсыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.EngineerMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.EngineerMenuStrip.Name = "EngineerMenuStrip";
            this.EngineerMenuStrip.Size = new System.Drawing.Size(934, 24);
            this.EngineerMenuStrip.TabIndex = 33;
            this.EngineerMenuStrip.Text = "menuStrip1";
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
            this.вернутьсяНаГлавнуюToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.вернутьсяНаГлавнуюToolStripMenuItem.Text = "Вернуться на главную";
            this.вернутьсяНаГлавнуюToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяНаГлавнуюToolStripMenuItem_Click);
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
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
            this.сформироватьОтчетToolStripMenuItem,
            this.списрToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.отчетыToolStripMenuItem.Text = "Клиенты";
            // 
            // сформироватьОтчетToolStripMenuItem
            // 
            this.сформироватьОтчетToolStripMenuItem.Name = "сформироватьОтчетToolStripMenuItem";
            this.сформироватьОтчетToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.сформироватьОтчетToolStripMenuItem.Text = "Добавить нового клиента";
            this.сформироватьОтчетToolStripMenuItem.Click += new System.EventHandler(this.сформироватьОтчетToolStripMenuItem_Click);
            // 
            // списрToolStripMenuItem
            // 
            this.списрToolStripMenuItem.Name = "списрToolStripMenuItem";
            this.списрToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.списрToolStripMenuItem.Text = "Посмотреть всех клиентов";
            this.списрToolStripMenuItem.Click += new System.EventHandler(this.списрToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            // авирейсыToolStripMenuItem
            // 
            this.авирейсыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотретьВсеАвиарейсыToolStripMenuItem});
            this.авирейсыToolStripMenuItem.Name = "авирейсыToolStripMenuItem";
            this.авирейсыToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.авирейсыToolStripMenuItem.Text = "Авирейсы";
            // 
            // просмотретьВсеАвиарейсыToolStripMenuItem
            // 
            this.просмотретьВсеАвиарейсыToolStripMenuItem.Name = "просмотретьВсеАвиарейсыToolStripMenuItem";
            this.просмотретьВсеАвиарейсыToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.просмотретьВсеАвиарейсыToolStripMenuItem.Text = "Просмотреть все авиарейсы";
            this.просмотретьВсеАвиарейсыToolStripMenuItem.Click += new System.EventHandler(this.просмотретьВсеАвиарейсыToolStripMenuItem_Click);
            // 
            // SalesmanAddTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.FlightCB);
            this.Controls.Add(this.FlightLabel);
            this.Controls.Add(this.AddNewClient);
            this.Controls.Add(this.ClientCB);
            this.Controls.Add(this.ClientLabel);
            this.Controls.Add(this.AddTicketBtn);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.EngineerMenuStrip);
            this.Name = "SalesmanAddTicketForm";
            this.Text = "Добавить проданный билет";
            this.Controls.SetChildIndex(this.EngineerMenuStrip, 0);
            this.Controls.SetChildIndex(this.ExitBtn, 0);
            this.Controls.SetChildIndex(this.NameLabel, 0);
            this.Controls.SetChildIndex(this.AddTicketBtn, 0);
            this.Controls.SetChildIndex(this.ClientLabel, 0);
            this.Controls.SetChildIndex(this.ClientCB, 0);
            this.Controls.SetChildIndex(this.AddNewClient, 0);
            this.Controls.SetChildIndex(this.FlightLabel, 0);
            this.Controls.SetChildIndex(this.FlightCB, 0);
            this.EngineerMenuStrip.ResumeLayout(false);
            this.EngineerMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddTicketBtn;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ClientLabel;
        private System.Windows.Forms.ComboBox ClientCB;
        private System.Windows.Forms.Button AddNewClient;
        private System.Windows.Forms.ComboBox FlightCB;
        private System.Windows.Forms.Label FlightLabel;
        private System.Windows.Forms.MenuStrip EngineerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяНаГлавнуюToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрВсехАвиарейсовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сформироватьОтчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авирейсыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотретьВсеАвиарейсыToolStripMenuItem;
    }
}