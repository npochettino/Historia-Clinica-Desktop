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
    public partial class FrmAntecedentes : Form
    {
        public FrmAntecedentes()
        {
            InitializeComponent();
        }

        private string operacion;
        private string agregarOperacion = "A";
        private string modificarOperacion = "M";

        private void CargarGrilla()
        {
            gcAntecedentes.DataSource = ControladorGeneral.RecuperarTodosAntecedentes();
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

            DataTable dtAntecedente = ControladorGeneral.RecuperarAntecedentePorCodigo(codigo);

            txtDescripcion.Text = dtAntecedente.Rows[0][1].ToString();
            txtComentario.Text = dtAntecedente.Rows[0][2].ToString();
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
            string operacionActual = "";
            string titulo = "";
            if (operacion.Equals(agregarOperacion))
            {
                operacionActual = "Agregó";
                titulo = "Alta Antecedentes";
                ControladorGeneral.InsertarActualizarAntecedente(0, txtDescripcion.Text, txtComentario.Text);
            }
            else
            {
                operacionActual = "Modificó";
                titulo = "Modificacion Antecedentes";
                int codigo = obtenerCodigoFilaSeleccionada();
                ControladorGeneral.InsertarActualizarAntecedente(codigo, txtDescripcion.Text, txtComentario.Text);
            }

            Utils.MostrarMensajeDeInformacion("El Antecedente se" + " " + operacionActual + " " + "correctamente", titulo);
            Utils.ActualizarEstadogbDatos(gbDatos);
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

        private void Eliminar()
        {

            if (Utils.MostrarMensajeConfirmacion("¿Esta seguro que desea eliminar el Antecedente?"))

                try
                {
                    ControladorGeneral.EliminarAntecedente(obtenerCodigoFilaSeleccionada());
                    Utils.MostrarMensajeDeInformacion("Se elimino el antecedente correctamente", "Eliminacion de Antecendete");
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
        }
    }
}
