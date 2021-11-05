﻿using senai.spmedic.webAPI.Interfaces;
using senai.spmedic.WebAPI.Contexts;
using senai.spmedic.WebAPI.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace senai.spmedic.WebAPI.Repositories
{
    public class MedicoRepository : IMedicoRepository
    {

        SPMEDGROUPContext ctx = new SPMEDGROUPContext();
        public void Atualizar(Medico MedicoAtualizado)
        {
            Medico medicoBuscado = BuscarPorId(MedicoAtualizado.IdMedico);

            if (MedicoAtualizado.IdClinica != 0)
            {
                medicoBuscado.IdClinica = MedicoAtualizado.IdClinica;
            }

            if (MedicoAtualizado.Crm != null)
            {
                medicoBuscado.Crm = MedicoAtualizado.Crm;
            }


            if (MedicoAtualizado.IdEspecialidade != 0)
            {
                medicoBuscado.IdEspecialidade = MedicoAtualizado.IdEspecialidade;
            }

            if (medicoBuscado.IdUsuario != 0)
            {
                medicoBuscado.IdUsuario = MedicoAtualizado.IdUsuario;
            }

            ctx.Medicos.Update(medicoBuscado);

            ctx.SaveChanges();
        }

        public Medico BuscarPorId(int idMedico)
        {
            return ctx.Medicos.Include(u => u.IdUsuarioNavigation).Include(c => c.IdClinicaNavigation).Include(e => e.IdEspecialidadeNavigation).FirstOrDefault(m => m.IdMedico == idMedico);
        }

        public void Cadastrar(Medico novoMedico)
        {
            ctx.Medicos.Add(novoMedico);

            ctx.SaveChanges();
        }

        public void Deletar(int idMedico)
        {
            Medico medicoBuscado = BuscarPorId(idMedico);

            ctx.Medicos.Remove(medicoBuscado);

            ctx.SaveChanges();
        }

        public List<Medico> Listar()
        {
            return ctx.Medicos.Include(u => u.IdUsuarioNavigation).Include(c => c.IdClinicaNavigation).Include(e => e.IdEspecialidadeNavigation).ToList();
        }
    }
}
