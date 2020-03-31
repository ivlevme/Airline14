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
            this.SuspendLayout();
            // 
            // AddTicketBtn
            // 
            this.AddTicketBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.AddTicketBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.AddTicketBtn.FlatAppearance.BorderSize = 0;
            this.AddTicketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddTicketBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.AddTicketBtn.Location = new System.Drawing.Point(396, 201);
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
            this.NameLabel.Location = new System.Drawing.Point(222, 20);
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
            this.ClientLabel.Location = new System.Drawing.Point(359, 72);
            this.ClientLabel.Name = "ClientLabel";
            this.ClientLabel.Size = new System.Drawing.Size(49, 16);
            this.ClientLabel.TabIndex = 20;
            this.ClientLabel.Text = "Клиент";
            // 
            // ClientCB
            // 
            this.ClientCB.FormattingEnabled = true;
            this.ClientCB.Location = new System.Drawing.Point(362, 91);
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
            this.AddNewClient.Location = new System.Drawing.Point(646, 88);
            this.AddNewClient.Name = "AddNewClient";
            this.AddNewClient.Size = new System.Drawing.Size(176, 29);
            this.AddNewClient.TabIndex = 22;
            this.AddNewClient.Text = "Добавить нового клиента";
            this.AddNewClient.UseVisualStyleBackColor = false;
            // 
            // FlightCB
            // 
            this.FlightCB.FormattingEnabled = true;
            this.FlightCB.Location = new System.Drawing.Point(362, 147);
            this.FlightCB.Name = "FlightCB";
            this.FlightCB.Size = new System.Drawing.Size(255, 24);
            this.FlightCB.TabIndex = 24;
            // 
            // FlightLabel
            // 
            this.FlightLabel.AutoSize = true;
            this.FlightLabel.Location = new System.Drawing.Point(359, 128);
            this.FlightLabel.Name = "FlightLabel";
            this.FlightLabel.Size = new System.Drawing.Size(36, 16);
            this.FlightLabel.TabIndex = 23;
            this.FlightLabel.Text = "Рейс";
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
            this.Name = "SalesmanAddTicketForm";
            this.Text = "Добавить проданный билет";
            this.Controls.SetChildIndex(this.NameLabel, 0);
            this.Controls.SetChildIndex(this.AddTicketBtn, 0);
            this.Controls.SetChildIndex(this.ClientLabel, 0);
            this.Controls.SetChildIndex(this.ClientCB, 0);
            this.Controls.SetChildIndex(this.AddNewClient, 0);
            this.Controls.SetChildIndex(this.FlightLabel, 0);
            this.Controls.SetChildIndex(this.FlightCB, 0);
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
    }
}