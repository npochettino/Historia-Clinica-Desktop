using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Clases;
using BibliotecaHistorialMedico.ClasesComplementarias;
using NHibernate;

namespace BibliotecaHistorialMedico
{
    class ModuloPrueba
    {
        public static void Main()
        {
            string consulta = "from Antecedente";
            ISession nhSesion = ManejoNHibernate.IniciarSesion();
            List<Antecedente> listaAntecedentes = nhSesion.CreateQuery(consulta).List<Antecedente>().ToList();
        }
    }
}
