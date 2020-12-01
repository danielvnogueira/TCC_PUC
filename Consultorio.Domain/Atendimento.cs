using System;
using System.Collections.Generic;

namespace Consultorio.Domain
{
    public class Atendimento
    {
        public int Id { get; set; }

       // public string ImageUrl { get; set; }

        public DateTime DataConsulta { get; set; }

        public DateTime DataSintomas { get; set; }

        public int DiasQuarentena { get; set; }

        public string Descricao { get; set; }

        public string Observacao { get; set; }

        public int ResponsavelId { get; set; } //Tabela de apoio
        public Responsavel Responsavel { get; set; } // de dentro da tabela atendimento consigo ver a tabela paciente


        public int SintomasId { get; set; } // Tabela de apoio
        public Sintomas Sintomas { get; set; } // de dentro da tabela atendimento consigo ver a tabela paciente


        public int StatusId { get; set; } // Tabela de apoio
        public Status Status { get; set; } // de dentro da tabela atendimento consigo ver a tabela paciente


        public int? HospitalId { get; set; } // Tabela de apoio
        public Hospital Hospital { get; set; } // de dentro da tabela atendimento consigo ver a tabela paciente

        public int PacienteId { get; set; } // Reference a tabela paciente
        public Paciente Paciente { get; set; } // de dentro da tabela atendimento consigo ver a tabela paciente


        public List<Acompanhamentos> Acompanhamentos { get; set; }

    }
}