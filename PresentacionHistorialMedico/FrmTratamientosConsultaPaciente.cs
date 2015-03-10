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

        DataTable tablaTratamientosAsignados = new DataTable();
        DataTable tablaTratamientosTodos = new DataTable();
        public int mCodigoConsulta;
        private string operacionActual;
        private string titulo;

        public FrmTratamientosConsultaPaciente()
        {
            InitializeComponent();
        }

        private void FrmTratamientosConsultaPaciente_Load(object sender, EventArgs e)
        {
            tablaTratamientosAsignados.Columns.Add("codigoTratamiento");
            tablaTratamientosAsignados.Columns.Add("descripcionTratamiento");
            tablaTratamientosAsignados.Columns.Add("comentario");
            CargarDatosPantalla();
        }

        private void CargarDatosPantalla()
        {
            tablaTratamientosTodos = ControladorGeneral.RecuperarTodosTratamientos();
            gcTratamientos.DataSource = tablaTratamientosTodos;
            tablaTratamientosAsignados = ControladorGeneral.RecuperarTratamientosConsultaPorConsulta(mCodigoConsulta);
            gcTratamienosAsignados.DataSource = tablaTratamientosAsignados;

        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            tablaTratamientosAsignados.Rows.Add(obtenerCodigoFilaSeleccionadaEstudios(), obtenerDescripcionFilaSeleccionadaEstudios(), "");
            gcTratamienosAsignados.DataSource = tablaTratamientosAsignados;
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

            if (arrIntFilasSeleccionadas.Length != 0)
            {

                DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)gcTratamienosAsignados.MainView).GetRow(arrIntFilasSeleccionadas[0]));

                tablaTratamientosAsignados.Rows.Remove(drvFilaSeleccionada.Row);
                gcTratamienosAsignados.DataSource = tablaTratamientosAsignados;
            }
            else
                Utils.MostrarMensajeDeInformacion("No hay fila seleccionada", "Error");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            operacionActual = "cargados";
            titulo = "Tratamientos Consulta Paciente";

            //Elimino todos los tratamientos cargados para esta consulta
            ControladorGeneral.EliminarTratamientosConsultaPorConsulta(mCodigoConsulta);

            //Vuelvo a cargar los estudios actualizados para esta consulta
            for (int i = 0; i < tablaTratamientosAsignados.Rows.Count; i++)
            {

                ControladorGeneral.InsertarConsultaTratamiento(mCodigoConsulta, int.Parse(tablaTratamientosAsignados.Rows[i]["codigoTratamiento"].ToString()),tablaTratamientosAsignados.Rows[i]["comentario"].ToString());
            }

            Utils.MostrarMensajeDeInformacion("Los tratamientos consulta fueron" + " " + operacionActual + " " + "correctamente", titulo);
        }

        private void gcTratamienosAsignados_MouseDown(object sender, MouseEventArgs e)
        {
            gcTratamienosAsignados.ContextMenuStrip = CTMTratamientoConsulta;
        }

        private void modificarComentarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmComentario frmComentario = new FrmComentario(this);
            frmComentario.isTratamiento = true;
            frmComentario.ShowDialog();

        }


        public void GuardarEnDataTableAsignados(string resultado)
        {

            int[] arrIntFilasSeleccionadas = ((GridView)this.gcTratamienosAsignados.MainView).GetSelectedRows();

            DataRowView drvFilaSeleccionada = (DataRowView)(((GridView)gcTratamienosAsignados.MainView).GetRow(arrIntFilasSeleccionadas[0]));

            drvFilaSeleccionada[2] = resultado;

            tablaTratamientosAsignados = (DataTable)gcTratamienosAsignados.DataSource;

            gcTratamienosAsignados.DataSource = tablaTratamientosAsignados;



        }
    }
}
