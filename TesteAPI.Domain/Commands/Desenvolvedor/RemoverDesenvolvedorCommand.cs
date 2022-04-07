using System;
using TesteAPI.Shared.Interfaces;

namespace TesteAPI.Domain.Commands.Desenvolvedor
{
    public class RemoverDesenvolvedorCommand : ICommand
    {
        public Guid Id { get; set; }
    }
}
