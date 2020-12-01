namespace Consultorio.WebAPI.Model
{
    public class Agenda
    {
        public int AgendaId { get; set; }

        public string NomePaciente { get; set; }

        public string Local { get; set; }

        public string Data { get; set; }

        public string Sintomas { get; set; }

        public int DiasAfastado { get; set; }

        public string Status { get; set; }

        public string ImageUrl { get; set; }
        
    }
}