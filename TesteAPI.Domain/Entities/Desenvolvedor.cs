using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TesteAPI.Domain.Entities.Enum;
using TesteAPI.Shared.Entities;

namespace TesteAPI.Domain.Entities
{
    public class Desenvolvedor : EntityBase
    {
        private Desenvolvedor()
        {
        }

        public Desenvolvedor(Nivel nivel, string nome, ESexo sexo, DateTime? dataNascimento, int idade, string hobby)
        {
            Nivel = nivel;
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Idade = idade;
            Hobby = hobby;
        }

        public Nivel Nivel { get; private set; }
        public string Nome { get; private set; }
        public ESexo Sexo { get; private set; }
        public DateTime? DataNascimento { get; private set; }
        public int Idade { get; private set; }
        public string Hobby { get; private set; }

        public void Alterar(Nivel nivel, string nome, ESexo sexo, DateTime? dataNascimento, int idade, string hobby)
        {
            Nivel = nivel;
            Nome = nome;
            Sexo = sexo;
            DataNascimento = dataNascimento;
            Idade = idade;
            Hobby = hobby;
        }

        public void AlterarNivel(Nivel nivel)
        {
            Nivel = nivel;
        }
    }
}
