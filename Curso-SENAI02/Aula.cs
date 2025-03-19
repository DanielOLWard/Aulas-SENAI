////              fundamentos do C#

//// toda linha termina com ';'
//// <tipo do dado> <nome> = <valor inicial>
//// = - atribuicao

//// entrada e saida
//// operadores
//// constantes e variaveis

//// mostra coisas no console (saida)
//Console.Write("informe um usuario: ");
//// manda coisas para o console (entrada)
//string usuario = Console.ReadLine();
////ReadLine so le texto para usar numero, precisa converter (Parse converte string para int ou double)
//Console.Write("insira um numero: ");
//int data = int.Parse(Console.ReadLine());
////concatenacao
//Console.WriteLine("Ola, seja bem vindo: " + usuario);
////interpolacao
//Console.WriteLine($"Ola, seja bem vindo: {usuario}");

//// NUMEROS

//// variavel - o valor pode mudar
//// so guardar como numero aquilo que vai usar para fazer calculo
//// int - numero inteiro
//int idade = 18;
//idade = 22;
//idade = 23;
//Console.WriteLine(idade);

////constante - o valor nao muda
//const int novaidade = 24;
////novaidade = 26;  (comentado so pra nao ficar com erros no codigo)
//Console.WriteLine(novaidade);

//// double - numeros quebrados
//double preco = 9.99;

//// float - numeros quebrados (aceita menos casas decimais)(usa menos memoria)(obrigatorio usar "f" no final)
//float altura = 1.80f;

//// bool - false ou true (condicao)
//bool careca = false;

//// LETRAS

//// string - qualquer caractere
//string texto = "is Ward9012 BB!";

//// char - para guardar 1 cactere
//char letra = 'B';

//string nome = "ward";
//string novonome = nome;

//int numero1 = 1;
//int numero2 = 2;

//int resultado = numero1 + numero2;

//// Operadores

//// Operadores aritimeticos

//// + - soma ou concatena (juntar texto)

//Console.WriteLine(5 + 4);

//Console.WriteLine(5 + "5");

//// - - subtracao
//Console.WriteLine(4 - 5);

//// * - multiplicacao
//Console.WriteLine(5 * 7);

//// / - divisao
//Console.WriteLine(7.0 / 3);

//// 1 - parenteses
//// 2 - multiplicacao e divisao
//// 3 - soma e subtracao
//Console.WriteLine((4 - 9.0) / 2);

//// modulo - da o resto da divisao
//Console.WriteLine(5 % 2);


//// Operadores de comparacao

//// == - Igual
//Console.WriteLine(numero1 == numero2);

//// != - diferente 
//Console.WriteLine(5 != 6);

//// > - maior
//Console.WriteLine(5 > 6);

//// >= - maior ou igual
//Console.WriteLine(5 >= 4);

//// < - menor 
//Console.WriteLine(7 < 9);

//// <= menor ou igual
//Console.WriteLine(7 <= 11);

////Estruturas Condicionais(if e else)

//Console.Write("informe sua idade: ");
//int idadeif = int.Parse(Console.ReadLine());

//// condicional simples
//if (idadeif > 18)
//{
//    Console.WriteLine("vc e maior de idade!");
//}
//else
//{
//    Console.WriteLine("vc e menor de idade!");
//}

//// operador ternário (if else simplificado)
//int idadeternario = 20;
//string msg = (idadeternario > 18) ? "maior de idade" : "menor de idade";

//// condicional encadeada
//if (idadeif > 17)
//{
//    Console.WriteLine("adulto");
//}
//else if (idadeif > 12)
//{
//    Console.WriteLine("adolescente");
//}
//else
//{
//    Console.WriteLine("crianca");
//}

//// operador e - &&
//// operador ou - ||
//bool autorizaPais = true;
//if (idadeif > 16 && autorizaPais == true)
//{
//    Console.WriteLine("pode votar!");
//}

//// estrturas de repeticao <repete uma acao especifica>
//// imprima todos os numeros de 1 a 5

//// while - enquanto <repete uma acao ENQUANTO algo for verdade>
//int numero = 1;
//while (numero <= 5)
//{
//    Console.WriteLine(numero);
//    // numero = numero + 1; <comentado pois nao precisa de 2 comandos iguais>
//    // comando abaixo igual o de cima, porem, e um atalho
//    numero++;
//}

//// Adivinhe a minha idade

//// Do/while - faca

////exemplo usando o while
//Console.WriteLine("informe a idade");
//int idade = int.Parse(Console.ReadLine());

//while (idade != 20)
//{
//    Console.WriteLine("informe a idade");
//    idade = int.Parse(Console.ReadLine());
//}

//// exemplo com  o do/while
//// precisa criar a variavel fora das cahves, pois se criar dentro das chaves ela nao pode ser usado fora
//int idade;
//do
//{
//    Console.WriteLine("informe a idade");
//    idade = int.Parse(Console.ReadLine());
//} while (idade != 20);

//// for - para
////quero imprimir os numeros de 1 a 5
//// <cria uma variavel chamada i (indice)> <condicao para continuar> <incremento ao usar a chave
//for (int i = 0; i < 6; i++)
//{
//    Console.WriteLine(i);
//}

// Tratamento de erros

//int numero = int.Parse(Console.ReadLine());

// Exception = erro
// IOExeption - In and Out - Entrada e Saida
// FormatException - Erros no formato (tipo de dado)
// OverflowException - variavel transbordou

// try/catch - Tentar/Pegar
//
//try
//{
//    int num = int.Parse(Console.ReadLine());
//}
//catch (FormatException ex)
//{
//    Console.WriteLine("Erro: informe apenas numeros");
//}
//catch (OverflowException ex)
//{
//    Console.WriteLine("Erro: numero muito grande");
//}
////finaliza programas que deram erro
//finally
//{

//}

//int idade  = int.Parse(Console.ReadLine());
////cria um erro
//if (idade >120)
//{
//    throw new ArgumentOutOfRangeException("Idade invalida");
//}