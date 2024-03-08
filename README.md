# Desenvolvimento.net
Este é um projeto desenvolvido como parte da disciplina de Desenvolvimento Para Ambiente Microsoft .NET na faculdade. Utilizando a linguagem C# e o framework .NET, buscamos aplicar os conceitos aprendidos em sala de aula.

## <a name="indice">Aulas</a>
- Aula 1 - Introdução à disciplina, ao .NET e a linguagem C#
- Aula 2 - Operadores e funções lambda
- Aula 3 - Condicional

## <a name="indice">Exercícios</a>
- [Exercício 1](#exe1)
- [Exercício 2](#exe2)
- [Exercício 3](#exe3)

---

## <a name="exe1">Exercício 1</a>
1. É possível comparar tanto tipos de valor quanto tipos de referência usando o método Equals? Sim, é possível comparar.
   a. Dê, pelo menos, três exemplos distintos de uso com tipos de valor e referência.
   ```csharp
   // Tipos de valor
   int valueA = 10;
   int valueB = 10;
  
   Console.WriteLine ("valueA.Equals(valueB) -> " + valueA.Equals(valueB)); 
   // valueA.Equals(valueB) -> True
   ```
   ```csharp
    // Tipos de referência
    string stringA = "Deise";
    string stringB = "Deise";
    
    Console.WriteLine ("stringA.Equals(stringB) -> " + stringA.Equals(stringB)); 
    // stringA.Equals(stringB) -> True
    
    stringB = "DeiseModificada";
    
    Console.WriteLine ("stringA.Equals(stringB) -> " + stringA.Equals(stringB)); 
    // stringA.Equals(stringB) -> False
   ```
   ```csharp
    // Tipos de referência
    int[] arrayA = { 1, 2, 3, 4, 5 };
    int[] arrayB = arrayA;
    
    Console.WriteLine ("arrayA.Equals(arrayB) -> " + arrayA.Equals(arrayB)); 
    // arrayA.Equals(arrayB) -> True
   ```
2. Como atribuir o valor de um array 'a' para um array 'b' e, em seguida, modificar 'b' sem afetar o array original?
   
   Se copiar um array no outro, vai por refêrência e quando edita arrayB, o arrayA é editado também: 
   ```csharp
    int[] arrayA = { 1, 2, 3, 4, 5 };
    int[] arrayB = arrayA;
    
    Console.WriteLine("arrayA -> " + arrayA);
    Console.WriteLine("arrayB -> " + arrayB);
    
    Console.WriteLine ("arrayA.Equals(arrayB) -> " + arrayA.Equals(arrayB)); 
    // arrayA.Equals(arrayB) -> True
    
    arrayB[0] = 0;
    
    Console.WriteLine ("arrayA.Equals(arrayB) -> " + arrayA.Equals(arrayB)); 
    // arrayA.Equals(arrayB) -> True
   ```
   Para poder modificar sem afetar o array original, é necessário criar um array novo e usar o método Copy:
   ```csharp  ​
    int[] arrayA = { 1, 2, 3, 4, 5 };
    int[] arrayB = new int[arrayA.Length];
    
    Array.Copy(arrayA, arrayB, arrayA.Length);
    
    arrayB[0] = 0;
    ```

3. Explique cada comando e o que acontece no seguinte código.

   ```csharp  ​
    // Cria uma lista dinâmica de string 
    List<string> nomes = new List<string>();
    
    // Adiciona string diferentes na lista 
    nomes.AddRange(new [] {".net", "2023", "ifnmg"});
    
    // Imprime no console o tipo da lista (embaixo o retorno no console)
    Console.WriteLine(nomes);
    ```
    ```csharp  ​
    System.Collections.Generic.List`1[System.String]
    ```

4. Pesquise e apresente uma forma de exibir todos os elementos da variável “nomes” do exemplo anterior, sem usar uma estrutura de repetição explicitamente, nos moldes tradicionais.
   ```csharp  ​
    foreach (string nome in nomes)
    {
      Console.WriteLine(nome);
    }
    ```
    ```csharp  ​
    nomes.ForEach(Console.WriteLine);
    ```
---

## <a name="exe2">Exercício 2</a>

(Dupla) Utilize os conhecimentos vistos em sala de aula sobre o sistemas de tipos (especialmente sobre os tipos de valor e referência) da Linguagem C#. Crie um enunciado de questão que seja capaz de avaliar se quem resolver entendeu a diferenças entre os tipos de valor e referência.

---

## <a name="exe3">Exercício 3</a>

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
