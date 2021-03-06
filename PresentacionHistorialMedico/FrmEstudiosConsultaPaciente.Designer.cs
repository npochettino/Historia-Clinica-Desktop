﻿namespace PresentacionHistorialMedico
{
    partial class FrmEstudiosConsultaPaciente
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
            this.gcEstudios = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estudios = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Resultado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gcEstudiosAsignados = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.codigoAsignado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.descripcionEstudioAsingado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ResultadoAsigando = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnIzquierda = new DevExpress.XtraEditors.SimpleButton();
            this.btnDerecha = new DevExpress.XtraEditors.SimpleButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.CMSComentario = new System.Windows.Forms.ContextMenuStrip();
            this.modificarComentarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcEstudios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEstudiosAsignados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.CMSComentario.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.Controls.Add(this.gcEstudios, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gcEstudiosAsignados, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(693, 272);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gcEstudios
            // 
            this.gcEstudios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcEstudios.Location = new System.Drawing.Point(3, 3);
            this.gcEstudios.MainView = this.gridView1;
            this.gcEstudios.Name = "gcEstudios";
            this.gcEstudios.Size = new System.Drawing.Size(309, 266);
            this.gcEstudios.TabIndex = 0;
            this.gcEstudios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.codigo,
            this.Estudios,
            this.Resultado});
            this.gridView1.GridControl = this.gcEstudios;
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
            // gcEstudiosAsignados
            // 
            this.gcEstudiosAsignados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcEstudiosAsignados.Location = new System.Drawing.Point(381, 3);
            this.gcEstudiosAsignados.MainView = this.gridView2;
            this.gcEstudiosAsignados.Name = "gcEstudiosAsignados";
            this.gcEstudiosAsignados.Size = new System.Drawing.Size(309, 266);
            this.gcEstudiosAsignados.TabIndex = 1;
            this.gcEstudiosAsignados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.gcEstudiosAsignados.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gcEstudiosAsignados_MouseDown);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.codigoAsignado,
            this.descripcionEstudioAsingado,
            this.ResultadoAsigando});
            this.gridView2.GridControl = this.gcEstudiosAsignados;
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
            this.descripcionEstudioAsingado.Caption = "Descripcion Estudio";
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
            this.ResultadoAsigando.OptionsColumn.AllowEdit = false;
            this.ResultadoAsigando.OptionsColumn.AllowFocus = false;
            this.ResultadoAsigando.OptionsColumn.ReadOnly = true;
            this.ResultadoAsigando.Visible = true;
            this.ResultadoAsigando.VisibleIndex = 1;
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
            this.btnIzquierda.Click += new System.EventHandler(this.btnIzquierda_Click);
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
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.59885F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.40115F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 272);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.68504F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(693, 127);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.63342F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.36658F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(319, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(371, 121);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.btnCancelar, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnGuardar, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(60, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(308, 115);
            this.tableLayoutPanel6.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(187, 42);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.Location = new System.Drawing.Point(31, 42);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 30);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // CMSComentario
            // 
            this.CMSComentario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarComentarioToolStripMenuItem});
            this.CMSComentario.Name = "CMSComentario";
            this.CMSComentario.Size = new System.Drawing.Size(181, 26);
            // 
            // modificarComentarioToolStripMenuItem
            // 
            this.modificarComentarioToolStripMenuItem.Name = "modificarComentarioToolStripMenuItem";
            this.modificarComentarioToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modificarComentarioToolStripMenuItem.Text = "Modificar Resultado";
            this.modificarComentarioToolStripMenuItem.Click += new System.EventHandler(this.modificarComentarioToolStripMenuItem_Click);
            // 
            // FrmEstudiosConsultaPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 399);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmEstudiosConsultaPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estudios Consulta";
            this.Load += new System.EventHandler(this.FrmEstudiosConsultaPaciente_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcEstudios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcEstudiosAsignados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.CMSComentario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gcEstudios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gcEstudiosAsignados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.SimpleButton btnDerecha;
        private DevExpress.XtraEditors.SimpleButton btnIzquierda;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private DevExpress.XtraGrid.Columns.GridColumn Estudios;
        private DevExpress.XtraGrid.Columns.GridColumn codigo;
        private DevExpress.XtraGrid.Columns.GridColumn codigoAsignado;
        private DevExpress.XtraGrid.Columns.GridColumn descripcionEstudioAsingado;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraGrid.Columns.GridColumn Resultado;
        private DevExpress.XtraGrid.Columns.GridColumn ResultadoAsigando;
        private System.Windows.Forms.ContextMenuStrip CMSComentario;
        private System.Windows.Forms.ToolStripMenuItem modificarComentarioToolStripMenuItem;
    }
}