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
    public partial class FrmDiagnosticos : Form
    {
        public FrmDiagnosticos()
        {
            InitializeComponent();
        }

        private string operacion;
        private string agregarOperacion = "A";
        private string modificarOperacion = "M";

        private void FrmDiagnosticos_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }


        private void CargarGrilla()
        {
            gcDiagnostico.DataSource = ControladorGeneral.RecuperarTodosDiagnosticos();
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

        private void Modificar()
        {
            operacion = modificarOperacion;
            Utils.ActualizarEstadogbDatos(gbDatos);
            CargarDatosForm(obtenerCodigoFilaSeleccionada());
        }

        private void CargarDatosForm(int codigo)
        {

            DataTable dtDiagnostico = ControladorGeneral.RecuperarDiagnosticoPorCodigo(codigo);

            txtDescripcion.Text = dtDiagnostico.Rows[0][1].ToString();
        }


        private int obtenerCodigoFilaSeleccionada()
        {
            int codigo = 0;
            int[] arrIntFilasSeleccionadas = ((GridView)this.gcDiagnostico.MainView).GetSelectedRows();

            DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)gcDiagnostico.MainView).GetRow(arrIntFilasSeleccionadas[0]));

            return codigo = Convert.ToInt32(drvFilaSeleccionada[0]);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Utils.ActualizarEstadogbDatos(gbDatos);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string operacionActual = "";
            string titulo = "";
            if (operacion.Equals(agregarOperacion))
            {
                operacionActual = "agregó";
                titulo = "Alta Diagnóstico";
                ControladorGeneral.InsertarActualizarDiagnostico(0, txtDescripcion.Text);
            }
            else
            {
                operacionActual = "modificó";
                titulo = "Modificación Diagnóstico";
                int codigo = obtenerCodigoFilaSeleccionada();
                ControladorGeneral.InsertarActualizarDiagnostico(codigo, txtDescripcion.Text);
            }

            Utils.MostrarMensajeDeInformacion("El Diagnóstico se" + " " + operacionActual + " " + "correctamente", titulo);
            Utils.ActualizarEstadogbDatos(gbDatos);
            CargarGrilla();
            LimpiarForm();
        }


        private void LimpiarForm()
        {
            txtDescripcion.Clear();

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
        private void Eliminar()
        {

            if (Utils.MostrarMensajeConfirmacion("¿Está seguro que desea eliminar el Diagnóstico?"))

                try
                {
                    ControladorGeneral.EliminarDiagnostico(obtenerCodigoFilaSeleccionada());
                    Utils.MostrarMensajeDeInformacion("Se eliminó el diagnóstico correctamente", "Eliminación de Diagnóstico");
                }
                catch (Exception ex)
                {
                    Utils.MostrarMensajeDeError(ex);


                }


            CargarGrilla();
        }
    }
}
