using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaHistorialMedico.Clases
{
    class EstudioConsulta
    {
        public virtual int Codigo { get; set; }
        public virtual string Resultado { get; set; }
        public virtual ConsultaPaciente ConsultaPaciente { get; set; }
        public virtual Estudio Estudio { get; set; }
    }
}
