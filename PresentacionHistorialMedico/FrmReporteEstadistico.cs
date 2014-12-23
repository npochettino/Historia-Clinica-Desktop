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
        DataTable tablaReporte = new DataTable();
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
            dsReporte.TablaReporte.Clear();
            CargarReporte();
        }

        private void CargarReporte()
        {
            tablaReporte = ControladorGeneral.RecuperarConsultaPacientePorMotivoConsultaDiagnosticoYFecha(int.Parse(cbMotivo.SelectedValue.ToString()), int.Parse(cbDiagnostico.SelectedValue.ToString()), Convert.ToDateTime(dtpFechaDesde.Value), Convert.ToDateTime(dtpFechaHasta.Value));






            foreach (DataRow fila in tablaReporte.Rows)
            {
                DataRow filaReporte = dsReporte.TablaReporte.NewRow();
                filaReporte["fecha"] = fila["fecha"];
                filaReporte["nombreApellidoPaciente"] = fila["nombreApellidoPaciente"];
                filaReporte["comentario"] = fila["comentario"];
                filaReporte["obraSocial"] = fila["obraSocial"];

                dsReporte.TablaReporte.Rows.Add(filaReporte);

            }


            //ReportParameter[] parameters = new ReportParameter[2];
            ////Establecemos el valor de los parámetros
            //parameters[0] = new ReportParameter("motivoConsulta", cbMotivo.SelectedText);
            //parameters[1] = new ReportParameter("diagnostico", cbDiagnostico.SelectedText);
            //this.rpvReporteEstadistico.LocalReport.SetParameters(parameters);


            DSReporteEstadistico dsReporte1 = dsReporte;
            ReportDataSource datasource = new ReportDataSource("DSReporteEstadistico", dsReporte1.Tables[0]);
            rpvReporteEstadistico.LocalReport.DataSources.Clear();
            rpvReporteEstadistico.LocalReport.DataSources.Add(datasource);
            rpvReporteEstadistico.RefreshReport();
        }




    }
}
