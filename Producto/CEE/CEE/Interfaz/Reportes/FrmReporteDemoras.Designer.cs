namespace CEE.Interfaz.Reportes
{
    partial class FrmReporteDemoras
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteDemoras));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSet1 = new CEE.Interfaz.Reportes.DataSets.DataSet1();
            this.dataTableCantPrestamoPorCarreraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTableCantPrestamoPorCarreraTableAdapter = new CEE.Interfaz.Reportes.DataSets.DataSet1TableAdapters.DataTableCantPrestamoPorCarreraTableAdapter();
            this.dataTablePrestamosDemoradosPorCarreraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTablePrestamosDemoradosPorCarreraTableAdapter = new CEE.Interfaz.Reportes.DataSets.DataSet1TableAdapters.DataTablePrestamosDemoradosPorCarreraTableAdapter();
            this.dataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTable1TableAdapter = new CEE.Interfaz.Reportes.DataSets.DataSet1TableAdapters.DataTable1TableAdapter();
            this.dataTablePrestamosDemoradosPorUniversidadBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataTablePrestamosDemoradosPorUniversidadTableAdapter = new CEE.Interfaz.Reportes.DataSets.DataSet1TableAdapters.DataTablePrestamosDemoradosPorUniversidadTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableCantPrestamoPorCarreraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePrestamosDemoradosPorCarreraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePrestamosDemoradosPorUniversidadBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCarreraEstado";
            reportDataSource1.Value = this.dataTableCantPrestamoPorCarreraBindingSource;
            reportDataSource2.Name = "DataSetCarreraDemorados";
            reportDataSource2.Value = this.dataTablePrestamosDemoradosPorCarreraBindingSource;
            reportDataSource3.Name = "DataSetUniversidadEstado";
            reportDataSource3.Value = this.dataTable1BindingSource;
            reportDataSource4.Name = "DataSetUniversidadDemorados";
            reportDataSource4.Value = this.dataTablePrestamosDemoradosPorUniversidadBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CEE.Interfaz.Reportes.Diseños.Report3.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableCantPrestamoPorCarreraBindingSource
            // 
            this.dataTableCantPrestamoPorCarreraBindingSource.DataMember = "DataTableCantPrestamoPorCarrera";
            this.dataTableCantPrestamoPorCarreraBindingSource.DataSource = this.dataSet1;
            // 
            // dataTableCantPrestamoPorCarreraTableAdapter
            // 
            this.dataTableCantPrestamoPorCarreraTableAdapter.ClearBeforeFill = true;
            // 
            // dataTablePrestamosDemoradosPorCarreraBindingSource
            // 
            this.dataTablePrestamosDemoradosPorCarreraBindingSource.DataMember = "DataTablePrestamosDemoradosPorCarrera";
            this.dataTablePrestamosDemoradosPorCarreraBindingSource.DataSource = this.dataSet1;
            // 
            // dataTablePrestamosDemoradosPorCarreraTableAdapter
            // 
            this.dataTablePrestamosDemoradosPorCarreraTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1BindingSource
            // 
            this.dataTable1BindingSource.DataMember = "DataTable1";
            this.dataTable1BindingSource.DataSource = this.dataSet1;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // dataTablePrestamosDemoradosPorUniversidadBindingSource
            // 
            this.dataTablePrestamosDemoradosPorUniversidadBindingSource.DataMember = "DataTablePrestamosDemoradosPorUniversidad";
            this.dataTablePrestamosDemoradosPorUniversidadBindingSource.DataSource = this.dataSet1;
            // 
            // dataTablePrestamosDemoradosPorUniversidadTableAdapter
            // 
            this.dataTablePrestamosDemoradosPorUniversidadTableAdapter.ClearBeforeFill = true;
            // 
            // FrmReporteDemoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmReporteDemoras";
            this.Text = "FrmReporteDemoras";
            this.Load += new System.EventHandler(this.FrmReporteDemoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableCantPrestamoPorCarreraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePrestamosDemoradosPorCarreraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePrestamosDemoradosPorUniversidadBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource dataTableCantPrestamoPorCarreraBindingSource;
        private DataSets.DataSet1TableAdapters.DataTableCantPrestamoPorCarreraTableAdapter dataTableCantPrestamoPorCarreraTableAdapter;
        private System.Windows.Forms.BindingSource dataTablePrestamosDemoradosPorCarreraBindingSource;
        private DataSets.DataSet1TableAdapters.DataTablePrestamosDemoradosPorCarreraTableAdapter dataTablePrestamosDemoradosPorCarreraTableAdapter;
        private System.Windows.Forms.BindingSource dataTable1BindingSource;
        private DataSets.DataSet1TableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.BindingSource dataTablePrestamosDemoradosPorUniversidadBindingSource;
        private DataSets.DataSet1TableAdapters.DataTablePrestamosDemoradosPorUniversidadTableAdapter dataTablePrestamosDemoradosPorUniversidadTableAdapter;
    }
}