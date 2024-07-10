## Exercício 10.1

[Deve-se usar os conceitos de Orientação a Objetos: construtor, propriedades, atributos privados, pelo menos um método e herança] 

A tarefa é determinar se uma sentença é um pangrama. Um pangrama é uma sentença que utiliza cada letra do alfabeto pelo menos uma vez. É insensível a maiúsculas e minúsculas.

O programa deve solicitar ao usuário se ele deseja usar em Inglês ou Português. Deverá ter uma classe base com os atributos/métodos comuns e duas classes derivadas especializadas para a tarefa em cada idioma.  Poderá ser em dupla.

Entrada<br>
Inglês<br>
The quick brown fox jumps over the 2 lazy dog

Saída <br>
É um pangrama

Entrada<br>
Português<br>
Gazeta publica hoje: breve anuncio de faxina na quermesse

Saída<br>
É um pangrama

Entrada<br>
Português<br>
Esta_frase nao usa todas as letras, estao faltando algumas

Saída<br>
Não é um pangrama

```csharp
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
```
