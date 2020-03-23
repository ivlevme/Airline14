namespace Airline14
{
    partial class AuthForm
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
            this.LoginLabel = new System.Windows.Forms.Label();
            this.LoginTB = new System.Windows.Forms.TextBox();
            this.PasswordTB = new System.Windows.Forms.TextBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SinginBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Ubuntu", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(280, 47);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLabel.Size = new System.Drawing.Size(413, 41);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Местная Авиакомпания";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.LoginLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginLabel.Location = new System.Drawing.Point(283, 183);
            this.LoginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(56, 20);
            this.LoginLabel.TabIndex = 3;
            this.LoginLabel.Text = "Логин";
            // 
            // LoginTB
            // 
            this.LoginTB.Location = new System.Drawing.Point(287, 206);
            this.LoginTB.Name = "LoginTB";
            this.LoginTB.Size = new System.Drawing.Size(406, 21);
            this.LoginTB.TabIndex = 4;
            // 
            // PasswordTB
            // 
            this.PasswordTB.Font = new System.Drawing.Font("Ubuntu", 9F);
            this.PasswordTB.Location = new System.Drawing.Point(287, 283);
            this.PasswordTB.Name = "PasswordTB";
            this.PasswordTB.PasswordChar = '●';
            this.PasswordTB.Size = new System.Drawing.Size(406, 21);
            this.PasswordTB.TabIndex = 6;
            this.PasswordTB.TextChanged += new System.EventHandler(this.PasswordTB_TextChanged);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Ubuntu", 12F);
            this.PasswordLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PasswordLabel.Location = new System.Drawing.Point(283, 260);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(65, 20);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Пароль";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // SinginBtn
            // 
            this.SinginBtn.BackColor = System.Drawing.Color.MediumBlue;
            this.SinginBtn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.SinginBtn.FlatAppearance.BorderSize = 0;
            this.SinginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SinginBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.SinginBtn.Location = new System.Drawing.Point(414, 340);
            this.SinginBtn.Name = "SinginBtn";
            this.SinginBtn.Size = new System.Drawing.Size(99, 32);
            this.SinginBtn.TabIndex = 7;
            this.SinginBtn.Text = "Войти";
            this.SinginBtn.UseVisualStyleBackColor = false;
            this.SinginBtn.Click += new System.EventHandler(this.SinginButton_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.SinginBtn);
            this.Controls.Add(this.PasswordTB);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.LoginTB);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.NameLabel);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "AuthForm";
            this.Text = "Авторизация";
            this.Controls.SetChildIndex(this.NameLabel, 0);
            this.Controls.SetChildIndex(this.LoginLabel, 0);
            this.Controls.SetChildIndex(this.LoginTB, 0);
            this.Controls.SetChildIndex(this.PasswordLabel, 0);
            this.Controls.SetChildIndex(this.PasswordTB, 0);
            this.Controls.SetChildIndex(this.SinginBtn, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.TextBox LoginTB;
        private System.Windows.Forms.TextBox PasswordTB;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button SinginBtn;
    }
}

