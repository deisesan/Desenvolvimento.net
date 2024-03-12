## Exercício 4

1. Escrever par ou ímpar na tela, a partir de uma variável:
   * com switch
     ```csharp  ​
     Console.Write("Valor: ");
     int value = int.Parse(Console.ReadLine() ?? "0");
     
     switch (value % 2)
     {
       case 0: 
         Console.WriteLine("Par");
         break;
       case 1:
         Console.WriteLine("Ímpar");
         break;
       default:
         Console.WriteLine("Valor Inválido");
         break;
     }
     ```
   
   * com if sem else
  
     ```csharp  ​
     Console.Write("Valor: ");
     int value;
     bool parseSuccess = int.TryParse(Console.ReadLine(), out value);
     
     if (parseSuccess)
       Console.WriteLine((value % 2 == 0) ? "Par" : "Ímpar");
     ```
     
   * sem nenhuma estrutura de controle

     ```csharp  ​
     Console.Write("Valor: ");
     int value = int.Parse(Console.ReadLine() ?? "0");
     
     string[] options = { "Par", "Ímpar" };
     
     // Se value par, imprime option[0]
     // Se value ímpar, impre option[1]
     Console.WriteLine(options[(value % 2)]);
     ```
     
   * com operador ternário
  
       ```csharp  ​
     Console.Write("Valor: ");
     int value = int.Parse(Console.ReadLine() ?? "0");
     
     Console.WriteLine((value % 2 == 0) ? "Par" : "Ímpar");
     ```
  
2. Escreva um programa que use switch para encontrar o valor máximo entre dois números

      ```csharp  ​
       Console.Write("Valor A: ");
       int valueA = int.Parse(Console.ReadLine() ?? "0");
       
       Console.Write("Valor B: ");
       int valueB = int.Parse(Console.ReadLine() ?? "0");
       
       switch (valueA, valueB)
       {
         case ( > 0, > 0) when valueA > valueB:
           Console.WriteLine($"{valueA} > {valueB}");
           break;
         case ( > 0, > 0) when valueB > valueA:
           Console.WriteLine($"{valueB} > {valueA}");
           break;
       }
       
       Console.WriteLine($"O máximo entre {valueA} e {valueB}: {Math.Max(valueA, valueB)}");
      ```
