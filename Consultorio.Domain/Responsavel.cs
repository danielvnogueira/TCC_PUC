using System.Collections.Generic;

namespace Consultorio.Domain
{
    public class Responsavel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Cpf { get; set; }

        public string TpConselho { get; set; }

        public int NrConselho { get; set; }

        public string Email { get; set; }

        public string Telefone { get; set; }

        public List<Atendimento> Atendimentos { get; set; }

        public List<ResponsavelAtendimento> ResponsavelAtendimentos { get; set; }
    }
}