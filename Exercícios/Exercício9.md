## Exercício 9 - Pré-Avaliação

1. Avalie os códigos abaixo, informe a saída para cada caso e justifique:

   a. Passa direto no primeiro case por que não tem um break, reproduz o segundo case e para, mostrando a palavra “Um” no console.
   
   b. Mostra a divisão inteira de 2/3, no caso 0.

   c. Retorna NaN.

   d. Gera uma exceção.

   e. Retorna o valor 0 na tela que é o valor de Z.

2. Você está trabalhando em um projeto de programação orientada a objetos e precisa implementar a propriedade "TipoEmpregado" em uma classe chamada "Empregado". Essa propriedade deve atender aos seguintes requisitos:

   a. O valor da propriedade só pode ser acessado por código dentro da própria classe "Empregado" .

   b. O valor da propriedade só pode ser modificado por código dentro da própria classe "Empregado".

   c. Sua tarefa é garantir que a implementação da propriedade "TipoEmpregado" atenda a esses requisitos.
   ```csharp
   class Empregado {
    	public int TipoEmpregado {
    		get;
    		set;
    	}
    }
   ```
  
3. Como você completaria o seguinte código sem gerar erro de sintaxe?

   
    ```csharp
    String[] nomes = { "VW", "Fiat", "Ford", "Hyundai" };

    foreach (string i in nomes)
    {
      Console.WriteLine(i);
    }
    ```

    ```csharp
    private static void Main(string[] args)
    {
      Console.WriteLine("Olá,Mundo!");
    }
    ```

    ```csharp
    double number;
    Console.WriteLine("Digite um número:");
    while (!double.TryParse(Console.ReadLine(), out number))
      Console.WriteLine("Valor incorreto");
    ```

    ```csharp
    try
    {
      int[] numeros = { 1, 2, 3 };
      Console.WriteLine(numeros[10]);
    }
    catch
    {
      Console.WriteLine("Algo errado.");
    }
    finally
    {
      Console.WriteLine("Exemplo 'try catch'.");
    }
    ```

    ```csharp
    try
    {
      int[] numeros = { 1, 2, 3 };
      Console.WriteLine(numeros[10]);
    }
    catch
    {
      Console.WriteLine("Algo errado.");
    }
    finally
    {
      Console.WriteLine("Exemplo 'try catch'.");
    }
    ```

    ```csharp
    int num = 9;
    double numfloat = 8.99;
    float numfloat = 8.99f;
    char letra = 'A';
    bool booleano = false;
    string texto = "Olá, mundo";
    ```

4. Responda as questões abaixo sobre a Linguagem C#, com definição e exemplo:
   a. Como se declara um tipo anônimo? var tipoAnonimo
   
   b. Qual é a palavra-chave necessária para um parâmetro ser uma referência a parâmetro de saída? out

   c. Qual é o modificador de acesso padrão de um membro de classe? private

   d. Qual é a convenção de nomes de variáveis e de métodos?
   
       variáveis → primeira letra em minúsculo

       métodos → primeira letra sempre em maiúsculo

   e. De quantas maneiras você pode passar parâmetros para um método?

       referência

       valor

       opcional

       usando a palavra ref

       nomeado

   f. Qual é a classe base de todos os tipos de dados? Object     

   g. Quais são os tipos de variáveis em que os valores são atribuídos diretamente? Tipo de valor

   h. Diferencie os comandos “break” e “continue”.

       break → para o fluxo do escopo 
        
       continue ->interrompe no ponto definido, devolve a interação para a estrutura e ela faz o fluxo seguinte
   

6. Crie uma classe chamada Balança, que deve ser capaz de medir pesos com uma determinada precisão. A classe Balança possui as seguintes propriedades:
