using System;
using System.Collections.Generic;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva1
    {
        public List<Pessoa1> Hospedes { get; private set; } = new List<Pessoa1>();
        public Suite1 SuiteReservada { get; private set; }

        public void CadastrarHospedes()
        {
            Console.Write("\nSeja bem vindo!");

            Console.Write("Quantos hóspedes deseja cadastrar? ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine($"\nCadastro do hóspede #{i + 1}");

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Sobrenome: ");
                string sobrenome = Console.ReadLine();

                Hospedes.Add(new Pessoa1(nome, sobrenome));
            }

            // Escolha da suíte
            SuiteReservada = new Suite1();

            // Validação de capacidade
            if (Hospedes.Count > SuiteReservada.Capacidade)
            {
                Console.WriteLine($"\n❌ A suíte {SuiteReservada.TipoSuite} comporta até {SuiteReservada.Capacidade} pessoas.");
                Console.WriteLine($"Você tentou cadastrar {Hospedes.Count} hóspedes.");
                Console.WriteLine("Reserva não pode ser concluída.");
                return;
            }

            // Cálculo do valor total
            decimal valorTotal = CalcularValorDiaria(SuiteReservada.Dias, SuiteReservada.ValorDiaria);

            // Resumo da reserva
            Console.WriteLine("\n=== RESUMO DA RESERVA ===");
            Console.WriteLine("\nHóspedes:");

            foreach (var pessoa in Hospedes)
            {
                Console.WriteLine($"- {pessoa.NomeCompleto}");
            }

            Console.WriteLine($"Suíte: {SuiteReservada.TipoSuite}");
            Console.WriteLine($"Dias reservados: {SuiteReservada.Dias}");
            Console.WriteLine($"Valor da diária: R$ {SuiteReservada.ValorDiaria}");
            Console.WriteLine($"Quantidade de hóspedes: {Hospedes.Count}");
            Console.WriteLine($"Valor total da reserva: R$ {valorTotal}");
        }

        public decimal CalcularValorDiaria(int diasReservados, decimal valorDiaria)
        {
            decimal valor = diasReservados * valorDiaria;

            if (diasReservados >= 10)
            {
                valor *= 0.9m; // 10% de desconto
            }

            return valor;
        }
    }
}