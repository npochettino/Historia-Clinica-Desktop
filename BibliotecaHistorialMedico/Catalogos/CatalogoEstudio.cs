using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Clases;
using NHibernate;

namespace BibliotecaHistorialMedico.Catalogos
{
    class CatalogoEstudio
    {
        public static void InsertarActualizar(Estudio estudio, ISession nhSesion)
        {
            try
            {
                nhSesion.SaveOrUpdate(estudio);
                nhSesion.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Estudio> RecuperarTodos(ISession nhSesion)
        {
            List<Estudio> listaEstudios = new List<Estudio>();

            try
            {
                string consulta = "from Estudio";
                listaEstudios = nhSesion.CreateQuery(consulta).List<Estudio>().ToList();
                return listaEstudios;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Estudio RecuperarPorCodigo(int codigoEstudio, ISession nhSesion)
        {
            Estudio estudio;

            try
            {
                string consulta = "from Estudio e where e.Codigo = " + codigoEstudio;
                estudio = nhSesion.CreateQuery(consulta).UniqueResult<Estudio>();
                return estudio;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Eliminar(Estudio estudio, ISession nhSesion)
        {
            try
            {
                nhSesion.Delete(estudio);
                nhSesion.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
