namespace ProyectoResidencias.Catalogos.Vehiculos
{
    partial class ReporteVehiculos
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.activoJcasDataSet = new ProyectoResidencias.ActivoJcasDataSet();
            this.vVehiculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vVehiculosTableAdapter = new ProyectoResidencias.ActivoJcasDataSetTableAdapters.vVehiculosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.activoJcasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vVehiculosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.vVehiculosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoResidencias.Informes.ReporteVehiculos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // activoJcasDataSet
            // 
            this.activoJcasDataSet.DataSetName = "ActivoJcasDataSet";
            this.activoJcasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vVehiculosBindingSource
            // 
            this.vVehiculosBindingSource.DataMember = "vVehiculos";
            this.vVehiculosBindingSource.DataSource = this.activoJcasDataSet;
            // 
            // vVehiculosTableAdapter
            // 
            this.vVehiculosTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteVehiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteVehiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReporteVehiculos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ReporteVehiculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activoJcasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vVehiculosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ActivoJcasDataSet activoJcasDataSet;
        private System.Windows.Forms.BindingSource vVehiculosBindingSource;
        private ActivoJcasDataSetTableAdapters.vVehiculosTableAdapter vVehiculosTableAdapter;
    }
}