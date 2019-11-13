namespace CEE.Interfaz.Reportes
{
    partial class FrmListadoPrestamos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmListadoPrestamos));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dataSetListadoPrestamos1 = new CEE.Interfaz.Reportes.DataSets.DataSetListadoPrestamos();
            this.dataTableListadoPrestamosTableAdapter1 = new CEE.Interfaz.Reportes.DataSets.DataSetListadoPrestamosTableAdapters.DataTableListadoPrestamosTableAdapter();
            this.dataTableListadoPrestamosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListadoPrestamos1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableListadoPrestamosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetListadoPrestamos";
            reportDataSource1.Value = this.dataTableListadoPrestamosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CEE.Interfaz.Reportes.Diseños.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1044, 571);
            this.reportViewer1.TabIndex = 0;
            // 
            // dataSetListadoPrestamos1
            // 
            this.dataSetListadoPrestamos1.DataSetName = "DataSetListadoPrestamos";
            this.dataSetListadoPrestamos1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataTableListadoPrestamosTableAdapter1
            // 
            this.dataTableListadoPrestamosTableAdapter1.ClearBeforeFill = true;
            // 
            // dataTableListadoPrestamosBindingSource
            // 
            this.dataTableListadoPrestamosBindingSource.DataMember = "DataTableListadoPrestamos";
            this.dataTableListadoPrestamosBindingSource.DataSource = this.dataSetListadoPrestamos1;
            // 
            // FrmListadoPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1068, 595);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmListadoPrestamos";
            this.Text = "FrmListadoPrestamos";
            this.Load += new System.EventHandler(this.FrmListadoPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetListadoPrestamos1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableListadoPrestamosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DataSets.DataSetListadoPrestamos dataSetListadoPrestamos1;
        private DataSets.DataSetListadoPrestamosTableAdapters.DataTableListadoPrestamosTableAdapter dataTableListadoPrestamosTableAdapter1;
        private System.Windows.Forms.BindingSource dataTableListadoPrestamosBindingSource;


    }
}