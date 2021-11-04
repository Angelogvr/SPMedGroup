using senai.spmedic.webAPI.Interfaces;
using senai.spmedic.WebAPI.Contexts;
using senai.spmedic.WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedic.WebAPI.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {

        SPMEDGROUPContext ctx = new SPMEDGROUPContext();
        public void AdicionarDescricao(int idConsulta, string descricao)
        {
            throw new NotImplementedException();
        }

        public void AlterarStatus(int idConsulta, int idSituacao)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Consulta consultaAtualizada)
        {
            throw new NotImplementedException();
        }

        public Consulta BuscarPorId(int idConsulta)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Consulta novaConsulta)
        {
            ctx.Consulta.Add(novaConsulta);

            ctx.SaveChanges();
        }

        public void Deletar(int idConsulta)
        {
            throw new NotImplementedException();
        }

        public List<Consulta> Listar()
        {
            throw new NotImplementedException();
        }

        public List<Consulta> ListarMinhas(int idUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
