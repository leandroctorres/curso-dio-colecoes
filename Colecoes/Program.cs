using System;
using System.Collections.Generic;
using System.Linq;
using Colecoes.Helper;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {

					/** 1)
					* Criando e percorrendo um array
					*/
					System.Console.WriteLine("1)-------------------------");
					int [] arrayInteiros = new int[3];

					arrayInteiros[0] = 10;
					arrayInteiros[1] = 20;
					arrayInteiros[2] = int.Parse("30");

					System.Console.WriteLine("Percorrendo o array pelo for");
					for (int i=0; i < arrayInteiros.Length; i++)
					{
						System.Console.WriteLine(arrayInteiros[i]);
					}

					System.Console.WriteLine("Percorrendo o array pelo ForEach");
					foreach (int item in arrayInteiros)
					{
						System.Console.WriteLine(item);
					}

					/** 2)
					* Array Multidimensional
					*/
					System.Console.WriteLine("2)-------------------------");

					int [,] matriz = new int[4, 2]
					{
						{ 8, 8 },
						{ 10, 20 },
						{ 50, 100 },
						{ 90, 200 }
					};

					for (int i = 0; i < matriz.GetLength(0); i++)
					{
						for (int j = 0; j < matriz.GetLength(1); j++)
						{
							System.Console.WriteLine(matriz[i, j]);
						}
					}

					/** 3)
					* Ordenando via bubble sort
					*/
					System.Console.WriteLine("3)-------------------------");
					OperacoesArray op = new OperacoesArray();
					int[] array = new int[5] {6, 3, 8, 1, 9};

					System.Console.WriteLine("Array original");
					op.ImprimirArray(array);

					op.OrdenarBubbleSort(ref array);

					System.Console.WriteLine("Array ordenado:");
					op.ImprimirArrayLinha(array);

					/** 4)
					* Classe Array
					*/
					System.Console.WriteLine("4)-------------------------");
					int[] array2 = new int[6] {7, 4, 9, 1, 12, 2};

					System.Console.WriteLine("Array original");
					op.ImprimirArrayLinha(array2);

					op.Ordenar(ref array2);

					System.Console.WriteLine("Array ordenado:");
					op.ImprimirArrayLinha(array2);

					/** 5)
					* Copiar Array
					*/
					System.Console.WriteLine("5)-------------------------");
					int[] arrayCopia = new int[10];

					System.Console.WriteLine("Array antes da cópia");
					op.ImprimirArrayLinha(arrayCopia);

					op.Copiar(ref array, ref arrayCopia);
					System.Console.WriteLine("Array após a cópia");
					op.ImprimirArrayLinha(arrayCopia);

					/** 6)
					* Verificando se um elemtento existe
					*/
					System.Console.WriteLine("6)-------------------------");
					int valorProcurado = 1;
					int valorProcurado2 = 85;
					bool existe = op.Existe(array2, valorProcurado);

					if (existe)
					{
						System.Console.WriteLine("Encontrei o valor: {0}", valorProcurado);
					}
					else
					{
						System.Console.WriteLine("Não encontrei o valor: {0}", valorProcurado);
					}

					bool existeVP2 = op.Existe(array2, valorProcurado2);

					if (existeVP2)
					{
						System.Console.WriteLine("Encontrei o valor: {0}", valorProcurado2);
					}
					else
					{
						System.Console.WriteLine("Não encontrei o valor: {0}", valorProcurado2);
					}

					/** 7)
					* Verifiando todos os elementos do array
					*/
					System.Console.WriteLine("7)-------------------------");
					int valorProcurado3 = 0;
					bool todosMaiorQue = op.TodosMaiorQue(array, valorProcurado3);

					if (todosMaiorQue)
					{
						System.Console.WriteLine("Todos os valores são maiores que {0}", valorProcurado3);
					}
					else
					{
						System.Console.WriteLine("Existe valores que não são maiores do que {0}", valorProcurado3);
					}

					/** 8)
					* Encontrando um elemento no array
					*/
					System.Console.WriteLine("8)-------------------------");
					int valorProcurado4 = 9;
					int valorAchado = op.ObterValor(array, valorProcurado4);

					if (valorAchado > 0)
					{
						System.Console.WriteLine("Encontrei o valor");
					}
					else
					{
						System.Console.WriteLine("Não encontrei o valor");
					}

					/** 9)
					* Encontrando um elemento no array
					*/
					System.Console.WriteLine("9)-------------------------");
					int valorProcurado5 = 8;

					int indice = op.ObterIndice(array, valorProcurado5);

					if(indice > -1)
					{
						System.Console.WriteLine("O índice do elemento {0} é: {1}", valorProcurado5, indice);
					}
					else
					{
						System.Console.WriteLine("Valor não existe no array");
					}

					/** 10)
					* Redimensionando um array
					*/
					System.Console.WriteLine("10)-------------------------");

					System.Console.WriteLine($"Capacidade atual do array: {array.Length}");
					op.RedimensionarArray(ref array, array.Length *2);
					System.Console.WriteLine($"Capacidade do array após redimenssionar: {array.Length}");

					/** 11)
					* Convertendo um array
					*/
					System.Console.WriteLine("11)-------------------------");
					string[] arrayStrings = op.ConverterParaArrayString(array);
					op.ImprimirArrayStringsLinha(arrayStrings);

					/** 12)
					* Declarando e acesando uma lista
					*/
					System.Console.WriteLine("12)-------------------------");
					List<string> estados = new List<string>();
					estados.Add("SP");
					estados.Add("MG");
					estados.Add("BA");

					System.Console.WriteLine($"Quantidade de elementos na lista: {estados.Count}");

					foreach (var item in estados)
					{
						System.Console.WriteLine(item);
					}

					for (int i = 0; i < estados.Count; i++)
					{
						System.Console.WriteLine($"Índice {i}, Valor: {estados[i]}");
					}

					/** 13)
					* Removendo elemento da lista
					*/
					System.Console.WriteLine("13)-------------------------");
					OperacoesLista opLista = new OperacoesLista();

					opLista.ImprimirListaString(estados);
					System.Console.WriteLine("Removendo o elemento");
					estados.Remove("MG");
					opLista.ImprimirListaString(estados);

					/** 14)
					* Adicionando coleções na lista
					*/
					System.Console.WriteLine("14)-------------------------");

					string[] estadosArray = new string[2] {"SC", "RJ"};

					opLista.ImprimirListaString(estados);
					System.Console.WriteLine("Adicionando elementos");
					estados.AddRange(estadosArray);
					opLista.ImprimirListaString(estados);

					/** 15)
					* Adicionando coleções na lista
					*/
					System.Console.WriteLine("15)-------------------------");
					estados.Insert(1,"PI");
					opLista.ImprimirListaString(estados);

					/** 16)
					* Fila
					*/
					System.Console.WriteLine("16)-------------------------");

					Queue<string> fila = new Queue<string>();

					fila.Enqueue("Leonardo");
					fila.Enqueue("Eduardo");
					fila.Enqueue("André");

					System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

					while (fila.Count > 0)
					{
						System.Console.WriteLine($"Vez de: {fila.Peek()}");
						System.Console.WriteLine($"{fila.Dequeue()} atendido ");
					}

					System.Console.WriteLine($"Pessoas na fila: {fila.Count}");

					/** 17)
					* Pilha
					*/
					System.Console.WriteLine("17)-------------------------");
					Stack<string> pilhaLivros = new Stack<string>();

					pilhaLivros.Push(".Net");
					pilhaLivros.Push("POO");
					pilhaLivros.Push("Código Limpo");

					System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");
					while (pilhaLivros.Count > 0)
					{
						System.Console.WriteLine($"Próximo livro para a leitura: {pilhaLivros.Peek()}");;
						System.Console.WriteLine($"{pilhaLivros.Pop()} lido com sucesso");
					}

					System.Console.WriteLine($"Livros para a leitura: {pilhaLivros.Count}");

					/** 18)
					* Dicionário
					*/
					System.Console.WriteLine("18)-------------------------");
					Dictionary<string, string> dicionarioEstados = new Dictionary<string, string>();

					dicionarioEstados.Add("SP", "São Paulo");
					dicionarioEstados.Add("MG", "Minas Gerais");
					dicionarioEstados.Add("BA", "Bahia");

					foreach (KeyValuePair<string, string> item in dicionarioEstados)
					{
						System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
					}

					/** 19)
					* Acessando um valor
					*/
					System.Console.WriteLine("19)-------------------------");

					string estadoProcurado = "BA";
					System.Console.WriteLine(dicionarioEstados[estadoProcurado]);

					/** 20)
					* Atualizando um valor
					*/
					System.Console.WriteLine("20)-------------------------");
					System.Console.WriteLine("Valor original");
					System.Console.WriteLine(dicionarioEstados[estadoProcurado]);

					dicionarioEstados[estadoProcurado] = "BA - Teste Atualização";

					System.Console.WriteLine("Valor atualizado");
					System.Console.WriteLine(dicionarioEstados[estadoProcurado]);

					/** 21)
					* Removendo um valor
					*/
					System.Console.WriteLine("21)-------------------------");

					foreach (KeyValuePair<string, string> item in dicionarioEstados)
					{
						System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
					}

					string estadoProcurado2 = "SP";

					System.Console.WriteLine($"Removendo o valor: {estadoProcurado2}");
					dicionarioEstados.Remove(estadoProcurado2);

					foreach (KeyValuePair<string, string> item in dicionarioEstados)
					{
						System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
					}

					/** 22)
					* Acessando de maneira segura
					*/
					System.Console.WriteLine("22)-------------------------");
					string estadoProcurado3 = "SC";

					if(dicionarioEstados.TryGetValue(estadoProcurado3, out string estadoEncontrado))
					{
						System.Console.WriteLine(estadoEncontrado);
					}
					else
					{
						System.Console.WriteLine($"Chave {estadoProcurado3} não existe na lista");
					}

					/** 23)
					* LINQ
					* Obtendo e ordenando valores com LINQ
					*/
					System.Console.WriteLine("23)-------------------------");
					int[] arrayNumeros = new int[10] {100, 1, 4, 0, 8, 15, 19, 19, 4, 100 };

					var numerosParesQuery =
								from num in arrayNumeros
								where num % 2 == 0
								orderby num
								select num;

					var numerosParesMetodo = arrayNumeros.Where(x => x % 2 == 0).OrderBy(x => x).ToList();

					System.Console.WriteLine("Números pares query: " + string.Join(", ", numerosParesQuery));
					System.Console.WriteLine("Números pares método: " + string.Join(", ", numerosParesMetodo));

					/** 24)
					* LINQ
					* Valores mínimos, máximo e médio
					*/
					System.Console.WriteLine("24)-------------------------");

					var minimo = arrayNumeros.Min();
					var maximo = arrayNumeros.Max();
					var medio = arrayNumeros.Average();

					System.Console.WriteLine($"Mínimo: {minimo}");;
					System.Console.WriteLine($"Maximo: {maximo}");;
					System.Console.WriteLine($"Medio: {medio}");

					/** 25)
					* Sum e Distinct
					*/
					System.Console.WriteLine("25)-------------------------");

					var soma = arrayNumeros.Sum();
					var arrayUnico = arrayNumeros.Distinct().ToArray();

					System.Console.WriteLine($"Soma: {soma}");
					System.Console.WriteLine($"Array original: {string.Join(", ", arrayNumeros)}");
					System.Console.WriteLine($"Array distinto: {string.Join(", ", arrayUnico)}");




















        }
    }
}
