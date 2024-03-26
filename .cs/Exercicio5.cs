int stopVariable = 1;

while (stopVariable != 0)
{
  Console.WriteLine("Financiamento");
  Console.Write("No. de meses: ");
  bool numberInstallmentsParse = int.TryParse(Console.ReadLine(), out int numberInstallments);
  Console.Write("Taxa de juros mensal %: ");
  bool interestRateParse = double.TryParse(Console.ReadLine(), out double interestRate);
  Console.Write("Valor financiado: ");
  bool valueParse = double.TryParse(Console.ReadLine(), out double value);

  if (numberInstallmentsParse && interestRateParse && valueParse)
  {
    // Fórmula para calcular a parcela -> Cálculo de Financiamento
    // CF = taxaDeJuros / 1 - ((1 + taxaDeJuros)^(-nMeses));
    double interestRatePercent = interestRate / 100;
    double cf = interestRatePercent / (1 - Math.Pow(1 + interestRatePercent, -numberInstallments));

    decimal portion = Math.Truncate((decimal)cf * (decimal)value * 100) / 100;
    decimal total = Math.Truncate(portion * numberInstallments * 100) / 100;
    decimal interestValue = Math.Truncate((total - (decimal)value) * 100) / 100;

    Console.WriteLine($"\nParcela:  {Math.Round(portion, 2):F2}");
    Console.WriteLine($"O total desse financiamento de {numberInstallments}");
    Console.WriteLine($"parcelas é {Math.Round(total, 2):F2} reais");
    Console.WriteLine($"sendo {Math.Round(interestValue, 2):F2} de juros");
  }

  Console.WriteLine("\nDigite 0 para finalizar a simulação");
  stopVariable = int.Parse(Console.ReadLine() ?? "0");
}
