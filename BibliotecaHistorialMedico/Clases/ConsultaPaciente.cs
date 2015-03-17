using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaHistorialMedico.Clases
{
    class ConsultaPaciente
    {
        public ConsultaPaciente()
        {
            ConsultasPacienteTratamientos = new List<ConsultaPacienteTratamiento>();
        }

        public virtual int Codigo { get; set; }
        public virtual DateTime Fecha { get; set; }
        public virtual string Comentario { get; set; }
        public virtual Paciente Paciente { get; set; }
        public virtual MotivoConsulta MotivoConsulta { get; set; }
        public virtual Diagnostico Diagnostico { get; set; }
        public virtual IList<ConsultaPacienteTratamiento> ConsultasPacienteTratamientos { get; set; }

    }
}
