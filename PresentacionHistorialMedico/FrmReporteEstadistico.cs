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
using Microsoft.Reporting.WinForms;

namespace PresentacionHistorialMedico
{
    public partial class FrmReporteEstadistico : Form
    {

        DSReporteEstadistico dsReporte = new DSReporteEstadistico();
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


            this.rpvReporteEstadistico.RefreshReport();
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

        private void sbEmitir_Click(object sender, EventArgs e)
        {
            CargarReporte();
        }

        private void CargarReporte()
        {
            ////DataTable tablaReporte = ControladorGeneral.rec
            //foreach (DataRow fila in tablaReporte.Rows)
            //{
            //    DataRow filaReporte = dsReporte.TablaReporte.NewRow();
            //    filaReporte["fecha"] = fila["fecha"];
            //    filaReporte["nombreApellido"] = fila["nombreApellido"];
            //    filaReporte["comentario"] = fila["comentario"];
            //    filaReporte["obraSocial"] = fila["obraSocial"];

            //    dsReporte.TablaReporte.Rows.Add(filaReporte);

            //}

            ////rpvReporteEstadistico.ProcessingMode = ProcessingMode.Local;
            ////ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/ReportPagoaProfesores.rdlc");
            //DSReporteEstadistico dsReporte1 = dsReporte;
            //ReportDataSource datasource = new ReportDataSource("DSReportePagoProfesores", dsReporte1.Tables[0]);
            //rpvReporteEstadistico.LocalReport.DataSources.Clear();
            //rpvReporteEstadistico.LocalReport.DataSources.Add(datasource);
        }




    }
}
