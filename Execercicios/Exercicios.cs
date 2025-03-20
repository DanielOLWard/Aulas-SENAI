////          Excercicios 12/03

//// exerciccio 1
//using System.Reflection.PortableExecutable;

//Console.WriteLine(54 + 54);
//// exerciccio 2
//Console.WriteLine(5 * 5);
//// exerciccio 3
//Console.WriteLine(4 - 2);
//// exerciccio 4
//Console.WriteLine((6 + 6 + 6) / 3);
//// exerciccio 5
//Console.WriteLine(8 % 2);

////         Excercicios 13/03

//// exrcicio 1
//Console.WriteLine("escreva dois numeros para eu lhe dizer qual deles é maior: ");
//int numero1 = int.Parse(Console.ReadLine());
//int numero2 = int.Parse(Console.ReadLine());

//if (numero1 > numero2)
//{
//    Console.WriteLine("O primeiro é maior");
//}
//else if (numero1 < numero2)
//{
//    Console.WriteLine("O segundo é maior");
//}
//else
//{
//    Console.WriteLine("Os dois são iguais");
//}

//// exercicio 2
//Console.WriteLine("informe a sua idade: ");
//int idade = int.Parse(Console.ReadLine());

//if (idade > 18)
//{
//    Console.WriteLine("Você é adulto!");
//}
//else if (idade > 13)
//{
//    Console.WriteLine("Você é adolescente!");
//}
//else
//{
//    Console.WriteLine("Você é crianca!");
//}

//// excercicio 3
//Console.WriteLine("escreva um numero e eu lhe direi se e par ou impar!");
//int numero = int.Parse(Console.ReadLine());

//if (numero % 2 == 1)
//{
//    Console.WriteLine("É impar!");
//}
//else
//{
//    Console.WriteLine("É par!");
//}

//// excercicio 4
//Console.WriteLine("escreva tres numeros e irei lhe dizer qual deles é o maior!!!");
//int num1 = int.Parse(Console.ReadLine());
//int num2 = int.Parse(Console.ReadLine());
//int num3 = int.Parse(Console.ReadLine());

//if (num1 > num2 && num1 > num3)
//{
//    Console.WriteLine("O primeiro é maior");
//}
//else if (num2 > num1 && num2 > num3)
//{
//    Console.WriteLine("O segundo é maior");
//}
//else if (num3 > num1 && num3 > num2)
//{
//    Console.WriteLine("O terceiro e maior");
//}
//else
//{
//    Console.WriteLine("Os tres são iguais");
//}

//// excercicio 5
//Console.WriteLine("Me entregue 3 numeros e euirei resolver bhaskara!!!");
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = int.Parse(Console.ReadLine());

//int delta = b * b - (4 * a * c);

//double raiz1 = (-b + Math.Sqrt(delta)) / (2 * a);
//double raiz2 = (-b - Math.Sqrt(delta)) / (2 * a);

//if (delta > 0)
//{
//    Console.WriteLine($"As raizes são: {raiz1} e {raiz2}");
//}
//else
//{
//    Console.WriteLine("Não existe raizes rais para esse calculo");
//}

//// EXERCICIOS (17/03/2022)

//// Exercicio 01 (conte de 1 a 20)
//int numero = 0;
//do
//{
//    Console.WriteLine(numero);
//    numero++;
//} while (numero <= 20);

//// exercicio 02 (valide a senha 1234, continue pedindo ate que acerte)
//Console.WriteLine("acerte a senha");
//int senha = int.Parse(Console.ReadLine());

//while (senha != 1234)
//{
//    Console.WriteLine("tente dnv");
//    senha = int.Parse(Console.ReadLine());
//}

//// exercicio 03 (tauada, peca ao usuario um numero e exiba a tabuada de 1 a 10)

//Console.WriteLine("fale um numero e receba a sua tabuada");
//int tabuada = int.Parse(Console.ReadLine());
//int numerador = 1;
//while (numerador < 10)
//{
//    numerador++;
//    Console.WriteLine($"{tabuada} x {numerador} = {tabuada * numerador}");
//}

//// Exercicio 4 (contagem regressiva, peca um numero ao usuario e  realize uma contagem regressiva ate 0)

//Console.WriteLine("me entrege um numero que eu realizarei a contagem regressiva");
//int numero = int.Parse(Console.ReadLine());

//do
//{
//    Console.WriteLine(numero--);
//} while (numero > 0);

//// exercicio 5 (media de notas, Solicite notas ao usuário (entre 0 e 10) até que ele insira um número inválido. Depois, exiba a média das notas)

//double notas;
//double SomaNotas = 0.0;
//double qtdNotas = 0.0;

//do
//{
//    Console.Write("informe uma nota: ");
//    notas = int.Parse(Console.ReadLine());
//    if (notas >= 0 && notas <= 10)
//    {
//        SomaNotas = notas + SomaNotas;
//        qtdNotas++;
//    }
//} while (notas >= 0 && notas <= 10);

//double media = SomaNotas / qtdNotas;
//Console.WriteLine("a media e: " + media);
////________________________________________________________________________________________________

//// EXERCICIOS 18/03

//// Excercicio 1 Entrada Segura de Números - Crie um programa que peça ao usuário para digitar um número inteiro. O programa deve usar `try/catch` para garantir que o usuário insira um número válido

//using System.ComponentModel;

//Console.WriteLine("Digite um numero: ");
//try
//{
//    int numero = int.Parse(Console.ReadLine());
//}
//catch (FormatException ex)
//{
//    Console.WriteLine("Apenas numeros sao aceitos!!");
//}

//// Excercicio 2 Divisao segura - Crie um programa que peça dois números ao usuário e divida o primeiro pelo segundo. Use try/catch para evitar divisão por zero e entrada inválida

//Console.WriteLine("digite 2 numeros e eu irei dividir: ");
//try
//{
//    int dividendo = int.Parse(Console.ReadLine());
//    int divisor = int.Parse(Console.ReadLine());
//    int resultado = dividendo / divisor;
//    Console.WriteLine(resultado);
//}
//catch (FormatException ex)
//{
//    Console.WriteLine("Apenas numeros sao aceitos!!");
//}
//catch (DivideByZeroException ex)
//{
//    Console.WriteLine("Nao e possivel dividir por zero!!");
//}

//// Exercicio 3 Validacao de idade - Peça ao usuário para inserir sua idade e diga se ele é maior ou menor de idade. Use try/catch para evitar entradas inválidas.

//Console.WriteLine("Insira uma idade: ");
//int idade = 0;
//try
//{
//    idade = int.Parse(Console.ReadLine());
//    if (idade > 120 || idade < 0)
//    {
//        throw new OverflowException();
//    }
//}
//catch (FormatException ex)
//{
//    Console.WriteLine("Apenas numeros sao aceitos!!");
//}
//catch (OverflowException ex)
//{
//    Console.WriteLine("Insira uma idade valida!!");
//}

//// Exercicio 4 Contagem progressiva segura - Peça ao usuário para inserir um número inteiro positivo. O programa deve contar de 1 até esse número. Se a entrada for inválida ou negativa, exiba um erro.

//Console.WriteLine("Escreva um numero e irei contar ate ele: ");
//int numUser = int.Parse(Console.ReadLine());
//int i = 1;
//try
//{
//    if (numUser > 500)
//    {
//        throw new OverflowException();
//    }
//    do
//    {
//        Console.WriteLine(i);
//        i++;
//    } while (i <= numUser);
//}
//catch (FormatException ex)
//{
//    Console.WriteLine("Apenas numeros sao aceitos!!");
//}
//catch (OverflowException ex)
//{
//    Console.WriteLine("Numero muito grande");
//}
//catch (ArgumentOutOfRangeException)
//{
//    Console.WriteLine("Insira apenas numeros negativos!!");
//}

//// Exercicio 5 soma de numeros - Crie um programa que peça ao usuário para inserir 5 números e some-os. Use try/catch para lidar com entradas inválidas.

//int soma = 0;
//int numero = 0;
//bool verificada = false;

//for (int i = 1; i <= 5; i++)  // Alterado para incluir 5 números
//{
//    Console.WriteLine($"Digite o {i}º número: ");
//    verificada = false;

//    while (!verificada)  // A lógica de verificação precisa ser corrigida para verificar a entrada
//    {
//        try
//        {
//            numero = int.Parse(Console.ReadLine());

//            if (numero < 0)
//            {
//                throw new ArgumentOutOfRangeException();  // Lança uma exceção se o número for negativo
//            }

//            soma += numero;  // Adiciona o número à soma
//            verificada = true;  // A entrada foi válida, sai do loop
//        }
//        catch (FormatException)
//        {
//            Console.WriteLine("Erro: Entre somente com números inteiros!");
//        }
//        catch (ArgumentOutOfRangeException)
//        {
//            Console.WriteLine("Erro: Não é permitido números negativos!");
//        }
//        catch (OverflowException)
//        {
//            Console.WriteLine("Erro: Número muito grande!");
//        }
//    }
//}

//Console.WriteLine($"A soma dos números é: {soma}");

////________________________________________________________________________________________________

//// EXERCICIOS 19/03

//// Exercicio 1 crie um vetor de idades que armazene 4 idades

//int[] idades = new int[4];

//for (int i = 0; i < 4; i++)
//{
//    Console.WriteLine($"escreva a idade {i}");
//    idades[i] = int.Parse(Console.ReadLine());
//}
//for (int i = 0; i < 4; i++)
//{
//    Console.WriteLine($"a idade {i} e: {idades[i]}");
//}