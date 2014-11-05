using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace PresentacionHistorialMedico
{
    public class Utils
    {
        public static bool MostrarMensajeConfirmacion(string mensaje)
        {
            return (XtraMessageBox.Show(mensaje, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes);
        }

        public static void MostrarMensajeDeError(Exception ex)
        {
            XtraMessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MostrarMensajeDeInformacion(string mensaje, string titulo)
        {
            XtraMessageBox.Show(mensaje, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        internal static void ActualizarEstadogbDatos(GroupBox gbDatos)
        {
            if (gbDatos.Visible)
                gbDatos.Visible = false;
            else
                gbDatos.Visible = true;
        }
    }
}
