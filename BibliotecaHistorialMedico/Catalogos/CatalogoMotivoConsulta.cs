using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Clases;
using NHibernate;

namespace BibliotecaHistorialMedico.Catalogos
{
    class CatalogoMotivoConsulta
    {
        public static void InsertarActualizar(MotivoConsulta MotivoConsulta, ISession nhSesion)
        {
            try
            {
                nhSesion.SaveOrUpdate(MotivoConsulta);
                nhSesion.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<MotivoConsulta> RecuperarTodos(ISession nhSesion)
        {
            List<MotivoConsulta> listaMotivosDiagnostico = new List<MotivoConsulta>();

            try
            {
                string consulta = "from MotivoConsulta";
                listaMotivosDiagnostico = nhSesion.CreateQuery(consulta).List<MotivoConsulta>().ToList();
                return listaMotivosDiagnostico;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static MotivoConsulta RecuperarPorCodigo(int codigoMotivoConsulta, ISession nhSesion)
        {
            MotivoConsulta MotivoConsulta;

            try
            {
                string consulta = "from MotivoConsulta md where md.Codigo = " + codigoMotivoConsulta;
                MotivoConsulta = nhSesion.CreateQuery(consulta).UniqueResult<MotivoConsulta>();
                return MotivoConsulta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Eliminar(MotivoConsulta MotivoConsulta, ISession nhSesion)
        {
            try
            {
                nhSesion.Delete(MotivoConsulta);
                nhSesion.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
