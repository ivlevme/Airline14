namespace Airline14
{
    partial class ManageReportViewMoney
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.PassengersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet1 = new Airline14.DataSet1();
            this.NameLabel = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PassengersTableAdapter = new Airline14.DataSet1TableAdapters.PassengersTableAdapter();
            this.StatsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StatsTableAdapter = new Airline14.DataSet1TableAdapters.StatsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PassengersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            // 
            // PassengersBindingSource
            // 
            this.PassengersBindingSource.DataMember = "Passengers";
            this.PassengersBindingSource.DataSource = this.DataSet1;
            // 
            // DataSet1
            // 
            this.DataSet1.DataSetName = "DataSet1";
            this.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Ubuntu", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(31, 27);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLabel.Size = new System.Drawing.Size(336, 41);
            this.NameLabel.TabIndex = 19;
            this.NameLabel.Text = "Финансовый отчет";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NameLabel.Click += new System.EventHandler(this.NameLabel_Click);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.StatsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Airline14.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(38, 100);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(881, 404);
            this.reportViewer1.TabIndex = 20;
            // 
            // PassengersTableAdapter
            // 
            this.PassengersTableAdapter.ClearBeforeFill = true;
            // 
            // StatsBindingSource
            // 
            this.StatsBindingSource.DataMember = "Stats";
            this.StatsBindingSource.DataSource = this.DataSet1;
            // 
            // StatsTableAdapter
            // 
            this.StatsTableAdapter.ClearBeforeFill = true;
            // 
            // ManageReportViewMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.NameLabel);
            this.Name = "ManageReportViewMoney";
            this.Load += new System.EventHandler(this.ManageReportViewMoney_Load);
            this.Controls.SetChildIndex(this.ExitBtn, 0);
            this.Controls.SetChildIndex(this.NameLabel, 0);
            this.Controls.SetChildIndex(this.reportViewer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.PassengersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PassengersBindingSource;
        private DataSet1 DataSet1;
        private DataSet1TableAdapters.PassengersTableAdapter PassengersTableAdapter;
        private System.Windows.Forms.BindingSource StatsBindingSource;
        private DataSet1TableAdapters.StatsTableAdapter StatsTableAdapter;
    }
}
