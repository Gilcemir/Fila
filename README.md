# Fila
Implementação de uma pilha FIFO ou melhor, uma Fila.

Neste código implementei uma Fila, onde o primeiro a entrar é o primeiro a sair. Como eu não queria usar nenhuma estrutura de dados pronta do c# (uma lista, por exemplo), criei nodos que se comunicam através de referências para o próximo nodo.

Conceitualmente, criei uma fila circular, onde o último se conecta com o primeiro. Ou seja, se eu insiro 1, 2, 3, 4 na fila, respectivamente, ficará assim:

1 -> 2 -> 3 -> 4 -> 1

Caso a Fila tenha apenas um elemento, ele aponta para null. 1 -> null.

O objetivo desses códigos é pura e simplesmente para aprendizagem. Sendo assim, no método "Main", testei o código inserindo vários elementos iguais, para ter certeza que cada nodo criado é uma instância de objeto diferente. Também tentei tirar objetos de uma lista vazia, para ver se o programa estava pegando a exceção.

Métodos da Classe Fila:

StackUp(obj): Passa um objeto obj como argumento.

Unstack(); Retorna o primeiro objeto que entrou na fila.

print(); Imprime os objetos da Fila.