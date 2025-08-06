public class Suite1
{
    public string TipoSuite { get; private set; } = string.Empty;
    public int Capacidade { get; private set; } = 0;
    public decimal ValorDiaria { get; private set; } = 0;
    public int Dias { get; private set; } = 0;
    public decimal PrecoTotal { get; private set; } = 0;

    public Suite1()
    {
        Console.WriteLine("Escolha o tipo de suíte:");
        Console.WriteLine("1 - Junior");
        Console.WriteLine("2 - Máster");
        Console.WriteLine("3 - Conjugada");
        Console.Write("Opção: ");
        string? escolha = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(escolha))
        {
            Console.WriteLine("Opção inválida.");
            return;
        }

        switch (escolha.ToLower())
        {
            case "1":
            case "junior":
                TipoSuite = "Junior";
                Capacidade = 2;
                ValorDiaria = 300;
                break;

            case "2":
            case "máster":
            case "master":
                TipoSuite = "Máster";
                Capacidade = 4;
                ValorDiaria = 700;
                break;

            case "3":
            case "conjugada":
                TipoSuite = "Conjugada";
                Capacidade = 5;
                ValorDiaria = 1200;
                break;

            default:
                Console.WriteLine("Opção inválida.");
                return;
        }

        Console.Write("Quantos dias deseja reservar? ");
        if (!int.TryParse(Console.ReadLine(), out int dias) || dias <= 0)
        {
            Console.WriteLine("Número de dias inválido.");
            return;
        }

        Dias = dias;

        if (Dias >= 10)
        {
            PrecoTotal = (ValorDiaria * Dias) * 0.9m;
        }
        else
        {
            PrecoTotal = ValorDiaria * Dias;
        }

        Console.WriteLine($"\nSuíte {TipoSuite} selecionada.");
        Console.WriteLine($"Capacidade para {Capacidade} pessoas.");
        Console.WriteLine($"Total de: {Dias} dia(s).");
        Console.WriteLine($"Preço da diária: R$ {ValorDiaria}");
        Console.WriteLine($"Valor total da reserva: R$ {PrecoTotal}");

        if (Dias >= 10)
        {
            Console.WriteLine("✅ Desconto de 10% aplicado por reserva acima de 10 dias.");
        }
    }
}