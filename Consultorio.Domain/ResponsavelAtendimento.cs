namespace Consultorio.Domain
{
    public class ResponsavelAtendimento
    {
        public int ResponsavelId { get; set; }

        public Responsavel Responsavel { get; set; }

        public int AtendimentoId { get; set; }

        public Atendimento Atendimento { get; set; }
    }
}