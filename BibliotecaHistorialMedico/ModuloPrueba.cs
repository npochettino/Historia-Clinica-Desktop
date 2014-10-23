using System;
using System.Collections.Generic;
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

            ControladorGeneral.RecuperarPacientePorCodigo(16);
            ControladorGeneral.InsertarActualizarPaciente(0, "Ezequiel Dalaison", "4444444", "ezequieldalaison13@gmail.com", "Viamonte 67 bis");
            ControladorGeneral.EliminarPaciente(16);
        }
    }
}
