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

        public FrmEstudiosConsultaPaciente()
        {
            InitializeComponent();
        }

        private void FrmEstudiosConsultaPaciente_Load(object sender, EventArgs e)
        {
            tablaEstudios.Columns.Add("codigoEstudio");
            tablaEstudios.Columns.Add("descripcion");
            CargarDatosPantalla();

        }

        private void CargarDatosPantalla()
        {
            gcEstudios.DataSource = ControladorGeneral.RecuperarTodosEstudios();
            gcEstudiosAsignados.DataSource = tablaEstudios;


        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            tablaEstudios.Rows.Add(obtenerCodigoFilaSeleccionadaEstudios(), obtenerDescripcionFilaSeleccionadaEstudios());
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



    }
}
