using System.Collections.Generic;

namespace Consultorio.Domain
{
    public class Hospital
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Local { get; set; }

        public string DsInternacao { get; set; }

        public List<Atendimento> Atendimentos { get; set; }    
    }
}