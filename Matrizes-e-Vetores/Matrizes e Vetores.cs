#Exercicio 1
# Cria um vetor (lista) de inteiros com 10 posições
vetor = [0] * 10

# Preenche o vetor com os valores desejados
for i in range(10):
  vetor[i] = (i + 1) * 10

# Exibe os valores do vetor usando um loop for
print("Valores do vetor:")
for valor in vetor:
  print(valor)

#Exercicio 2
# Cria uma matriz 4x4 (lista de listas)
matriz = [['' for _ in range(4)] for _ in range(4)]

# Lista de caracteres para preencher a matriz
caracteres = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p']

# Preenche a matriz com os caracteres
indice = 0
for i in range(4):
  for j in range(4):
    matriz[i][j] = caracteres[indice]
    indice += 1

# Exibe os valores da matriz usando dois loops for
print("Valores da matriz:")
for linha in matriz:
  for caractere in linha:
    print(caractere, end=' ')
  print()

      #Exercicio 3
# Vetor com 10 elementos inteiros positivos
vetor = [15, 28, 5, 36, 12, 48, 22, 55, 9, 31]

# Solicita ao usuário um valor inteiro positivo para procurar
try:
  valor_procurado = int(input("Digite um valor inteiro positivo para procurar no vetor: "))
  if valor_procurado <= 0:
    print("Por favor, digite um valor inteiro positivo.")
  else:
    # Procura o valor no vetor
    encontrado = False
    for indice, valor in enumerate(vetor):
      if valor == valor_procurado:
        print(f"O valor {valor_procurado} foi encontrado no índice {indice}.")
        encontrado = True
        break  # Se encontrar, não precisa continuar procurando

    # Informa se o elemento não existe no vetor
    if not encontrado:
      print(f"O valor {valor_procurado} não existe no vetor.")

except ValueError:
  print("Entrada inválida. Por favor, digite um número inteiro.")

#Exercicio 4
import random

# Inicializa uma matriz 3x3 com números reais positivos aleatórios
matriz = []
for i in range(3):
    linha = []
    for j in range(3):
        linha.append(random.uniform(0.1, 10.0)) # Números aleatórios entre 0.1 e 10.0
    matriz.append(linha)

# Exibe a matriz
print("Matriz:")
for linha in matriz:
    print(linha)

# Calcula e exibe a soma dos elementos de cada linha
print("\nSoma dos elementos de cada linha:")
for i in range(3):
    soma_linha = sum(matriz[i])
    print(f"Linha {i+1}: {soma_linha:.2f}") # Formata para duas casas decimais

#Exercicio 5
import random

# Inicializa uma matriz 5x5 com inteiros aleatórios entre -10 e 10
matriz = []
for i in range(5):
    linha = []
    for j in range(5):
        linha.append(random.randint(-10, 10)) # Inteiros aleatórios entre -10 e 10
    matriz.append(linha)

# Exibe a matriz
print("Matriz:")
for linha in matriz:
    print(linha)

# Encontra o maior elemento da matriz
maior_elemento = matriz[0][0] # Assume que o primeiro elemento é o maior inicialmente
for linha in matriz:
    for elemento in linha:
        if elemento > maior_elemento:
            maior_elemento = elemento

# Exibe o maior elemento
print(f"\nO maior elemento da matriz é: {maior_elemento}")
