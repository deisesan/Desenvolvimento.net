## Exercício 7

Construa um programa para tratamento de erros para uma calculadora simples de números inteiros (adição, multiplicação e divisão). O objetivo é ter uma calculadora funcional que retorne uma string com o seguinte padrão: 16 + 51 = 67, quando fornecidos os argumentos 16, 51 e +.

Chamada: Calculatora.Calcular(16, 51, "+");

Exceções: 

- Qualquer valor diferente deve gerar ArgumentOutOfRangeException
- Valores vazios ArgumentException
- Null ArgumentNullException
- Divisão por zero
