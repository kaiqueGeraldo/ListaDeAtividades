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



// 4. Escreva um programa em C# que solicite ao usuário 3 (três) números inteiros e retorne se
// os números foram ou não foram digitados em ordem crescente.

//Console.WriteLine("Digite três números.\n\nDigite um número: ");
//string num1 = Console.ReadLine();

//Console.WriteLine("Digite outro número: ");
//string num2 = Console.ReadLine();

//Console.WriteLine("Digite outro número: ");
//string num3 = Console.ReadLine();

//int[] numeros = { Int32.Parse(num1), Int32.Parse(num2), Int32.Parse(num3) };
//Array.Sort(numeros);

//if (Int32.Parse(num2) > Int32.Parse(num3) || Int32.Parse(num3) < Int32.Parse(num1))
//{
//    Console.WriteLine($"\n{0}\n{1}\n{2}\nOs números não foram inseridos em ordem crescente", num1, num2, num3);
//}
//else
//{
//    Console.WriteLine($"\n{0}\n{1}\n{2}\nOs números foram inseridos em ordem crescente", num1, num2, num3);
//}



// 5. Faça um programa em C# que solicite ao usuário um número inteiro e retorne se é par ou ímpar.

//Console.WriteLine("Par ou ímpar?.\n\nDigite um número: ");
//string num1 = Console.ReadLine();

//if (Int32.Parse(num1) % 2 == 0)
//{
//    Console.WriteLine($"{num1} é par.");
//}
//else
//{
//    Console.WriteLine($"{num1} é ímpar.");
//}



// 6. Faça um programa em C# que solicite ao usuário um número inteiro e retorne se é múltiplo de 5 e de 10 ao mesmo tempo.

//Console.WriteLine("Múltiplo de 5 e de 10?.\n\nDigite um número: ");
//string num1 = Console.ReadLine();

//if (Int32.Parse(num1) % 5 == 0 && Int32.Parse(num1) % 10 == 0)
//{
//    Console.WriteLine($"{num1} é múltiplo de 5 e de 10 ao mesmo tempo.");
//}
//else if (Int32.Parse(num1) % 5 == 0)
//{
//    Console.WriteLine($"{num1} é somente múltiplo de 5.");
//}
//else
//{
//    Console.WriteLine($"{num1} não é múltiplo de 5 e nem de 10.");
//}



// 7. Escreva um programa em C# que receba dois números reais. Verifique se a soma dos números
// digitados é maior que 10 e mostre na tela:
//Se a soma for maior que 10, mostrar na tela: Número maior que 10.
//Se a soma for menor ou igual a 10, mostrar na tela: Número menor ou igual a 10.

//Console.WriteLine("Soma dos números maior que 10?.\n\nDigite um número: ");
//string num1 = Console.ReadLine();

//Console.WriteLine("Digite outro número: ");
//string num2 = Console.ReadLine();

//int resultado = Int32.Parse(num1) + Int32.Parse(num2);

//if (resultado > 10)
//{
//    Console.WriteLine($"{num1} + {num2} = {resultado}. Maior que 10");
//}
//else
//{
//    Console.WriteLine($"{num1} + {num2} = {resultado}. Menor ou igual a 10");
//}



// 8.  A prefeitura de Recife criou um programa de empréstimo para seus funcionários com desconto em folha.
// O valor da prestação não pode ultrapassar 30% do salário bruto do funcionário.
// Faça um programa em C# que solicite o valor do salário bruto, o valor da prestação e
// informe se o empréstimo pode ou não ser concedido. 
// Validações: 
// Não aceitar salário <= 0 
// Não aceitar prestação <= 0

//Console.WriteLine("Empréstimo em folha.\n\nDigite o valor do salário bruto: ");
//int salarioBruto = LerSalarioBruto();

//int salarioPorcentagem = salarioBruto / (100 / 30);

//Console.WriteLine($"O valor máximo a ser retirado é de R${salarioPorcentagem}. Digite o valor do empréstimo solicitado: ");
//int ValorEmprestimo = LerEmprestimo();

//if (ValorEmprestimo > salarioPorcentagem)
//{
//    Console.WriteLine("O valor do empréstimo é maior que 30% do salário bruto. Não liberado!");
//}
//else
//{
//    Console.WriteLine("Empréstimo liberado!");
//}

//static int LerSalarioBruto()
//{
//    int salario;
//    while (!int.TryParse(Console.ReadLine(), out salario) || salario <= 0)
//    {
//        Console.WriteLine("Valor inválido. Tente Novamente. ");
//    }
//    return salario;
//}

//static int LerEmprestimo()
//{
//    int emprestimo;
//    while (!int.TryParse(Console.ReadLine(), out emprestimo) || emprestimo <= 0)
//    {
//        Console.WriteLine("Valor inválido. Tente Novamente. ");
//    }
//    return emprestimo;
//}



// 9. Uma companhia aérea define os preços de suas passagens a partir da informação do
// destino bem como do número de passagens (se é apenas ida ou se inclui também a volta).
// Faça um programa em C# que solicite o destino bem como se o cliente deseja somente ida ou
// ida e volta. Informe o preço de acordo com a tabela abaixo (PS: a empresa não trabalha nos trechos sul e sudeste).

//Console.WriteLine("Passagens aéreas.\nEscolha o destino que quer ir: Norte(1); Nordeste(2); Centro-Oeste(3)");
//int destino = LerDestino();

//Console.WriteLine("Otíma escolha. A passagem será somente de ida(1) ou acopanha a volta(2)? ");
//int idaVolta = LerIdaVolta();

//if (destino == 1 && idaVolta == 1)
//{
//    Console.WriteLine($"O valor total da passagem de ida é de R$280. Boa Viagem!!");
//}
//else if (destino == 1 && idaVolta == 2)
//{
//    Console.WriteLine($"O valor total da passagem de ida e volta é de R$400. Boa Viagem!!");
//}
//else if (destino == 2 && idaVolta == 1)
//{
//    Console.WriteLine($"O valor total da passagem de ida é de R$380. Boa Viagem!!");
//}
//else if (destino == 2 && idaVolta == 2)
//{
//    Console.WriteLine($"O valor total da passagem de ida e volta é de R$628. Boa Viagem!!");
//}
//else if (destino == 3 && idaVolta == 1)
//{
//    Console.WriteLine($"O valor total da passagem de ida é de R$620. Boa Viagem!!");
//}
//else
//{
//    Console.WriteLine($"O valor total da passagem de ida e volta é de R$1100. Boa Viagem!!");
//}

//static int LerDestino()
//{
//    int lugarDestino;
//    while(!int.TryParse(Console.ReadLine(), out lugarDestino) || lugarDestino <= 0 || lugarDestino > 3)
//    {
//        Console.WriteLine("A empresa não trabalha nos trechos sul e sudeste. Insira um valor válido entre 1 e 3. ");
//    }
//    return lugarDestino;
//}static int LerIdaVolta()
//{
//    int IdaVolta;
//    while(!int.TryParse(Console.ReadLine(), out IdaVolta) || IdaVolta <= 0 || IdaVolta > 2)
//    {
//        Console.WriteLine("A empresa não trabalha com essa opção. Insira um valor válido entre 1 e 2. ");
//    }
//    return IdaVolta;
//}



// 10. Uma instituição bancária utiliza um dígito verificador para validar o número da conta (com 3 dígitos)
// de seus clientes. Faça um programa em C# que solicite o número da conta e calcule o dígito verificador.
// Os passos para calcular o dígito verificador são: Ex: Número da conta = 235.
// 1) somar o número da conta com o seu inverso. Ex: 235 + 532 = 767
// 2) Multiplicar cada digito do número obtido no passo anterior pela sua ordem posicional e somar esses resultados.
// O último digito do número obtido é o dígito verificador. Ex: 7 x 1 + 6 x 2 + 7 x 3 = 40 (dígito verificador = 0).

//Console.WriteLine("Dígito Verificador.\n\nDigite um valor de 3 dígitos para calcular o dígito verificador: ");
//string input = Console.ReadLine();

//string[] num = input.Split(' ');

//if (num.Length == 1)
//{
//    if (double.TryParse(num[0], out double numero1))
//    { 

//    }
//}
//double inverso = 1.0 / Int32.Parse(input);
//double calculoInverso = Int32.Parse(input) + inverso;


//static double LerNumero()
//{
//    double num;
//    while (!double.TryParse(Console.ReadLine(), out num) || num <100 || num > 1000) ;
//    {
//        Console.WriteLine("Precisamos de um valor de 3 dígitos para calcular o dígito verificador. Tente Novamente.");
//    }
//    return num;
//}



// 11. . Faça o teste de mesa para numero_1= 15 e numero_2= 6
// resultado = ((numero_1 % 2) * 3) + (13 - 2 + numero_2)
// Responda:
// A). Qual o conteúdo da variável resultado quando termina o algoritmo?
// R:

// B). Analise o pseudocódigo e responda: o que mostrará na tela? 
// R:

// C). Reescrever o algoritmo utilizando a linguagem de programação C#

Console.WriteLine("Insira um número inteiro: ");
string num1 = Console.ReadLine();

Console.WriteLine("Insira outro número inteiro: ");
string num2 = Console.ReadLine();

int resultado = ((Int32.Parse(num1) % 2) * 3) + (13 - 2 + Int32.Parse(num2));    

if (resultado <= 0)
{
    Console.WriteLine($"Resultado menor ou igual a 0. Resutado = {resultado}");
}
else if (resultado > 0 && resultado <= 20)
{
    Console.WriteLine($"Resultado maior que zero e menor ou igual a 20. Resutado = {resultado}");
}
else
{
    Console.WriteLine($"Resultado maior que 20. Resutado = {resultado}");
}