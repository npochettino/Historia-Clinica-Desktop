namespace PresentacionHistorialMedico
{
    partial class FrmDiagnosticos
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
            this.tbDiagnosticos = new System.Windows.Forms.TableLayoutPanel();
            this.gcDiagnostico = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodigoDiagnostico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.lbDescripcion = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnModificar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.tbDiagnosticos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcDiagnostico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbDiagnosticos
            // 
            this.tbDiagnosticos.ColumnCount = 2;
            this.tbDiagnosticos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.83146F));
            this.tbDiagnosticos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.16854F));
            this.tbDiagnosticos.Controls.Add(this.gcDiagnostico, 1, 0);
            this.tbDiagnosticos.Controls.Add(this.panel1, 0, 0);
            this.tbDiagnosticos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDiagnosticos.Location = new System.Drawing.Point(0, 0);
            this.tbDiagnosticos.Name = "tbDiagnosticos";
            this.tbDiagnosticos.RowCount = 1;
            this.tbDiagnosticos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbDiagnosticos.Size = new System.Drawing.Size(890, 399);
            this.tbDiagnosticos.TabIndex = 0;
            // 
            // gcDiagnostico
            // 
            this.gcDiagnostico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcDiagnostico.Location = new System.Drawing.Point(312, 3);
            this.gcDiagnostico.MainView = this.gridView1;
            this.gcDiagnostico.Name = "gcDiagnostico";
            this.gcDiagnostico.Size = new System.Drawing.Size(575, 393);
            this.gcDiagnostico.TabIndex = 0;
            this.gcDiagnostico.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Descripcion,
            this.CodigoDiagnostico});
            this.gridView1.GridControl = this.gcDiagnostico;
            this.gridView1.Name = "gridView1";
            // 
            // Descripcion
            // 
            this.Descripcion.Caption = "Descripcion";
            this.Descripcion.FieldName = "descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.OptionsColumn.AllowEdit = false;
            this.Descripcion.OptionsColumn.AllowFocus = false;
            this.Descripcion.OptionsColumn.ReadOnly = true;
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 0;
            // 
            // CodigoDiagnostico
            // 
            this.CodigoDiagnostico.Caption = "Codigo";
            this.CodigoDiagnostico.FieldName = "codigoDiagnostico";
            this.CodigoDiagnostico.Name = "CodigoDiagnostico";
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
            this.panel1.Size = new System.Drawing.Size(303, 393);
            this.panel1.TabIndex = 1;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.btnCancelar);
            this.gbDatos.Controls.Add(this.btnGuardar);
            this.gbDatos.Controls.Add(this.lbDescripcion);
            this.gbDatos.Controls.Add(this.txtDescripcion);
            this.gbDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatos.Location = new System.Drawing.Point(0, 0);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(303, 393);
            this.gbDatos.TabIndex = 6;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos Diagnostico";
            this.gbDatos.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(173, 213);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(52, 213);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 30);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lbDescripcion
            // 
            this.lbDescripcion.AutoSize = true;
            this.lbDescripcion.Location = new System.Drawing.Point(16, 123);
            this.lbDescripcion.Name = "lbDescripcion";
            this.lbDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lbDescripcion.TabIndex = 5;
            this.lbDescripcion.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(106, 120);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(154, 20);
            this.txtDescripcion.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(102, 266);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 34);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(102, 182);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 34);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(102, 93);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 34);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // FrmDiagnosticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 399);
            this.Controls.Add(this.tbDiagnosticos);
            this.Name = "FrmDiagnosticos";
            this.Text = "Diagnosticos";
            this.Load += new System.EventHandler(this.FrmDiagnosticos_Load);
            this.tbDiagnosticos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcDiagnostico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbDiagnosticos;
        private DevExpress.XtraGrid.GridControl gcDiagnostico;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnModificar;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private System.Windows.Forms.GroupBox gbDatos;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private System.Windows.Forms.Label lbDescripcion;
        private System.Windows.Forms.TextBox txtDescripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoDiagnostico;
    }
}