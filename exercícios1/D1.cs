using System;

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

            for (int counter = 2; counter < 11; counter += 2)
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
			var sum = 0.0;

            for (int counter = 0; true; counter++)
            {
                System.Console.WriteLine("Digite uma idade");
				var result = Console.ReadLine();

				if (result == "0")
				{
                    var average = (sum / counter).ToString("0.00");
			        System.Console.WriteLine($"A média da turma é: {average}");
					break;
				}
				
				sum += Int32.Parse(result);
            }
		}
		static void Exercise5()
		{
			var womenBetween18And35 = 0;

            for (int counter = 0; counter < 5; counter++)
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

			var percentage = (womenBetween18And35 * 100) / 5;
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
        System.Console.WriteLine($"{valorTotalGasto.ToString("0,00")}");
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
            Console.WriteLine("Forneça um número");
            var firstNumber = Double.Parse(Console.ReadLine());

            Console.WriteLine("Forneça um número");
            var secondNumber = Double.Parse(Console.ReadLine());

            Console.WriteLine("Forneça um número");
            var thirdNumber = Double.Parse(Console.ReadLine());

            if (firstNumber > (secondNumber + thirdNumber))
            {
                Console.WriteLine("O primeiro número é maior que a soma dos demais");
            }
            else
            {
                Console.WriteLine("O primeiro número NAO é maior que a soma dos demais");
            }
		}
        static void Exercise10()
		{
        // 10)Ler 02 números reais do teclado (A e B), 
        // verificar e imprimir qual deles é maior, ou a mensagem "A = B" caso sejam iguais.
        var tecla = new double [2];
        var maiorNumero = 0.0;

        for (int i = 0; i < tecla.Length; i++)
        {
        System.Console.WriteLine("DIGITE UMA TECLA");
            tecla[i] = int.Parse(Console.ReadLine());

            if (tecla[i] > tecla[i + 1])
            {
                maiorNumero = tecla[i];
            }
            else if (tecla[i] > tecla[i + 1])
            {
                maiorNumero = tecla[i + 1];
            }
        }
            System.Console.WriteLine($"O maior número é {maiorNumero}");
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
            var biggestNumber = 0;

            for (int counter = 0; counter < 10; counter++)
            {
                System.Console.WriteLine("Forneça um número");
                var input = Int32.Parse(Console.ReadLine());

                if (input > biggestNumber)
                {
                    biggestNumber = input;
                }
            }

            System.Console.WriteLine("O maior número é:");
            System.Console.WriteLine(biggestNumber);
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
            while (true)
            {
                Console.WriteLine("Forneça um número");
                var input = Int32.Parse(Console.ReadLine());

                if (input == -1)
                {
                    break;
                }

                Console.WriteLine("Tabuada:");
                for (var i = 1; i < 11; i++)
                {
                    Console.WriteLine(input * i);
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
                System.Console.WriteLine(maca.ToString("0.00")); //14,3
            }
            
            if (result >= 12)
            {
                maca = duzia * result;
                System.Console.WriteLine(maca.ToString("0.00"));
            }
        }
        static void Main(string[] args)
		{
            Exercise16();
		}
	}
}