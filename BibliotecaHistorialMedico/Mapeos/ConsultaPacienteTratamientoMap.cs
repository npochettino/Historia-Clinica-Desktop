using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Clases;
using FluentNHibernate.Mapping;

namespace BibliotecaHistorialMedico.Mapeos
{
    class ConsultaPacienteTratamientoMap : ClassMap<ConsultaPacienteTratamiento>
    {
        public ConsultaPacienteTratamientoMap()
        {
            Table("ConsultasPacienteTratamiento");
            Id(x => x.Codigo).Column("idConsultaPacienteTratamiento").GeneratedBy.Identity();
            Map(x => x.Comentario).Column("comentario");

            References(x => x.Tratamiento).Column("idTratamiento").Cascade.None().Not.LazyLoad();
        }
    }
}
