using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaHistorialMedico.Clases
{
    class Paciente
    {
        public virtual int Codigo { get; set; }
        public virtual string ApellidoNombre { get; set; }
        public virtual string Telefono { get; set; }
        public virtual string Mail { get; set; }
        public virtual string Direccion { get; set; }
    }
}
