namespace PresentacionHistorialMedico
{
    partial class FrmReporteEstadistico
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.cbDiagnostico = new System.Windows.Forms.ComboBox();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblMotivoConsulta = new System.Windows.Forms.Label();
            this.lblFechaHasta = new System.Windows.Forms.Label();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.cbMotivo = new System.Windows.Forms.ComboBox();
            this.sbEmitir = new DevExpress.XtraEditors.SimpleButton();
            this.rpvReporteEstadistico = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DSReporteEstadistico = new PresentacionHistorialMedico.DSReporteEstadistico();
            this.TablaReporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSReporteEstadistico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaReporteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rpvReporteEstadistico, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.90017F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.09983F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1007, 581);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.02198F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.97802F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.sbEmitir, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1001, 97);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.cbDiagnostico, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.dtpFechaHasta, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblFechaDesde, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblMotivoConsulta, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblFechaHasta, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblDiagnostico, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.dtpFechaDesde, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbMotivo, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(775, 91);
            this.tableLayoutPanel3.TabIndex = 1;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel3_Paint);
            // 
            // cbDiagnostico
            // 
            this.cbDiagnostico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDiagnostico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiagnostico.FormattingEnabled = true;
            this.cbDiagnostico.Location = new System.Drawing.Point(600, 57);
            this.cbDiagnostico.Name = "cbDiagnostico";
            this.cbDiagnostico.Size = new System.Drawing.Size(154, 21);
            this.cbDiagnostico.TabIndex = 7;
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaHasta.Location = new System.Drawing.Point(582, 12);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(190, 20);
            this.dtpFechaHasta.TabIndex = 5;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Location = new System.Drawing.Point(61, 16);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(71, 13);
            this.lblFechaDesde.TabIndex = 0;
            this.lblFechaDesde.Text = "Fecha Desde";
            // 
            // lblMotivoConsulta
            // 
            this.lblMotivoConsulta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMotivoConsulta.AutoSize = true;
            this.lblMotivoConsulta.Location = new System.Drawing.Point(55, 61);
            this.lblMotivoConsulta.Name = "lblMotivoConsulta";
            this.lblMotivoConsulta.Size = new System.Drawing.Size(83, 13);
            this.lblMotivoConsulta.TabIndex = 1;
            this.lblMotivoConsulta.Text = "Motivo Consulta";
            // 
            // lblFechaHasta
            // 
            this.lblFechaHasta.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFechaHasta.AutoSize = true;
            this.lblFechaHasta.Location = new System.Drawing.Point(448, 16);
            this.lblFechaHasta.Name = "lblFechaHasta";
            this.lblFechaHasta.Size = new System.Drawing.Size(68, 13);
            this.lblFechaHasta.TabIndex = 2;
            this.lblFechaHasta.Text = "Fecha Hasta";
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Location = new System.Drawing.Point(451, 61);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(63, 13);
            this.lblDiagnostico.TabIndex = 3;
            this.lblDiagnostico.Text = "Diagnostico";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaDesde.Location = new System.Drawing.Point(196, 12);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(187, 20);
            this.dtpFechaDesde.TabIndex = 4;
            // 
            // cbMotivo
            // 
            this.cbMotivo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMotivo.FormattingEnabled = true;
            this.cbMotivo.Location = new System.Drawing.Point(212, 57);
            this.cbMotivo.Name = "cbMotivo";
            this.cbMotivo.Size = new System.Drawing.Size(154, 21);
            this.cbMotivo.TabIndex = 6;
            // 
            // sbEmitir
            // 
            this.sbEmitir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sbEmitir.Location = new System.Drawing.Point(839, 28);
            this.sbEmitir.Name = "sbEmitir";
            this.sbEmitir.Size = new System.Drawing.Size(103, 41);
            this.sbEmitir.TabIndex = 2;
            this.sbEmitir.Text = "Emitir";
            this.sbEmitir.Click += new System.EventHandler(this.sbEmitir_Click);
            // 
            // rpvReporteEstadistico
            // 
            this.rpvReporteEstadistico.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DSReporteEstadistico";
            reportDataSource1.Value = this.TablaReporteBindingSource;
            this.rpvReporteEstadistico.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvReporteEstadistico.LocalReport.ReportEmbeddedResource = "PresentacionHistorialMedico.ReporteEstadistico.rdlc";
            this.rpvReporteEstadistico.Location = new System.Drawing.Point(3, 106);
            this.rpvReporteEstadistico.Name = "rpvReporteEstadistico";
            this.rpvReporteEstadistico.Size = new System.Drawing.Size(1001, 472);
            this.rpvReporteEstadistico.TabIndex = 1;
            // 
            // DSReporteEstadistico
            // 
            this.DSReporteEstadistico.DataSetName = "DSReporteEstadistico";
            this.DSReporteEstadistico.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TablaReporteBindingSource
            // 
            this.TablaReporteBindingSource.DataMember = "TablaReporte";
            this.TablaReporteBindingSource.DataSource = this.DSReporteEstadistico;
            // 
            // FrmReporteEstadistico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 581);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmReporteEstadistico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Estadístico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReporteEstadistico_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DSReporteEstadistico)).EndInit();
            
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblMotivoConsulta;
        private System.Windows.Forms.Label lblFechaHasta;
        private System.Windows.Forms.Label lblDiagnostico;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private DevExpress.XtraEditors.SimpleButton sbEmitir;
        private System.Windows.Forms.ComboBox cbDiagnostico;
        private System.Windows.Forms.ComboBox cbMotivo;
        private Microsoft.Reporting.WinForms.ReportViewer rpvReporteEstadistico;
        private System.Windows.Forms.BindingSource TablaReporteBindingSource;
        private DSReporteEstadistico DSReporteEstadistico;
    }
}