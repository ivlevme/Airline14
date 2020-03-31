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
            this.обновитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьАвирейсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрВсехАвиарейсовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllFlightBtn = new System.Windows.Forms.Button();
            this.AddFlightBtn = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.createReportBTN = new System.Windows.Forms.Button();
            this.ManagerMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ManagerMenuStrip
            // 
            this.ManagerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаToolStripMenuItem,
            this.пользователиToolStripMenuItem,
            this.отчетыToolStripMenuItem,
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
            this.обновитьToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.программаToolStripMenuItem.Text = "Программа";
            // 
            // обновитьToolStripMenuItem
            // 
            this.обновитьToolStripMenuItem.Name = "обновитьToolStripMenuItem";
            this.обновитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.обновитьToolStripMenuItem.Text = "Обновить";
            // 
            // выйтиToolStripMenuItem
            // 
            this.выйтиToolStripMenuItem.Name = "выйтиToolStripMenuItem";
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.выйтиToolStripMenuItem.Text = "Выйти";
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
            this.создатьАвирейсToolStripMenuItem.Text = "Создать авиарейс";
            // 
            // просмотрВсехАвиарейсовToolStripMenuItem
            // 
            this.просмотрВсехАвиарейсовToolStripMenuItem.Name = "просмотрВсехАвиарейсовToolStripMenuItem";
            this.просмотрВсехАвиарейсовToolStripMenuItem.Size = new System.Drawing.Size(232, 22);
            this.просмотрВсехАвиарейсовToolStripMenuItem.Text = "Просмотреть все авиарейсы";
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
            // AllFlightBtn
            // 
            this.AllFlightBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.AllFlightBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.AllFlightBtn.FlatAppearance.BorderSize = 0;
            this.AllFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllFlightBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.AllFlightBtn.Location = new System.Drawing.Point(337, 215);
            this.AllFlightBtn.Name = "AllFlightBtn";
            this.AllFlightBtn.Size = new System.Drawing.Size(241, 32);
            this.AllFlightBtn.TabIndex = 12;
            this.AllFlightBtn.Text = "Список всех авиарейсов";
            this.AllFlightBtn.UseVisualStyleBackColor = false;
            this.AllFlightBtn.Click += new System.EventHandler(this.AllFlightBtn_Click);
            // 
            // AddFlightBtn
            // 
            this.AddFlightBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.AddFlightBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.AddFlightBtn.FlatAppearance.BorderSize = 0;
            this.AddFlightBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddFlightBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.AddFlightBtn.Location = new System.Drawing.Point(337, 153);
            this.AddFlightBtn.Name = "AddFlightBtn";
            this.AddFlightBtn.Size = new System.Drawing.Size(241, 32);
            this.AddFlightBtn.TabIndex = 11;
            this.AddFlightBtn.Text = "Добавить новый авиарейс";
            this.AddFlightBtn.UseVisualStyleBackColor = false;
            this.AddFlightBtn.Click += new System.EventHandler(this.AddFlightBtn_Click);
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
            this.createReportBTN.Location = new System.Drawing.Point(337, 277);
            this.createReportBTN.Name = "createReportBTN";
            this.createReportBTN.Size = new System.Drawing.Size(241, 32);
            this.createReportBTN.TabIndex = 14;
            this.createReportBTN.Text = "Сформировать отчет";
            this.createReportBTN.UseVisualStyleBackColor = false;
            // 
            // ManagerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.createReportBTN);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.AllFlightBtn);
            this.Controls.Add(this.AddFlightBtn);
            this.Controls.Add(this.ManagerMenuStrip);
            this.MainMenuStrip = this.ManagerMenuStrip;
            this.Name = "ManagerMainForm";
            this.Text = "Панель менеджера";
            this.Controls.SetChildIndex(this.ManagerMenuStrip, 0);
            this.Controls.SetChildIndex(this.AddFlightBtn, 0);
            this.Controls.SetChildIndex(this.AllFlightBtn, 0);
            this.Controls.SetChildIndex(this.NameLabel, 0);
            this.Controls.SetChildIndex(this.createReportBTN, 0);
            this.ManagerMenuStrip.ResumeLayout(false);
            this.ManagerMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ManagerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обновитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьАвирейсToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрВсехАвиарейсовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сформироватьОтчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button AllFlightBtn;
        private System.Windows.Forms.Button AddFlightBtn;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Button createReportBTN;
    }
}