using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Clases;
using NHibernate;

namespace BibliotecaHistorialMedico.Catalogos
{
    class CatalogoAntecedentePaciente
    {
        public static void InsertarActualizar(AntecedentePaciente antecedentePaciente, ISession nhSesion)
        {
            try
            {
                nhSesion.SaveOrUpdate(antecedentePaciente);
                nhSesion.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<AntecedentePaciente> RecuperarTodos(ISession nhSesion)
        {
            List<AntecedentePaciente> listaAntecedentesPaciente = new List<AntecedentePaciente>();

            try
            {
                string consulta = "from AntecedentePaciente";
                listaAntecedentesPaciente = nhSesion.CreateQuery(consulta).List<AntecedentePaciente>().ToList();
                return listaAntecedentesPaciente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static AntecedentePaciente RecuperarPorCodigo(int codigoAntecedentePaciente, ISession nhSesion)
        {
            AntecedentePaciente antecedentePaciente;

            try
            {
                string consulta = "from AntecedentePaciente ap where ap.Codigo = " + codigoAntecedentePaciente;
                antecedentePaciente = nhSesion.CreateQuery(consulta).UniqueResult<AntecedentePaciente>();
                return antecedentePaciente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Eliminar(AntecedentePaciente antecedentePaciente, ISession nhSesion)
        {
            try
            {
                nhSesion.Delete(antecedentePaciente);
                nhSesion.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<AntecedentePaciente> RecuperarPorPaciente(int codigoPaciente, ISession nhSesion)
        {
            List<AntecedentePaciente> listaAntecedentesPaciente = new List<AntecedentePaciente>();

            try
            {
                string consulta = "from AntecedentePaciente ap where ap.Paciente.Codigo = " + codigoPaciente;
                listaAntecedentesPaciente = nhSesion.CreateQuery(consulta).List<AntecedentePaciente>().ToList();
                return listaAntecedentesPaciente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
