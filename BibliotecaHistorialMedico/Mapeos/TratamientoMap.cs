using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Clases;
using FluentNHibernate.Mapping;

namespace BibliotecaHistorialMedico.Mapeos
{
    class TratamientoMap : ClassMap<Tratamiento>
    {
        public TratamientoMap()
        {
            Table("Tratamientos");
            Id(x => x.Codigo).Column("idTratamiento").GeneratedBy.Identity();
            Map(x => x.Descripcion).Column("descipcionTratamiento");
        }
    }
}
