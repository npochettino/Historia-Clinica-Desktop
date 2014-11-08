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
        public static void InsertarActualizar(MotivoConsulta motivoConsulta, ISession nhSesion)
        {
            try
            {
                nhSesion.SaveOrUpdate(motivoConsulta);
                nhSesion.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<MotivoConsulta> RecuperarTodos(ISession nhSesion)
        {
            List<MotivoConsulta> listaMotivosConsulta = new List<MotivoConsulta>();

            try
            {
                string consulta = "from MotivoConsulta";
                listaMotivosConsulta = nhSesion.CreateQuery(consulta).List<MotivoConsulta>().ToList();
                return listaMotivosConsulta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static MotivoConsulta RecuperarPorCodigo(int codigoMotivoConsulta, ISession nhSesion)
        {
            MotivoConsulta motivoConsulta;

            try
            {
                string consulta = "from MotivoConsulta md where md.Codigo = " + codigoMotivoConsulta;
                motivoConsulta = nhSesion.CreateQuery(consulta).UniqueResult<MotivoConsulta>();
                return motivoConsulta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Eliminar(MotivoConsulta motivoConsulta, ISession nhSesion)
        {
            try
            {
                nhSesion.Delete(motivoConsulta);
                nhSesion.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
