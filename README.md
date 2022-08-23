# random_unique_integers
Script criado para gerar listas de Integers aleatórios e não repetidos na Unity.

## Como usar
Coloque o script onde desejar em seu projeto na Unity e quando quiser utilizar as funções, insira *using GarzetTools;* no topo do script.

A utilização é feita da seguitne forma:

List< int > i = GetRandom.RandomNumInRange(X, Y); 

Sendo X o tamanho do array de ints aleatórios e Y o maior número aleatório possível. Caso não insira um valor máximo, ele é definido como 100.
