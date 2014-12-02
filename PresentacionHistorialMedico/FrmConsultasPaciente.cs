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
using DevExpress.XtraGrid.Views.Grid;

namespace PresentacionHistorialMedico
{
    public partial class FrmConsultasPaciente : Form
    {
        private short mCondigoCliente;
        private string operacion;
        private string agregarOperacion = "A";
        private string modificarOperacion = "M";

        public FrmConsultasPaciente()
        {
            InitializeComponent();
        }

        public FrmConsultasPaciente(short CodigoCliente)
        {

            this.mCondigoCliente = CodigoCliente;
        }

        private void FrmConsultasPaciente_Load(object sender, EventArgs e)
        {
            CargarDatosPantalla();

        }


        private void CargarDatosPantalla()
        {
            //Cargo la grilla
            gcConsultaPaciente.DataSource = ControladorGeneral.RecuperarTodosConsultaPaciente().Tables[0];
            //Cargo el combo del motivo consulta
            DataTable dsMotivosConsulta = ControladorGeneral.RecuperarTodosMotivosConsulta();
            cbMotivo.DataSource = dsMotivosConsulta;
            cbMotivo.DisplayMember = "descripcion";
            cbMotivo.ValueMember = "codigoMotivoConsulta";
            //Cargo el combo Diagnostico consulta
            DataTable dsDiagnosticoConsulta = ControladorGeneral.RecuperarTodosDiagnosticos();
            cbDiagnostico.DataSource = dsDiagnosticoConsulta;
            cbDiagnostico.DisplayMember = "descripcion";
            cbDiagnostico.ValueMember = "codigoDiagnostico";



        }

        private void Agregar()
        {
            operacion = agregarOperacion;
            Utils.ActualizarEstadogbDatos(gbDatos);

        }


        private void LimpiarForm()
        {
            txtPaciente.Clear();
            rtComentario.Clear();
        }

        private int obtenerCodigoFilaSeleccionada()
        {
            int codigo = 0;
            int[] arrIntFilasSeleccionadas = ((GridView)this.gcConsultaPaciente.MainView).GetSelectedRows();

            DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)gcConsultaPaciente.MainView).GetRow(arrIntFilasSeleccionadas[0]));

            return codigo = Convert.ToInt32(drvFilaSeleccionada[0]);
        }

        private int obtenerCodigoPacienteFilaSeleccionada()
        {
            int codigo = 0;
            int[] arrIntFilasSeleccionadas = ((GridView)this.gcConsultaPaciente.MainView).GetSelectedRows();

            DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)gcConsultaPaciente.MainView).GetRow(arrIntFilasSeleccionadas[0]));

            return codigo = Convert.ToInt32(drvFilaSeleccionada[1]);
        }



        private void CargarDatosForm(int codigo)
        {

            DataTable dsConsultaPacienteActual = ControladorGeneral.RecuperarConsultaPacientePorCodigo(codigo).Tables[0];

            dtpFechaConsulta.Value = DateTime.Parse(dsConsultaPacienteActual.Rows[0]["fecha"].ToString());
            txtPaciente.Text = dsConsultaPacienteActual.Rows[0]["nombreApellidoPaciente"].ToString();
            rtComentario.Text = dsConsultaPacienteActual.Rows[0]["comentario"].ToString();
            cbMotivo.SelectedValue = dsConsultaPacienteActual.Rows[0]["codigoMotivoConsulta"].ToString();
            cbDiagnostico.SelectedValue = dsConsultaPacienteActual.Rows[0]["codigoDiagnostico"].ToString();




        }


        private void Modificar()
        {
            operacion = modificarOperacion;
            Utils.ActualizarEstadogbDatos(gbDatos);
            CargarDatosForm(obtenerCodigoFilaSeleccionada());
        }

        private void Eliminar()
        {

            if (Utils.MostrarMensajeConfirmacion("¿Está seguro que desea eliminar la consulta del paciente?"))

                try
                {
                    ControladorGeneral.EliminarConsultaPaciente(obtenerCodigoFilaSeleccionada());
                    Utils.MostrarMensajeDeInformacion("Se eliminó la consulta del paciente correctamente", "Eliminación de Consulta Paciente");
                }
                catch (Exception ex)
                {
                    Utils.MostrarMensajeDeError(ex);


                }


            CargarDatosPantalla();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void Guardar()
        {
            string operacionActual = "";
            string titulo = "";



            if (operacion.Equals(agregarOperacion))
            {
                operacionActual = "agregó";
                titulo = "Alta Consulta Paciente";
                ControladorGeneral.InsertarActualizarConsultaPaciente(0, obtenerCodigoPacienteFilaSeleccionada(), dtpFechaConsulta.Value, rtComentario.Text, int.Parse(cbMotivo.SelectedValue.ToString()), int.Parse(cbDiagnostico.SelectedValue.ToString()), new List<int>());
            }
            else
            {
                operacionActual = "modificó";
                titulo = "Modificación Consulta Paciente";
                int codigo = obtenerCodigoFilaSeleccionada();

                ControladorGeneral.InsertarActualizarConsultaPaciente(obtenerCodigoFilaSeleccionada(), obtenerCodigoPacienteFilaSeleccionada(), dtpFechaConsulta.Value, rtComentario.Text, int.Parse(cbMotivo.SelectedValue.ToString()), int.Parse(cbDiagnostico.SelectedValue.ToString()), new List<int>());
            }

            Utils.MostrarMensajeDeInformacion("La consulta paciente se" + " " + operacionActual + " " + "correctamente", titulo);
            Utils.ActualizarEstadogbDatos(gbDatos);
            CargarDatosPantalla();
            LimpiarForm();
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Utils.ActualizarEstadogbDatos(gbDatos);
        }

    }
}
