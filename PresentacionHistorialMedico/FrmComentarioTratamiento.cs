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
    public partial class FrmComentario : Form
    {
        private Form frmSource;
        public Boolean isTratamiento;

        public FrmComentario(Form frmSource)
        {
            InitializeComponent();
            this.frmSource = frmSource;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (isTratamiento)
                ((FrmTratamientosConsultaPaciente)this.frmSource).GuardarEnDataTableAsignados(rtComentario.Text);
            else
                ((FrmEstudiosConsultaPaciente)this.frmSource).GuardarEnDataTableAsignados(rtComentario.Text);

            this.Close();
        }

        private void FrmComentario_Load(object sender, EventArgs e)
        {
            if (isTratamiento)
            {
                lblComentario.Text = "Comentario";
                this.Text = "Modificar Comentario";
            }
            else
            {
                lblComentario.Text = "Resultado";
                this.Text = "Modificar Resultado";
            }
        }



    }
}
