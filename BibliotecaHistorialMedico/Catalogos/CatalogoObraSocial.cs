using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Clases;
using NHibernate;

namespace BibliotecaHistorialMedico.Catalogos
{
    class CatalogoObraSocial
    {
        public static void InsertarActualizar(ObraSocial obraSocial, ISession nhSesion)
        {
            try
            {
                nhSesion.SaveOrUpdate(obraSocial);
                nhSesion.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<ObraSocial> RecuperarTodos(ISession nhSesion)
        {
            List<ObraSocial> listaObraSociales = new List<ObraSocial>();

            try
            {
                string consulta = "from ObraSocial";
                listaObraSociales = nhSesion.CreateQuery(consulta).List<ObraSocial>().ToList();
                return listaObraSociales;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static ObraSocial RecuperarPorCodigo(int codigoObraSocial, ISession nhSesion)
        {
            ObraSocial obraSocial;

            try
            {
                string consulta = "from ObraSocial os where os.Codigo = " + codigoObraSocial;
                obraSocial = nhSesion.CreateQuery(consulta).UniqueResult<ObraSocial>();
                return obraSocial;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Eliminar(ObraSocial obraSocial, ISession nhSesion)
        {
            try
            {
                nhSesion.Delete(obraSocial);
                nhSesion.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
