using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Clases;
using FluentNHibernate.Mapping;

namespace BibliotecaHistorialMedico.Mapeos
{
    class DiagnosticoMap : ClassMap<Diagnostico>
    {
        public DiagnosticoMap()
        {
            Table("Diagnosticos");
            Id(x => x.Codigo).Column("idDiagnostico").GeneratedBy.Identity();
            Map(x => x.Descripcion).Column("descripcionDiagnostico");
        }
    }
}
