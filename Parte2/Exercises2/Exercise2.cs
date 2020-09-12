using System;
using System.Collections.Generic;

namespace Exercises2
{
    class Program
    {
        public List<double> ExerciseArrays1Q1(List<double> arrayA, List<double> ArrayB)
        {
        //Leia dois arrays A e B com 15 elementos. Construir um array C, 
        //onde cada elemento de C é a subtração do elemento correspondente de A com B. No final imprimir o array C.

        var arrayC = new List<double>();

        for (int i = 0; i < arrayA.Count; i++)
        {
            arrayC.Add(arrayA[i] - ArrayB[i]);
        }
        
        return arrayC;
        }
        public List<double> ExerciseArrays1Q2Direto(List<double> arrayA)
        {
        //Ler um array com 10 inteiros e mostrar os números na ordem direta e inversa a que foram lidos.
        var formaDireta = new List<double>(){};

        for (int i = 0; i < arrayA.Count; i++)
        {
            formaDireta.Add(arrayA[i]);
        }
        return formaDireta;
        }
        public List<double> ExerciseArrays1Q2Inverso(List<double> arrayA)
        {
        //Ler um array com 10 inteiros e mostrar os números na ordem direta e inversa a que foram lidos.
        var formaInversa = new List<double>(){};

        for (int i = arrayA.Count - 1; i >= 0 ; i--)
        {
            formaInversa.Add(arrayA[i]);
        }
        return formaInversa;
        }
        public string ExerciseArrays1Q3True(List<double> arrayA)
        {
//Leia 10 elementos e armazene em um array A. Em seguida, 
// solicite pelo teclado um número qualquer e pesquise no array se o número existe. 
// Caso, seja verdade imprima a mensagem: “O número existe no array”, caso contrário “Número inexistente”.

        var exist = false;
        var search = 25;
        //var search = 26;
        foreach (var item in arrayA)
        {
            if (search == item)
            {
                exist = true;
            }
        }
        
        var answer = exist ? "O número existe no array" : "Número inexistente";
        return answer;
        }
        public string ExerciseArrays1Q3False(List<double> arrayA)
        {

        var exist = false;
        // var search = 25;
        var search = 26;
        foreach (var item in arrayA)
        {
            if (search == item)
            {
                exist = true;
            }
        }
        
        var answer = exist ? "O número existe no array" : "Número inexistente";
        return answer;
        }
        public string ExerciseArrays1Q4True()
        {
            // 4-Leia dois arrays A e B com 10 elementos.  
            // Em seguida, compare os arrays e verifique se os mesmos são iguais ou diferentes.

            const int arrayLenght = 10;
            
            var firstArray = new double?[arrayLenght] {0, 2, 3, 1, 4, 25, 7, 8, 9, 15};
            var secondArray = new double[arrayLenght] {7, 1, 9, 1, 5, 10, 578, 29, 51, 2};
            var saoIguais = false;
            var arraySaoIguais = true;

            foreach (var item in secondArray)
            {
                for (int j = 0; j < secondArray.Length; j++)
                {
                    if(firstArray[j] == item) 
                    {
                        saoIguais = true;
                        firstArray[j] = null;
                        arraySaoIguais = true;
                        break;
                    }
                    if(!saoIguais)
                    {
                        arraySaoIguais = false;
                    }
                }
            }
            
            var message = arraySaoIguais ? "São iguais" : "Não são iguais";
            return message;
        } 
        public string ExerciseArrays1Q4False()
        {
            // 4-Leia dois arrays A e B com 10 elementos.  
            // Em seguida, compare os arrays e verifique se os mesmos são iguais ou diferentes.

            const int arrayLenght = 10;
            
            var firstArray = new double?[arrayLenght] {0, 2, 3, 1, 4, 25, 7, 8, 9, 15};
            var secondArray = new double[arrayLenght] {45, 5, 10, 12, 5, 10, 578, 29, 51, 54};
            var saoIguais = false;
            var arraySaoIguais = true;

            foreach (var item in secondArray)
            {
                for (int j = 0; j < arrayLenght; j++)
                {
                    if(firstArray[j] == item) 
                    {
                        saoIguais = true;
                        firstArray[j] = null;
                        arraySaoIguais = true;
                        break;
                    }
                    if(!saoIguais)
                    {
                        arraySaoIguais = false;
                    }
                }
            }
            
            var message = arraySaoIguais ? "São iguais" : "Não são iguais";
            return message;
        } 
        public string ExerciseArrays1Q5()
        {
        //Leia um array A com 15 elementos, e calcule a média aritmética dos mesmos, 
        //em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média

        var myList = new List<double>(){2,4,6,8};
        var sum = 0.0;
        (int aboveAverage, int average, int belowAverage) counter = (0, 0, 0);
        for(int i = 0; i < myList.Count; i++)
        {
            sum += myList[i];
        }
        var average = sum / myList.Count;
        foreach (var item in myList)
        {
            if (item > average)
            {
                counter.aboveAverage++;//2
                continue;
            }
            
            if (item == average)
            {
                counter.average++;
                continue;
            }
            counter.belowAverage++;//2
        }
        var returnedValues = $"{counter.aboveAverage}, {counter.average}, {counter.belowAverage}";
        return returnedValues;
        }
//         public string ExerciseArrays1Q6(List<double> arrayA, List<double> arrayB, List<double> arrayC)
//         {
// // Leia um array A com 12 elementos. Após sua leitura, colocar os seus elementos em ordem crescente. 
// // Depois ler um array B também com doze elementos, colocar os elementos de B em ordem decrescente. 
// // Construir um array C, onde cada elemento de C é a soma do elemento correspondente de A com b. 
// // Colocar em ordem crescente a matriz C e apresentar os seus valores.

//         foreach (var item in arrayA)
//         {
//             var temporary = double.MinValue;
//             for (int i = 0; i < arrayA.Count; i++)
//             {
//                 if (item > temporary && item > arrayC[i])
//                 {
//                     temporary = arrayC[i];
//                     arrayC[i] = arrayA[i];
//                     arrayA[i] = temporary;
//                 }

//                 if (temporary > item && temporary > arrayC[i])
//                 {
//                     double[,] sla = new double[2,3];
//                     sla[arrayA[i], arrayB[i]; 
//                 }
//             }
//         }
        
    }
}