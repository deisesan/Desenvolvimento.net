## Exercício 1

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
