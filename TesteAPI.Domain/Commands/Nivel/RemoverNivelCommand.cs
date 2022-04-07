using System;
using TesteAPI.Shared.Interfaces;

namespace TesteAPI.Domain.Commands.Nivel
{
    public class RemoverNivelCommand : ICommand
    {
        public Guid Id { get; set; }
    }
}
