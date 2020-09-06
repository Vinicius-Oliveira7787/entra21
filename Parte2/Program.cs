using System;
using System.Collections.Generic;

namespace Entra21_2
{
    class Program
    {
        public int[] Exercise1A()
        {
            var array = new int[10];
            for (int i = 1; i < 11; i++)
            {
                array[i - 1] = i;
            }
            return array;
        } 
        public int[] Exercise1B()
        {
            var arrayB = new int[10];
            for (int i = 10; i > 0; i--)
            {
                arrayB[arrayB.Length - i] = i;
            }
            return arrayB;
        }
        public int[] Exercise1C()
        {
            var numbers = new int[5];

            for (int counter = 2; counter < 11; counter+=2)
            {
                var index = (counter / 2) - 1;
				numbers[index] = counter;
            }
            return numbers;
        }
        public int Exercise2()
        {
            var finalResult = 0;
            for (int i = 1; i < 101; i++)
            {
                finalResult += i;
            }
            return finalResult;
        }
        public int[] Exercise3()
        {
            var numberOddBelowTwoHundred = new int[199];
            var counter = 0;
            for (int i = 1; i < 200; i+= 2)
            {
                numberOddBelowTwoHundred[counter] = i;
                counter++;
            }
            return numberOddBelowTwoHundred;
        }
        public double Exercise4(List<int> ages)
        {
            // 4)Calcular a média de idade de uma turma qualquer. 
            // O algoritmo deve parar quando for digitada a idade igual a zero.    
            
            double sum = 0;
            var answers = ages.Count;
            foreach (var item in ages)
            {
                if (item == 0)
                {
                    break;
                }
                sum += item;
            }
            var average = (sum / answers);
            
            return average;
        }
        public double Exercise5(List<int> womenAge)
        {
            //5)Criar um algoritmo que peça o nome e a idade de 5 mulheres. 
            // Após informar estes dados, o programa deve mostrar apenas 
            // porcentagem de mulheres que estão com idade entre 18 e 35. 
            var sum = 0;
            var counter = womenAge.Count;
            
            foreach (var item in womenAge)
            {
                if (item > 17 && item < 36)
                {
                    sum++;
                }
            }
            
            var percent = (sum * 100) / counter;
            return percent;
        }
        public string Exercise6Cadastro()
        {
            //6)Criar um algoritmo que simule uma urna eletrônica. 
            // Esta urna deve possuir dois candidatos e possui três modos. 
            // O primeiro é o modo de CADASTRO, onde o sistema pergunta o nome de cada um dos dois candidatos. 
            // Por medidas de segurança, para poder cadastrar um candidato na urna 
            // o sistema deve solicitar ao usuário a senha para poder ter acesso (a senha do sistema é Pa$$w0rd). 

            var password = "wrong_password";
            while (password != "Pa$$w0rd")
            {
                if (password == "Pa$$w0rd")
                {
                    break;
                }
                password = "Pa$$w0rd";
            }
            return password;
        }
        public string Exercise6Votos(List<string> candidatesNames)
        {
            //List<string> candidatesNames
            //O segundo modo é o modo de votos, onde o usuário informa 1 para votar no primeiro candidato 
            // e 2 para votar no segundo candidato. 
            // O terceiro modo, é o modo de apuração de votos, 
            // onde o sistema verifica qual candidato tem mais votos. Caso o número de votos seja igual, 
            // o sistema deve imprimir a mensagem "SEGUNDO TURNO", 
            // caso contrário deve imprimir o nome do candidato vencedor e o número de votos que ele obteve.
            var firstCandidateVotes = 2;
            var secondCandidateVotes = 0;
            // var firstCandidateVotes = 0;
            // var secondCandidateVotes = 2;
            var winner = "";
            
            if (firstCandidateVotes > secondCandidateVotes)
            {
                winner = candidatesNames[0];
            }
            if (firstCandidateVotes < secondCandidateVotes)
            {
                winner = candidatesNames[1];
            }
            return winner;
        }
        public string Exercise6SecondTurn(List<string> candidatesNames)
        {
            // O terceiro modo, é o modo de apuração de votos, 
            // onde o sistema verifica qual candidato tem mais votos. Caso o número de votos seja igual, 
            // o sistema deve imprimir a mensagem "SEGUNDO TURNO", 
            // caso contrário deve imprimir o nome do candidato vencedor e o número de votos que ele obteve.

            var firstCandidateVotes = 2;
            var secondCandidateVotes = 2;
            var winner = "";
            
            if (firstCandidateVotes > secondCandidateVotes)
            {
                winner = candidatesNames[0];
            }
            else if (firstCandidateVotes < secondCandidateVotes)
            {
                winner = candidatesNames[1];
            }
            else if(firstCandidateVotes == secondCandidateVotes)
            {
                winner = "SEGUNDO TURNO";
            }
            return winner;
        }
        public double Exercise7()
        {
        // 7)Calcular a quantidade de dinheiro gasta por um fumante. 
        // Dados: o número de anos que ele fuma, o nº de cigarros fumados por dia e o preço de uma carteira.
        var years = 2 * 365;
        var cigarreteDays = 7;
        var boxPrice = 2.30;
        
        var spentAverage = years * cigarreteDays * boxPrice;
        return spentAverage;
        }
        public string Exercise8True()
        {
            int x = 6;
            int y = 3;
            string k = "";
            if (x % y == 0)
            {
            k = "multiplo";
            }
            return k;
        }
        public string Exercise8False()
        {
            int x = 3;
            int y = 6;
            string k = "";

            if (x % y != 0)
            {
                k = "não é multiplo";
            }
            return k;
        }
        public string Exercise9True()
        {
            // 9)Fazer um algoritmo para ler 03 números reais do teclado e verificar 
            // se o primeiro é maior que a soma dos outros dois.

            var firstNumber = 8;
            var secondNumber = 10;
            var thirdNumber = 1;
            var biggestNumber = "";
            var sum = firstNumber + thirdNumber;

            if (secondNumber > sum)
            {
                biggestNumber += "is bigger";
            }
            return biggestNumber;
        }
        public string Exercise9False()
        {
            // 9)Fazer um algoritmo para ler 03 números reais do teclado e verificar 
            // se o primeiro é maior que a soma dos outros dois.

            var firstNumber = 8;
            var secondNumber = 10;
            var thirdNumber = 3;
            var biggestNumber = "";
            var sum = firstNumber + thirdNumber;

            if (secondNumber > sum)
            {
                biggestNumber += "is bigger";
            }
            else if(secondNumber < sum)
            {
                biggestNumber += "isn't bigger";
            }
            return biggestNumber;
        }
        public string Exercise9Equal()
        {
            // 9)Fazer um algoritmo para ler 03 números reais do teclado e verificar 
            // se o primeiro é maior que a soma dos outros dois.

            var firstNumber = 8;
            var secondNumber = 10;
            var thirdNumber = 2;
            var biggestNumber = "";
            var sum = firstNumber + thirdNumber;

            if (secondNumber > sum)
            {
                biggestNumber += "is bigger";
            }
            else if (secondNumber < sum)
            {
                biggestNumber += "isn't bigger";
            }
            else if (secondNumber == sum)
            {
                biggestNumber += "equal";
                
            }
            return biggestNumber;
        }
        public string Exercise10FirstNumberBigger() 
        {
            var biggestNumber = "";
            var firstNumber = 50;
            var secondNumber = 49;
            if (firstNumber > secondNumber)
            {
                biggestNumber += "FirstNumber is bigger";
            }
            return biggestNumber;
        }
        public string Exercise10SecondNumberBigger() 
        {
            var biggestNumber = "";
            var firstNumber = 4562124;
            var secondNumber = 24134652;
            if (firstNumber > secondNumber)
            {
                biggestNumber += "FirstNumber is bigger";
            }
            if (firstNumber < secondNumber)
            {
                biggestNumber += "SecondNumber is bigger";
            }
            return biggestNumber;
        }
        public string Exercise10Equal() 
        {
            var biggestNumber = "";
            var firstNumber = 50;
            var secondNumber = 50;
            if (firstNumber > secondNumber)
            {
                biggestNumber += "FirstNumber is bigger";
            }
            else if (firstNumber < secondNumber)
            {
                biggestNumber += "SecondNumber is bigger";
            }
            else
            {
                biggestNumber += "They are equal";
            }
            return biggestNumber;
        }
        public double Exercise11()
        {
        // 11)Ler 02 números inteiros do teclado. Se o segundo for diferente de zero, 
        // calcular e imprimir o quociente do primeiro pelo segundo. Caso contrário, 
        // imprimir a mensagem: "DIVISÃO POR ZERO".

        var firstAndSecondNumer = new List<double>(){10, 5};
        var returnedResult = firstAndSecondNumer[0] / firstAndSecondNumer[1];

        return returnedResult;
        }
        public string Exercise11ButIsDivisionByZero()
        {

        var firstAndSecondNumer = new List<double>(){10, 0};
        var returnedResult = "";
        for (int i = 0; i < firstAndSecondNumer.Count; i++)
        {
            if (firstAndSecondNumer[i] == 0)
            {
                returnedResult = "DIVISÃO POR ZERO";
            }
        }
        return returnedResult;
        }
        public int Exercise12()
        {
            //12)Ler 4 números inteiros e calcular a soma dos que forem pares.

            var fourNumber = new List<int>(){1,2,3,4};
            var sum = 0;

            foreach (var item in fourNumber)
            {
                if (item % 2 == 0)
                {
                    sum += item;
                }
            }
            return sum;
        }
        public double Exercise13()
        {

        var numbers = new List<double>(){1,2,3,4,5,6,7,8,9,10};
        var biggestNumber = 0.0;

        foreach (var item in numbers)
        {
            if (item > biggestNumber)
            {
                biggestNumber = item;
            }    
        }
        return biggestNumber;
        }
        public string Exercise14(double firstNumber, double secondNumber, double thirdNumber)
        {
            //14)Ler três valores e colocá-los em ordem.
            var temporary = 0.0;
            var finalResult = "";
            
            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                temporary = thirdNumber;
                thirdNumber = firstNumber;
                firstNumber = temporary;
            }
            
            if (secondNumber > thirdNumber && secondNumber > firstNumber)
            {
                temporary = thirdNumber;
                thirdNumber = secondNumber;
                secondNumber = temporary;
            }
            
            if (firstNumber > secondNumber)
            {
                temporary = secondNumber;
                secondNumber = firstNumber;
                firstNumber = temporary;
            }
            finalResult += $"{firstNumber},{secondNumber},{thirdNumber}";

            return finalResult;
        }
        public string Exercise15(List<double> numbers)
        {
        //15)Ler 10 números e imprimir quantos são múltiplos de 3 e quantos são múltiplos de 5.
        var numbersMultipleByFive = 0;
        var numbersMultipleByThree = 0;
        foreach (var item in numbers)
        {
            if (item % 5 == 0)
            {
                numbersMultipleByFive++;
            }
            if (item % 3 == 0)
            {
                numbersMultipleByThree++;
            }
        }
        var finalResult = $"{numbersMultipleByThree},{numbersMultipleByFive}";
        return finalResult;
        }
        public string Exercise16(List<double> Salary)
        {
        // 16)Ler o salário de uma pessoa e imprimir o Salário Líquido de acordo com a redução do imposto descrito ao lado:
        // Menor ou igual a R$ 600,00 - ISENTO
        // Maior que R$ 600,00 e menor ou igual a 100 - 20% desconto
        // Maior que R$ 1.200,00 e menor ou igual a R$2000 - 25% desconto
        // Maior que R$ 2.000,00 - 30% desconto
        var returnedSalaryDiscount = "";

        for (int i = 0; i < Salary.Count; i++)
        {
            if (Salary[i] <= 600)
            {
                returnedSalaryDiscount += $"ISENTO,";    
                continue;
            }

            if(Salary[i] > 600 && Salary[i] < 1200)
            {
                //returnedSalaryDiscount += $"{Salary[i] * 0.80}";
                returnedSalaryDiscount += " 20%,";
                continue;
            }

            if(Salary[i] > 1200 && Salary[i] < 2000)
            {
                returnedSalaryDiscount += " 25%,";
                continue;
            }

            if(Salary[i] > 2000)
            {
                returnedSalaryDiscount += " 30%";
            }
        }

        return returnedSalaryDiscount;
        }
        public List<string> Exercise17(List<int> tabuada)
        {
        //17)Imprimir a tabuada de qualquer número fornecido pelo usuário até que o usuário forneça o valor –1.

        var returnoTabuada = new List<string>();

        foreach (var item in tabuada)
        {
            for (int i = 1; i < tabuada.Count; i++)
            {
                var temporary = $"{item * i}";
                returnoTabuada.Add($"{temporary}");
            }
        }
            return returnoTabuada;
        }
        // static void Main(string[] args)
		// {
 
        //     System.Console.WriteLine("\nCom os algarismos 1, 4, 6 e 8 pode-se formar vários números de três algarismos distintos.");
        //     System.Console.WriteLine("Qual é a soma de todos esses números?");
        //     (int centena, int dezena, int unidade, int finalResult) resultado = (0, 0, 0, 0);
            
        //     resultado.centena = 6*(100+400+600+800);
        //     resultado.dezena = 6*(10+40+60+80);
        //     resultado.unidade = 6*(1+4+6+8);
        //     resultado.finalResult = resultado.centena + resultado.dezena + resultado.unidade;
        //     System.Console.WriteLine($"\nR: {resultado.finalResult}");
		// }
    }
}