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

        private string operacion;
        private string agregarOperacion = "A";
        private string modificarOperacion = "M";

        private void CargarGrilla()
        {
            //gcAntecedentes.DataSource = ControladorGeneral.RecuperarTodosAntecedentes();
        }

        private void FrmAntecedentes_Load(object sender, EventArgs e)
        {
            CargarGrilla();
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

            //DataTable dtAntecedente = ControladorGeneral.RecuperarAntecedentePorCodigo(codigo);


            //txtDescripcion.Text = dtAntecedente.Rows[0]["descripcion"].ToString();
            //txtComentario.Text = dtAntecedente.Rows[0]["comentario"].ToString();
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
                //ControladorGeneral.InsertarActualizarAntecedente(0, txtDescripcion.Text, txtComentario.Text);
            }
            else
            {
                operacionActual = "modificó";
                titulo = "Modificación Antecedentes";
                int codigo = obtenerCodigoFilaSeleccionada();
                //ControladorGeneral.InsertarActualizarAntecedente(codigo, txtDescripcion.Text, txtComentario.Text);
            }

            Utils.MostrarMensajeDeInformacion("El Antecedente se" + " " + operacionActual + " " + "correctamente", titulo);
            Utils.ActualizarEstadogbDatos(gbDatos);

            LimpiarForm();
            CargarGrilla();
        }

        private void LimpiarForm()
        {
            txtComentario.Clear();
            txtDescripcion.Clear();
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
                    //ControladorGeneral.EliminarAntecedente(obtenerCodigoFilaSeleccionada());
                    //Utils.MostrarMensajeDeInformacion("Se eliminó el antecedente correctamente", "Eliminación de Antecedente");
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
