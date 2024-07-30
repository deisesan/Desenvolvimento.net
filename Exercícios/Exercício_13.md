## Exercício 13

- Modifique o último exemplo de forma que o usuário seja notificado caso o campo de nova Tarefa esteja vazio.
- Use o elemento p e CSS inline para mudar a cor.
- A mensagem não deve permanecer quando o usuário digitar corretamente.

```razor
  @page "/tasks"
  @rendermode InteractiveServer
  
  <h1>Tasks</h1>
  
  <ul style="list-style-type: none; padding: 0;">
    @foreach (var t in tasks)
    {
      <li>
        <input type="checkbox" @bind="t.Check" />
        @t.Title
      </li>
    }
  </ul>
  
  <input placeholder="Alguma tarefa" @bind="@newTask" @oninput="ClearValidationMessage"/>
  
  <button @onclick="CreateTask">Adicionar</button>
  @if (!string.IsNullOrWhiteSpace(validationMessage))
  {
      <p style="color: red;">@validationMessage</p>
  }
  
  @code {
    private List<Item> tasks = new List<Item>();
    private string? newTask;
    private string validationMessage = "";
  
    private void CreateTask() {
      if (string.IsNullOrWhiteSpace(newTask))
      {
          validationMessage = "Por favor, insira uma tarefa.";
          return;
      }
  
      tasks.Add(new Item { Title = newTask });
      newTask = string.Empty;
      validationMessage = "";  
    }
    
    private void ClearValidationMessage()
    {
        validationMessage = "";
    }
  
    public class Item {
      public string? Title { get; set; }
      public bool? Check { get; set; }
    }
  }
```
