namespace ProyectoResidencias.Activo.BienesDadosDeBaja
{
    partial class RVBienesBaja
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.activoJcasDataSet = new ProyectoResidencias.ActivoJcasDataSet();
            this.activoJcasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bajaBienesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bajaBienesTableAdapter = new ProyectoResidencias.ActivoJcasDataSetTableAdapters.BajaBienesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.activoJcasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.activoJcasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bajaBienesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bajaBienesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ProyectoResidencias.Informes.ReporteBaja.rdlc";
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
            // activoJcasDataSetBindingSource
            // 
            this.activoJcasDataSetBindingSource.DataSource = this.activoJcasDataSet;
            this.activoJcasDataSetBindingSource.Position = 0;
            // 
            // bajaBienesBindingSource
            // 
            this.bajaBienesBindingSource.DataMember = "BajaBienes";
            this.bajaBienesBindingSource.DataSource = this.activoJcasDataSetBindingSource;
            // 
            // bajaBienesTableAdapter
            // 
            this.bajaBienesTableAdapter.ClearBeforeFill = true;
            // 
            // RVBienesBaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "RVBienesBaja";
            this.Text = "RVBienesBaja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RVBienesBaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.activoJcasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.activoJcasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bajaBienesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource activoJcasDataSetBindingSource;
        private ActivoJcasDataSet activoJcasDataSet;
        private System.Windows.Forms.BindingSource bajaBienesBindingSource;
        private ActivoJcasDataSetTableAdapters.BajaBienesTableAdapter bajaBienesTableAdapter;
    }
}