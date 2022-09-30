using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemplesProps.Models
{
    public class Pessoa
    {
        private string _nome;
        public string Nome
        {
            get => _nome.ToUpper(); // body expression

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");   
                }
                _nome = value;
            }
        }
        public int Idade {get; set;}

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}