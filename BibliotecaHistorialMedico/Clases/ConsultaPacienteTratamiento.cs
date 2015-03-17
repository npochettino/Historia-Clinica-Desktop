using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaHistorialMedico.Clases
{
    class ConsultaPacienteTratamiento
    {
        public virtual int Codigo { get; set; }
        public virtual string Comentario { get; set; }

        public virtual Tratamiento Tratamiento { get; set; }
    }
}
