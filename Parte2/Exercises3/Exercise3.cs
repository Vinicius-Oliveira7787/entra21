using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises3
{
    class Program
    {
        public List<double> Exercise1(List<double> firstList, List<double> secondList)
        {
            //Popule dois vetores com 10 valores cada. Após esta operação, troque o conteúdo dos vetores.            
            
            var returnedList = new List<double>();
                
            for (int i = 0; i < firstList.Count; i++)
            {
                returnedList.Add((firstList[i] * firstList[i]) / 2);  
            }
            
            for (int i = 0; i < firstList.Count; i++)
            {
                returnedList.Add((secondList[i] * secondList[i]) / 2);  
            }
            
            return returnedList;
        }
       
        public bool Exercise2(List<double> semCriatividade)
        {
            //Dado um vetor qualquer com 10 números,faça um programa que informa se há ou não números repetidos nesse vetor.

            var toComPreguica = false;

            foreach (var item in semCriatividade)
            {
                for (int i = 1; i < semCriatividade.Count; i++)
                {
                    if(item == semCriatividade[i])
                    {
                        toComPreguica = true;
                        break;
                    }
                }
            }
            
            return toComPreguica;
        }
       
        public (string, string) Exercise3(List<string> peopleInterviewed, List<string> MenAndWomen)
        {    
            (int menDisliked, int womenLiked) Interview = (0,0);
            
            for (int i = 0; i < MenAndWomen.Count; i++)
            {
                if (MenAndWomen[i] == "man" &&  peopleInterviewed[i] == "no")
                {
                    Interview.menDisliked++;
                    continue;
                }

                if (MenAndWomen[i] == "woman" &&  peopleInterviewed[i] == "yes")
                {
                    Interview.womenLiked++;
                }
            }
            
            var percentWomenLiked = (Interview.womenLiked * 100) / peopleInterviewed.Count;
            var percentMenDisliked = (Interview.menDisliked * 100) / peopleInterviewed.Count;

            var peopleLiked = peopleInterviewed.Where(item => item == "yes").Count();
            var peopleDisliked = peopleInterviewed.Where(item => item == "no").Count();
            
            var totalAnswers = $"Liked: {peopleLiked}, Disliked: {peopleDisliked}";
            var menDislikedAndWomenLiked = $"{percentMenDisliked}% men disliked, {percentWomenLiked}% women liked";
            
            (string Percentage, string LikedOrNot) people = (menDislikedAndWomenLiked, totalAnswers);
            return people;
        }
       
        public double ExerciseArrays2Q4(List<double> listaDoVetorDeUmaMatrizDeCincoElementosLol)
        {
            //Desenvolver um programa que efetue a leitura de cinco elementos de uma matriz 
            // A do tipo vetor. No final, apresente o total da soma de todos os elementos que sejam impares.

            return listaDoVetorDeUmaMatrizDeCincoElementosLol.Where(item => item % 2 != 0).Sum();
        }
       
        public int ExerciseArrays2Q5(List<double> lazyList)     
        {
            //Contar quantos valores de um vetor de 10 posições são positivos.

            return lazyList.Where(item => item > 0).Count();
        }
       
        public string ExerciseArrays2Q6(List<double> lazyList)     
        {
            //Ler um vetor de 10 posições (aceitar somente números positivos). 
            //Escrever a seguir o valor do maior elemento de Q e a respectiva posição que ele ocupa no vetor.    

            (double biggestNumber, int biggestNumberIndex) exercise = (double.MinValue, 0);

            for (int i = 0; i < lazyList.Count; i++)
            {
                if(lazyList[i] > exercise.biggestNumber)
                {
                    exercise.biggestNumber = lazyList[i];
                    exercise.biggestNumberIndex = i;
                }
            }
            
            return $"Maior número: {exercise.biggestNumber}, Posição do index: {exercise.biggestNumberIndex}";
        }
      
        public double ExerciseArrays2Q7(List<double> numbers)
        {
            //Crie e popule um vetor A e imprima na tela o número de vezes que existe um número 
            //residindo na mesma posição do vetor que seu valor numérico.            
            
            var equalNumbers = 0.0;

            for (int i = 0; i < numbers.Count; i++)
            {
                if(numbers[i] == i)
                {
                    equalNumbers++;
                }
            }

            return equalNumbers;
        } 
       
        public double ExerciseArrays2Q8(List<string> letters)    
        {
            //Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto. 
            //No final, imprima quantas destas são vogais.

            var count = letters.Where(item => item == "a" || item == "e" || item == "i" || item == "o" || item == "u").Count();
            return count;
        }
       
        public string ExerciseArrays2Q9(List<string> letters)
        {
            //Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto. 
            //No final, imprima a string resultante da soma das strings que residem em índices pares.

            var resultantString = "";
            for (int i = 0; i < letters.Count; i++)
            {
                if (i % 2 == 0)
                {
                    resultantString += letters[i]; 
                }
            }
            return resultantString;
        }
    }
}