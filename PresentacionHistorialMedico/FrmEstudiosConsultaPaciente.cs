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
        DataTable tablaEstudiosAsignados = new DataTable();
        DataTable tablaEstudiosTodos = new DataTable();
        public int mCodigoConsulta;
        private string operacionActual;
        private string titulo;

        public FrmEstudiosConsultaPaciente()
        {
            InitializeComponent();
        }

        private void FrmEstudiosConsultaPaciente_Load(object sender, EventArgs e)
        {
            tablaEstudiosAsignados.Columns.Add("codigoEstudio");
            tablaEstudiosAsignados.Columns.Add("descripcionEstudio");
            tablaEstudiosAsignados.Columns.Add("resultado");
            CargarDatosPantalla();

        }

        private void CargarDatosPantalla()
        {
            tablaEstudiosTodos = ControladorGeneral.RecuperarTodosEstudios();
            gcEstudios.DataSource = tablaEstudiosTodos;
            tablaEstudiosAsignados = ControladorGeneral.RecuperarTodosEstudioConsulta(mCodigoConsulta);
            gcEstudiosAsignados.DataSource = tablaEstudiosAsignados;
            RefrescarGrillaEstudios();
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {

            tablaEstudiosAsignados.Rows.Add(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, obtenerCodigoFilaSeleccionadaEstudios(), obtenerDescripcionFilaSeleccionadaEstudios(), "");
            gcEstudiosAsignados.DataSource = tablaEstudiosAsignados;

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

            tablaEstudiosAsignados.Rows.Remove(drvFilaSeleccionada.Row);
            gcEstudiosAsignados.DataSource = tablaEstudiosAsignados;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tablaEstudiosAsignados.Clear();

            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            operacionActual = "cargados";
            titulo = "Estudios Consulta Paciente";

            //Elimino todos los estudios cargados para esta consulta
            ControladorGeneral.EliminarEstudioConsultaPorConsulta(mCodigoConsulta);

            //Vuelvo a cargar los estudios actualizados para esta consulta
            for (int i = 0; i < tablaEstudiosAsignados.Rows.Count; i++)
            {

                ControladorGeneral.InsertarActualizarEstudioConsulta(0, mCodigoConsulta, int.Parse(tablaEstudiosAsignados.Rows[i]["codigoEstudio"].ToString()), tablaEstudiosAsignados.Rows[i]["resultado"].ToString());
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

        private void RefrescarGrillaEstudios()
        {
            //DataTable tablaFiltrada = new DataTable();
            //DataRow[] foundRows = tablaEstudiosTodos.Select("codigoEstudio < 4");

            //tablaEstudiosTodos.Clear();
            //tablaEstudiosTodos.Rows.agre

            //for (int i = 0; i < foundRows.Length-1; i++)
            //{
            //    tablaFiltrada.Rows.Add(foundRows[i][0]);
            //}
            //gcEstudios.DataSource = tablaFiltrada;


        }

        private void gcEstudiosAsignados_Click(object sender, EventArgs e)
        {
            rtResultado.Text = obtenerResultadoFilaSeleccionadaEstudios();

        }



    }
}
