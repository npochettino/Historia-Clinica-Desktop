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
    public partial class FrmEstudiosConsultaPaciente : Form
    {
        DataTable tablaEstudios = new DataTable();
        public int mCodigoConsulta;
        private string operacionActual;
        private string titulo;

        public FrmEstudiosConsultaPaciente()
        {
            InitializeComponent();
        }

        private void FrmEstudiosConsultaPaciente_Load(object sender, EventArgs e)
        {
            tablaEstudios.Columns.Add("codigoEstudio");
            tablaEstudios.Columns.Add("descripcionEstudio");
            tablaEstudios.Columns.Add("resultado");
            CargarDatosPantalla();

        }

        private void CargarDatosPantalla()
        {
            gcEstudios.DataSource = ControladorGeneral.RecuperarTodosEstudios();
            tablaEstudios = ControladorGeneral.RecuperarTodosEstudioConsulta(mCodigoConsulta);
            gcEstudiosAsignados.DataSource = tablaEstudios;



        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {

            tablaEstudios.Rows.Add(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, obtenerCodigoFilaSeleccionadaEstudios(), obtenerDescripcionFilaSeleccionadaEstudios(), "");
            gcEstudiosAsignados.DataSource = tablaEstudios;

        }


        private int obtenerCodigoFilaSeleccionadaEstudios()
        {
            int codigo = 0;
            int[] arrIntFilasSeleccionadas = ((GridView)this.gcEstudios.MainView).GetSelectedRows();

            DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)gcEstudios.MainView).GetRow(arrIntFilasSeleccionadas[0]));

            return codigo = Convert.ToInt32(drvFilaSeleccionada[0]);
        }

        private string obtenerDescripcionFilaSeleccionadaEstudios()
        {
            string codigo = "";
            int[] arrIntFilasSeleccionadas = ((GridView)this.gcEstudios.MainView).GetSelectedRows();

            DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)gcEstudios.MainView).GetRow(arrIntFilasSeleccionadas[0]));

            return codigo = drvFilaSeleccionada[1].ToString();
        }


        private string obtenerResultadoFilaSeleccionadaEstudios()
        {

            int[] arrIntFilasSeleccionadas = ((GridView)this.gcEstudiosAsignados.MainView).GetSelectedRows();

            DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)gcEstudiosAsignados.MainView).GetRow(arrIntFilasSeleccionadas[0]));

            return drvFilaSeleccionada[12].ToString();



        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            int[] arrIntFilasSeleccionadas = ((GridView)this.gcEstudiosAsignados.MainView).GetSelectedRows();

            DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)gcEstudiosAsignados.MainView).GetRow(arrIntFilasSeleccionadas[0]));

            tablaEstudios.Rows.Remove(drvFilaSeleccionada.Row);
            gcEstudiosAsignados.DataSource = tablaEstudios;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            operacionActual = "cargados";
            titulo = "Estudios Consulta Paciente";

            //Elimino todos los estudios cargados para esta consulta
            ControladorGeneral.EliminarEstudioConsultaPorConsulta(mCodigoConsulta);

            //Vuelvo a cargar los estudios actualizados para esta consulta
            for (int i = 0; i < tablaEstudios.Rows.Count; i++)
            {

                ControladorGeneral.InsertarActualizarEstudioConsulta(0, mCodigoConsulta, int.Parse(tablaEstudios.Rows[i]["codigoEstudio"].ToString()), tablaEstudios.Rows[i]["resultado"].ToString());
            }

            Utils.MostrarMensajeDeInformacion("Los estudios consulta fueron" + " " + operacionActual + " " + "correctamente", titulo);
        }

        private void btnGuardarComentario_Click(object sender, EventArgs e)
        {
            GuardarResultadoEnDataTableEstudiosAsignados(rtResultado.Text);
        }

        private void GuardarResultadoEnDataTableEstudiosAsignados(string resultado)
        {

            int[] arrIntFilasSeleccionadas = ((GridView)this.gcEstudiosAsignados.MainView).GetSelectedRows();

            DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)gcEstudiosAsignados.MainView).GetRow(arrIntFilasSeleccionadas[0]));

            drvFilaSeleccionada[12] = resultado;

        }



        private void gcEstudiosAsignados_Click(object sender, EventArgs e)
        {
            rtResultado.Text = obtenerResultadoFilaSeleccionadaEstudios();

        }



    }
}
