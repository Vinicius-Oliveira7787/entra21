using System;
using System.Collections.Generic;

namespace Exercises3
{
    class Program
    {
        public List<double> ExerciseArrays2Q1()
        {
//Popule dois vetores com 10 valores cada. Após esta operação, troque o conteúdo dos vetores.            
        var firstList = new List<double>(){1, 2, 3, 4};
        var secondList = new List<double>(){5, 6, 7, 8};
        var returnedList = new List<double>();//answers: 0,5, 2, 4, 5, 8, 12,5, 18, 24,5, 32
            
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
        public bool ExerciseArrays2Q2()
        {
//Dado um vetor qualquer com 10 números,faça um programa que informa se há ou não números repetidos nesse vetor.

        var semCriatividade = new List<double>(){1, 165, 21, 13, 541, 48, 416, 151, 25, 25};
        var toComPreguica = false;

        foreach (var item in semCriatividade)
        {
            for (int i = 0; i < semCriatividade.Count; i++)
            {
                if (item == semCriatividade[i])
                {
                    toComPreguica = true;
                }
            }
        }
        return toComPreguica;
        }
        public string ExerciseArrays2Q3YesOrNo()
        {
// Um certa empresa fez uma pesquisa para saber se as pessoas gostaram ou não 
// de um novo produto lançado no mercado. Para isso, forneceu-se o sexo do entrevistado
// e a sua resposta (sim ou não). Sabendo-se que foram entrevistadas 10 pessoas, 
// fazer um algoritmo que calcule e escreva:
// • O número de pessoas que responderam sim; //done
// • O número de pessoas que responderam não; //done
// • A percentagem de pessoas do sexo feminino que responderam sim;
// • A percentagem de pessoas do sexo masculino que responderam não;            
        var peopleInterviewed = new List<string>(){"yes","yes","yes","yes","no","no","no","no","no","no"};
        var peopleLiked = 0;
        var peopleDisliked = 0;

        foreach (var item in peopleInterviewed)
        {
            var temporary = item == "yes" ? peopleLiked++ : peopleDisliked++;
        }
        var returnedAnswers = $"{peopleLiked} pessoas gostaram, {peopleDisliked} pessoas não gostaram";
        return returnedAnswers;
        }
        public string ExerciseArrays2Q3PercentageMenDislikedWomenLiked()
        {    
        var peopleInterviewed = new List<string>(){"yes","yes","yes","yes","no","no","no","no","no","no"};
        var peopleInterviewedMenAndWomen = new List<string>()
        {"man","woman","man","woman","man","woman","man","woman","man","woman"};
        (int menDisliked, int womenLiked) Interview = (0,0);
        
        for (int i = 0; i < peopleInterviewedMenAndWomen.Count; i++)
        {
            if (peopleInterviewedMenAndWomen[i] == "man" &&  peopleInterviewed[i] == "no")
            {
                Interview.menDisliked++;
            }
            if (peopleInterviewedMenAndWomen[i] == "woman" &&  peopleInterviewed[i] == "yes")
            {
                Interview.womenLiked++;
            }
        }
        var percentWomenLiked = (Interview.womenLiked * 100) / peopleInterviewed.Count;
        var percentMenDisliked = (Interview.menDisliked * 100) / peopleInterviewed.Count;

var returnedAnswers = $"{percentMenDisliked}% dos homens não gostaram, {percentWomenLiked}% das mulheres gostaram";
        return returnedAnswers;
        }
        public double ExerciseArrays2Q4()
        {
//Desenvolver um programa que efetue a leitura de cinco elementos de uma matriz 
// A do tipo vetor. No final, apresente o total da soma de todos os elementos // que sejam impares.

        var listaDoVetorDeUmaMatrizDeCincoElementosLol = new List<double>(){1.5, 2.75, 4, 4, 15.2,};
        var totalSum = 0.0;

        for (int i = 0; i < listaDoVetorDeUmaMatrizDeCincoElementosLol.Count; i++)
        {
            if (listaDoVetorDeUmaMatrizDeCincoElementosLol[i] % 2 != 0)
            {
                totalSum += listaDoVetorDeUmaMatrizDeCincoElementosLol[i];
            }
        }
        return totalSum;
        }
        public int ExerciseArrays2Q5()     
        {
//Contar quantos valores de um vetor de 10 posições são positivos.
        var lazyList = new List<double>(){-1, 1.5, -6541, 12, 468, -654, -218, -41684, 2184, 11, 354, 15};

        var positiveValuesCounter = 0;
        for (int i = 0; i < lazyList.Count; i++)
        {
            if (lazyList[i] > 0)
            {
                positiveValuesCounter++;
            }
        }
        return positiveValuesCounter;
        }
        public string ExerciseArrays2Q6()     
        {
//Ler um vetor de 10 posições (aceitar somente números positivos). 
//Escrever a seguir o valor do maior elemento de Q e a respectiva posição que ele ocupa no vetor.    

        var lazyList = new List<double>(){-1, 1.5, -6541, 12, 468, -654, -218, -41684, 2184, 11, 354, 15};

        (double biggestNumber, int biggestNumberIndex) exercise = (0.0, 0);

        for (int i = 0; i < lazyList.Count; i++)
        {
            if(lazyList[i] > exercise.biggestNumber)
            {
                exercise.biggestNumber = lazyList[i];
                exercise.biggestNumberIndex = i;
            }
        }
        var abc = $"Maior número: {exercise.biggestNumber}, Posição do index: {exercise.biggestNumberIndex}";
        return abc;
        }
        public double ExerciseArrays2Q7()
        {
//Crie e popule um vetor A e imprima na tela o número de vezes que existe um número 
//residindo na mesma posição do vetor que seu valor numérico.            
        var numbers = new List<double>(){0, 1, -6541, 12, 468, -654, -218, -41684, 2184, 11, 354, 15};
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

        var returnedNumberOfvowels = 0;
        for (int i = 0; i < letters.Count; i++)
        {
            if (letters[i] == "a" || letters[i] == "e" || letters[i] == "i" || letters[i] == "o" || letters[i] == "u")
            {
                returnedNumberOfvowels++;
            }
        }
        return returnedNumberOfvowels;
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