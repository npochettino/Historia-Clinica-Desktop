using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Clases;
using NHibernate;

namespace BibliotecaHistorialMedico.Catalogos
{
    class CatalogoEstudioConsulta
    {
        public static void InsertarActualizar(EstudioConsulta estudioConsulta, ISession nhSesion)
        {
            try
            {
                nhSesion.SaveOrUpdate(estudioConsulta);
                nhSesion.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<EstudioConsulta> RecuperarTodos(ISession nhSesion)
        {
            List<EstudioConsulta> listaEstudiosConsulta = new List<EstudioConsulta>();

            try
            {
                string consulta = "from EstudioConsulta";
                listaEstudiosConsulta = nhSesion.CreateQuery(consulta).List<EstudioConsulta>().ToList();
                return listaEstudiosConsulta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static EstudioConsulta RecuperarPorCodigo(int codigoEstudioConsulta, ISession nhSesion)
        {
            EstudioConsulta estudioConsulta;

            try
            {
                string consulta = "from EstudioConsulta ec where ec.Codigo = " + codigoEstudioConsulta;
                estudioConsulta = nhSesion.CreateQuery(consulta).UniqueResult<EstudioConsulta>();
                return estudioConsulta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Eliminar(EstudioConsulta estudioConsulta, ISession nhSesion)
        {
            try
            {
                nhSesion.Delete(estudioConsulta);
                nhSesion.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
