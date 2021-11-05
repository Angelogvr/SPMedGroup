using senai.spmedic.webAPI.Interfaces;
using senai.spmedic.WebAPI.Contexts;
using senai.spmedic.WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedic.WebAPI.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {

        SPMEDGROUPContext ctx = new SPMEDGROUPContext();
        public void AdicionarDescricao(int idConsulta, string descricao)
        {
            Consulta consultaBuscada = BuscarPorId(idConsulta);

            if (descricao == null || descricao == "")
            {
                consultaBuscada.Descricao = consultaBuscada.Descricao;
            }
            else
            {
                consultaBuscada.Descricao = descricao;
            }

            ctx.Consulta.Update(consultaBuscada);

            ctx.SaveChanges();
        }

        public void AlterarStatus(int idConsulta, int idSituacao)
        {
            Consulta consultaBuscada = BuscarPorId(idConsulta);

            switch (idSituacao)
            {
                case 1:
                    consultaBuscada.IdSituacao = 1;
                    break;

                case 2:
                    consultaBuscada.IdSituacao = 2;
                    break;

                case 3:
                    consultaBuscada.IdSituacao = 3;
                    break;

                default:
                    consultaBuscada.IdSituacao = consultaBuscada.IdSituacao;
                    break;
            }

            ctx.Consulta.Update(consultaBuscada);

            ctx.SaveChanges();
        }

        public void Atualizar(Consulta consultaAtualizada)
        {
            Consulta consultaBuscada = BuscarPorId(consultaAtualizada.IdConsulta);

            if (consultaAtualizada.IdMedico != 0)
            {
                consultaBuscada.IdMedico = consultaAtualizada.IdMedico;
            }

            if (consultaAtualizada.IdUsuario != 0)
            {
                consultaBuscada.IdUsuario = consultaAtualizada.IdUsuario;
            }

            if (consultaAtualizada.IdSituacao != 0)
            {
                consultaBuscada.IdSituacao = consultaAtualizada.IdSituacao;
            }

            consultaBuscada.Horario = consultaAtualizada.Horario;

            if (consultaAtualizada.Descricao != null)
            {
                consultaBuscada.Descricao = consultaAtualizada.Descricao;
            }

            ctx.Consulta.Update(consultaBuscada);

            ctx.SaveChanges();
        }

        public Consulta BuscarPorId(int idConsulta)
        {
            return ctx.Consulta.Include(m => m.IdMedicoNavigation).Include(p => p.IdUsuarioNavigation).Include(s => s.IdSituacaoNavigation).FirstOrDefault(c => c.IdConsulta == idConsulta);
        }

        public void Cadastrar(Consulta novaConsulta)
        {
            ctx.Consulta.Add(novaConsulta);

            ctx.SaveChanges();
        }

        public void Deletar(int idConsulta)
        {
            Consulta consultaBuscada = BuscarPorId(idConsulta);

            ctx.Consulta.Remove(consultaBuscada);

            ctx.SaveChanges();
        }

        public List<Consulta> Listar()
        {
            return ctx.Consulta.Include(m => m.IdMedicoNavigation).Include(p => p.IdUsuarioNavigation).Include(s => s.IdSituacaoNavigation).ToList();
        }

        public List<Consulta> ListarMinhas(int idUsuario)
        {
            return ctx.Consulta
                           .Include(p => p.IdMedicoNavigation)
                           .Include(p => p.IdUsuarioNavigation)
                           .Include(p => p.IdSituacaoNavigation)
                           .Where(p => p.IdMedicoNavigation.IdUsuario == idUsuario || p.IdUsuarioNavigation.IdUsuario == idUsuario)
                           .ToList();
        }
    }
}
