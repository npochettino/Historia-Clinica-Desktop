using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Clases;
using NHibernate;

namespace BibliotecaHistorialMedico.Catalogos
{
    class CatalogoPacientes
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

        public static void InsertarActualizar(Paciente paciente)
        {

        }

        internal static Paciente RecuperarPorCodigo(int codigoPaciente)
        {
            throw new NotImplementedException();
        }
    }
}
