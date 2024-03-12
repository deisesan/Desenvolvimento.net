## Exercício 3

1. Escreva um programa em C# que receba dois números inteiros do usuário e exiba o resultado das seguintes operações: adição, subtração, multiplicação, divisão inteira e resto da divisão entre os números. Pesquisar uma forma de verificar se o tipo está correto.

   ```csharp  ​
   Console.WriteLine("Digite dois números inteiros");
   
   Console.Write("Valor A: ");
   int valueA = int.Parse(Console.ReadLine() ?? "0");
   
   Console.Write("Valor B: ");
   int valueB = int.Parse(Console.ReadLine() ?? "0");
   
   Console.WriteLine($"\nAdição: {valueA + valueB}");
   Console.WriteLine($"Subtração: {valueA - valueB}");
   Console.WriteLine($"Multiplicação: {valueA * valueB}");
   
   try
   {
     Console.WriteLine($"Divisão Inteira: {valueA / valueB}");
   }
   catch (DivideByZeroException)
   {
     Console.WriteLine("Divisão Inteira -> Divisão de {0} por zero.", valueA);
   }
   
   try
   {
     Console.WriteLine($"Resto da Divisão: {valueA % valueB}");
   }
   catch (DivideByZeroException)
   {
     Console.WriteLine("Resto da Divisão -> Divisão de {0} por zero.", valueA);
   }
    ```
   
2. Escreva um programa em C# que utilize uma única expressão lambda para fazer todas as operações da questão 1. Em seguida, exiba o resultado na tela.

   ```csharp  ​
   Console.WriteLine("\n\nDigite dois números inteiros");
   
   Console.Write("Valor A: ");
   int valueA = int.Parse(Console.ReadLine() ?? "0");
   
   Console.Write("Valor B: ");
   int valueB = int.Parse(Console.ReadLine() ?? "0");
   
   Func<int, int, Func<int, int, int>, int> OperacoesAritmeticas = (valueA, valueB, operacao) => operacao(valueA, valueB);
   
   Console.WriteLine($"\nAdição: {OperacoesAritmeticas(valueA, valueB, (a, b) => a + b)}");
   Console.WriteLine($"Subtração: {OperacoesAritmeticas(valueA, valueB, (a, b) => a - b)}");
   Console.WriteLine($"Multiplicação: {OperacoesAritmeticas(valueA, valueB, (a, b) => a * b)}");
   
   try
   {
     Console.WriteLine($"Divisão Inteira: {OperacoesAritmeticas(valueA, valueB, (a, b) => a / b)}");
   }
   catch (DivideByZeroException)
   {
     Console.WriteLine("Divisão Inteira -> Divisão de {0} por zero.", valueA);
   }
   
   try
   {
     Console.WriteLine($"Resto da Divisão: {OperacoesAritmeticas(valueA, valueB, (a, b) => a % b)}");
   }
   catch (DivideByZeroException)
   {
     Console.WriteLine("Resto da Divisão -> Divisão de {0} por zero.", valueA);
   }
   ```
