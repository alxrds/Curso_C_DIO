using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        private string _nome;
        private string _sobrenome;
        private int _idade;
        public string Nome 
        { 
            get => _nome;
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vázio");
                }
                _nome = value;
            }
        }
                public string Sobrenome 
        { 
            get => _sobrenome;
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O sobrenome não pode ser vázio");
                }
                _sobrenome = value;
            }
        }
        public int Idade 
        { 
            get => _idade; 
            set
            {
                if(value < 0){
                    throw new ArgumentException("A idade não pode ser menor que 0");
                }
                _idade = value;
            }
        }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}