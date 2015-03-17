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
    public partial class FrmAntecedentesPacientes : Form
    {
        public FrmAntecedentesPacientes()
        {
            InitializeComponent();
        }

        public int mCondigoPaciente;
        public string mNombrePaciente;
        private string operacion;
        private string agregarOperacion = "A";
        private string modificarOperacion = "M";

        private void CargarGrilla()
        {
            //Cargo la grilla
            gcAntecedentes.DataSource = ControladorGeneral.RecuperarAntecedentesPorPaciente(mCondigoPaciente);

        }

        private void FrmAntecedentes_Load(object sender, EventArgs e)
        {

            CargarDatosPantalla();
        }

        private void CargarDatosPantalla()
        {

            //Cargo la grilla
            gcAntecedentes.DataSource = ControladorGeneral.RecuperarAntecedentesPorPaciente(mCondigoPaciente);
            //Cargo el combobox
            DataTable dsDiagnosticoConsulta = ControladorGeneral.RecuperarTodosDiagnosticos(false);
            cbDiagnostico.DataSource = dsDiagnosticoConsulta;
            cbDiagnostico.DisplayMember = "descripcion";
            cbDiagnostico.ValueMember = "codigoDiagnostico";
            //Cargo el nombre del paciente
            txtNombrePaciente.Text = mNombrePaciente;
        }




        private void Agregar()
        {
            operacion = agregarOperacion;
            Utils.ActualizarEstadogbDatos(gbDatos);
        }

        private void Modificar()
        {
            operacion = modificarOperacion;
            Utils.ActualizarEstadogbDatos(gbDatos);
            CargarDatosForm(obtenerCodigoFilaSeleccionada());
        }

        private void CargarDatosForm(int codigo)
        {
            DataTable dtAntecedente = ControladorGeneral.RecuperarAntecedentePacientePorCodigo(obtenerCodigoFilaSeleccionada());

            cbDiagnostico.SelectedValue = dtAntecedente.Rows[0]["codigoDiagnostico"].ToString();
            txtNombrePaciente.Text = mNombrePaciente;
            txtComentario.Text = dtAntecedente.Rows[0]["comentario"].ToString();
            string mTipoDiagnostico = dtAntecedente.Rows[0]["tipo"].ToString();

            if (mTipoDiagnostico.Equals("P"))
                rbPersonal.Checked = true;
            else
                rbFamiliar.Checked = true;
        }


        private int obtenerCodigoFilaSeleccionada()
        {
            int codigo = 0;
            int[] arrIntFilasSeleccionadas = ((GridView)this.gcAntecedentes.MainView).GetSelectedRows();

            DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)gcAntecedentes.MainView).GetRow(arrIntFilasSeleccionadas[0]));

            return codigo = Convert.ToInt32(drvFilaSeleccionada[0]);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }

        private void GuardarDatos()
        {
            string operacionActual = "";
            string titulo = "";

            if (operacion.Equals(agregarOperacion))
            {
                operacionActual = "agregó";
                titulo = "Alta Antecedentes";
                ControladorGeneral.InsertarActualizarAntecedentePaciente(0, mCondigoPaciente, int.Parse(cbDiagnostico.SelectedValue.ToString()), txtComentario.Text, ObtenerTipoAntecenteSeleccionado());
            }
            else
            {
                operacionActual = "modificó";
                titulo = "Modificación Antecedentes";
                ControladorGeneral.InsertarActualizarAntecedentePaciente(obtenerCodigoFilaSeleccionada(), mCondigoPaciente, int.Parse(cbDiagnostico.SelectedValue.ToString()), txtComentario.Text, ObtenerTipoAntecenteSeleccionado());
            }

            Utils.MostrarMensajeDeInformacion("El Antecedente se" + " " + operacionActual + " " + "correctamente", titulo);
            Utils.ActualizarEstadogbDatos(gbDatos);

            LimpiarForm();
            CargarGrilla();
        }

        private string ObtenerTipoAntecenteSeleccionado()
        {
            if (rbFamiliar.Checked)
                return "F";
            else
                return "P";

        }

        private void LimpiarForm()
        {
            txtComentario.Clear();

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

        private void Eliminar()
        {

            if (Utils.MostrarMensajeConfirmacion("¿Está seguro que desea eliminar el Antecedente?"))

                try
                {
                    ControladorGeneral.EliminarAntecedentePaciente(obtenerCodigoFilaSeleccionada());
                    Utils.MostrarMensajeDeInformacion("se eliminó el antecedente correctamente", "eliminación de antecedente");
                }
                catch (Exception ex)
                {
                    Utils.MostrarMensajeDeError(ex);


                }


            CargarGrilla();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Utils.ActualizarEstadogbDatos(gbDatos);
            LimpiarForm();
        }
    }
}
