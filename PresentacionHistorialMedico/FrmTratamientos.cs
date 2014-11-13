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
    public partial class FrmTratamientos : Form
    {
        public FrmTratamientos()
        {
            InitializeComponent();
        }

        private void FrmTratamientos_Load(object sender, EventArgs e)
        {
            CargarGrilla();
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
            gcTratamientos.DataSource = ControladorGeneral.RecuperarTodosTratamientos();
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

            DataTable dtTratamiento = ControladorGeneral.RecuperarTratamientoPorCodigo(codigo);

            txtDescripcion.Text = dtTratamiento.Rows[0][1].ToString();
        }


        private int obtenerCodigoFilaSeleccionada()
        {
            int codigo = 0;
            int[] arrIntFilasSeleccionadas = ((GridView)this.gcTratamientos.MainView).GetSelectedRows();

            DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)gcTratamientos.MainView).GetRow(arrIntFilasSeleccionadas[0]));

            return codigo = Convert.ToInt32(drvFilaSeleccionada[0]);
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

            if (Utils.MostrarMensajeConfirmacion("¿Está seguro que desea eliminar el Tratamiento?"))

                try
                {
                    ControladorGeneral.EliminarTratamiento(obtenerCodigoFilaSeleccionada());
                    Utils.MostrarMensajeDeInformacion("Se eliminó el Tratamiento correctamente", "Eliminación de Tratamiento");
                }
                catch (Exception ex)
                {
                    Utils.MostrarMensajeDeError(ex);


                }


            CargarGrilla();
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            Agregar();
        }

        private void btnModificar_Click_1(object sender, EventArgs e)
        {
            Modificar();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string operacionActual = "";
            string titulo = "";
            if (operacion.Equals(agregarOperacion))
            {
                operacionActual = "agregó";
                titulo = "Alta Tratamiento";
                ControladorGeneral.InsertarActualizarTratamiento(0, txtDescripcion.Text);
            }
            else
            {
                operacionActual = "modificó";
                titulo = "Modificación Tratamiento";
                int codigo = obtenerCodigoFilaSeleccionada();
                ControladorGeneral.InsertarActualizarTratamiento(codigo, txtDescripcion.Text);
            }

            Utils.MostrarMensajeDeInformacion("El Tratamiento se" + " " + operacionActual + " " + "correctamente", titulo);
            Utils.ActualizarEstadogbDatos(gbDatos);
            CargarGrilla();
            LimpiarForm();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Utils.ActualizarEstadogbDatos(gbDatos);
        }



    }

}
