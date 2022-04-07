using System;
using System.Collections.Generic;
using TesteAPI.Domain.Entities;

namespace TesteAPI.Domain.IRepository
{
    public interface INivelRepository
    {
        void Salvar(Nivel nivel);
        void Atualizar(Nivel nivel);
        void Remover(Guid id);
        Nivel ObterPorId(Guid id);
        IEnumerable<Nivel> ObterTodos();
        

    }
}
