namespace PresentacionHistorialMedico
{
    partial class FrmConsultasPaciente
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gcConsultaPaciente = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodigoPaciente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Paciente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Motivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Diagnostico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodigoMotivo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodigoDiagnostico = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtPaciente = new System.Windows.Forms.TextBox();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.cbDiagnostico = new System.Windows.Forms.ComboBox();
            this.lblDiagnostico = new System.Windows.Forms.Label();
            this.cbMotivo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblComentario = new System.Windows.Forms.Label();
            this.rtComentario = new System.Windows.Forms.RichTextBox();
            this.dtpFechaConsulta = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNombreApellido = new System.Windows.Forms.Label();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnModificar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.CMSEstudiosConsulta = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.estudiosRealizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tratamientoRealizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcConsultaPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.CMSEstudiosConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.79775F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.20225F));
            this.tableLayoutPanel1.Controls.Add(this.gcConsultaPaciente, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(890, 399);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gcConsultaPaciente
            // 
            this.gcConsultaPaciente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcConsultaPaciente.Location = new System.Drawing.Point(285, 3);
            this.gcConsultaPaciente.MainView = this.gridView1;
            this.gcConsultaPaciente.Name = "gcConsultaPaciente";
            this.gcConsultaPaciente.Size = new System.Drawing.Size(602, 393);
            this.gcConsultaPaciente.TabIndex = 0;
            this.gcConsultaPaciente.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcConsultaPaciente.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gcConsultaPaciente_MouseDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Codigo,
            this.CodigoPaciente,
            this.Fecha,
            this.Paciente,
            this.Motivo,
            this.Diagnostico,
            this.CodigoMotivo,
            this.CodigoDiagnostico});
            this.gridView1.GridControl = this.gcConsultaPaciente;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "codigo";
            this.Codigo.FieldName = "codigoConsultaPaciente";
            this.Codigo.Name = "Codigo";
            this.Codigo.OptionsColumn.AllowEdit = false;
            this.Codigo.OptionsColumn.AllowFocus = false;
            this.Codigo.OptionsColumn.ReadOnly = true;
            // 
            // CodigoPaciente
            // 
            this.CodigoPaciente.Caption = "CodigoPaciente";
            this.CodigoPaciente.FieldName = "codigoPaciente";
            this.CodigoPaciente.Name = "CodigoPaciente";
            // 
            // Fecha
            // 
            this.Fecha.Caption = "Fecha";
            this.Fecha.FieldName = "fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.OptionsColumn.AllowEdit = false;
            this.Fecha.OptionsColumn.AllowFocus = false;
            this.Fecha.OptionsColumn.ReadOnly = true;
            this.Fecha.Visible = true;
            this.Fecha.VisibleIndex = 0;
            // 
            // Paciente
            // 
            this.Paciente.Caption = "Paciente";
            this.Paciente.FieldName = "nombreApellidoPaciente";
            this.Paciente.Name = "Paciente";
            this.Paciente.OptionsColumn.AllowEdit = false;
            this.Paciente.OptionsColumn.AllowFocus = false;
            this.Paciente.OptionsColumn.ReadOnly = true;
            this.Paciente.Visible = true;
            this.Paciente.VisibleIndex = 1;
            // 
            // Motivo
            // 
            this.Motivo.Caption = "Motivo Consulta";
            this.Motivo.FieldName = "descripcionMotivoConsulta";
            this.Motivo.Name = "Motivo";
            this.Motivo.OptionsColumn.AllowEdit = false;
            this.Motivo.OptionsColumn.AllowFocus = false;
            this.Motivo.OptionsColumn.ReadOnly = true;
            this.Motivo.Visible = true;
            this.Motivo.VisibleIndex = 2;
            // 
            // Diagnostico
            // 
            this.Diagnostico.Caption = "Diagnostico";
            this.Diagnostico.FieldName = "descripcionDiagnostico";
            this.Diagnostico.Name = "Diagnostico";
            this.Diagnostico.OptionsColumn.AllowEdit = false;
            this.Diagnostico.OptionsColumn.AllowFocus = false;
            this.Diagnostico.OptionsColumn.ReadOnly = true;
            this.Diagnostico.Visible = true;
            this.Diagnostico.VisibleIndex = 3;
            // 
            // CodigoMotivo
            // 
            this.CodigoMotivo.Caption = "CodigoMotivo";
            this.CodigoMotivo.FieldName = "codigoMotivoConsulta";
            this.CodigoMotivo.Name = "CodigoMotivo";
            // 
            // CodigoDiagnostico
            // 
            this.CodigoDiagnostico.Caption = "CodigoDiagnostico";
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
            this.panel1.Size = new System.Drawing.Size(276, 393);
            this.panel1.TabIndex = 1;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtPaciente);
            this.gbDatos.Controls.Add(this.btnCancelar);
            this.gbDatos.Controls.Add(this.btnGuardar);
            this.gbDatos.Controls.Add(this.cbDiagnostico);
            this.gbDatos.Controls.Add(this.lblDiagnostico);
            this.gbDatos.Controls.Add(this.cbMotivo);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.lblComentario);
            this.gbDatos.Controls.Add(this.rtComentario);
            this.gbDatos.Controls.Add(this.dtpFechaConsulta);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.lbNombreApellido);
            this.gbDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatos.Location = new System.Drawing.Point(0, 0);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(276, 393);
            this.gbDatos.TabIndex = 6;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos Consulta Paciente";
            this.gbDatos.Visible = false;
            // 
            // txtPaciente
            // 
            this.txtPaciente.Enabled = false;
            this.txtPaciente.Location = new System.Drawing.Point(103, 85);
            this.txtPaciente.Name = "txtPaciente";
            this.txtPaciente.Size = new System.Drawing.Size(156, 20);
            this.txtPaciente.TabIndex = 19;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(172, 357);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelar.TabIndex = 18;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(51, 357);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 30);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // cbDiagnostico
            // 
            this.cbDiagnostico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiagnostico.FormattingEnabled = true;
            this.cbDiagnostico.Location = new System.Drawing.Point(103, 170);
            this.cbDiagnostico.Name = "cbDiagnostico";
            this.cbDiagnostico.Size = new System.Drawing.Size(156, 21);
            this.cbDiagnostico.TabIndex = 16;
            // 
            // lblDiagnostico
            // 
            this.lblDiagnostico.AutoSize = true;
            this.lblDiagnostico.Location = new System.Drawing.Point(14, 173);
            this.lblDiagnostico.Name = "lblDiagnostico";
            this.lblDiagnostico.Size = new System.Drawing.Size(63, 13);
            this.lblDiagnostico.TabIndex = 15;
            this.lblDiagnostico.Text = "Diagnostico";
            // 
            // cbMotivo
            // 
            this.cbMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMotivo.FormattingEnabled = true;
            this.cbMotivo.Location = new System.Drawing.Point(103, 124);
            this.cbMotivo.Name = "cbMotivo";
            this.cbMotivo.Size = new System.Drawing.Size(156, 21);
            this.cbMotivo.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Motivo Consulta";
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(17, 203);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(60, 13);
            this.lblComentario.TabIndex = 11;
            this.lblComentario.Text = "Comentario";
            // 
            // rtComentario
            // 
            this.rtComentario.Location = new System.Drawing.Point(17, 228);
            this.rtComentario.Name = "rtComentario";
            this.rtComentario.Size = new System.Drawing.Size(242, 118);
            this.rtComentario.TabIndex = 10;
            this.rtComentario.Text = "";
            // 
            // dtpFechaConsulta
            // 
            this.dtpFechaConsulta.Location = new System.Drawing.Point(103, 36);
            this.dtpFechaConsulta.Name = "dtpFechaConsulta";
            this.dtpFechaConsulta.Size = new System.Drawing.Size(156, 20);
            this.dtpFechaConsulta.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Fecha";
            // 
            // lbNombreApellido
            // 
            this.lbNombreApellido.AutoSize = true;
            this.lbNombreApellido.Location = new System.Drawing.Point(20, 85);
            this.lbNombreApellido.Name = "lbNombreApellido";
            this.lbNombreApellido.Size = new System.Drawing.Size(49, 13);
            this.lbNombreApellido.TabIndex = 7;
            this.lbNombreApellido.Text = "Paciente";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(89, 266);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 34);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(89, 182);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 34);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(89, 93);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 34);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // CMSEstudiosConsulta
            // 
            this.CMSEstudiosConsulta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudiosRealizadosToolStripMenuItem,
            this.tratamientoRealizadosToolStripMenuItem});
            this.CMSEstudiosConsulta.Name = "CMSEstudiosConsulta";
            this.CMSEstudiosConsulta.Size = new System.Drawing.Size(198, 48);
            // 
            // estudiosRealizadosToolStripMenuItem
            // 
            this.estudiosRealizadosToolStripMenuItem.Name = "estudiosRealizadosToolStripMenuItem";
            this.estudiosRealizadosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.estudiosRealizadosToolStripMenuItem.Text = "Estudios Realizados";
            this.estudiosRealizadosToolStripMenuItem.Click += new System.EventHandler(this.estudiosRealizadosToolStripMenuItem_Click);
            // 
            // tratamientoRealizadosToolStripMenuItem
            // 
            this.tratamientoRealizadosToolStripMenuItem.Name = "tratamientoRealizadosToolStripMenuItem";
            this.tratamientoRealizadosToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.tratamientoRealizadosToolStripMenuItem.Text = "Tratamiento Realizados";
            this.tratamientoRealizadosToolStripMenuItem.Click += new System.EventHandler(this.tratamientoRealizadosToolStripMenuItem_Click);
            // 
            // FrmConsultasPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 399);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmConsultasPaciente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultas Paciente";
            this.Load += new System.EventHandler(this.FrmConsultasPaciente_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcConsultaPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.CMSEstudiosConsulta.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gcConsultaPaciente;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnModificar;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lbNombreApellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaConsulta;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.RichTextBox rtComentario;
        private System.Windows.Forms.ComboBox cbMotivo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbDiagnostico;
        private System.Windows.Forms.Label lblDiagnostico;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private System.Windows.Forms.TextBox txtPaciente;
        private DevExpress.XtraGrid.Columns.GridColumn Paciente;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha;
        private DevExpress.XtraGrid.Columns.GridColumn Motivo;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private DevExpress.XtraGrid.Columns.GridColumn Diagnostico;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoMotivo;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoPaciente;
        private DevExpress.XtraGrid.Columns.GridColumn CodigoDiagnostico;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private System.Windows.Forms.ContextMenuStrip CMSEstudiosConsulta;
        private System.Windows.Forms.ToolStripMenuItem estudiosRealizadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tratamientoRealizadosToolStripMenuItem;
    }
}