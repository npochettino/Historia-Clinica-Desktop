using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Catalogos;
using BibliotecaHistorialMedico.Clases;
using BibliotecaHistorialMedico.ClasesComplementarias;
using NHibernate;

namespace BibliotecaHistorialMedico.Controladores
{
    public class ControladorGeneral
    {
        public static DataTable RecuperarPacientes()
        {
            DataTable tablaPacientes = new DataTable();
            tablaPacientes.Columns.Add("codigoPaciente");
            tablaPacientes.Columns.Add("apellidoNombre");
            tablaPacientes.Columns.Add("telefono");
            tablaPacientes.Columns.Add("mail");
            tablaPacientes.Columns.Add("direccion");

            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                List<Paciente> listaPacientes = CatalogoPacientes.RecuperarTodos(nhSesion);
                tablaPacientes = (from p in listaPacientes select p).Aggregate(tablaPacientes, (dt, r) => { dt.Rows.Add(r.Codigo, r.ApellidoNombre, r.Telefono, r.Mail, r.Direccion); return dt; });

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                nhSesion.Close();
                nhSesion.Dispose();
            }

            return tablaPacientes;
        }

        public static void InsertarActualizarPaciente(int codigoPaciente, string apellidoNombre, string telefono, string mailPaciente, string direccion)
        {
            ISession nhSesion = ManejoNHibernate.IniciarSesion();

            try
            {
                Paciente paciente;

                if (codigoPaciente == 0)
                {
                    paciente = new Paciente();
                }
                else
                {
                    paciente = CatalogoPacientes.RecuperarPorCodigo(codigoPaciente);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
