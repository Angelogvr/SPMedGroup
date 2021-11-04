using System;
using System.Collections.Generic;

#nullable disable

namespace senai.spmedic.WebAPI.Domains
{
    public partial class Situacao
    {
        public Situacao()
        {
            Consulta = new HashSet<Consulta>();
        }

        public int IdSituacao { get; set; }
        public string DescSituacao { get; set; }

        public virtual ICollection<Consulta> Consulta { get; set; }
    }
}
