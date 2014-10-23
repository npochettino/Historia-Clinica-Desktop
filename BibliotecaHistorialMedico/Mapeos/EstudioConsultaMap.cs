using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Clases;
using FluentNHibernate.Mapping;

namespace BibliotecaHistorialMedico.Mapeos
{
    class EstudioConsultaMap : ClassMap<EstudioConsulta>
    {
        public EstudioConsultaMap()
        {
            Table("EstudiosConsulta");
            Id(x => x.Codigo).Column("idEstudioConsulta").GeneratedBy.Identity();
            Map(x => x.Resultado).Column("resultadoEstudioConsulta");

            References(x => x.Estudio).Column("idEstudio").Cascade.None().Not.LazyLoad();
            References(x => x.ConsultaPaciente).Column("idConsultaPaciente").Cascade.None().Not.LazyLoad();
        }
    }
}
