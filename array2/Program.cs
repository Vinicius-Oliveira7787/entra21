using System;

namespace array2
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

         var a = new double [4];
         var numerosRepetidos = false;   
            for (int i = 0; i < a.Length; i++)
            {
                System.Console.WriteLine("Digite um número");
                    a[i] = double.Parse(Console.ReadLine());

                for (int j = i + 1; j < a.Length; j++)
                {   
                    if (a[i] == a[j] && j != i)
                    {
                        numerosRepetidos = true;
                        break;
                    }
                }
            }
        var message = numerosRepetidos ? "há números repetidos nesse vetor." : "não há números repetidos nesse vetor.";
        System.Console.WriteLine($"{message}");

        }
        static void Exercise3()
		{
// 3)Um certa empresa fez uma pesquisa para saber se as pessoas gostaram ou não de um novo produto lançado no mercado. Para isso, forneceu-se o sexo do entrevistado e a sua resposta (sim ou não). Sabendo-se que foram entrevistadas 10 pessoas, fazer um algoritmo que calcule e escreva:
// • O número de pessoas que responderam sim;
// • O número de pessoas que responderam não;
// • A percentagem de pessoas do sexo feminino que responderam sim;
// • A percentagem de pessoas do sexo masculino que responderam não;
        }
        static void Exercise4()
		{
// 4)Desenvolver um programa que efetue a leitura de cinco elementos de uma matriz // A do tipo vetor. No final, apresente o total da soma de todos os elementos // que sejam impares.
        }
        static void Exercise5()
		{
// 5)Contar quantos valores de um vetor de 10 posições são positivos.
        }
        static void Exercise6()
		{
// 6)Ler um vetor de 10 posições (aceitar somente números positivos). Escrever a seguir o valor do maior elemento de Q e a respectiva posição que ele ocupa no vetor.
        }
        static void Exercise7()
		{
// 7)Crie e popule um vetor A e imprima na tela o número de vezes que existe um número residindo na mesma posição do vetor que seu valor numérico.
        }
        static void Exercise8()
		{
// 8)Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto. No final, imprima quantas destas são vogais.
        }
        static void Exercise9()
		{
// 9)Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto. No final, imprima a string resultante da soma das strings que residem em índices pares.
        }
    static void Main(string[] args)
		{
            Exercise2();
		}
	}
}