using System;
using System.Collections.Generic;

namespace Array2
{
	class Program
	{
        static void Exercise1()
		{
            // 1)Popule dois vetores com 10 valores cada. 
            // Após esta operação, troque o conteúdo dos vetores.
            const int arraylenght = 10;
            var a = new double [arraylenght];
            var b = new double [arraylenght];

            for (int i = 0; i < arraylenght; i++)
            {
            System.Console.WriteLine($"Digite um número para o vetor 1 na posição{i}");
                a[i] = double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arraylenght; i++)
            {
            System.Console.WriteLine($"Digite um número para o vetor 2 na posição{i}");
                b[i] = double.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arraylenght; i++)
            {
                a[i] = (a[i] * a[i]) / 3.75;
            }
            for (int i = 0; i < arraylenght; i++)
            {
                b[i] = (b[i] * b[i]) / 5.50;
            }
            
            for (int i = 0; i < arraylenght; i++)
            {
                System.Console.WriteLine($"{a[i]}");
                System.Console.WriteLine($"{b[i]}");
            }
        }
        static void Exercise2()
		{
        // 2)Dado um vetor qualquer com 10 números, 
        //faça um programa que informa se há ou não números repetidos nesse vetor.

        var a = new double [10];
        var numerosRepetidos = false;   
            
        for (int i = 0; i < a.Length; i++)
        {
            System.Console.WriteLine("Digite um número");
            a[i] = double.Parse(Console.ReadLine());
        }      
        foreach (var item in a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                if (item == a[i])
                {
                    numerosRepetidos = true;
                    break;
                }
            }
        }
        var message = numerosRepetidos ? "há números repetidos nesse vetor." : "não há números repetidos nesse vetor.";
        System.Console.WriteLine($"{message}");
        // for (int i = 0; i < a.Length; i++)
        // {
        //     for (int j = 1; j < a.Length; j++)
        //     {  
        //         if (i != j && a[i] == a[j])
        //         {
        //             numerosRepetidos = true;
        //             break;
        //         }
                    
        //         else if (!numerosRepetidos)
        //         {
        //             break;
        //         }
        //     }
        // }
        }
        static void Exercise3()
		{
        // 3)Um certa empresa fez uma pesquisa para saber 
        // se as pessoas gostaram ou não de um novo produto lançado no mercado. 
        // Para isso, forneceu-se o sexo do entrevistado e a sua resposta (sim ou não). 
        // Sabendo-se que foram entrevistadas 10 pessoas, fazer um algoritmo que calcule e escreva:
        // • O número de pessoas que responderam sim;
        // • O número de pessoas que responderam não;
        // • A percentagem de pessoas do sexo feminino que responderam sim;
        // • A percentagem de pessoas do sexo masculino que responderam não;
        var numeroDeEntrevistados = 10;
        (int sim, int nao) avaliacao = (0, 0);
        (int mulheresSim, int homensNao) avaliacaoSexo = (0, 0);

        for (int i = 0; i < numeroDeEntrevistados; i++)
        {
            System.Console.WriteLine("Você gostou da apresentação de nosso novo produto? Responda com sim ou não");
            var resultAvaliacao = Console.ReadLine();
            
            if (resultAvaliacao == "sim")
            {
                avaliacao.sim++;
            }
            else if (resultAvaliacao == "não")
            {
                avaliacao.nao++;
            }
        
            System.Console.WriteLine("Qual seu sexo?");
                var resultSexo = Console.ReadLine();
            if (resultSexo == "masculino" && resultAvaliacao == "não")
            {
                avaliacaoSexo.homensNao++;
            }
             
            else if (resultSexo == "feminino" && resultAvaliacao == "sim")
            {
                avaliacaoSexo.mulheresSim++;
            }
        }
        var totalMulheresSim = (avaliacaoSexo.mulheresSim * 100) / numeroDeEntrevistados;
        var totalHomensNao = (avaliacaoSexo.homensNao * 100) / numeroDeEntrevistados;

        System.Console.WriteLine($"porcentagem de homens que responderam não: {totalHomensNao}%");
        System.Console.WriteLine($"porcentagem de mulheres que responderam sim: {totalMulheresSim}%");
        System.Console.WriteLine($"O número de pessoas que responderam sim foi de: {avaliacao.sim}");
        System.Console.WriteLine($"O número de pessoas que responderam não foi de: {avaliacao.nao}");
        }
        static void Exercise4()
		{
        // 4)Desenvolver um programa que efetue a leitura de cinco elementos de uma matriz 
        // A do tipo vetor. No final, apresente o total da soma de todos os elementos que sejam impares.
        
            var a = new double[5];
            var finalResult = 0.0;
            
            for (int i = 0; i < a.Length; i++)
            {
                System.Console.WriteLine("Digite um número:");
                a[i] = double.Parse(Console.ReadLine());
            
                if (a[i] % 2 != 0)
                {
                    finalResult += a[i];
                }
            }
            System.Console.WriteLine($"A soma total de todos os elementos que são impares é: {finalResult}");
        }
        static void Exercise5()
		{
        // 5)Contar quantos valores de um vetor de 10 posições são positivos.

        var a = new double[10];
        var totalDeNumerosPositivos = 0.0;

            for (int i = 0; i < a.Length; i++)
            {
                System.Console.WriteLine("Digite um número:");
                a[i] = double.Parse(Console.ReadLine());
                
                if (a[i] > 0)
                {
                    totalDeNumerosPositivos++;
                }
            }
        System.Console.WriteLine($"O total de valores positivos digitados é de:{totalDeNumerosPositivos}");
        }
        static void Exercise6()
		{
        // 6)Ler um vetor de 10 posições (aceitar somente números positivos). 
        //Escrever a seguir o valor do maior elemento de A e a respectiva posição que ele ocupa no vetor.

            var a = new double[10];

            (double biggest, int position) number = (0.0, 0);

            for (int i = 0; i < a.Length; i++)
            {
                
                System.Console.WriteLine("Digite um número:");
                a[i] = double.Parse(Console.ReadLine());
                
                if (a[i] < 1)
                {
                    System.Console.WriteLine("somente números positivos, tente novamente");
                    i--;
                    continue;
                }
                if (a[i] > number.biggest)
                {
                    number.biggest = a[i];
                    number.position = i;
                }
            }
            System.Console.WriteLine($"Maior número digitado: {number.biggest}");
            System.Console.WriteLine($"Sua posição no arranjo: {number.position}");
        }
        static void Exercise7()
		{
            // 7)Crie e popule um vetor A e imprima na tela o número de vezes que existe um número 
            //residindo na mesma posição do vetor que seu valor numérico.

        System.Console.WriteLine("Quantos números você quer inserir?");
            var index = int.Parse(Console.ReadLine());
        var myList = new List<double>(index);
        var equalNumbers = 0.0;

            for (int i = 0; i < myList.Count; i++)
            {
                System.Console.WriteLine("Digite um número");
                while(true)
                {
                    try
                    {
                        myList[i] = double.Parse(Console.ReadLine());
                        break;
                    }
                    catch (System.Exception)
                    {
                        System.Console.WriteLine("Número inválido!");                
                    }
                }
                equalNumbers = (myList[i] == i) ? equalNumbers +=1 : equalNumbers;
            }
            System.Console.WriteLine($"Há {equalNumbers} números na mesma posição dos seus valores.");
        }
        static void Exercise8()
		{
            // 8)Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto. 
            //No final, imprima quantas destas são vogais.

            var x = new string[4];
            var vogais = 0;

            for (int i = 0; i < x.Length; i++)
            {
                System.Console.WriteLine("Digite uma letra do alfabeto");
                x[i] = Console.ReadLine();
                
                if (x[i] == "a" || x[i] == "e" || x[i] == "i" || x[i] == "o" || x[i] == "u")
                {
                    vogais++;
                }
            }
            System.Console.WriteLine($"{vogais} letras são vogais.");
        }
        static void Exercise9()
		{
        // 9)Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto.
        // No final, imprima a string resultante da soma das strings que residem em índices pares.

            var x = new string[10];
            var stringResult = "";

            for (int i = 0; i < x.Length; i++)
            {
                System.Console.WriteLine("Digite uma letra do alfabeto");
                x[i] = Console.ReadLine();
            }
            for (int i = 2; i < x.Length; i+= 2)
            {
                stringResult += x[i];
            }
            System.Console.WriteLine($"{stringResult}");
        }
    static void Main(string[] args)
		{
            Exercise8();
		}
	}
}