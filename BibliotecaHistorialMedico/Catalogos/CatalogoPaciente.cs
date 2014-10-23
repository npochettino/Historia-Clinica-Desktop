using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Clases;
using NHibernate;

namespace BibliotecaHistorialMedico.Catalogos
{
    class CatalogoPaciente
    {
        public static List<Paciente> RecuperarTodos(ISession nhSesion)
        {
            List<Paciente> listaPacientes = new List<Paciente>();

            try
            {
                string consulta = "from Paciente";
                listaPacientes = nhSesion.CreateQuery(consulta).List<Paciente>().ToList();
                return listaPacientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void InsertarActualizar(Paciente paciente, ISession nhSesion)
        {
            try
            {
                nhSesion.SaveOrUpdate(paciente);
                nhSesion.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Paciente RecuperarPorCodigo(int codigoPaciente, ISession nhSesion)
        {
            Paciente paciente;

            try
            {
                string consulta = "from Paciente p where p.Codigo = " + codigoPaciente;
                paciente = nhSesion.CreateQuery(consulta).UniqueResult<Paciente>();
                return paciente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Eliminar(Paciente paciente, ISession nhSesion)
        {
            try
            {
                nhSesion.Delete(paciente);
                nhSesion.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
