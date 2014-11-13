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
    public partial class FrmEstudios : Form
    {
        public FrmEstudios()
        {
            InitializeComponent();
        }

        private string operacion;
        private string agregarOperacion = "A";
        private string modificarOperacion = "M";

        private void FrmEstudios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            gcEstudios.DataSource = ControladorGeneral.RecuperarTodosEstudios();
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

            DataTable dtAntecedente = ControladorGeneral.RecuperarEstudioPorCodigo(codigo);


            txtDescripcion.Text = dtAntecedente.Rows[0]["descripcion"].ToString();

        }


        private int obtenerCodigoFilaSeleccionada()
        {
            int codigo = 0;
            int[] arrIntFilasSeleccionadas = ((GridView)this.gcEstudios.MainView).GetSelectedRows();

            DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)gcEstudios.MainView).GetRow(arrIntFilasSeleccionadas[0]));

            return codigo = Convert.ToInt32(drvFilaSeleccionada[0]);
        }


        private void GuardarDatos()
        {
            string operacionActual = "";
            string titulo = "";
            if (operacion.Equals(agregarOperacion))
            {
                operacionActual = "agregó";
                titulo = "Alta Estudio";
                ControladorGeneral.InsertarActualizarEstudio(0, txtDescripcion.Text);
            }
            else
            {
                operacionActual = "modificó";
                titulo = "Modificación Estudio";
                int codigo = obtenerCodigoFilaSeleccionada();
                ControladorGeneral.InsertarActualizarEstudio(codigo, txtDescripcion.Text);
            }

            Utils.MostrarMensajeDeInformacion("El Estudio se" + " " + operacionActual + " " + "correctamente", titulo);
            Utils.ActualizarEstadogbDatos(gbDatos);

            LimpiarForm();
            CargarGrilla();
        }

        private void LimpiarForm()
        {
            txtDescripcion.Clear();
        }

        private void Eliminar()
        {

            if (Utils.MostrarMensajeConfirmacion("¿Está seguro que desea eliminar el Estudio?"))

                try
                {
                    ControladorGeneral.EliminarEstudio(obtenerCodigoFilaSeleccionada());
                    Utils.MostrarMensajeDeInformacion("Se eliminó el estudio correctamente", "Eliminación de Estudio");
                }
                catch (Exception ex)
                {
                    Utils.MostrarMensajeDeError(ex);


                }


            CargarGrilla();
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarDatos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            Cancelar();
        }

        private void Cancelar()
        {
            Utils.ActualizarEstadogbDatos(gbDatos);
            LimpiarForm();
        }

    }
}
