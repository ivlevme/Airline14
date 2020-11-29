namespace Airline14
{
    partial class ManagerReportViewClients
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.passengersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Airline14.DataSet1();
            this.NameLabel = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.personalinformationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passengersTableAdapter = new Airline14.DataSet1TableAdapters.PassengersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.passengersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            // 
            // passengersBindingSource
            // 
            this.passengersBindingSource.DataMember = "Passengers";
            this.passengersBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Ubuntu", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameLabel.Location = new System.Drawing.Point(87, 23);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.NameLabel.Size = new System.Drawing.Size(755, 41);
            this.NameLabel.TabIndex = 19;
            this.NameLabel.Text = "Отчет по действующим клиентам компании";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.passengersBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Airline14.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(94, 86);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(748, 405);
            this.reportViewer1.TabIndex = 20;
            // 
            // personalinformationDataGridViewTextBoxColumn
            // 
            this.personalinformationDataGridViewTextBoxColumn.DataPropertyName = "Personal_information";
            this.personalinformationDataGridViewTextBoxColumn.HeaderText = "Personal_information";
            this.personalinformationDataGridViewTextBoxColumn.Name = "personalinformationDataGridViewTextBoxColumn";
            // 
            // passengersTableAdapter
            // 
            this.passengersTableAdapter.ClearBeforeFill = true;
            // 
            // ManagerReportViewClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.NameLabel);
            this.Name = "ManagerReportViewClients";
            this.Text = "v";
            this.Load += new System.EventHandler(this.ManagerReportView_Load);
            this.Controls.SetChildIndex(this.NameLabel, 0);
            this.Controls.SetChildIndex(this.reportViewer1, 0);
            this.Controls.SetChildIndex(this.ExitBtn, 0);
            ((System.ComponentModel.ISupportInitialize)(this.passengersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalinformationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personalInformationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passportInformationDataGridViewTextBoxColumn;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource passengersBindingSource;
        private DataSet1TableAdapters.PassengersTableAdapter passengersTableAdapter;
    }
}
