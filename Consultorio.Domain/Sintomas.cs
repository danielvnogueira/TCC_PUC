using System.Collections.Generic;

namespace Consultorio.Domain
{
    public class Sintomas
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public List<Atendimento> Atendimentos { get; set; }
    }
}