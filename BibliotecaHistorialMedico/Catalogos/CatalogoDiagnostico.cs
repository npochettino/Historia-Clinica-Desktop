using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Clases;
using NHibernate;

namespace BibliotecaHistorialMedico.Catalogos
{
    class CatalogoDiagnostico
    {
        public static void InsertarActualizar(Diagnostico diagnostico, ISession nhSesion)
        {
            try
            {
                nhSesion.SaveOrUpdate(diagnostico);
                nhSesion.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Diagnostico> RecuperarTodos(ISession nhSesion)
        {
            List<Diagnostico> listaDiagnosticos = new List<Diagnostico>();

            try
            {
                string consulta = "from Diagnostico";
                listaDiagnosticos = nhSesion.CreateQuery(consulta).List<Diagnostico>().ToList();
                return listaDiagnosticos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Diagnostico> RecuperarTodosMenosSinDiagnostico(ISession nhSesion)
        {
            List<Diagnostico> listaDiagnosticos = new List<Diagnostico>();

            try
            {
                string consulta = "from Diagnostico";
                listaDiagnosticos = nhSesion.CreateQuery(consulta).List<Diagnostico>().Where(x=>x.Codigo != 1).ToList();
                return listaDiagnosticos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static Diagnostico RecuperarPorCodigo(int codigoDiagnostico, ISession nhSesion)
        {
            Diagnostico diagnostico;

            try
            {
                string consulta = "from Diagnostico d where d.Codigo = " + codigoDiagnostico;
                diagnostico = nhSesion.CreateQuery(consulta).UniqueResult<Diagnostico>();
                return diagnostico;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Eliminar(Diagnostico diagnostico, ISession nhSesion)
        {
            try
            {
                nhSesion.Delete(diagnostico);
                nhSesion.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
