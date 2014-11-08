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
            ControladorGeneral.InsertarActualizarTratamiento(0, "TratamientoPrueba");
            ControladorGeneral.InsertarActualizarTratamiento(1, "TratamientoPrueba1");
            DataTable t = ControladorGeneral.RecuperarTratamientoPorCodigo(1);
            DataTable t2 = ControladorGeneral.RecuperarTodosTratamientos();
            ControladorGeneral.EliminarTratamiento(1);
        }
    }
}
