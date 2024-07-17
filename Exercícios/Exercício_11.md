## Exercício 11

Você deve implementar um programa C# que realiza a ordenação de uma lista de nomes utilizando diferentes estratégias de ordenação.

Deve ter:

Um interface IOrdenação que defina um contrato para as estratégias de ordenação. Essa interface deve conter um método Sort que recebe uma lista de strings como parâmetro.

Duas classes concretas, que implementam a interface, e representem diferentes estratégias de ordenação: QuickSort (padrão) e MergeSort

Uma classe ListaOrdenada que atuará como o contexto as estratégias de ordenação. Atributos: uma lista de strings e um do tipo IOrdenação

No método Sort, da classe ListaOrdenada, chame o método Sort da estratégia de ordenação atual e, em seguida, itere sobre a lista de nomes e exiba-os.

```csharp
Main
ListaOrdenada
estudantes = new();
estudades.Add("Jose");
…
estudantes.SetEstrategia(new QuickSort());
estudantes.Sort();
estudantes.SetEstrategia(new MergeSort());
estudantes.Sort();
```

Referência: 
  - [Merge Sort – Data Structure and Algorithms Tutorials](https://www.geeksforgeeks.org/merge-sort/) - Adaptado para Lista de Strings

```csharp
  ListaOrdenada estudantes;
  
  estudantes = new ListaOrdenada();
  
  estudantes.Add("Alecsandre");
  estudantes.Add("Deise");
  
  estudantes.SetEstrategia(new QuickSort());
  estudantes.Sort();
  estudantes.ViewList();
  
  estudantes.Add("Anne");
  estudantes.Add("Dayany");
  
  estudantes.SetEstrategia(new MergeSort());
  estudantes.Sort();
  estudantes.ViewList();
  
  public interface IOrdenacao
  {
    void Sort(List<string> list);
  }
  
  public class QuickSort : IOrdenacao
  {
    public void Sort(List<string> list)
    {
      list.Sort();
    }
  }
  
  public class MergeSort : IOrdenacao
  {
    private void Merge(List<string> list, int start, int mid, int end)
    {
      int sizeLeft = mid - start + 1;
      int sizeRight = end - mid;
  
      string[] Left = new string[sizeLeft];
      string[] Right = new string[sizeRight];
      int i, j;
  
      for (i = 0; i < sizeLeft; ++i)
        Left[i] = list[start + i];
      for (j = 0; j < sizeRight; ++j)
        Right[j] = list[mid + 1 + j];
  
      i = 0;
      j = 0;
  
      int temp = start;
      while (i < sizeLeft && j < sizeRight)
      {
        if (String.Compare(Left[i], Right[j], StringComparison.InvariantCulture) <= 0)
        {
          list[temp] = Left[i];
          i++;
        }
        else
        {
          list[temp] = Right[j];
          j++;
        }
        temp++;
      }
  
      while (i < sizeLeft)
      {
        list[temp] = Left[i];
        i++;
        temp++;
      }
  
  
      while (j < sizeRight)
      {
        list[temp] = Right[j];
        j++;
        temp++;
      }
    }
  
    public void SortRecursive(List<string> list, int start, int end)
    {
      if (start < end)
      {
        int mid = start + (end - start) / 2;
  
        SortRecursive(list, start, mid);
        SortRecursive(list, mid + 1, end);
  
        Merge(list, start, mid, end);
      }
    }
  
    public void Sort(List<string> list)
    {
      SortRecursive(list, 0, list.Count - 1);
    }
  }
  
  public class ListaOrdenada
  {
    protected List<string> list { get; set; } = [];
    protected IOrdenacao estrategia { get; set; } = new QuickSort();
  
    public void Add(string item)
    {
      list.Add(item);
    }
  
    public void Sort()
    {
      estrategia.Sort(list);
    }
  
    public void SetEstrategia(IOrdenacao estrategia)
    {
      this.estrategia = estrategia;
    }
  
    public void ViewList()
    {
      Console.WriteLine("-----------------------------");
  
      foreach (var item in list)
      {
        Console.WriteLine(item);
      }
    }
  }
```
