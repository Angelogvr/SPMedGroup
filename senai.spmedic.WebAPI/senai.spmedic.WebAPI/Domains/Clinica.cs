using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace senai.spmedic.WebAPI.Domains
{
    public partial class Clinica
    {
        public Clinica()
        {
            Medicos = new HashSet<Medico>();
        }

        public int IdClinica { get; set; }
        public string NomeFantasia { get; set; }
        public string Endereco { get; set; }
        public TimeSpan Funcionamento { get; set; }
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }


        [Required(ErrorMessage = "O horário de abertura é obrigatório!")]
        public TimeSpan HorarioAbertura { get; set; }

        [Required(ErrorMessage = "O horário de fechamento é obrigatório!")]
        public TimeSpan HorarioFechamento { get; set; }
        public virtual ICollection<Medico> Medicos { get; set; }
    }
}
