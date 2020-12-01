using System;
using System.Collections.Generic;

namespace Consultorio.Domain
{
    public class Acompanhamentos
    {
        public int Id { get; set; }

       // public string ImageUrl { get; set; }

        public DateTime DtAcompanhamento { get; set; }

        public string Descricao { get; set; }

        public int AtendimentoId { get; set; }
        public Atendimento Atendimento { get; set; }
    }
}