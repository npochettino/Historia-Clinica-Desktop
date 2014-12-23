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

namespace PresentacionHistorialMedico
{
    public partial class FrmReporteEstadistico : Form
    {
        public FrmReporteEstadistico()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmReporteEstadistico_Load(object sender, EventArgs e)
        {

            CargarForm();


            this.reportViewer1.RefreshReport();
        }

        private void CargarForm()
        {
            cbMotivo.DataSource = ControladorGeneral.RecuperarTodosMotivosConsulta();
            cbMotivo.DisplayMember = "descripcion";
            cbMotivo.ValueMember = "codigoMotivoConsulta";

            cbDiagnostico.DataSource = ControladorGeneral.RecuperarTodosDiagnosticos();
            cbDiagnostico.DisplayMember = "descripcion";
            cbDiagnostico.ValueMember = "codigoDiagnostico";
        }




    }
}
