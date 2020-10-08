using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Exercises3
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

            var sameNumbers = false;

            for (int i = 0; i < semCriatividade.Count; i++)
            {
                for (int k = 0; k < semCriatividade.Count; k++)
                {
                    if (i != k && semCriatividade[i] == semCriatividade[k])
                    {
                        sameNumbers = true;
                    }
                }
            }
            
            return sameNumbers;
        }
       
        public (string, string, int, int) Exercise3(List<(string genders, string genderAnswers)> peopleInterviewed)
        {   
            // 3)Um certa empresa fez uma pesquisa para saber 
            // se as pessoas gostaram ou não de um novo produto lançado no mercado. 
            // Para isso, forneceu-se o sexo do entrevistado e a sua resposta (sim ou não). 
            // Sabendo-se que foram entrevistadas 10 pessoas, fazer um algoritmo que calcule e escreva:
            // • O número de pessoas que responderam sim;
            // • O número de pessoas que responderam não;
            // • A percentagem de pessoas do sexo feminino que responderam sim;
            // • A percentagem de pessoas do sexo masculino que responderam não; 
           
           var menCount = peopleInterviewed.Where(item => item.genders == "man").Count();
           var womencount = peopleInterviewed.Where(item => item.genders == "woman").Count();

           var peopleWhoHaveLiked = peopleInterviewed.Where(item => item.genderAnswers == "yes").Count();
           var peopleWhoHaveDisliked = peopleInterviewed.Where(item => item.genderAnswers == "not").Count();

            var menDisliked = peopleInterviewed.Where(item => item.genders == "man" && item.genderAnswers == "not").Count();
            var womenLiked = peopleInterviewed.Where(item => item.genders == "woman" && item.genderAnswers == "yes").Count();

           var percentageMan = (menDisliked * 100) / menCount;
           var percentageWoman = (womenLiked * 100) / womencount;

            (string percentageWomen, string percentageMen, int didNotLiked, int didLiked) 
            returned = ($"{percentageWoman}%", $"{percentageMan}%", peopleWhoHaveDisliked, peopleWhoHaveLiked);
            return returned;
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
       
        public string ExerciseArrays2Q6(double[] lazyList)     
        {
            //Ler um vetor de 10 posições (aceitar somente números positivos). 
            //Escrever a seguir o valor do maior elemento de Q e a respectiva posição que ele ocupa no vetor.    

            var biggestNumber = lazyList.Max();
            var biggestNumberIndex = Array.IndexOf(lazyList, biggestNumber);
            
            return $"Maior número: {biggestNumber}, Posição do index: {biggestNumberIndex}";
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

            return letters
                .Where(item => item == "a" || item == "e" || item == "i" || item == "o" || item == "u")
                .Count();
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