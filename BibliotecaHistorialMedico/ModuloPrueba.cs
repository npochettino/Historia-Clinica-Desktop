using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Clases;
using BibliotecaHistorialMedico.ClasesComplementarias;
using BibliotecaHistorialMedico.Controladores;
using NHibernate;

namespace BibliotecaHistorialMedico
{
    class ModuloPrueba
    {
        public static void Main()
        {
            DataTable t = ControladorGeneral.RecuperarTratamientosConsultaPorConsulta(2);
            ControladorGeneral.EliminarTratamientosConsultaPorConsulta(2);
        }
    }
}
