using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Clases;
using FluentNHibernate.Mapping;

namespace BibliotecaHistorialMedico.Mapeos
{
    class AntecedentePacienteMap : ClassMap<AntecedentePaciente>
    {
        public AntecedentePacienteMap()
        {
            Table("AntecedentesPaciente");
            Id(x => x.Codigo).Column("idPacienteAntecedente").GeneratedBy.Identity();
            Map(x => x.Comentario).Column("comentarioPacienteAntecedente");
            Map(x => x.Tipo).Column("tipoAntecedente");

            References(x => x.Paciente).Column("idPaciente").Cascade.None().Not.LazyLoad();
            References(x => x.Diagnostico).Column("idDiagnostico").Cascade.None().Not.LazyLoad();
        }
    }
}
