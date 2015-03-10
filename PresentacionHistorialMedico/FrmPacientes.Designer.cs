namespace PresentacionHistorialMedico
{
    partial class frmPacientes
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gcPacientes = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Telefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Direccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Codigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ObraSocial = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sexo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DNI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.lblTelefono2 = new System.Windows.Forms.Label();
            this.txtTelefono2 = new System.Windows.Forms.TextBox();
            this.cbObraSocial = new System.Windows.Forms.ComboBox();
            this.lblObraSocial = new System.Windows.Forms.Label();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbNombreApellido = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombreApellido = new System.Windows.Forms.TextBox();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnModificar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.CMSPacientes = new System.Windows.Forms.ContextMenuStrip();
            this.verConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verAntecedentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Telefono2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcPacientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.CMSPacientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.37078F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.62921F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.gcPacientes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(890, 399);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gcPacientes
            // 
            this.gcPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcPacientes.Location = new System.Drawing.Point(299, 3);
            this.gcPacientes.MainView = this.gridView1;
            this.gcPacientes.Name = "gcPacientes";
            this.gcPacientes.Size = new System.Drawing.Size(588, 393);
            this.gcPacientes.TabIndex = 0;
            this.gcPacientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gcPacientes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gcPacientes_MouseDown);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Nombre,
            this.Email,
            this.Telefono,
            this.Telefono2,
            this.Direccion,
            this.Codigo,
            this.ObraSocial,
            this.sexo,
            this.DNI});
            this.gridView1.GridControl = this.gcPacientes;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsFind.AlwaysVisible = true;
            // 
            // Nombre
            // 
            this.Nombre.Caption = "Nombre y apellido";
            this.Nombre.FieldName = "apellidoNombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.OptionsColumn.AllowEdit = false;
            this.Nombre.OptionsColumn.AllowFocus = false;
            this.Nombre.OptionsColumn.ReadOnly = true;
            this.Nombre.Visible = true;
            this.Nombre.VisibleIndex = 1;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "mail";
            this.Email.Name = "Email";
            this.Email.OptionsColumn.AllowEdit = false;
            this.Email.OptionsColumn.AllowFocus = false;
            this.Email.OptionsColumn.ReadOnly = true;
            this.Email.Visible = true;
            this.Email.VisibleIndex = 2;
            // 
            // Telefono
            // 
            this.Telefono.Caption = "Teléfono";
            this.Telefono.FieldName = "telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.OptionsColumn.AllowEdit = false;
            this.Telefono.OptionsColumn.AllowFocus = false;
            this.Telefono.OptionsColumn.ReadOnly = true;
            this.Telefono.Visible = true;
            this.Telefono.VisibleIndex = 3;
            // 
            // Direccion
            // 
            this.Direccion.Caption = "Dirección";
            this.Direccion.FieldName = "direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.OptionsColumn.AllowEdit = false;
            this.Direccion.OptionsColumn.AllowFocus = false;
            this.Direccion.OptionsColumn.ReadOnly = true;
            this.Direccion.Visible = true;
            this.Direccion.VisibleIndex = 5;
            // 
            // Codigo
            // 
            this.Codigo.Caption = "Codigo";
            this.Codigo.FieldName = "codigoPaciente";
            this.Codigo.Name = "Codigo";
            // 
            // ObraSocial
            // 
            this.ObraSocial.Caption = "Obra Social";
            this.ObraSocial.FieldName = "descripcionObraSocial";
            this.ObraSocial.Name = "ObraSocial";
            this.ObraSocial.OptionsColumn.AllowEdit = false;
            this.ObraSocial.OptionsColumn.AllowFocus = false;
            this.ObraSocial.OptionsColumn.ReadOnly = true;
            this.ObraSocial.Visible = true;
            this.ObraSocial.VisibleIndex = 6;
            // 
            // sexo
            // 
            this.sexo.Caption = "Sexo";
            this.sexo.FieldName = "sexo";
            this.sexo.Name = "sexo";
            this.sexo.OptionsColumn.AllowEdit = false;
            this.sexo.OptionsColumn.AllowFocus = false;
            this.sexo.OptionsColumn.ReadOnly = true;
            this.sexo.Visible = true;
            this.sexo.VisibleIndex = 7;
            // 
            // DNI
            // 
            this.DNI.Caption = "DNI";
            this.DNI.FieldName = "dni";
            this.DNI.Name = "DNI";
            this.DNI.OptionsColumn.AllowEdit = false;
            this.DNI.OptionsColumn.AllowFocus = false;
            this.DNI.OptionsColumn.ReadOnly = true;
            this.DNI.Visible = true;
            this.DNI.VisibleIndex = 0;
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
            this.panel1.Size = new System.Drawing.Size(290, 393);
            this.panel1.TabIndex = 1;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.lblTelefono2);
            this.gbDatos.Controls.Add(this.txtTelefono2);
            this.gbDatos.Controls.Add(this.cbObraSocial);
            this.gbDatos.Controls.Add(this.lblObraSocial);
            this.gbDatos.Controls.Add(this.rbFemenino);
            this.gbDatos.Controls.Add(this.rbMasculino);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Controls.Add(this.btnCancelar);
            this.gbDatos.Controls.Add(this.btnGuardar);
            this.gbDatos.Controls.Add(this.label5);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.lbEmail);
            this.gbDatos.Controls.Add(this.lbTelefono);
            this.gbDatos.Controls.Add(this.lbNombreApellido);
            this.gbDatos.Controls.Add(this.txtTelefono);
            this.gbDatos.Controls.Add(this.txtDireccion);
            this.gbDatos.Controls.Add(this.txtEmail);
            this.gbDatos.Controls.Add(this.txtDNI);
            this.gbDatos.Controls.Add(this.txtNombreApellido);
            this.gbDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDatos.Location = new System.Drawing.Point(0, 0);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(290, 393);
            this.gbDatos.TabIndex = 3;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos Paciente";
            this.gbDatos.Visible = false;
            // 
            // lblTelefono2
            // 
            this.lblTelefono2.AutoSize = true;
            this.lblTelefono2.Location = new System.Drawing.Point(18, 238);
            this.lblTelefono2.Name = "lblTelefono2";
            this.lblTelefono2.Size = new System.Drawing.Size(58, 13);
            this.lblTelefono2.TabIndex = 19;
            this.lblTelefono2.Text = "Teléfono 2";
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.Location = new System.Drawing.Point(108, 238);
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.Size = new System.Drawing.Size(152, 20);
            this.txtTelefono2.TabIndex = 18;
            // 
            // cbObraSocial
            // 
            this.cbObraSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbObraSocial.FormattingEnabled = true;
            this.cbObraSocial.Location = new System.Drawing.Point(108, 307);
            this.cbObraSocial.Name = "cbObraSocial";
            this.cbObraSocial.Size = new System.Drawing.Size(152, 21);
            this.cbObraSocial.TabIndex = 17;
            // 
            // lblObraSocial
            // 
            this.lblObraSocial.AutoSize = true;
            this.lblObraSocial.Location = new System.Drawing.Point(21, 307);
            this.lblObraSocial.Name = "lblObraSocial";
            this.lblObraSocial.Size = new System.Drawing.Size(60, 13);
            this.lblObraSocial.TabIndex = 16;
            this.lblObraSocial.Text = "Obra social";
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(189, 272);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 15;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(106, 272);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 14;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Sexo";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(173, 353);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 30);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(56, 353);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(91, 30);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Dirección";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(21, 122);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(32, 13);
            this.lbEmail.TabIndex = 7;
            this.lbEmail.Text = "Email";
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Location = new System.Drawing.Point(18, 200);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(49, 13);
            this.lbTelefono.TabIndex = 6;
            this.lbTelefono.Text = "Teléfono";
            // 
            // lbNombreApellido
            // 
            this.lbNombreApellido.AutoSize = true;
            this.lbNombreApellido.Location = new System.Drawing.Point(11, 43);
            this.lbNombreApellido.Name = "lbNombreApellido";
            this.lbNombreApellido.Size = new System.Drawing.Size(91, 13);
            this.lbNombreApellido.TabIndex = 5;
            this.lbNombreApellido.Text = "Nombre y apellido";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(108, 200);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(152, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(108, 159);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(152, 20);
            this.txtDireccion.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(108, 119);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(152, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(108, 80);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(152, 20);
            this.txtDNI.TabIndex = 1;
            // 
            // txtNombreApellido
            // 
            this.txtNombreApellido.Location = new System.Drawing.Point(108, 40);
            this.txtNombreApellido.Name = "txtNombreApellido";
            this.txtNombreApellido.Size = new System.Drawing.Size(154, 20);
            this.txtNombreApellido.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(94, 254);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 34);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(94, 170);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(99, 34);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(94, 81);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 34);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // CMSPacientes
            // 
            this.CMSPacientes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verConsultasToolStripMenuItem,
            this.verAntecedentesToolStripMenuItem});
            this.CMSPacientes.Name = "contextMenuStrip1";
            this.CMSPacientes.Size = new System.Drawing.Size(167, 48);
            // 
            // verConsultasToolStripMenuItem
            // 
            this.verConsultasToolStripMenuItem.Name = "verConsultasToolStripMenuItem";
            this.verConsultasToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.verConsultasToolStripMenuItem.Text = "Ver consultas";
            this.verConsultasToolStripMenuItem.Click += new System.EventHandler(this.verConsultasToolStripMenuItem_Click);
            // 
            // verAntecedentesToolStripMenuItem
            // 
            this.verAntecedentesToolStripMenuItem.Name = "verAntecedentesToolStripMenuItem";
            this.verAntecedentesToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.verAntecedentesToolStripMenuItem.Text = "Ver Antecedentes";
            this.verAntecedentesToolStripMenuItem.Click += new System.EventHandler(this.verAntecedentesToolStripMenuItem_Click);
            // 
            // Telefono2
            // 
            this.Telefono2.Caption = "Teléfono 2";
            this.Telefono2.FieldName = "telefono2";
            this.Telefono2.Name = "Telefono2";
            this.Telefono2.OptionsColumn.AllowEdit = false;
            this.Telefono2.OptionsColumn.AllowFocus = false;
            this.Telefono2.OptionsColumn.ReadOnly = true;
            this.Telefono2.Visible = true;
            this.Telefono2.VisibleIndex = 4;
            // 
            // frmPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 399);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmPacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.frmPacientes_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcPacientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.CMSPacientes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraGrid.GridControl gcPacientes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn Telefono;
        private DevExpress.XtraGrid.Columns.GridColumn Direccion;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnModificar;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtNombreApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbNombreApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDNI;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraGrid.Columns.GridColumn Codigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Label lblObraSocial;
        private System.Windows.Forms.ComboBox cbObraSocial;
        private System.Windows.Forms.ContextMenuStrip CMSPacientes;
        private System.Windows.Forms.ToolStripMenuItem verConsultasToolStripMenuItem;
        private DevExpress.XtraGrid.Columns.GridColumn ObraSocial;
        private DevExpress.XtraGrid.Columns.GridColumn sexo;
        private DevExpress.XtraGrid.Columns.GridColumn DNI;
        private System.Windows.Forms.ToolStripMenuItem verAntecedentesToolStripMenuItem;
        private System.Windows.Forms.Label lblTelefono2;
        private System.Windows.Forms.TextBox txtTelefono2;
        private DevExpress.XtraGrid.Columns.GridColumn Telefono2;
    }
}

