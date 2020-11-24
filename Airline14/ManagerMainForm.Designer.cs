namespace Airline14
{
    partial class ManagerMainForm
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
            this.ManagerMenuStrip = new System.Windows.Forms.MenuStrip();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрВсехАвиарейсовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пунктНазначенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеПToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllFlightBtn = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.createReportBTN = new System.Windows.Forms.Button();
            this.AllDestinationBTN = new System.Windows.Forms.Button();
            this.createReportViewBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ManagerMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
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
            this.ManagerMenuStrip.Size = new System.Drawing.Size(934, 24);
            this.ManagerMenuStrip.TabIndex = 1;
            this.ManagerMenuStrip.Text = "menuStrip1";
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
            this.просмотрВсехАвиарейсовToolStripMenuItem});
            this.пользователиToolStripMenuItem.Name = "пользователиToolStripMenuItem";
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.пользователиToolStripMenuItem.Text = "Авиарейсы";
            // 
            // просмотрВсехАвиарейсовToolStripMenuItem
            // 
            this.просмотрВсехАвиарейсовToolStripMenuItem.Name = "просмотрВсехАвиарейсовToolStripMenuItem";
            this.просмотрВсехАвиарейсовToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.просмотрВсехАвиарейсовToolStripMenuItem.Text = "Просмотреть все авиарейсы";
            this.просмотрВсехАвиарейсовToolStripMenuItem.Click += new System.EventHandler(this.просмотрВсехАвиарейсовToolStripMenuItem_Click);
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сформироватьОтчетToolStripMenuItem});
            this.отчетыToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
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
            this.всеПToolStripMenuItem});
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
            // AllFlightBtn
            // 
            this.AllFlightBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.AllFlightBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.AllFlightBtn.FlatAppearance.BorderSize = 0;
            this.AllFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllFlightBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.AllFlightBtn.Location = new System.Drawing.Point(342, 124);
            this.AllFlightBtn.Name = "AllFlightBtn";
            this.AllFlightBtn.Size = new System.Drawing.Size(241, 32);
            this.AllFlightBtn.TabIndex = 12;
            this.AllFlightBtn.Text = "Список всех авиарейсов";
            this.AllFlightBtn.UseVisualStyleBackColor = false;
            this.AllFlightBtn.Click += new System.EventHandler(this.AllFlightBtn_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Ubuntu", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(301, 58);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLabel.Size = new System.Drawing.Size(340, 41);
            this.NameLabel.TabIndex = 13;
            this.NameLabel.Text = "Панель менеджера";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // createReportBTN
            // 
            this.createReportBTN.BackColor = System.Drawing.Color.MediumBlue;
            this.createReportBTN.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.createReportBTN.FlatAppearance.BorderSize = 0;
            this.createReportBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createReportBTN.ForeColor = System.Drawing.SystemColors.Info;
            this.createReportBTN.Location = new System.Drawing.Point(342, 326);
            this.createReportBTN.Name = "createReportBTN";
            this.createReportBTN.Size = new System.Drawing.Size(241, 47);
            this.createReportBTN.TabIndex = 14;
            this.createReportBTN.Text = "Сформировать отчет по продажам c выбором даты";
            this.createReportBTN.UseVisualStyleBackColor = false;
            this.createReportBTN.Click += new System.EventHandler(this.createReportBTN_Click);
            // 
            // AllDestinationBTN
            // 
            this.AllDestinationBTN.BackColor = System.Drawing.Color.MediumBlue;
            this.AllDestinationBTN.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.AllDestinationBTN.FlatAppearance.BorderSize = 0;
            this.AllDestinationBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllDestinationBTN.ForeColor = System.Drawing.SystemColors.Info;
            this.AllDestinationBTN.Location = new System.Drawing.Point(342, 277);
            this.AllDestinationBTN.Name = "AllDestinationBTN";
            this.AllDestinationBTN.Size = new System.Drawing.Size(241, 32);
            this.AllDestinationBTN.TabIndex = 16;
            this.AllDestinationBTN.Text = "Список всех пунктов назначения";
            this.AllDestinationBTN.UseVisualStyleBackColor = false;
            this.AllDestinationBTN.Click += new System.EventHandler(this.AllDestinationBTN_Click);
            // 
            // createReportViewBTN
            // 
            this.createReportViewBTN.BackColor = System.Drawing.Color.MediumBlue;
            this.createReportViewBTN.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.createReportViewBTN.FlatAppearance.BorderSize = 0;
            this.createReportViewBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createReportViewBTN.ForeColor = System.Drawing.SystemColors.Info;
            this.createReportViewBTN.Location = new System.Drawing.Point(341, 176);
            this.createReportViewBTN.Name = "createReportViewBTN";
            this.createReportViewBTN.Size = new System.Drawing.Size(241, 32);
            this.createReportViewBTN.TabIndex = 17;
            this.createReportViewBTN.Text = "Сформировать отчет по клиентам";
            this.createReportViewBTN.UseVisualStyleBackColor = false;
            this.createReportViewBTN.Click += new System.EventHandler(this.createReportViewBTN_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumBlue;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Info;
            this.button1.Location = new System.Drawing.Point(341, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 32);
            this.button1.TabIndex = 18;
            this.button1.Text = "Сформировать отчет всей выручке";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ManagerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.createReportViewBTN);
            this.Controls.Add(this.AllDestinationBTN);
            this.Controls.Add(this.createReportBTN);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AllFlightBtn);
            this.Controls.Add(this.ManagerMenuStrip);
            this.MainMenuStrip = this.ManagerMenuStrip;
            this.Name = "ManagerMainForm";
            this.Text = "Панель менеджера";
            this.Controls.SetChildIndex(this.ManagerMenuStrip, 0);
            this.Controls.SetChildIndex(this.AllFlightBtn, 0);
            this.Controls.SetChildIndex(this.NameLabel, 0);
            this.Controls.SetChildIndex(this.createReportBTN, 0);
            this.Controls.SetChildIndex(this.AllDestinationBTN, 0);
            this.Controls.SetChildIndex(this.createReportViewBTN, 0);
            this.Controls.SetChildIndex(this.ExitBtn, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.ManagerMenuStrip.ResumeLayout(false);
            this.ManagerMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ManagerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрВсехАвиарейсовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сформироватьОтчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button AllFlightBtn;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button createReportBTN;
        private System.Windows.Forms.ToolStripMenuItem пунктНазначенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеПToolStripMenuItem;
        private System.Windows.Forms.Button AllDestinationBTN;
        private System.Windows.Forms.Button createReportViewBTN;
        private System.Windows.Forms.Button button1;
    }
}