using System;
using TesteAPI.Domain.Entities.Enum;
using TesteAPI.Shared.Interfaces;

namespace TesteAPI.Domain.Commands.Desenvolvedor
{
    public class CriarDesenvolvedorCommand : ICommand
    {
        public Guid Nivel { get; set; }
        public string Nome { get; set; }
        public ESexo Sexo { get; set; }
        public DateTime? DataNascimento { get; set; }
        public int Idade { get; set; }
        public string Hobby { get; set; }
    }
}
