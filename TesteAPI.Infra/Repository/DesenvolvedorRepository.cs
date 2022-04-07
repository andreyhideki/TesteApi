using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAPI.Domain.Entities;
using TesteAPI.Domain.IRepository;
using TesteAPI.Infra.Transaction;

namespace TesteAPI.Infra.Repository
{
    public class DesenvolvedorRepository : IDesenvolvedorRepository
    {
        private readonly ApiDbContext _context;
        private readonly IUnitOfWork _uow;

        public DesenvolvedorRepository(ApiDbContext context, NivelRepository repository, IUnitOfWork uow)
        {
            _context = context;
            _uow = uow;
        }

        public void Atualizar(Desenvolvedor desenvolvedor)
        {
            _context.Entry(desenvolvedor).State = EntityState.Modified;
            _uow.Commit();
        }

        public bool ExisteDesenvolvedorComNivel(Guid nivel)
        {
            return _context.Desenvolvedores.Any(d => d.Nivel.Id == nivel);
        }

        public IEnumerable<Desenvolvedor> ObterDesenvolvedoresComNivel(Guid nivel)
        {
            return _context.Desenvolvedores
                .Include(d => d.Nivel)
                .Where(d => d.Nivel.Id == nivel);
                //.ToList();
        }

        public Desenvolvedor ObterPorId(Guid id)
        {
            return _context.Desenvolvedores.Find(id);
        }

        public IEnumerable<Desenvolvedor> ObterTodos()
        {
            return _context.Desenvolvedores.ToList();
        }

        public void Remover(Guid id)
        {
            var desenvolvedor = _context.Desenvolvedores.Find(id);

            if (desenvolvedor != null)
            {
                _context.Desenvolvedores.Remove(desenvolvedor);
                _uow.Commit();
            }
            else
            {
                _uow.Rollback();
                throw new Exception("Atenção! Desenvolvedor não encontrado.");
            }
        }

        public void Salvar(Desenvolvedor desenvolvedor)
        {
            _context.Desenvolvedores.Add(desenvolvedor);
            _uow.Commit();
        }
    }
}
