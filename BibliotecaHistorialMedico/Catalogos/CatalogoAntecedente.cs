using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Clases;
using NHibernate;

namespace BibliotecaHistorialMedico.Catalogos
{
    class CatalogoAntecedente
    {
        public static void InsertarActualizar(Antecedente antecedente, ISession nhSesion)
        {
            try
            {
                nhSesion.SaveOrUpdate(antecedente);
                nhSesion.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Antecedente> RecuperarTodos(ISession nhSesion)
        {
            List<Antecedente> listaAntecedentes;

            try
            {
                string consulta = "from Antecedente";
                listaAntecedentes = nhSesion.CreateQuery(consulta).List<Antecedente>().ToList();
                return listaAntecedentes;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Antecedente RecuperarPorCodigo(int codigoAntecedente, ISession nhSesion)
        {
            Antecedente antecedente;

            try
            {
                string consulta = "from Antecedente a where a.Codigo = " + codigoAntecedente;
                antecedente = nhSesion.CreateQuery(consulta).UniqueResult<Antecedente>();
                return antecedente;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Eliminar(Antecedente antecedente, ISession nhSesion)
        {
            try
            {
                nhSesion.Delete(antecedente);
                nhSesion.Flush();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
