namespace Airline14
{
    partial class SalesmanMainForm
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
            this.AllClientBtn = new System.Windows.Forms.Button();
            this.AllTickettBtn = new System.Windows.Forms.Button();
            this.EngineerMenuStrip = new System.Windows.Forms.MenuStrip();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьАвирейсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрВсехАвиарейсовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.авиарейсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllFlightsBTN = new System.Windows.Forms.Button();
            this.EngineerMenuStrip.SuspendLayout();
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
            this.NameLabel.Location = new System.Drawing.Point(239, 57);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLabel.Size = new System.Drawing.Size(484, 41);
            this.NameLabel.TabIndex = 17;
            this.NameLabel.Text = "Панель агента по продажам";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AllClientBtn
            // 
            this.AllClientBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.AllClientBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.AllClientBtn.FlatAppearance.BorderSize = 0;
            this.AllClientBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllClientBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.AllClientBtn.Location = new System.Drawing.Point(351, 132);
            this.AllClientBtn.Name = "AllClientBtn";
            this.AllClientBtn.Size = new System.Drawing.Size(241, 32);
            this.AllClientBtn.TabIndex = 16;
            this.AllClientBtn.Text = "Список всех клиентов";
            this.AllClientBtn.UseVisualStyleBackColor = false;
            this.AllClientBtn.Click += new System.EventHandler(this.AllClientBtn_Click);
            // 
            // AllTickettBtn
            // 
            this.AllTickettBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.AllTickettBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.AllTickettBtn.FlatAppearance.BorderSize = 0;
            this.AllTickettBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllTickettBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.AllTickettBtn.Location = new System.Drawing.Point(351, 185);
            this.AllTickettBtn.Name = "AllTickettBtn";
            this.AllTickettBtn.Size = new System.Drawing.Size(241, 32);
            this.AllTickettBtn.TabIndex = 19;
            this.AllTickettBtn.Text = "Список всех  проданных билетов";
            this.AllTickettBtn.UseVisualStyleBackColor = false;
            this.AllTickettBtn.Click += new System.EventHandler(this.AllTickettBtn_Click);
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
            this.EngineerMenuStrip.TabIndex = 20;
            this.EngineerMenuStrip.Text = "menuStrip1";
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выйтиToolStripMenuItem});
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.программаToolStripMenuItem.Text = "Программа";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
            this.выйтиToolStripMenuItem.Click += new System.EventHandler(this.выйтиToolStripMenuItem_Click);
            // 
            // пользователиToolStripMenuItem
            // 
            this.пользователиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьАвирейсToolStripMenuItem,
            this.просмотрВсехАвиарейсовToolStripMenuItem});
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.пользователиToolStripMenuItem.Text = "Билеты";
            // 
            // создатьАвирейсToolStripMenuItem
            // 
            this.создатьАвирейсToolStripMenuItem.Name = "создатьАвирейсToolStripMenuItem";
            this.создатьАвирейсToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.создатьАвирейсToolStripMenuItem.Text = "Добавить проданный билет";
            this.создатьАвирейсToolStripMenuItem.Click += new System.EventHandler(this.создатьАвирейсToolStripMenuItem_Click);
            // 
            // просмотрВсехАвиарейсовToolStripMenuItem
            // 
            this.просмотрВсехАвиарейсовToolStripMenuItem.Name = "просмотрВсехАвиарейсовToolStripMenuItem";
            this.просмотрВсехАвиарейсовToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
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
            // авиарейсыToolStripMenuItem
            // 
            this.авиарейсыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотToolStripMenuItem});
            this.авиарейсыToolStripMenuItem.Name = "авиарейсыToolStripMenuItem";
            this.авиарейсыToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.авиарейсыToolStripMenuItem.Text = "Авиарейсы";
            // 
            // просмотToolStripMenuItem
            // 
            this.просмотToolStripMenuItem.Name = "просмотToolStripMenuItem";
            this.просмотToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.просмотToolStripMenuItem.Text = "Посмотреть все авиарейсы";
            this.просмотToolStripMenuItem.Click += new System.EventHandler(this.просмотToolStripMenuItem_Click);
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
            // AllFlightsBTN
            // 
            this.AllFlightsBTN.BackColor = System.Drawing.Color.MediumBlue;
            this.AllFlightsBTN.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.AllFlightsBTN.FlatAppearance.BorderSize = 0;
            this.AllFlightsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllFlightsBTN.ForeColor = System.Drawing.SystemColors.Info;
            this.AllFlightsBTN.Location = new System.Drawing.Point(351, 238);
            this.AllFlightsBTN.Name = "AllFlightsBTN";
            this.AllFlightsBTN.Size = new System.Drawing.Size(241, 32);
            this.AllFlightsBTN.TabIndex = 21;
            this.AllFlightsBTN.Text = "Список всех авиарейсов";
            this.AllFlightsBTN.UseVisualStyleBackColor = false;
            this.AllFlightsBTN.Click += new System.EventHandler(this.AllFlightsBTN_Click);
            // 
            // SalesmanMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.AllFlightsBTN);
            this.Controls.Add(this.AllTickettBtn);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AllClientBtn);
            this.Controls.Add(this.EngineerMenuStrip);
            this.Name = "SalesmanMainForm";
            this.Text = "Панель агента по продажам";
            this.Controls.SetChildIndex(this.EngineerMenuStrip, 0);
            this.Controls.SetChildIndex(this.ExitBtn, 0);
            this.Controls.SetChildIndex(this.AllClientBtn, 0);
            this.Controls.SetChildIndex(this.NameLabel, 0);
            this.Controls.SetChildIndex(this.AllTickettBtn, 0);
            this.Controls.SetChildIndex(this.AllFlightsBTN, 0);
            this.EngineerMenuStrip.ResumeLayout(false);
            this.EngineerMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button AllClientBtn;
        private System.Windows.Forms.Button AllTickettBtn;
        private System.Windows.Forms.MenuStrip EngineerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьАвирейсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрВсехАвиарейсовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сформироватьОтчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem авиарейсыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотToolStripMenuItem;
        private System.Windows.Forms.Button AllFlightsBTN;
    }
}