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
    public partial class FrmTratamientosConsultaPaciente : Form
    {

        DataTable tablaTratamientos = new DataTable();
        public int mCodigoConsulta;
        private string operacionActual;
        private string titulo;
        public FrmTratamientosConsultaPaciente()
        {
            InitializeComponent();
        }

        private void FrmTratamientosConsultaPaciente_Load(object sender, EventArgs e)
        {
            tablaTratamientos.Columns.Add("codigoTratamiento");
            tablaTratamientos.Columns.Add("descripcionTratamiento");
            CargarDatosPantalla();
        }

        private void CargarDatosPantalla()
        {
            gcTratamientos.DataSource = ControladorGeneral.RecuperarTodosTratamientos();
            //tablaTratamientos = ControladorGeneral.RecuperarT
            gcTratamienosAsignados.DataSource = tablaTratamientos;
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            tablaTratamientos.Rows.Add(obtenerCodigoFilaSeleccionadaEstudios(), obtenerDescripcionFilaSeleccionadaEstudios());
            gcTratamienosAsignados.DataSource = tablaTratamientos;
        }

        private string obtenerDescripcionFilaSeleccionadaEstudios()
        {

            int[] arrIntFilasSeleccionadas = ((GridView)this.gcTratamientos.MainView).GetSelectedRows();

            DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)gcTratamientos.MainView).GetRow(arrIntFilasSeleccionadas[0]));

            return drvFilaSeleccionada[1].ToString();
        }


        private int obtenerCodigoFilaSeleccionadaEstudios()
        {
            int codigo = 0;
            int[] arrIntFilasSeleccionadas = ((GridView)this.gcTratamientos.MainView).GetSelectedRows();

            DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)gcTratamientos.MainView).GetRow(arrIntFilasSeleccionadas[0]));

            return codigo = Convert.ToInt32(drvFilaSeleccionada[0]);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            int[] arrIntFilasSeleccionadas = ((GridView)this.gcTratamienosAsignados.MainView).GetSelectedRows();

            DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)gcTratamienosAsignados.MainView).GetRow(arrIntFilasSeleccionadas[0]));

            tablaTratamientos.Rows.Remove(drvFilaSeleccionada.Row);
            gcTratamienosAsignados.DataSource = tablaTratamientos;
        }
    }
}
