namespace Airline14
{
    partial class EngineerMainForm
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
            this.AllUsersButton = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.Label();
            this.EngineerMenuStrip = new System.Windows.Forms.MenuStrip();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрВсехПользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьНовогоПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.аэротехникаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьАэротехнкикуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокВсейАэротехнкикиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllAerotechnicBtn = new System.Windows.Forms.Button();
            this.EngineerMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            // 
            // AllUsersButton
            // 
            this.AllUsersButton.BackColor = System.Drawing.Color.MediumBlue;
            this.AllUsersButton.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.AllUsersButton.FlatAppearance.BorderSize = 0;
            this.AllUsersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllUsersButton.ForeColor = System.Drawing.SystemColors.Info;
            this.AllUsersButton.Location = new System.Drawing.Point(360, 147);
            this.AllUsersButton.Name = "AllUsersButton";
            this.AllUsersButton.Size = new System.Drawing.Size(241, 31);
            this.AllUsersButton.TabIndex = 13;
            this.AllUsersButton.Text = "Список всех отчетов";
            this.AllUsersButton.UseVisualStyleBackColor = false;
            this.AllUsersButton.Click += new System.EventHandler(this.AllUsersButton_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Ubuntu", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(334, 75);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLabel.Size = new System.Drawing.Size(315, 41);
            this.NameLabel.TabIndex = 11;
            this.NameLabel.Text = "Панель инженера";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.EngineerMenuStrip.TabIndex = 14;
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
            this.добавитьАэротехнкикуToolStripMenuItem,
            this.списокВсейАэротехнкикиToolStripMenuItem});
            this.аэротехникаToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.аэротехникаToolStripMenuItem.Name = "аэротехникаToolStripMenuItem";
            this.аэротехникаToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.аэротехникаToolStripMenuItem.Text = "Аэротехника";
            // 
            // добавитьАэротехнкикуToolStripMenuItem
            // 
            this.добавитьАэротехнкикуToolStripMenuItem.Name = "добавитьАэротехнкикуToolStripMenuItem";
            this.добавитьАэротехнкикуToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.добавитьАэротехнкикуToolStripMenuItem.Text = "Добавить аэротехнкику";
            this.добавитьАэротехнкикуToolStripMenuItem.Click += new System.EventHandler(this.добавитьАэротехнкикуToolStripMenuItem_Click);
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
            // AllAerotechnicBtn
            // 
            this.AllAerotechnicBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.AllAerotechnicBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.AllAerotechnicBtn.FlatAppearance.BorderSize = 0;
            this.AllAerotechnicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AllAerotechnicBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.AllAerotechnicBtn.Location = new System.Drawing.Point(360, 198);
            this.AllAerotechnicBtn.Name = "AllAerotechnicBtn";
            this.AllAerotechnicBtn.Size = new System.Drawing.Size(241, 31);
            this.AllAerotechnicBtn.TabIndex = 18;
            this.AllAerotechnicBtn.Text = "Список всей аэротехники";
            this.AllAerotechnicBtn.UseVisualStyleBackColor = false;
            this.AllAerotechnicBtn.Click += new System.EventHandler(this.AllAerotechnicBtn_Click);
            // 
            // EngineerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.AllAerotechnicBtn);
            this.Controls.Add(this.AllUsersButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.EngineerMenuStrip);
            this.Name = "EngineerMainForm";
            this.Text = "Панель инженера";
            this.Controls.SetChildIndex(this.EngineerMenuStrip, 0);
            this.Controls.SetChildIndex(this.ExitBtn, 0);
            this.Controls.SetChildIndex(this.NameLabel, 0);
            this.Controls.SetChildIndex(this.AllUsersButton, 0);
            this.Controls.SetChildIndex(this.AllAerotechnicBtn, 0);
            this.EngineerMenuStrip.ResumeLayout(false);
            this.EngineerMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AllUsersButton;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.MenuStrip EngineerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрВсехПользователейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьНовогоПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.Button AllAerotechnicBtn;
        private System.Windows.Forms.ToolStripMenuItem аэротехникаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьАэротехнкикуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокВсейАэротехнкикиToolStripMenuItem;
    }
}