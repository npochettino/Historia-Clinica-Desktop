using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Clases;
using FluentNHibernate.Mapping;

namespace BibliotecaHistorialMedico.Mapeos
{
    class MotivoConsultaMap : ClassMap<MotivoConsulta>
    {
        public MotivoConsultaMap()
        {
            Table("MotivosConsulta");
            Id(x => x.Codigo).Column("idMotivoConsulta").GeneratedBy.Identity();
            Map(x => x.Descripcion).Column("descripcionMotivoConsulta");
        }
    }
}
