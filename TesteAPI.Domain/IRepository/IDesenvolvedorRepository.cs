using System;
using System.Collections.Generic;
using TesteAPI.Domain.Entities;

namespace TesteAPI.Domain.IRepository
{
    public interface IDesenvolvedorRepository
    {
        void Salvar(Desenvolvedor desenvolvedor);
        void Atualizar(Desenvolvedor desenvolvedor);
        void Remover(Guid id);
        Desenvolvedor ObterPorId(Guid id);
        IEnumerable<Desenvolvedor> ObterTodos();
        IEnumerable<Desenvolvedor> ObterDesenvolvedoresComNivel(Guid nivel);
        bool ExisteDesenvolvedorComNivel(Guid nivel);
    }
}
