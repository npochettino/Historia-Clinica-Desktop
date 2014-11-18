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
            DataTable t = ControladorGeneral.RecuperarTodosConsultaPaciente();
            DataTable t2 = ControladorGeneral.RecuperarConsultaPacientePorCodigo(8);
            ControladorGeneral.EliminarConsultaPaciente(8);
        }
    }
}
