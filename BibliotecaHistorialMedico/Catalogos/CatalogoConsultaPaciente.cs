using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Clases;
using NHibernate;

namespace BibliotecaHistorialMedico.Catalogos
{
    class CatalogoConsultaPaciente
    {
        public static void InsertarActualizar(ConsultaPaciente consultaPaciente, ISession nhSesion)
        {
            try
            {
                nhSesion.SaveOrUpdate(consultaPaciente);
                nhSesion.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<ConsultaPaciente> RecuperarTodos(ISession nhSesion, int codigoPaciente)
        {
            List<ConsultaPaciente> listaConsultaPacientes = new List<ConsultaPaciente>();

            try
            {
                string consulta = "from ConsultaPaciente p where p.Paciente.Codigo = " + codigoPaciente;
                listaConsultaPacientes = nhSesion.CreateQuery(consulta).List<ConsultaPaciente>().ToList();
                return listaConsultaPacientes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static ConsultaPaciente RecuperarPorCodigo(int codigoConsultaPaciente, ISession nhSesion)
        {
            ConsultaPaciente consultaPaciente;

            try
            {
                string consulta = "from ConsultaPaciente cp where cp.Codigo = " + codigoConsultaPaciente;
                consultaPaciente = nhSesion.CreateQuery(consulta).UniqueResult<ConsultaPaciente>();
                return consultaPaciente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Eliminar(ConsultaPaciente consultaPaciente, ISession nhSesion)
        {
            try
            {
                nhSesion.Delete(consultaPaciente);
                nhSesion.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
