## Exercício 10.2

Avalie seu código do exercício 10, com base nas vantagens e desvantagens  tratadas em sala de aula, e proponha um melhoramento dele (processo de refatoração).

Pode-se deixar o código menos acoplado, retirando as funções de tratamento de caracteres especiais de dentro da classe pangrama, ou reduzir código usado em duplicidade nas classes derivadas, ou usar upcast da classe pangrama para as classes derivadas ou não usar método abstract, entre outras possibilidades.

Referência: 
  - [REGEX](https://blog.dp6.com.br/regex-o-guia-essencial-das-express%C3%B5es-regulares-2fc1df38a481)
  - [Normalize](https://learn.microsoft.com/en-us/dotnet/api/system.string.normalize?view=net-8.0&redirectedfrom=MSDN#overloads)

```csharp
  using System.Text.RegularExpressions;
  
  Console.WriteLine("\nPangrama\n");
  Pangrama pangrama;
  int option;
  string phrase;
  
  do
  {
    Console.WriteLine("Opções de Idioma ");
    Console.WriteLine("1 - Inglês");
    Console.WriteLine("2 - Português");
    Console.WriteLine("3 - Sair");
    Console.WriteLine("Digite o número do idioma desejado: ");
  
    if (!int.TryParse(Console.ReadLine(), out option))
    {
      Console.WriteLine("\nNão é uma opção válida.\n");
    }
    else
    {
      Console.WriteLine("\nDigite uma sentença: ");
      phrase = Console.ReadLine() ?? "";
  
      switch (option)
      {
        case 1:
          Console.WriteLine("\nEntrada");
          Console.WriteLine("Inglês");
          Console.WriteLine(phrase + "\n");
  
          try
          {
            pangrama = new English { Phrase = phrase.ToLower() };
            Console.WriteLine(pangrama.ToString());
          }
          catch (ArgumentException error)
          {
            Console.WriteLine(error.Message);
          }
          break;
        case 2:
          Console.WriteLine("\nEntrada");
          Console.WriteLine("Português");
          Console.WriteLine(phrase + "\n");
  
          try
          {
            pangrama = new Portuguese { Phrase = phrase.ToLower().RemoveCaractExp() };
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
    protected string Alphabet { get; set; } = "";
    public string Phrase { get; set; } = "";
    public bool CheckPangrama()
    {
      return Alphabet.All(letter => this.Phrase.Contains(letter));
    }
  
    public override string ToString()
    {
      return CheckPangrama() ? "Saída \nÉ um pangrama.\n" : "Saída \nNão é um pangrama.\n";
    }
  }
  
  public class English : Pangrama
  {
    public English()
    {
      this.Alphabet = "abcdefghijklmnopqrstuvwxyz";
    }
  }
  
  public class Portuguese : Pangrama
  {
    public Portuguese()
    {
      this.Alphabet = "abcdefghijlmnopqrstuvxz";
    }
  }
  
  public static class StringManipulation
  {
    public static string RemoveCaractExp(this string phrase)
    {
      return Regex.Replace(phrase, @"[^a-zA-Z]", "");
    }
  
    public static string RemoveAcentos(this string phrase)
    {
      return phrase.Normalize(System.Text.NormalizationForm.FormC);
    }
  }
```
