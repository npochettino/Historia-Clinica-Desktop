using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Clases;
using FluentNHibernate.Mapping;

namespace BibliotecaHistorialMedico.Mapeos
{
    class AntecedenteMap : ClassMap<Antecedente>
    {
        public AntecedenteMap()
        {
            Table("Antecedentes");
            Id(x => x.Codigo).Column("idAntecedente").GeneratedBy.Identity();
            Map(x => x.Descripcion).Column("descripcionAntecedente");
            Map(x => x.Comentario).Column("comentarioAntecedente");
            
        }
    }
}
