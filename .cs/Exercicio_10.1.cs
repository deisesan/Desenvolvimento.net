Console.WriteLine("Pangrama");
Pangrama pangrama;
int option;
string phrase;
bool optionException;

do
{
  Console.WriteLine("Digite o número do idioma desejado: ");
  Console.WriteLine("1 - Inglês");
  Console.WriteLine("2 - Português");
  Console.WriteLine("3 - Sair");

  optionException = int.TryParse(Console.ReadLine(), out option);

  if (!optionException)
  {
    Console.WriteLine("Opção Inválida");
  }
  else
  {
    Console.WriteLine("Digite uma sentença: ");
    phrase = Console.ReadLine() ?? "";

    switch (option)
    {
      case 1:
        Console.WriteLine("Entrada");
        Console.WriteLine("Inglês");
        Console.WriteLine(phrase);

        try
        {
          pangrama = new English(phrase);
          Console.WriteLine(pangrama.ToString());
        }
        catch (ArgumentException error)
        {
          Console.WriteLine(error.Message);
        }
        break;
      case 2:
        Console.WriteLine("Entrada");
        Console.WriteLine("Português");
        Console.WriteLine(phrase);

        try
        {
          pangrama = new Portuguese(phrase);
          Console.WriteLine(pangrama.ToString());
        }
        catch (ArgumentException error)
        {
          Console.WriteLine(error.Message);
        }
        break;
      case 3:
        Console.WriteLine("Programa Finalizado.");
        break;
      default:
        Console.WriteLine("Opção Inválida.");
        break;
    }
  }
} while (option != 3);

public class Pangrama
{
  protected string? Phrase { get; set; }
  protected bool isPangrama { get; set; }

  public override string ToString()
  {
    return isPangrama ? "Saída \nÉ um pangrama." : "Saída \nNão é um pangrama.";
  }
}

public class English : Pangrama
{
  private string Alphabet = "abcdefghijklmnopqrstuvwxyz";

  public English(string phrase)
  {
    this.Phrase = phrase.ToLower();

    if (string.IsNullOrEmpty(this.Phrase))
      throw new ArgumentException("Não foi digitado uma frase.");
    else
      this.isPangrama = Alphabet.All(letter => this.Phrase.Contains(letter));
  }
}

public class Portuguese : Pangrama
{
  private string Alphabet = "abcdefghijlmnopqrstuvxz";

  public Portuguese(string phrase)
  {
    this.Phrase = phrase.ToLower();

    if (string.IsNullOrEmpty(this.Phrase))
      throw new ArgumentException("Não foi digitado uma frase.");
    else
      this.isPangrama = Alphabet.All(letter => this.Phrase.Contains(letter));
  }
}
