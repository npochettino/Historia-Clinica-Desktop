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
            ControladorGeneral.InsertarActualizarAntecedentePaciente(1, 1, 1, "Paaaaaa", "s");
            DataTable tttt = ControladorGeneral.RecuperarAntecedentePacientePorCodigo(1);
            DataTable aaa = ControladorGeneral.RecuperarTodosAntecedentesPaciente();
            ControladorGeneral.EliminarAntecedentePaciente(1);
        }
    }
}
