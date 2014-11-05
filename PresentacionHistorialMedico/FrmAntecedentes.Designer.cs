namespace PresentacionHistorialMedico
{
    partial class FrmAntecedentes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.btnModificar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.gcAntecedentes = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lbComentario = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Comentario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.gbDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAntecedentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbDatos);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(337, 393);
            this.panel1.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(119, 93);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 34);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(119, 182);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 34);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(119, 266);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 34);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lbComentario);
            this.gbDatos.Controls.Add(this.txtComentario);
            this.gbDatos.Controls.Add(this.btnCancelar);
            this.gbDatos.Controls.Add(this.btnGuardar);
            this.gbDatos.Controls.Add(this.lbDescripcion);
            this.gbDatos.Controls.Add(this.txtDescripcion);
            this.gbDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatos.Location = new System.Drawing.Point(0, 0);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(337, 393);
            this.gbDatos.TabIndex = 6;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos Antecedentes";
            this.gbDatos.Visible = false;
            // 
            // gcAntecedentes
            // 
            this.gcAntecedentes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcAntecedentes.Location = new System.Drawing.Point(346, 3);
            this.gcAntecedentes.MainView = this.gridView1;
            this.gcAntecedentes.Name = "gcAntecedentes";
            this.gcAntecedentes.Size = new System.Drawing.Size(541, 393);
            this.gcAntecedentes.TabIndex = 0;
            this.gcAntecedentes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Descripcion,
            this.Comentario,
            this.Codigo});
            this.gridView1.GridControl = this.gcAntecedentes;
            this.gridView1.Name = "gridView1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.61256F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.38744F));
            this.tableLayoutPanel1.Controls.Add(this.gcAntecedentes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(890, 399);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(203, 228);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(82, 228);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 30);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(46, 114);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbDescripcion.TabIndex = 13;
            this.lbDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(136, 111);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(154, 20);
            this.txtDescripcion.TabIndex = 12;
            // 
            // lbComentario
            // 
            this.lbComentario.AutoSize = true;
            this.lbComentario.Location = new System.Drawing.Point(46, 167);
            this.lbComentario.Name = "lbComentario";
            this.lbComentario.Size = new System.Drawing.Size(60, 13);
            this.lbComentario.TabIndex = 17;
            this.lbComentario.Text = "Comentario";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(136, 164);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(154, 20);
            this.txtComentario.TabIndex = 16;
            // 
            // Descripcion
            // 
            this.Descripcion.Caption = "Descripcio";
            this.Descripcion.FieldName = "descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.OptionsColumn.AllowEdit = false;
            this.Descripcion.OptionsColumn.AllowFocus = false;
            this.Descripcion.OptionsColumn.ReadOnly = true;
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 0;
            // 
            // Comentario
            // 
            this.Comentario.Caption = "Comentario";
            this.Comentario.FieldName = "comentario";
            this.Comentario.Name = "Comentario";
            this.Comentario.OptionsColumn.AllowEdit = false;
            this.Comentario.OptionsColumn.AllowFocus = false;
            this.Comentario.OptionsColumn.ReadOnly = true;
            this.Comentario.Visible = true;
            this.Comentario.VisibleIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Codigo";
            this.Codigo.FieldName = "codigoAntecedente";
            this.Codigo.Name = "Codigo";
            // 
            // FrmAntecedentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 399);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmAntecedentes";
            this.Text = "Antecedentes";
            this.Load += new System.EventHandler(this.FrmAntecedentes_Load);
            this.panel1.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcAntecedentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbDatos;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnModificar;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraGrid.GridControl gcAntecedentes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbComentario;
        private System.Windows.Forms.TextBox txtComentario;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Comentario;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;

    }
}