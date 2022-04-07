
using TesteAPI.Shared.Interfaces;

namespace TesteAPI.Domain.Commands.Nivel
{
    public class CriarNivelCommand : ICommand
    {
        public string Nome { get; set; }
    }
}
