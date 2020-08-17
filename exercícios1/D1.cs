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
        static void Main(string[] args)
		{
            //Exercise12();

            var somaTotal = 0; //variavel que efetuara a soma dos números
            for (int contador = 0; contador < 101; contador++) //cria a variavel contador, diz a condição para que se repitao laço de repetição(contador < 101) e incrementa 1 número a variavel contador toda vez q o laço se repete.
            {
                somaTotal += contador; //a variavel somaTotal está somando seu número com o número do contador.
            }
            System.Console.WriteLine(somaTotal); //o console escreve a variavel somaTotal
		}
	}
}