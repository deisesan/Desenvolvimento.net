## Exercício 7

Construa um programa para tratamento de erros para uma calculadora simples de números inteiros (adição, multiplicação e divisão). O objetivo é ter uma calculadora funcional que retorne uma string com o seguinte padrão: 16 + 51 = 67, quando fornecidos os argumentos 16, 51 e +.

Chamada: Calculator.Calculate(16, 51, "+");

Exceções: 

- Qualquer valor diferente deve gerar ArgumentOutOfRangeException
- Valores vazios ArgumentException
- Null ArgumentNullException
- Divisão por zero

```csharp
  Calculator teste = new();
  
  try {
      Console.WriteLine(teste.Calculate(16, 51, "+"));
  } catch(Exception ex){
      Console.WriteLine($"Error: {ex.Message}");
  }
  
  try {
      Console.WriteLine(teste.Calculate(16, 51, "*"));
  } catch(Exception ex){
      Console.WriteLine($"Error: {ex.Message}");
  }
  
  try {
      Console.WriteLine(teste.Calculate(16, 51, "/"));
  } catch(Exception ex){
      Console.WriteLine($"Error: {ex.Message}");
  }
  
  class Calculator
  {
    public Calculator() { }
  
    public string Calculate(int? valueA, int? valueB, string operatorArgument)
    {
      if (valueA == null || valueB == null)
        throw new ArgumentException("Valores vazios");
  
      if (operatorArgument == null)
        throw new ArgumentNullException("Null");
  
      if (operatorArgument == "/" && valueB == 0)
        throw new ArgumentException("Divisão por zero");
  
      switch (operatorArgument)
      {
        case "+":
          return $"{valueA} + {valueB} = {valueA + valueB}";
        case "*":
          return $"{valueA} * {valueB} = {valueA * valueB}";
        case "/":
          return $"{valueA} / {valueB} = {(double)valueA / valueB}";
        default:
          throw new ArgumentOutOfRangeException("Operador Inválido");
      }
    }
  
    ~Calculator() { }
  }
```
