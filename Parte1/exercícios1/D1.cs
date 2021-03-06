using System;
using System.Collections.Generic;

namespace D1
{
	class Program
	{
        static void Exercise1()
		{
			Console.WriteLine("crescente");
            
            for (int counter = 1; counter < 11; counter++)
            {
				Console.WriteLine(counter);
            }

			System.Console.WriteLine("decrescente");

            for (int counter = 10; counter > 0; counter--)
            {
				System.Console.WriteLine(counter);   
            }

			System.Console.WriteLine("apenas os pares");

            for (int counter = 0; counter < 11; counter += 2)
            {
                System.Console.WriteLine(counter);
            }
		}
		static void Exercise2()
		{
			var sum = 0;

            for (int counter = 1; counter < 101; counter++)
            {
				sum += counter;
            }

			System.Console.WriteLine("a soma dos números inteiros entre 1 e 100 é");
			System.Console.WriteLine(sum);
		}	
        static void Exercise3()
		{
            for (int counter = 1; counter < 200; counter += 2)
            {
				System.Console.WriteLine(counter);
            }
		}
		static void Exercise4()
		{
			(double sum,int result, int counter) x = (0.0, 0, 0);

            for (; x.result != 0; x.counter++)
            {
                System.Console.WriteLine("Digite uma idade");
				x.result = Int32.Parse(Console.ReadLine());
				
				x.sum += x.result;
            }
            var average = (x.sum / x.counter).ToString("0.00");
			System.Console.WriteLine($"A média da turma é: {average}");
		}
		static void Exercise5()
		{
			var womenBetween18And35 = 0;
            int counter = 0;

            for (; counter < 5; counter++)
            {
				System.Console.WriteLine("Qual é o seu nome?");
				Console.ReadLine();

				System.Console.WriteLine("Qual é a sua idade?");
				var age = Int32.Parse(Console.ReadLine());

				if (age > 17 && age < 36)
				{
					womenBetween18And35++;
				}
            }

			System.Console.WriteLine("Porcentagem de mulheres que tem entre 18 e 35 anos");

			var percentage = (womenBetween18And35 * 100) / counter;
			System.Console.WriteLine($"{percentage}%");
		}
		static void Exercise6()
		{
			const string registerMode = "1";
			const string votesMode = "2";
			const string resultMode = "3";

            var candidates = new (string name, int votes)[3];
			
			while (true)
			{
				System.Console.WriteLine("Selecione um dos modos a baixo:");
				System.Console.WriteLine($"{registerMode}) Cadastro de candidatos");
				System.Console.WriteLine($"{votesMode}) Votar");
				System.Console.WriteLine($"{resultMode}) Apuração dos votos");
				var mode = Console.ReadLine();

				if (mode == resultMode)
				{
					break;
				}

				if (mode == registerMode)
				{
					var password = "";
					while (password != "Pa$$w0rd")
					{
						System.Console.WriteLine("Digite a senha");
						password = Console.ReadLine();
					}

                    for (int i = 0; i < candidates.Length; i++)
                    {                   
                        System.Console.WriteLine($"Digite o nome do candidato nº{i + 1}");
                        candidates[i].name = Console.ReadLine();
                    }
				}

				if (mode == votesMode)
				{
                    for (int i = 0; i < candidates.Length; i++)
                    {
					    System.Console.WriteLine($"Vote {i + 1} para o candidato: {candidates[i].name}"); 
                    }

					var vote = Int32.Parse(Console.ReadLine());
					candidates[vote - 1].votes++;
				}
			}

            var winner = candidates[0];
            var isDraw = false;
            var drawCandidates = winner.name;

            for (int i = 1; i < candidates.Length; i++)
            {
                var currentCandidate = candidates[i];

                if (currentCandidate.votes > winner.votes)
                {
                    winner = currentCandidate;
                    drawCandidates = currentCandidate.name;
                }
                else if (currentCandidate.votes == winner.votes)
                {
                    isDraw = true;
                    drawCandidates += $", {currentCandidate.name}";
                }
            }

			if (isDraw)
			{
				System.Console.WriteLine($"Segundo turno entre: {drawCandidates}!");
			}
			else
			{
				System.Console.WriteLine($"O vencedor é: {winner.name}");
				System.Console.WriteLine($"Com o total de: {winner.votes} votos!");
			}
		}   
        static void Exercise7()  
        {
        // 7)Calcular a quantidade de dinheiro gasta por um fumante. 
        // Dados: o número de anos que ele fuma, o nº de cigarros fumados por dia e o preço de uma carteira.

        System.Console.WriteLine("Quantos anos você fuma cigarro?");
            var anosFumados = int.Parse(Console.ReadLine()) * 365;

        System.Console.WriteLine("Quantos cigarros você fuma por dia?");
            var cigarrosDias = int.Parse(Console.ReadLine());

        System.Console.WriteLine("Digite o preço da carteira:");
            var precoCarteira = double.Parse(Console.ReadLine());

        var valorTotalGasto = anosFumados * cigarrosDias * precoCarteira;
        System.Console.WriteLine($"Total gasto: {valorTotalGasto.ToString("0,00")}");
        }
        static void Exercise8()
        {
            //8)Ler dois números inteiros, X e Y, e apresentar mensagem informando se o X é múltiplo de Y.
            var saoMultiplos = false;
            
            System.Console.WriteLine("Digite um número:");
                var resultA = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite um número:");
                var resultB = double.Parse(Console.ReadLine());

            if (resultA % resultB == 0)
            {
                saoMultiplos = true;
            }
            var message = saoMultiplos ? "Os números são multiplos" : "Os números não são multiplos";
            System.Console.WriteLine(message);
        }
		static void Exercise9()
		{
            // 9)Fazer um algoritmo para ler 03 números reais do teclado
            // e verificar se o primeiro é maior que a soma dos outros dois.

            // Console.WriteLine("Forneça um número");
            // var firstNumber = Double.Parse(Console.ReadLine());

            // Console.WriteLine("Forneça um número");
            // var secondNumber = Double.Parse(Console.ReadLine());

            // Console.WriteLine("Forneça um número");
            // var thirdNumber = Double.Parse(Console.ReadLine());

            // if (firstNumber > (secondNumber + thirdNumber))
            // {
            //     Console.WriteLine("O primeiro número é maior que a soma dos demais");
            // }
            // else
            // {
            //     Console.WriteLine("O primeiro número NAO é maior que a soma dos demais");
            // }

            var x = new double[3];
            var y = false;

            for (int k = 0; k < x.Length; k++)
            {
                Console.WriteLine("Forneça um número");
                x[k] = Double.Parse(Console.ReadLine());
            }
            for (int i = 0; i < x.Length; i++)
            {
            for (int k = 1; k < x.Length; k++)
            {
                for (int j = 2; j < x.Length; j++)
                {
                    
                if (i != k && k != j && x[i] > (x[k] + x[j]))
                {
                    y = true;
                    break;
                }
                }
            }    
            }
            var K = y ? "O primeiro número é maior que a soma dos demais" : "O primeiro número NAO é maior que a soma dos demais";
            System.Console.WriteLine($"{K}");
		}
        static void Exercise10()
		{
        // 10)Ler 02 números reais do teclado (A e B), 
        // verificar e imprimir qual deles é maior, ou a mensagem "A = B" caso sejam iguais.

        var tecla = new double [2];
        //var maiorNumero = 0.0;
        for (int i = 0; i < tecla.Length; i++)
        {
            System.Console.WriteLine("DIGITE UMA TECLA");
            tecla[i] = int.Parse(Console.ReadLine());
        }
       
        for (int i = 0; i < tecla.Length; i++)
        {
            for (int k = 1; k < tecla.Length; k++)
            {
                if (i != k && tecla[i] > tecla[k])
                {
                    //maiorNumero = tecla[i];
                    System.Console.WriteLine($"O maior número é {tecla[i]}");
                    break;
                }
                
                else if (i != k && tecla[i] == tecla[k])
                {
                    System.Console.WriteLine("A = B");
                    break;
                }
            }

        }

        }
		static void Exercise11()
		{
            var firstNumber = 0;
            Console.WriteLine("Forneça um número");
            var firstInput = Console.ReadLine();
            
            var secondNumber = 0;
            Console.WriteLine("Forneça um número");
            var secondInput = Console.ReadLine();
            
            try
            {
                firstNumber = Int32.Parse(firstInput);
                secondNumber = Int32.Parse(secondInput);
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Um dos números está em formato inválido");
                System.Console.WriteLine("Tente novamente com outros números");
            }

            if (secondNumber != 0)
            {
                System.Console.WriteLine(firstNumber / secondNumber);
            }
            else
            {
                System.Console.WriteLine("DIVISÃO POR ZERO");
            }
		}
        static void Exercise12()
        {
        //12)Ler 4 números inteiros e calcular a soma dos que forem pares

        var numbers = new double[4];
        var total = 0.0;
        
        for (int i = 0; i < numbers.Length; i++)
        {
            System.Console.WriteLine("Digite um número:");
            numbers[i] = int.Parse(Console.ReadLine());
        
            if (numbers[i] % 2 == 0)
            {
                total += numbers[i];
            }
        }
        System.Console.WriteLine($"{total}");


        // (int numero1Par, int numero2Par, int numero3Par, int numero4Par) numerosPares = (0, 0, 0, 0);
        // System.Console.WriteLine("Digite um número:");
        // var result1 = int.Parse(Console.ReadLine());

        // System.Console.WriteLine("Digite um número:");
        // var result2 = int.Parse(Console.ReadLine());

        // System.Console.WriteLine("Digite um número:");
        // var result3 = int.Parse(Console.ReadLine());

        // System.Console.WriteLine("Digite um número:");
        // var result4 = int.Parse(Console.ReadLine());

        // if (result1 % 2 == 0)
        // {
        //     numerosPares.numero1Par = result1; 
        // }
        // if (result2 % 2 == 0)
        // {
        //     numerosPares.numero2Par = result2; 
        // }
        // if (result3 % 2 == 0)
        // {
        //     numerosPares.numero3Par = result3; 
        // }
        // if (result4 % 2 == 0)
        // {
        //     numerosPares.numero4Par = result4; 
        // }
        // var total = numerosPares.numero1Par + numerosPares.numero2Par + numerosPares.numero3Par + numerosPares.numero4Par;
        // System.Console.WriteLine($"{total}");
        }
		static void Exercise13()
		{
            //13)Ler 10 valores e determinar o maior dentre eles.

            var biggestNumber = 0;
            var numbers = 10;

            for (int counter = 0; counter < numbers; counter++)
            {
                System.Console.WriteLine("Forneça um número");
                var input = Int32.Parse(Console.ReadLine());

                if (input > biggestNumber)
                {
                    biggestNumber = input;
                }
            }

            System.Console.WriteLine($"O maior número é: {biggestNumber}");
		}
		static void Exercise14()
		{
            var smaller = Double.MinValue;
            var middle = Double.MinValue;
            var greater = Double.MinValue;

            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine("Forneça um número");
                var input = Double.Parse(Console.ReadLine());

                if (input > greater)
                {
                    smaller = middle;
                    middle = greater;
                    greater = input;
                }
                else if (input > middle)
                {
                    smaller = middle;
                    middle = input;
                }
                else
                {
                    smaller = input;
                }
            }

            System.Console.WriteLine(smaller);
            System.Console.WriteLine(middle);
            System.Console.WriteLine(greater);
		}
        static void Exercise15()
        {
        //15)Ler 10 números e imprimir quantos são múltiplos de 3 e quantos são múltiplos de 5.

        //var numerosMultiplosDe3 = 0;
        //var numerosMultiplosDe5 = 0;
        (int numerosMultiplosDe3, int numerosMultiplosDe5) numeros = (0, 0);
        
        for (int i = 0; i < 10; i++)
        {
            System.Console.WriteLine("Digite um número:");        
            var result = Double.Parse(Console.ReadLine());
        
            if (result % 3 == 0)
            {
                numeros.numerosMultiplosDe3++;
                continue;
            }
            
            else if (result % 5 == 0)
            {
                numeros.numerosMultiplosDe5++;
            }
        }
        System.Console.WriteLine($"Total de números multiplos de 3 = {numeros.numerosMultiplosDe3}");
        System.Console.WriteLine($"Total de números multiplos de 5 = {numeros.numerosMultiplosDe5}");
        

        //forma para escrever o valor linha por linha
        
        // var a = new double[10];
        // for (int i = 0; i < a.Length; i++)
        // {
        //     System.Console.WriteLine("Digite um número:");        
        //     a[i] = Double.Parse(Console.ReadLine());
        // }

        // foreach (var item in a)
        // {
        //     if (item % 3 == 0)
        //     {
        //         System.Console.WriteLine($"O número {item} é multiplo de 3");
        //     }
        //     if (item % 5 == 0)
        //     {
        //         System.Console.WriteLine($" O número {item} é multiplo de 5");
        //     }
        // }

        }
        static void Exercise16()
        {
        // 16)Ler o salário de uma pessoa e imprimir o Salário Líquido 
        // de acordo com a redução do imposto descrito ao lado:
        // Menor ou igual a R$ 600,00 - ISENTO
        // Maior que R$ 600,00 e menor ou igual a 100 - 20% desconto
        // Maior que R$ 1.200,00 e menor ou igual a R$2000 - 25% desconto
        // Maior que R$ 2.000,00 - 30% desconto
        
        System.Console.WriteLine("Digite seu salário:");
        var result = double.Parse(Console.ReadLine());

        if (result <= 600)
        {
            System.Console.WriteLine("Isento de imposto");
            return;
        }
        
        else if (result <= 1200)
        {
            var salario = result * 0.8;
            System.Console.WriteLine($"Seu salário recebe 20% de desconto resultando em: {salario}");
            return;
        }
        else if (result <= 2000)
        {
            var salario = result * 0.75;
            System.Console.WriteLine($"Seu salário recebe 25% de desconto resultando em: {salario}");
            return;
        }
        else if (result >= 2000)
        {
            var salario = result * 0.7;
            System.Console.WriteLine($"Seu salário recebe 30% de desconto resultando em: {salario}");
        }

        }
		static void Exercise17()
		{
            // 17)Imprimir a tabuada de qualquer número fornecido pelo usuário
            // até que o usuário forneça o valor –1.

            for (var input = 0; input != -1;)
            {
                Console.WriteLine("Forneça um número");
                input = Int32.Parse(Console.ReadLine());
                // if (input == -1)
                // {
                //     break;
                // }
                Console.WriteLine("Tabuada:");
                for (var i = 1; i < 11; i++)
                {
                    Console.WriteLine($"{input}x{i} = {input * i}");
                }
            }
		}
        static void Exercise18()
        {
            // 18)As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, 
            // e R$ 1,00 se forem compradas pelo menos 12. 
            // Escreva um programa que leia o número de maçãs compradas, calcule e
            // escreva o custo total da compra.
            double meiaDuzia = 1.30;
            double duzia = 1.00;
            var maca = 0.0;

            System.Console.WriteLine("Quantas maçãs você deseja comprar?");
            var result = double.Parse(Console.ReadLine());

            if (result < 12)
            {
                maca = meiaDuzia * result;
                System.Console.WriteLine(maca.ToString("0.00"));
            }
            
            else if (result >= 12)
            {
                maca = duzia * result;
                System.Console.WriteLine(maca.ToString("0.00"));
            }
        }
        static void Main(string[] args)
		{
            Exercise17();

//             double value = 0;
//             double result = 0;
//             var array = new string[2];
            
//             Console.WriteLine("Qual conversão você quer realizar?");
//                 for (int i = 0; i < 2; i++)
//                 {
//                     System.Console.WriteLine($"Centímetros");
//                     System.Console.WriteLine($"Metros");
//                     System.Console.WriteLine($"Quilômetros");
//                         array[i] = Console.ReadLine();
//                 }
//             System.Console.WriteLine("\nDigite o valor:");
//             value = double.Parse(Console.ReadLine());

//             if (array[0] == array[1])
//             {
//                 System.Console.WriteLine($"Você não pode comverter de {array[0]} para {array[1]}");
//             }
            
//             while (array[0] == "Centímetros")
//             {
//                 var centimetros = true;
// var centimetrous=centimetros ? $"Para metros: {result = value / 100}" : $"Para Quilômetros: {result = value / 100000}";
//                 if (array[1] == "Metros")
//                 {
//                     System.Console.WriteLine(centimetrous);
//                     break;
//                 }
//                 centimetros = false;
//                 System.Console.WriteLine(centimetrous);
//                 break;
//             }

//             while (array[0] == "Metros")
//             {
//                 var metros = true;
// var m=metros ? $"Para Centímetros: {result = value * 100}" : $"Para Quilômetros:{result = value / 1000}";
//                 if (array[1] == "Centímetros")
//                 {
//                     System.Console.WriteLine(m);
//                     break;
//                 }
//                 metros = false;
//                 System.Console.WriteLine(m);
//                 break;
//             }
            
//             while (array[0] == "Quilômetros")
//             {
//                 var metros = true;
// var q=quilometros ? $"Para Centímetros: {result = value * 100000}" : $"Para Metros: {result = value * 1000}";
//                 if (array[1] == "Centímetros")
//                 {
//                     System.Console.WriteLine(q);
//                     break;
//                 }
//                 metros = false;
//                 System.Console.WriteLine(q);
//                 break;
            // }           
		}
	}
}