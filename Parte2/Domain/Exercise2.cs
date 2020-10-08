using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Exercises2
    {
        public List<double> ExerciseArrays1Q1(List<double> arrayA, List<double> ArrayB)
        {
        // Leia dois arrays A e B com 15 elementos. Construir um array C, onde cada
        // elemento de C é a subtração do elemento correspondente de A com B. No final imprimir o array C.

        var arrayC = new List<double>();

        for (int i = 0; i < arrayA.Count; i++)
        {
            arrayC.Add(arrayA[i] - ArrayB[i]);
        }
        
        return arrayC;
        }
      
        public List<(double,double)> ExerciseArrays1Q2(List<double> array)
        {
            //Ler um array com 10 inteiros e mostrar os números na ordem direta e inversa a que foram lidos.
            
            var formas = new List<(double direto, double reverso)>();
            // var counter = 0;

            // for (int i = array.Count - 1; i >= 0 ; i--)
            // {
            //     formas.Add((array[counter], array[i]));
            //     counter++;
            // }
            
            var counter = array.Count -1;

            for (int i = 0; i < array.Count; i++)
            {
                formas.Add((array[i], array[counter]));
                counter--;
            }

            return formas;
        }
      
        public string Exercise3(double search, List<double> arrayA)
        {
            //Leia 10 elementos e armazene em um array A. Em seguida, 
            // solicite pelo teclado um número qualquer e pesquise no array se o número existe. 
            // Caso, seja verdade imprima a mensagem: “O número existe no array”, 
            // caso contrário “Número inexistente”.

            var exist = arrayA.Contains(search);
            
            return exist ? "O número existe no array" : "Número inexistente";
        }
      
        public string Exercise4(List<double> firstArray, List<double> secondArray)
        {
            // 4-Leia dois arrays A e B com 10 elementos.  
            // Em seguida, compare os arrays e verifique se os mesmos são iguais ou diferentes.

            var saoIguais = false;
            var arraySaoIguais = true;

            for (int i = 0; i < firstArray.Count; i++)
            {
                for (int k = 0; k < secondArray.Count; k++)
                {
                    if (i != k && firstArray[i] == secondArray[k])
                    {
                        saoIguais = true;
                        break;
                    }
                }
            }
    
            if(!saoIguais)
            {
                arraySaoIguais = false;
            }
            
            return arraySaoIguais ? "São iguais" : "Não são iguais";
        } 
       
        public string ExerciseArrays1Q5(List<double> myList)
        {
            //Leia um array A com 15 elementos, e calcule a média aritmética dos mesmos, 
            //em seguida, diga quantos dos elementos lidos estão abaixo, acima e na média

            (int aboveAverage, int average, int belowAverage) counter = (0, 0, 0);
            
            var average = myList.Sum() / myList.Count;
            foreach (var item in myList)
            {
                if (item > average)
                {
                    counter.aboveAverage++;
                    continue;
                }
                
                if (item == average)
                {
                    counter.average++;
                    continue;
                }
                
                counter.belowAverage++;
            }
            
            return $"{counter.aboveAverage}, {counter.average}, {counter.belowAverage}";
        }        
    }
}