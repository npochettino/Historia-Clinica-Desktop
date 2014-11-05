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


        public frmPacientes()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmPacientes_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            gcPacientes.DataSource = ControladorGeneral.RecuperarTodosPacientes();
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
            if (operacion.Equals(agregarOperacion))
            {
                operacionActual = "agregó";
                titulo = "Alta Paciente";
                ControladorGeneral.InsertarActualizarPaciente(0, txtNombreApellido.Text, txtTelefono.Text, txtEmail.Text, txtDireccion.Text);
            }
            else
            {
                operacionActual = "modificó";
                titulo = "Modificación Paciente";
                int codigo = obtenerCodigoFilaSeleccionada();
                ControladorGeneral.InsertarActualizarPaciente(codigo, txtNombreApellido.Text, txtTelefono.Text, txtEmail.Text, txtDireccion.Text);
            }

            Utils.MostrarMensajeDeInformacion("El Paciente se" + " " + operacionActual + " " + "correctamente", titulo);
            Utils.ActualizarEstadogbDatos(gbDatos);
            CargarGrilla();
            LimpiarForm();
        }

        private void LimpiarForm()
        {
            txtDireccion.Clear();
            txtDNI.Clear();
            txtEmail.Clear();
            txtNombreApellido.Clear();
            txtTelefono.Clear();
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
            txtEmail.Text = dtPacienteActual.Rows[0][3].ToString();
            txtDireccion.Text = dtPacienteActual.Rows[0][4].ToString();
            txtDNI.Text = dtPacienteActual.Rows[0][2].ToString();


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


            CargarGrilla();
        }



    }
}
