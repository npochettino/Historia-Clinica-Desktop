using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaHistorialMedico.Controladores;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace PresentacionHistorialMedico
{
    public partial class frmPacientes : Form
    {
        private string operacion;
        private string agregarOperacion = "A";
        private string modificarOperacion = "M";
        private string TAG_SEXO_MASCULINO = "M";
        private string TAG_SEXO_FEMENINO = "F";


        public frmPacientes()
        {
            InitializeComponent();
        }


        private void frmPacientes_Load(object sender, EventArgs e)
        {
            CargarDatosPantalla();

        }


        private void CargarDatosPantalla()
        {
            gcPacientes.DataSource = ControladorGeneral.RecuperarTodosPacientes();
            DataTable dtObraSocial = ControladorGeneral.RecuperarTodosObraSocial();
            cbObraSocial.DataSource = dtObraSocial;
            cbObraSocial.DisplayMember = "descripcion";
            cbObraSocial.ValueMember = "codigoObraSocial";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void Agregar()
        {
            operacion = agregarOperacion;
            Utils.ActualizarEstadogbDatos(gbDatos);

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string operacionActual = "";
            string titulo = "";
            string sexo = "";
            if (rbMasculino.Checked)
                sexo = TAG_SEXO_MASCULINO;
            else
                sexo = TAG_SEXO_FEMENINO;

            if (operacion.Equals(agregarOperacion))
            {
                operacionActual = "agregó";
                titulo = "Alta Paciente";
                ControladorGeneral.InsertarActualizarPaciente(0, txtNombreApellido.Text, txtTelefono.Text, txtEmail.Text, txtDireccion.Text, txtDNI.Text, sexo, int.Parse(cbObraSocial.SelectedValue.ToString()), txtTelefono2.Text);
            }
            else
            {
                operacionActual = "modificó";
                titulo = "Modificación Paciente";
                int codigo = obtenerCodigoFilaSeleccionada();

                ControladorGeneral.InsertarActualizarPaciente(codigo, txtNombreApellido.Text, txtTelefono.Text, txtEmail.Text, txtDireccion.Text, txtDNI.Text, sexo, int.Parse(cbObraSocial.SelectedValue.ToString()), txtTelefono2.Text);
            }

            Utils.MostrarMensajeDeInformacion("El Paciente se" + " " + operacionActual + " " + "correctamente", titulo);
            Utils.ActualizarEstadogbDatos(gbDatos);
            CargarDatosPantalla();
            LimpiarForm();
        }

        private void LimpiarForm()
        {
            txtDireccion.Clear();
            txtDNI.Clear();
            txtEmail.Clear();
            txtNombreApellido.Clear();
            txtTelefono.Clear();
            txtTelefono2.Clear();
        }

        private int obtenerCodigoFilaSeleccionada()
        {
            int codigo = 0;
            int[] arrIntFilasSeleccionadas = ((GridView)this.gcPacientes.MainView).GetSelectedRows();

            DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)gcPacientes.MainView).GetRow(arrIntFilasSeleccionadas[0]));

            return codigo = Convert.ToInt32(drvFilaSeleccionada[0]);
        }

        private void CargarDatosForm(int codigo)
        {

            DataTable dtPacienteActual = ControladorGeneral.RecuperarPacientePorCodigo(codigo);


            txtNombreApellido.Text = dtPacienteActual.Rows[0][1].ToString();
            txtTelefono.Text = dtPacienteActual.Rows[0][2].ToString();
            txtTelefono2.Text = dtPacienteActual.Rows[0][3].ToString();
            txtEmail.Text = dtPacienteActual.Rows[0][4].ToString();
            txtDireccion.Text = dtPacienteActual.Rows[0][5].ToString();
            txtDNI.Text = dtPacienteActual.Rows[0][6].ToString();
            if (dtPacienteActual.Rows[0]["sexo"].ToString().Equals(TAG_SEXO_FEMENINO))
                rbFemenino.Checked = true;
            else
                rbMasculino.Checked = true;
            cbObraSocial.SelectedValue = dtPacienteActual.Rows[0]["codigoObraSocial"].ToString();



        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void Modificar()
        {
            operacion = modificarOperacion;
            Utils.ActualizarEstadogbDatos(gbDatos);
            CargarDatosForm(obtenerCodigoFilaSeleccionada());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Utils.ActualizarEstadogbDatos(gbDatos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            Eliminar();
            LimpiarForm();
        }



        private void Eliminar()
        {

            if (Utils.MostrarMensajeConfirmacion("¿Está seguro que desea eliminar el paciente?"))

                try
                {
                    ControladorGeneral.EliminarPaciente(obtenerCodigoFilaSeleccionada());
                    Utils.MostrarMensajeDeInformacion("Se eliminó el paciente correctamente", "Eliminación de Paciente");
                }
                catch (Exception ex)
                {
                    Utils.MostrarMensajeDeError(ex);


                }


            CargarDatosPantalla();
        }

        private void verConsultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] selRows = ((GridView)this.gcPacientes.MainView).GetSelectedRows();

            DataRowView selRow = (DataRowView)(((GridView)gcPacientes.MainView).GetRow(selRows[0]));


            FrmConsultasPaciente mConsultasPacientes = new FrmConsultasPaciente();
            mConsultasPacientes.mCondigoPaciente = int.Parse(selRow[0].ToString());
            mConsultasPacientes.mNombrePaciente = selRow[1].ToString().ToString();

            mConsultasPacientes.ShowDialog();

        }

        private void gcPacientes_MouseDown(object sender, MouseEventArgs e)
        {
            gcPacientes.ContextMenuStrip = CMSPacientes;
        }

        private void verAntecedentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] selRows = ((GridView)this.gcPacientes.MainView).GetSelectedRows();

            DataRowView selRow = (DataRowView)(((GridView)gcPacientes.MainView).GetRow(selRows[0]));


            FrmAntecedentesPacientes mAntecedentesPacientes = new FrmAntecedentesPacientes();
            mAntecedentesPacientes.mCondigoPaciente = int.Parse(selRow[0].ToString());
            mAntecedentesPacientes.mNombrePaciente = selRow[1].ToString().ToString();

            mAntecedentesPacientes.ShowDialog();
        }



    }
}
