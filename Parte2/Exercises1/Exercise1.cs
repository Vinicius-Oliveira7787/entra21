using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises1
{
    class Program
    {
        public List<int> Exercise1A(List<int> array)
        {
            for (int i = 1; i < 11; i++)
            {
                array.Add(i);
            }
            return array;
        } 
      
        public int[] Exercise1B(List<int> numbers)
        {
            var array = new int[10];
            for (int i = array.Length - 1; i >= 0 ; i--)
            {
                numbers.Add(i);
                array[i] = numbers[i]; 
            }
            return array;
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
            
            // double sum = 0;
            // var zero = false;
            // int i = 0;
            
            // for (; i < ages.Count; i++)
            // {
            //     if (ages[i] == 0)
            //     {
            //         zero = true;
            //         break;
            //     }
            //     sum += ages[i];
            // }
            // var average = zero ? sum / i : sum / ages.Count;

            double average = (double)ages.Sum() / ages.Count;
            return average;
        }
        
        public double Exercise5(List<int> womenAge)
        {
            //5)Criar um algoritmo que peça o nome e a idade de 5 mulheres. 
            // Após informar estes dados, o programa deve mostrar apenas 
            // porcentagem de mulheres que estão com idade entre 18 e 35. 

            var count = womenAge.Where(item => item > 17 && item < 36).Count();
            return (count * 100) / womenAge.Count;
        }

        public string Exercise6(List<string> candidates, List<int> votes)
        {
            //     List<string> candidatesNames
            //     O segundo modo é o modo de votos, onde o usuário informa 1 para votar no primeiro candidato 
            //     e 2 para votar no segundo candidato. 
            //     O terceiro modo, é o modo de apuração de votos, 
            //     onde o sistema verifica qual candidato tem mais votos. Caso o número de votos seja igual, 
            //     o sistema deve imprimir a mensagem "SEGUNDO TURNO", 
            //     caso contrário deve imprimir o nome do candidato vencedor e o número de votos que ele obteve.
            //     var firstCandidateVotes = 2;

            var secondTurn = false;
            (string name, int votes) winner = ("", 0);

            for (int i = 0; i < candidates.Count; i++)
            {
                if (votes[i] > winner.votes)
                {
                    winner.votes = votes[i];
                    winner.name = candidates[i];
                }
            }
            
            for (int i = 0; i < candidates.Count; i++)
            {
                if (winner.votes == votes[i] && winner.name != candidates[i])
                {
                    secondTurn = true;
                    break;
                }
            }

            if (secondTurn)
            {
                return "SEGUNDO TURNO";
            }
            
            else
            {
                return $"Vencedor é: {winner.name}, com {winner.votes} votos";
            }
        }

        public double Exercise7(int years, double perDay, double price)
        {
            // Calcular a quantidade de dinheiro gasta por um fumante. 
            // Dados: o número de anos que ele fuma, o nº de cigarros fumados por dia e o preço de uma carteira.
            
            return (years * 365) * perDay * price;
            }
        
        public string Exercise8(int x, int y)
        {
            // Ler dois números inteiros, X e Y, e apresentar mensagem informando se o X é múltiplo de Y.
            
            return x % y == 0 ? "multiple" : "not multiple";
        }
        
        public string Exercise9(double firstNumber, double secondNumber, double thirdNumber)
        {
            // 9)Fazer um algoritmo para ler 03 números reais do teclado e verificar 
            // se o primeiro é maior que a soma dos outros dois.

            var sum = secondNumber + thirdNumber;

            if (firstNumber == sum)
            {
                return "equal";
            }

            else
            {
                return firstNumber > sum ? "is bigger" : "isn't bigger";
            }
        }
        
        public string Exercise10(double firstNumber, double secondNumber) 
        {
            if (firstNumber == secondNumber)
            {
                return "They are equal";
            }
            else
            {
                return firstNumber < secondNumber ? "SecondNumber is bigger" : "FirstNumber is bigger";
            }
        }
       
        public string Exercise11(double firstNumber, double secondNumber)
        {
            // 11)Ler 02 números inteiros do teclado. Se o segundo for diferente de zero, 
            // calcular e imprimir o quociente do primeiro pelo segundo. Caso contrário, 
            // imprimir a mensagem: "DIVISÃO POR ZERO".

            return firstNumber != 0 && secondNumber != 0 ? $"{firstNumber / secondNumber}" : "DIVISÃO POR ZERO";
        }
     
        public double Exercise12(List<int> numbers)
        {
            //12)Ler 4 números inteiros e calcular a soma dos que forem pares.

            return numbers.Where(item => item % 2 == 0).Sum();
        }
     
        public double Exercise13(List<double> numbers)
        {
            //Ler 10 valores e determinar o maior dentre eles.            
            var biggestNumber = double.MinValue;

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
            
            return $"{firstNumber},{secondNumber},{thirdNumber}";
        }
      
        public string Exercise15(List<double> numbers)
        {
            //15)Ler 10 números e imprimir quantos são múltiplos de 3 e quantos são múltiplos de 5.

            var numbersMultipleByThree = numbers.Where(item => item % 3 == 0).Count();
            var numbersMultipleByFive = numbers.Where(item => item % 5 == 0).Count();
            
            return $"{numbersMultipleByThree},{numbersMultipleByFive}";
        }
      
        public string Exercise16(double salary)
        {
            // 16)Ler o salário de uma pessoa e imprimir o Salário Líquido de acordo com a redução do imposto 
            //descrito ao lado:
            // Menor ou igual a R$ 600,00 - ISENTO
            // Maior que R$ 600,00 e menor ou igual a 100 - 20% desconto
            // Maior que R$ 1.200,00 e menor ou igual a R$2000 - 25% desconto
            // Maior que R$ 2.000,00 - 30% desconto

            var returnedSalaryDiscount = "";
            if (salary <= 600)
            {
                returnedSalaryDiscount = $"ISENTO";
            }

            else if(salary > 600 && salary < 1200)
            {
                returnedSalaryDiscount = $"20% = {salary * 0.80}";
            }

            else if(salary > 1200 && salary < 2000)
            {
                returnedSalaryDiscount = $"25% = {salary * 0.75}";
            }

            else if(salary > 2000)
            {
                returnedSalaryDiscount = $"30% = {salary * 0.70}";
            }
            
            return returnedSalaryDiscount;
        }
      
        public IEnumerable<int> Exercise17(int tabuada)
        {
            //17)Imprimir a tabuada de qualquer número fornecido pelo usuário até que o usuário forneça o valor –1.

            var multiplicationTable = new List<int>()
            {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
        
            return multiplicationTable.Select(item => item * tabuada);
        }
      
        public string Exercise18(int apples)
        {
            // 18)As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, 
            // e R$ 1,00 se forem compradas pelo menos 12. 
            // Escreva um programa que leia o número de maçãs compradas, calcule e
            // escreva o custo total da compra. 
        
            const double lessThenTwelve = 1.30;
            const double moreThenTwelve = 1.00;
            
            if (apples > 0)
            {
                return apples >= 12 ? $"R${apples * moreThenTwelve}" : $"R${apples * lessThenTwelve}";
            }   
            
            else
            {
                return "número de maçãs inválido!";
            }     
        }
    }
}