using System;

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
            (double vetor1, double vetor2) finalResult = (0.00, 0.00);

            for (int i = 0; i < arraylenght; i++)
            {
            System.Console.WriteLine("Digite um número:");
                a[i] = double.Parse(Console.ReadLine());
                finalResult.vetor1+= a[i];
            }

            for (int i = 0; i < arraylenght; i++)
            {
            System.Console.WriteLine("Digite um número");
                b[i] = double.Parse(Console.ReadLine());
                finalResult.vetor2+= b[i];
            }
                System.Console.WriteLine(finalResult.vetor1);
                System.Console.WriteLine(finalResult.vetor2);
                //não tá tão errado assim né? kkkkkkkkkkkk
                //falto criatividade na hora de trocar hahaah ^_^ 
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
            
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 1; j < a.Length; j++)
            {  
                if (i != j && a[i] == a[j])
                {
                    numerosRepetidos = true;
                    break;
                }
                    
                else if (numerosRepetidos)
                {
                    break;
                }
            }
        }
        var message = numerosRepetidos ? "há números repetidos nesse vetor." : "não há números repetidos nesse vetor.";
        System.Console.WriteLine($"{message}");
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
        // A do tipo vetor. No final, apresente o total da soma de todos os elementos // que sejam impares.
        
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

            var a = new double[3];

            (double maiorNumero, int posicao) numero = (0.0, 0);

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
                if (a[i] > numero.maiorNumero)
                {
                    numero.maiorNumero = a[i];
                    numero.posicao = i;
                }
            }
            System.Console.WriteLine($"Maior número digitado: {numero.maiorNumero}");
            System.Console.WriteLine($"Sua posição {numero.posicao}");
        }
        static void Exercise7()
		{
            // 7)Crie e popule um vetor A e imprima na tela o número de vezes que existe um número 
            //residindo na mesma posição do vetor que seu valor numérico.


        }
        static void Exercise8()
		{
            // 8)Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto. 
            //No final, imprima quantas destas são vogais.

            var x = new string[10];
            var vogais = 0;

            for (int i = 0; i < x.Length; i++)
            {
                System.Console.WriteLine("Digite uma letra do alfabeto");
                x[i] = Console.ReadLine();
            }
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == "A" && x[i] == "e" && x[i] == "i" && x[i] == "o" && x[i] == "u")
                {
                    vogais++;
                    System.Console.WriteLine($"{x[i]} é uma vogal");
                }    
            }
            System.Console.WriteLine($"{vogais} são vogais.");
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
            Exercise9();
		}
	}
}