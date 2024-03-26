int stopVariable;
ListDinamic classNumbers = new();

do
{
  Console.WriteLine("Digite o número da opção desejada: ");
  Console.WriteLine("1 - Adicionar mais um número");
  Console.WriteLine("2 - Verificar a média e o desvio");
  Console.WriteLine("0 - Finalizar");
  stopVariable = int.Parse(Console.ReadLine() ?? "0");

  switch (stopVariable)
  {
    case 1:
      Console.WriteLine("Digite o valor: ");
      classNumbers.addNumber(int.Parse(Console.ReadLine() ?? "0"));
      break;
    case 2:
      try
      {
        classNumbers.ToString();
      }
      catch (Exception e)
      {
        Console.WriteLine($"Error: {e}");
      }
      break;
  }
} while (stopVariable != 0);

class ListDinamic
{
  private List<int> numbers = new();

  public ListDinamic() { }

  public int Numbers { get; set; }

  public void addNumber(int value) { numbers.Add(value); }

  public double meanNumbers()
  {
    return numbers.Count() == 0 ?
        throw new ArgumentException("Não é possível calcular a média/desvioPadrão com uma lista vazia") :
        numbers.Average();
  }

  public double standardDeviation()
  {
    return Math.Sqrt(numbers.Sum(number => Math.Pow(number - numbers.Average(), 2)) / numbers.Count());
  }

  public override string ToString()
  {
    return $"Média: {meanNumbers():F2}\nDesvio Padrão:{standardDeviation():F2}";
  }
}
