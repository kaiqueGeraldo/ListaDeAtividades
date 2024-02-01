// 1. Faça um programa em C# que receba dois números inteiros e mostre na tela o maior número digitado.

//Console.WriteLine("Qual número é maior?\n\nDigite um número: ");
//string num1 = Console.ReadLine();

//Console.WriteLine("Digite outro número: ");
//string num2 = Console.ReadLine();

//if (Int32.Parse(num1) > Int32.Parse(num2))
//{
//    Console.WriteLine($"{num1} é o maior número");
//}
//else
//{
//    Console.WriteLine($"{num2} é o maior número");
//}



// 2. Escreva um programa em C# que receba 3 números reais e mostre-os na tela em ordem
// decrescente. Considere que o usuário digitará 3 números diferentes.

//Console.WriteLine("Números em ordem decrescente.\n\nDigite um número: ");
//string num1 = Console.ReadLine();

//Console.WriteLine("Digite outro número: ");
//string num2 = Console.ReadLine();

//Console.WriteLine("Digite outro número: ");
//string num3 = Console.ReadLine();

//int[] numeros = { Int32.Parse(num1), Int32.Parse(num2), Int32.Parse(num3) };
//Array.Sort(numeros, (a, b) => b.CompareTo(a));

//Console.WriteLine("Números em ordem decrescente: ");
//foreach (int num in numeros)
//{
//    Console.WriteLine(num + " ");
//}



// 3. Faça um programa em C# que receba do usuário três números inteiros e mostre-os na tela 
// em ordem crescente. Caso o usuário digite três números iguais, mostrar na tela a informação: 
// OS TRÊS NÚMEROS DIGITADOS SÃO IGUAIS.

//Console.WriteLine("Números em ordem crescente.\n\nDigite um número: ");
//string num1 = Console.ReadLine();

//Console.WriteLine("Digite outro número: ");
//string num2 = Console.ReadLine();

//Console.WriteLine("Digite outro número: ");
//string num3 = Console.ReadLine();

//int[] numeros = { Int32.Parse(num1), Int32.Parse(num2), Int32.Parse(num3) };
//Array.Sort(numeros);

//if (num1 == num2 || num2 == num3 || num1 == num3)
//{
//    throw new Exception("Erro!!! Os três números não podem ser iguais.");
//}
//else
//{
//    Console.WriteLine("Números em ordem crescente: ");
//    foreach (int num in numeros)
//    {
//        Console.WriteLine(num + " ");
//    }
//}