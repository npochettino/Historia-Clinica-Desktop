using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Clases;
using FluentNHibernate.Mapping;

namespace BibliotecaHistorialMedico.Mapeos
{
    class ObraSocialMap : ClassMap<ObraSocial>
    {
        public ObraSocialMap()
        {
            Table("ObrasSociales");
            Id(x => x.Codigo).Column("idObraSocial").GeneratedBy.Identity();
            Map(x => x.Descripcion).Column("descripcion");
        }
    }
}
