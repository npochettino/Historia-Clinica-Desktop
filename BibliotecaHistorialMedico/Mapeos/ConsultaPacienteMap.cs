using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Clases;
using FluentNHibernate.Mapping;

namespace BibliotecaHistorialMedico.Mapeos
{
    class ConsultaPacienteMap : ClassMap<ConsultaPaciente>
    {
        public ConsultaPacienteMap()
        {
            Table("ConsultasPaciente");
            Id(x => x.Codigo).Column("idConsultaPaciente").GeneratedBy.Identity();
            Map(x => x.Fecha).Column("fechaConsultaPaciente");
            Map(x => x.Comentario).Column("comentarioConsultaPaciente");

            References(x => x.Paciente).Column("idPaciente").Cascade.None().Not.LazyLoad();
            References(x => x.MotivoConsulta).Column("idMotivoConsulta").Cascade.None().Not.LazyLoad();
            References(x => x.Diagnostico).Column("idDiagnostico").Cascade.None().Not.LazyLoad();

            HasMany<ConsultaPacienteTratamiento>(x => x.ConsultasPacienteTratamientos).Table("ConsultasPacienteTratamiento").KeyColumn("idConsultaPaciente").Cascade.AllDeleteOrphan();
        }
    }
}
