using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaHistorialMedico.Clases
{
    public class Paciente
    {
        public virtual int Codigo { get; set; }
        public virtual string ApellidoNombre { get; set; }
        public virtual string Telefono { get; set; }
        public virtual string Mail { get; set; }
        public virtual string Direccion { get; set; }
        public virtual string Dni { get; set; }
        public virtual string Sexo { get; set; }
        public virtual ObraSocial ObraSocial { get; set; }
    }
}