using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaHistorialMedico.Clases;
using FluentNHibernate.Mapping;

namespace BibliotecaHistorialMedico.Mapeos
{
    class PacienteMap : ClassMap<Paciente>
    {
        public PacienteMap()
        {
            Table("Pacientes");
            Id(x => x.Codigo).Column("idPaciente").GeneratedBy.Identity();
            Map(x => x.ApellidoNombre).Column("apellidoNombrePaciente");
            Map(x => x.Telefono).Column("telefonoPaciente");
            Map(x => x.Telefono2).Column("telefono2Paciente");
            Map(x => x.Mail).Column("emailPaciente");
            Map(x => x.Direccion).Column("direccionPaciente");
            Map(x => x.Dni).Column("dni");
            Map(x => x.Sexo).Column("sexo");

            References(x => x.ObraSocial).Column("idObraSocial").Cascade.None().Not.LazyLoad();
        }
    }
}
