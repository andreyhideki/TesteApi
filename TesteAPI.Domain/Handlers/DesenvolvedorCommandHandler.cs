using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAPI.Domain.Commands.Desenvolvedor;
using TesteAPI.Domain.Entities;
using TesteAPI.Domain.IRepository;
using TesteAPI.Shared.Entities;
using TesteAPI.Shared.Interfaces;

namespace TesteAPI.Domain.Handlers
{
    public class DesenvolvedorCommandHandler : ICommandHandler<CriarDesenvolvedorCommand>,
        ICommandHandler<EditarDesenvolvedorCommand>,
        ICommandHandler<RemoverDesenvolvedorCommand>
    {
        private readonly IDesenvolvedorRepository _desenvolvedorRepository;
        private readonly INivelRepository _nivelRepository;

        public DesenvolvedorCommandHandler(IDesenvolvedorRepository desenvolvedorRepository, INivelRepository nivelRepository)
        {
            _desenvolvedorRepository = desenvolvedorRepository;
            _nivelRepository = nivelRepository;
        }

        public ICommandResult Handle(CriarDesenvolvedorCommand command)
        {
            var nivel = _nivelRepository.ObterPorId(command.Nivel);

            if (nivel == null)
            {
                return new CommandResult(false, "Nível não encontrado.");
            }

            var desenvolvedor = new Desenvolvedor(nivel, command.Nome, command.Sexo, command.DataNascimento,command.Idade, command.Hobby);

            _desenvolvedorRepository.Salvar(desenvolvedor);

            return new CommandResult(true, "Desenvolvedor criado com sucesso");
        }

        public ICommandResult Handle(EditarDesenvolvedorCommand command)
        {
            var nivel = _nivelRepository.ObterPorId(command.Nivel);

            if (nivel == null)
            {
                return new CommandResult(false, "Nível não encontrado.");
            }

            var desenvolvedor = _desenvolvedorRepository.ObterPorId(command.Id);

            if (desenvolvedor == null)
            {
                return new CommandResult(false, "Não foi possível editar o desenvolvedor.");
            }

            desenvolvedor.Alterar(nivel, command.Nome, command.Sexo, command.DataNascimento, command.Idade, command.Hobby);
            _desenvolvedorRepository.Atualizar(desenvolvedor);
            
            return new CommandResult(true, "Desenvolvedor editado com sucesso");
        }

        public ICommandResult Handle(RemoverDesenvolvedorCommand command)
        {
            var desenvolvedor = _desenvolvedorRepository.ObterPorId(command.Id);

            if (desenvolvedor == null)
            {
                return new CommandResult(false, "Não foi possível remover o desenvolvedor.");
            }

            _desenvolvedorRepository.Remover(desenvolvedor.Id);
            return new CommandResult(true, "Desenvolvedor removido com sucesso");
        }
    }
}
