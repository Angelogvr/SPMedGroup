using System;
using System.Collections.Generic;

#nullable disable

namespace senai.spmedic.WebAPI.Domains
{
    /// <summary>
    /// Classe que representa entidade (tabela) de Situacoes
    /// </summary>
    public partial class Situacao
    {
        public Situacao()
        {
            Consulta = new HashSet<Consulta>();
        }

        public byte IdSituacao { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
