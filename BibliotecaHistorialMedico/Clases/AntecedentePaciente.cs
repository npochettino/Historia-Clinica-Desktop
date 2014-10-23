using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaHistorialMedico.Clases
{
    class AntecedentePaciente
    {
        public virtual int Codigo { get; set; }
        public virtual string Comentario { get; set; }
        public virtual string Tipo { get; set; }
        public virtual Antecedente Antecedente { get; set; }
        public virtual Paciente Paciente { get; set; }
    }
}
