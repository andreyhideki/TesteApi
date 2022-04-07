using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TesteAPI.Domain.Entities;
using TesteAPI.Domain.IRepository;
using TesteAPI.Infra.Transaction;

namespace TesteAPI.Infra.Repository
{
    public class NivelRepository : INivelRepository
    {
        private readonly ApiDbContext _context;
        private readonly DesenvolvedorRepository _desenvolvedorRepository;
        private readonly IUnitOfWork _uow;

        public NivelRepository(ApiDbContext context, DesenvolvedorRepository desenvolvedorRepository, IUnitOfWork uow)
        {
            _context = context;
            _desenvolvedorRepository = desenvolvedorRepository;
            _uow = uow;
        }

        public void Atualizar(Nivel nivel)
        {
            _context.Entry(nivel).State = EntityState.Modified;
            _uow.Commit();
        }

        public Nivel ObterPorId(Guid id)
        {
            return _context.Niveis.Find(id);
        }

        public IEnumerable<Nivel> ObterTodos()
        {
            return _context.Niveis.ToList();
        }

        public void Remover(Guid id)
        {
            var nivel = _context.Niveis.Find(id);
            
            if (nivel != null)
            {
                var existeDesenvolvedores = _desenvolvedorRepository.ExisteDesenvolvedorComNivel(nivel.Id);
                if (!existeDesenvolvedores)
                {
                    _context.Niveis.Remove(nivel);
                    _uow.Commit();
                }
                else
                {
                    _uow.Rollback();
                    throw new Exception("Atenção! Desenvolvedores cadastrado nesse nível, impossibilitando a exclusão!");
                }
            }
        }

        public void Salvar(Nivel nivel)
        {
            _context.Niveis.Add(nivel);
            _uow.Commit();
        }
    }
}
