using Microsoft.AspNetCore.Http;
using senai.spmedic.webAPI.Interfaces;
using senai.spmedic.WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedic.WebAPI.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public void Atualizar(Usuario usuarioAtualizado)
        {
            throw new NotImplementedException();
        }

        public Usuario BuscarPorId(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuario novoUsuario)
        {
            throw new NotImplementedException();
        }

        public string ConsultarPerfilDir(int id_usuario)
        {
            throw new NotImplementedException();
        }

        public void CriarPasta()
        {
            throw new NotImplementedException();
        }

        public void Deletar(int idUsuario)
        {
            throw new NotImplementedException();
        }

        public List<Usuario> Listar()
        {
            throw new NotImplementedException();
        }

        public Usuario Login(string email, string senha)
        {
            throw new NotImplementedException();
        }

        public void SalvarPerfilDir(IFormFile foto, int id_usuario)
        {
            throw new NotImplementedException();
        }
    }
}
