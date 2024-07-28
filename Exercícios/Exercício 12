## Exercício 12

- Criar o app mostrado em aula 
- Alterar a página/componente Counter acrescentando um novo botão que adiciona +2 no contador.
Entregue o arquivo Counter.

```razor
@page "/counter"
@rendermode InteractiveServer

<PageTitle>Counter</PageTitle>

<h1>Counter</h1>

<p role="status">Current count: @currentCount</p>

<button class="btn btn-primary" @onclick="IncrementCount">+1</button>
<button class="btn btn-primary" @onclick="IncrementCountTwo">+2</button>

@code {
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

    private void IncrementCountTwo()
    {
        currentCount += 2;
    }
}
```
- Crie uma segunda página chamada Tarefas, e adicione ao menu. Basta ter um título h1.
