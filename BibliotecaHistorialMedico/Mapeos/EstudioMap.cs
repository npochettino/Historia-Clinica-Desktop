using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Clases;
using FluentNHibernate.Mapping;

namespace BibliotecaHistorialMedico.Mapeos
{
    class EstudioMap : ClassMap<Estudio>
    {
        public EstudioMap()
        {
            Table("Estudios");
            Id(x => x.Codigo).Column("idEstudio").GeneratedBy.Identity();
            Map(x => x.Descripcion).Column("descripcionEstudio");
        }
    }
}
