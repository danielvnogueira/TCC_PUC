using System;
using System.Collections.Generic;

namespace Consultorio.Domain
{
    public class Paciente
    {
        public int Id { get; set; }

        public string NomePaciente { get; set; }

       // public string ImageUrl { get; set; }

        public string Telefone { get; set; }

        public string Celular { get; set; }

        public string Email { get; set; }

        public DateTime DtNascimento { get; set; }

        public string Observacao { get; set; }

        public List<Atendimento> Atendimentos { get; set; }

    }
}