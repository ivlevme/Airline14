﻿namespace Airline14
{
    partial class ManagerAllDestionationForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ManagerMenuStrip = new System.Windows.Forms.MenuStrip();
            this.программаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяНаГлавнуюСтраницуМенеджераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выйтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пользователиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрВсехАвиарейсовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сформироватьОтчетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пунктыНазначенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрВсехПунктовНазначенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьВыбранныйПунктНазначенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыбранныйПунктНазначенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ManagerMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(910, 420);
            this.dataGridView1.TabIndex = 19;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Ubuntu", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(192, 58);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLabel.Size = new System.Drawing.Size(564, 41);
            this.NameLabel.TabIndex = 18;
            this.NameLabel.Text = "Список всех пунктов назначения";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ManagerMenuStrip
            // 
            this.ManagerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.программаToolStripMenuItem,
            this.пользователиToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.пунктыНазначенияToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.ManagerMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ManagerMenuStrip.Name = "ManagerMenuStrip";
            this.ManagerMenuStrip.Size = new System.Drawing.Size(934, 24);
            this.ManagerMenuStrip.TabIndex = 44;
            this.ManagerMenuStrip.Text = "menuStrip1";
            // 
            // программаToolStripMenuItem
            // 
            this.программаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вернутьсяНаГлавнуюСтраницуМенеджераToolStripMenuItem,
            this.выйтиToolStripMenuItem});
            this.программаToolStripMenuItem.Name = "программаToolStripMenuItem";
            this.программаToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.программаToolStripMenuItem.Text = "Программа";
            // 
            // вернутьсяНаГлавнуюСтраницуМенеджераToolStripMenuItem
            // 
            this.вернутьсяНаГлавнуюСтраницуМенеджераToolStripMenuItem.Name = "вернутьсяНаГлавнуюСтраницуМенеджераToolStripMenuItem";
            this.вернутьсяНаГлавнуюСтраницуМенеджераToolStripMenuItem.Size = new System.Drawing.Size(250, 22);
            this.вернутьсяНаГлавнуюСтраницуМенеджераToolStripMenuItem.Text = "Вернуться на главную страницу";
            this.вернутьсяНаГлавнуюСтраницуМенеджераToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяНаГлавнуюСтраницуМенеджераToolStripMenuItem_Click);
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
            this.пользователиToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.пользователиToolStripMenuItem.Text = "Авиарейсы";
            // 
            // просмотрВсехАвиарейсовToolStripMenuItem
            // 
            this.просмотрВсехАвиарейсовToolStripMenuItem.Name = "просмотрВсехАвиарейсовToolStripMenuItem";
            this.просмотрВсехАвиарейсовToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.просмотрВсехАвиарейсовToolStripMenuItem.Text = "Добавить авиарейс";
            this.просмотрВсехАвиарейсовToolStripMenuItem.Click += new System.EventHandler(this.просмотрВсехАвиарейсовToolStripMenuItem_Click);
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
            this.сформироватьОтчетToolStripMenuItem.Click += new System.EventHandler(this.сформироватьОтчетToolStripMenuItem_Click);
            // 
            // пунктыНазначенияToolStripMenuItem
            // 
            this.пунктыНазначенияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотрВсехПунктовНазначенияToolStripMenuItem,
            this.редактироватьВыбранныйПунктНазначенияToolStripMenuItem,
            this.удалитьВыбранныйПунктНазначенияToolStripMenuItem});
            this.пунктыНазначенияToolStripMenuItem.Name = "пунктыНазначенияToolStripMenuItem";
            this.пунктыНазначенияToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.пунктыНазначенияToolStripMenuItem.Text = "Пункты назначения";
            // 
            // просмотрВсехПунктовНазначенияToolStripMenuItem
            // 
            this.просмотрВсехПунктовНазначенияToolStripMenuItem.Name = "просмотрВсехПунктовНазначенияToolStripMenuItem";
            this.просмотрВсехПунктовНазначенияToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.просмотрВсехПунктовНазначенияToolStripMenuItem.Text = "Добавить пункт назначения";
            this.просмотрВсехПунктовНазначенияToolStripMenuItem.Click += new System.EventHandler(this.просмотрВсехПунктовНазначенияToolStripMenuItem_Click);
            // 
            // редактироватьВыбранныйПунктНазначенияToolStripMenuItem
            // 
            this.редактироватьВыбранныйПунктНазначенияToolStripMenuItem.Name = "редактироватьВыбранныйПунктНазначенияToolStripMenuItem";
            this.редактироватьВыбранныйПунктНазначенияToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.редактироватьВыбранныйПунктНазначенияToolStripMenuItem.Text = "Редактировать выбранный пункт назначения";
            // 
            // удалитьВыбранныйПунктНазначенияToolStripMenuItem
            // 
            this.удалитьВыбранныйПунктНазначенияToolStripMenuItem.Name = "удалитьВыбранныйПунктНазначенияToolStripMenuItem";
            this.удалитьВыбранныйПунктНазначенияToolStripMenuItem.Size = new System.Drawing.Size(323, 22);
            this.удалитьВыбранныйПунктНазначенияToolStripMenuItem.Text = "Удалить выбранный пункт назначения";
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
            // ManagerAllDestionationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ManagerMenuStrip);
            this.Name = "ManagerAllDestionationForm";
            this.Text = "Список пунктов назначения";
            this.Controls.SetChildIndex(this.ManagerMenuStrip, 0);
            this.Controls.SetChildIndex(this.ExitBtn, 0);
            this.Controls.SetChildIndex(this.NameLabel, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ManagerMenuStrip.ResumeLayout(false);
            this.ManagerMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.MenuStrip ManagerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem программаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяНаГлавнуюСтраницуМенеджераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выйтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пользователиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрВсехАвиарейсовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сформироватьОтчетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пунктыНазначенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрВсехПунктовНазначенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьВыбранныйПунктНазначенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыбранныйПунктНазначенияToolStripMenuItem;
    }
}