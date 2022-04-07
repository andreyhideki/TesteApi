using System;
using TesteAPI.Shared.Interfaces;

namespace TesteAPI.Domain.Commands.Nivel
{
    public class EditarNivelCommand : ICommand
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }    
    }
}
