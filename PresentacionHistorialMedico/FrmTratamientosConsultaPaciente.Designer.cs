namespace PresentacionHistorialMedico
{
    partial class FrmTratamientosConsultaPaciente
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gcTratamientos = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estudios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Resultado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcTratamienosAsignados = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.codigoAsignado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.descripcionEstudioAsingado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ResultadoAsigando = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnIzquierda = new DevExpress.XtraEditors.SimpleButton();
            this.btnDerecha = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblResultadoEstudio = new System.Windows.Forms.Label();
            this.rtResultado = new System.Windows.Forms.RichTextBox();
            this.btnGuardarComentario = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcTratamientos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTratamienosAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.Controls.Add(this.gcTratamientos, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gcTratamienosAsignados, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(693, 272);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // gcTratamientos
            // 
            this.gcTratamientos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTratamientos.Location = new System.Drawing.Point(3, 3);
            this.gcTratamientos.MainView = this.gridView1;
            this.gcTratamientos.Name = "gcTratamientos";
            this.gcTratamientos.Size = new System.Drawing.Size(309, 266);
            this.gcTratamientos.TabIndex = 0;
            this.gcTratamientos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.codigo,
            this.Estudios,
            this.Resultado});
            this.gridView1.GridControl = this.gcTratamientos;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // codigo
            // 
            this.codigo.Caption = "Codigo";
            this.codigo.FieldName = "codigoEstudio";
            this.codigo.Name = "codigo";
            this.codigo.OptionsColumn.AllowEdit = false;
            this.codigo.OptionsColumn.AllowFocus = false;
            // 
            // Estudios
            // 
            this.Estudios.Caption = "Descripcion Estudio";
            this.Estudios.FieldName = "descripcionEstudio";
            this.Estudios.Name = "Estudios";
            this.Estudios.OptionsColumn.AllowEdit = false;
            this.Estudios.OptionsColumn.AllowFocus = false;
            this.Estudios.OptionsColumn.ReadOnly = true;
            this.Estudios.Visible = true;
            this.Estudios.VisibleIndex = 0;
            // 
            // Resultado
            // 
            this.Resultado.Caption = "Resultado";
            this.Resultado.FieldName = "resultado";
            this.Resultado.Name = "Resultado";
            // 
            // gcTratamienosAsignados
            // 
            this.gcTratamienosAsignados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcTratamienosAsignados.Location = new System.Drawing.Point(381, 3);
            this.gcTratamienosAsignados.MainView = this.gridView2;
            this.gcTratamienosAsignados.Name = "gcTratamienosAsignados";
            this.gcTratamienosAsignados.Size = new System.Drawing.Size(309, 266);
            this.gcTratamienosAsignados.TabIndex = 1;
            this.gcTratamienosAsignados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.codigoAsignado,
            this.descripcionEstudioAsingado,
            this.ResultadoAsigando});
            this.gridView2.GridControl = this.gcTratamienosAsignados;
            this.gridView2.Name = "gridView2";
            // 
            // codigoAsignado
            // 
            this.codigoAsignado.Caption = "CodigoAsignado";
            this.codigoAsignado.FieldName = "codigoEstudio";
            this.codigoAsignado.Name = "codigoAsignado";
            // 
            // descripcionEstudioAsingado
            // 
            this.descripcionEstudioAsingado.Caption = "Descripcion Estdudio";
            this.descripcionEstudioAsingado.FieldName = "descripcionEstudio";
            this.descripcionEstudioAsingado.Name = "descripcionEstudioAsingado";
            this.descripcionEstudioAsingado.OptionsColumn.AllowEdit = false;
            this.descripcionEstudioAsingado.OptionsColumn.AllowFocus = false;
            this.descripcionEstudioAsingado.OptionsColumn.ReadOnly = true;
            this.descripcionEstudioAsingado.Visible = true;
            this.descripcionEstudioAsingado.VisibleIndex = 0;
            // 
            // ResultadoAsigando
            // 
            this.ResultadoAsigando.Caption = "ResultadoAsignado";
            this.ResultadoAsigando.FieldName = "resultado";
            this.ResultadoAsigando.Name = "ResultadoAsigando";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnIzquierda, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnDerecha, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(318, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(57, 266);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnIzquierda
            // 
            this.btnIzquierda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzquierda.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzquierda.Appearance.Options.UseFont = true;
            this.btnIzquierda.Location = new System.Drawing.Point(17, 188);
            this.btnIzquierda.Name = "btnIzquierda";
            this.btnIzquierda.Size = new System.Drawing.Size(23, 23);
            this.btnIzquierda.TabIndex = 2;
            this.btnIzquierda.Text = "<<";
            // 
            // btnDerecha
            // 
            this.btnDerecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDerecha.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDerecha.Appearance.Options.UseFont = true;
            this.btnDerecha.Location = new System.Drawing.Point(17, 55);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(23, 23);
            this.btnDerecha.TabIndex = 1;
            this.btnDerecha.Text = ">>";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.25686F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.74314F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 272);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(693, 127);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.btnCancelar, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnGuardar, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(379, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(311, 121);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(189, 45);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.Location = new System.Drawing.Point(32, 45);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 30);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel4.Controls.Add(this.lblResultadoEstudio, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.rtResultado, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnGuardarComentario, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 272);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.52892F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.47108F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(693, 127);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // lblResultadoEstudio
            // 
            this.lblResultadoEstudio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResultadoEstudio.AutoSize = true;
            this.lblResultadoEstudio.Location = new System.Drawing.Point(259, 3);
            this.lblResultadoEstudio.Name = "lblResultadoEstudio";
            this.lblResultadoEstudio.Size = new System.Drawing.Size(96, 13);
            this.lblResultadoEstudio.TabIndex = 0;
            this.lblResultadoEstudio.Text = "Resultado Estudio:";
            // 
            // rtResultado
            // 
            this.rtResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtResultado.Location = new System.Drawing.Point(3, 23);
            this.rtResultado.Name = "rtResultado";
            this.rtResultado.Size = new System.Drawing.Size(609, 101);
            this.rtResultado.TabIndex = 1;
            this.rtResultado.Text = "";
            // 
            // btnGuardarComentario
            // 
            this.btnGuardarComentario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardarComentario.Location = new System.Drawing.Point(618, 58);
            this.btnGuardarComentario.Name = "btnGuardarComentario";
            this.btnGuardarComentario.Size = new System.Drawing.Size(72, 30);
            this.btnGuardarComentario.TabIndex = 16;
            this.btnGuardarComentario.Text = "Guardar";
            // 
            // FrmTratamientosConsultaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 399);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmTratamientosConsultaPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tratamientos Consulta";
            this.Load += new System.EventHandler(this.FrmTratamientosConsultaPaciente_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcTratamientos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcTratamienosAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gcTratamientos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn codigo;
        private DevExpress.XtraGrid.Columns.GridColumn Estudios;
        private DevExpress.XtraGrid.Columns.GridColumn Resultado;
        private DevExpress.XtraGrid.GridControl gcTratamienosAsignados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn codigoAsignado;
        private DevExpress.XtraGrid.Columns.GridColumn descripcionEstudioAsingado;
        private DevExpress.XtraGrid.Columns.GridColumn ResultadoAsigando;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btnIzquierda;
        private DevExpress.XtraEditors.SimpleButton btnDerecha;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblResultadoEstudio;
        private System.Windows.Forms.RichTextBox rtResultado;
        private DevExpress.XtraEditors.SimpleButton btnGuardarComentario;

    }
}