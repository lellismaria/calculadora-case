## 🧮 Calculadora - Case Engenharia de Software JR.

Você precisa corrigir os seguintes problemas no codigo:

1. Aplicação só está processando o primeiro item da fila infinitamente.

2. Implemente a funcionalidade de divisão.

3. Aplicação não está calculando a penultima operação corretamente.

Saída esperada no console:

```saída
  14 - 8 = 6

  5 * 6 = 30

  2147483647 + 2 = 2147483649

  18 / 3 = 6
```

4. Implemente uma funcionalidade para imprimir toda a lista de operaçõoes a ser processada após cada calculo realizado.

5. Crie uma nova pilha (Stack) para guardar o resultado de cada calculo efetuado e imprima a pilha ao final

## Solução 01 - Aplicação só está processando o primeiro item da fila infinitamente:

### Problema Original:

No código original, estávamos enfrentando um problema onde o primeiro item da fila era processado repetidamente, resultando em um loop infinito. Isso acontecia por conta do método `Peek`, que era usado para visualizar o primeiro item da fila sem removê-lo. Dessa forma, a fila nunca ficava vazia, o que causava o processamento do mesmo item várias vezes.

<img src="https://i.imgur.com/g0RFsz8.png">

### Solução:

Para resolver o problema, substituímos o método `Peek` pelo método `Dequeue`.

- O método `Peek` apenas visualiza o primeiro item da fila, mas não o remove, como deveria ser feito.
- O método `Dequeue` remove e retorna o primeiro item da fila.

Outro ponto a ser analisado e que influenciava no resultado, era a condição `filaOperacoes.Count >= 0`, que nunca mudava, resultando nesse loop. Ajustando essa condição para `while (filaOperacoes.Count > 0)`, garantimos que o loop continue apenas enquanto houver itens na fila. Isso vai evitar o loop que ocorria antes e a fila será processada item por item até estar totalmente vazia.

<img src="https://i.imgur.com/S4DdCj3.png">

## Solução 02 - Implemente a funcionalidade de divisão:

### Problema Original:

O código original da calculadora não incluía a funcionalidade de divisão. As operações iniciais eram `soma (+)`, `subtração (-)` e `multiplicação (*)`. Para adicionar a operação de `divisão (/)`, implementamos um método específico para a divisão e tratamos possíveis exceções, como a divisão por zero.

<img src="https://i.imgur.com/Jl24O3K.png">

### Solução:

1. Adicionando o método de Divisão:

- Criamos um novo método dentro da classe `Calculadora` chamado de `case '/': operacao.resultado = divisao(operacao);break;`
- Utilizando esse método, realizamos a operação de divisão.

2. Criação do método de tratamento de exceção para divisão por zero:

- Dentro do método `divisão`, incluímos uma verificação para evitar que haja uma divisão por zero.
- Se `valorB` for zero, o método lançará uma exceção chamada `DivideByZeroException` com uma mensagem.

<img src="https://i.imgur.com/v27aihH.png">

## Solução 03 - Aplicação não está calculando a penúltima operação corretamente:

### Problema Original:

No código original, a penúltima operação não estava sendo calculada corretamente. Esse problema pode ter ocorrido por alguns motivos:

- Erro na lógica implementada no método de multiplicação.
- Problema na forma como as operações eram processadas na fila.

### Solução:

O problema de cálculo incorreto na penúltima operação foi resolvido assim que revisamos o método de multiplicação e a forma como as operações eram processadas dentro da fila. Utilizando o `Dequeue` para processar e remover cada operação da fila, garantiu que todas as operações fossem executadas normalmente. Com essas mudanças, a aplicação vai calcular corretamente todas as operações, incluindo as de multiplicação.

## Solução 04 - Implemente uma funcionalidade para imprimir toda a lista de operações a ser processada após cada cálculo realizado.

### Objetivo:

No código, adicionamos uma funcionalidade que imprime a lista de operações restantes na fila após o cálculo realizado. Isso facilita a visualização, permitindo verificar quais operações ainda precisam ser processadas, fornecendo uma visão mais clara do progresso.

### Solução:

Para implementar essa funcionalidade, fizemos as seguintes alterações no código:

- Após o cálculo de cada operação, o codigo imprime a fila de operações, listando todas as operações que ainda não foram realizadas.
- Isso vai ocorrer dentro do loop que está processando as operações na fila.

 <img src="https://i.imgur.com/sZQm200.png">

## Solução 05 - Crie uma nova pilha (Stack) para guardar o resultado de cada cálculo efetuado e imprima a pilha ao final:

### Objetivo:

Adicionamos uma `Pilha('Stack')` para armazenar os resultados de cada cálculo realizado, permitindo que se tenha um histórico dos resultados e isso iria facilitar a visualização dos resultados após o processamento de todas as operações.

### Solução:

Para adicionar essa funcionalidade, fizemos a seguinte adição:

1. Criação da `Pilha ('Stack')`:

- Aqui criamos uma nova pilha para conseguirmos armazenar os objetos que estão vindo da classe `Operacoes` depois do cálculo de cada operação.

2. Armazenamento dos Resultados:

- Assim que for feito o cálculo de cada operação, o resultado será `empurrado ('Push')` para a pilha.

3. Impressão da Pilha contendo os Resultados:

- Após o processamento de todas as operações, a pilha é percorrida e seus resultados serão impressos na tela.

<img src="https://i.imgur.com/wZEKSdS.png">

## Informação Adicional:

Analisando a saída com as operações, percebi que não estava voltando os resultados na ordem que eu gostaria. Sendo assim, pesquisei uma maneira de tentar solucionar essa situação e encontrei duas maneiras:

1. Usar a `Pilha` e inverter a ordem

- Aqui vamos continuar usando a pilha para armazenar os resultados normalmente, no final vamos apenas alterar o método e acrescentar o `Reverse` para inverter a ordem dos elementos da lista. Isso vai garantir que os cálculos sejam impressos na mesma ordem em que as operações foram processadas.

### Adicionando o método `Reverse`:
<img src="https://i.imgur.com/J2RtK86.png">

### Resultado:
<img src="https://i.imgur.com/gKoXBGf.png">

2. Usar uma `Lista` para manter a ordem correta

- Aqui nós vamos utilizar uma `Lista` no lugar da `Pilha` para armazenar os resultados necessários. A `Lista` vai manter a ordem que estamos buscando, garantido que o resultado seja impresso na ordem correta.

### Criando uma `Lista`
<img src="https://i.imgur.com/LhnKo2C.png">

### Resultado:

<img src="https://i.imgur.com/Zc3fefX.png">


## ✅ Resultado Final

### Antes da Solução:

<img src="https://i.imgur.com/RfgCkiK.png"> 

### Depois da Solução:

<img src="https://i.imgur.com/9sYiZuU.png">
