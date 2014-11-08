using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Clases;
using NHibernate;

namespace BibliotecaHistorialMedico.Catalogos
{
    class CatalogoTratamiento
    {
        public static void InsertarActualizar(Tratamiento tratamiento, ISession nhSesion)
        {
            try
            {
                nhSesion.SaveOrUpdate(tratamiento);
                nhSesion.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Tratamiento> RecuperarTodos(ISession nhSesion)
        {
            List<Tratamiento> listaTratamientos = new List<Tratamiento>();

            try
            {
                string consulta = "from Tratamiento";
                listaTratamientos = nhSesion.CreateQuery(consulta).List<Tratamiento>().ToList();
                return listaTratamientos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Tratamiento RecuperarPorCodigo(int codigoTratamiento, ISession nhSesion)
        {
            Tratamiento tratamiento;

            try
            {
                string consulta = "from Tratamiento t where t.Codigo = " + codigoTratamiento;
                tratamiento = nhSesion.CreateQuery(consulta).UniqueResult<Tratamiento>();
                return tratamiento;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Eliminar(Tratamiento tratamiento, ISession nhSesion)
        {
            try
            {
                nhSesion.Delete(tratamiento);
                nhSesion.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
