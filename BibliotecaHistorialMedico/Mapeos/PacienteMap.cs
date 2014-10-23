﻿using System;
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
            Map(x => x.Mail).Column("emailPaciente");
            Map(x => x.Direccion).Column("direccionPaciente");
        }
    }
}