using System;
using System.Collections.Generic;
using System.Linq;
using DesafioProjetoHospedagem.Models;
namespace DesafioProjetoHospedagem.Models
{
    public class Pessoa1
    {
        public Pessoa1(string nome, string sobrenome)
        {
            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("O nome não pode ser nulo ou vazio.");
            if (string.IsNullOrWhiteSpace(sobrenome))
                throw new ArgumentException("O sobrenome não pode ser nulo ou vazio.");

            Nome = nome;
            Sobrenome = sobrenome;
        }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
    }
}