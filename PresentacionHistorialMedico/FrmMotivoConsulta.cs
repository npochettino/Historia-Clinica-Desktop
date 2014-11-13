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
    public partial class FrmMotivoConsulta : Form
    {
        public FrmMotivoConsulta()
        {
            InitializeComponent();
        }

        private string operacion;
        private string agregarOperacion = "A";
        private string modificarOperacion = "M";

        private void FrmMotivoConsulta_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }



        private void CargarGrilla()
        {
            gcMotivoConsulta.DataSource = ControladorGeneral.RecuperarTodosMotivosConsulta();
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

            DataTable dtAntecedente = ControladorGeneral.RecuperarMotivoConsultaPorCodigo(codigo);


            txtDescripcion.Text = dtAntecedente.Rows[0]["descripcion"].ToString();

        }

        private int obtenerCodigoFilaSeleccionada()
        {
            int codigo = 0;
            int[] arrIntFilasSeleccionadas = ((GridView)this.gcMotivoConsulta.MainView).GetSelectedRows();

            DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)gcMotivoConsulta.MainView).GetRow(arrIntFilasSeleccionadas[0]));

            return codigo = Convert.ToInt32(drvFilaSeleccionada[0]);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string operacionActual = "";
            string titulo = "";
            if (operacion.Equals(agregarOperacion))
            {
                operacionActual = "agregó";
                titulo = "Alta Motivo de consulta";
                ControladorGeneral.InsertarActualizarMotivoConsulta(0, txtDescripcion.Text);
            }
            else
            {
                operacionActual = "modificó";
                titulo = "Modificación Motivo de consulta";
                int codigo = obtenerCodigoFilaSeleccionada();
                ControladorGeneral.InsertarActualizarMotivoConsulta(codigo, txtDescripcion.Text);
            }

            Utils.MostrarMensajeDeInformacion("El Motivo se" + " " + operacionActual + " " + "correctamente", titulo);
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

            if (Utils.MostrarMensajeConfirmacion("¿Está seguro que desea eliminar el Motivo de consulta?"))

                try
                {
                    ControladorGeneral.EliminarMotivoConsulta(obtenerCodigoFilaSeleccionada());
                    Utils.MostrarMensajeDeInformacion("Se eliminó el motivo consulta correctamente", "Eliminación de Motivo de consulta");
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

    }
}
