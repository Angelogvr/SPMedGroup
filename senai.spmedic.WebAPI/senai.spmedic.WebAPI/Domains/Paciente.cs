using System;
using System.Collections.Generic;

#nullable disable

namespace senai.spmedic.WebAPI.Domains
{
    public partial class Paciente
    {
        public int IdPaciente { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
