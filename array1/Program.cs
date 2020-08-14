﻿using System;

namespace array1
{
    class Program
    {
        static void Exercise1()
		{
         //     1-Leia dois arrays A e B com 15 elementos. 
         //     Construir um array C, onde cada elemento de C 
         //     é a subtração do elemento correspondente de A com B.
        
            var a = new int[15];
            var b = new int[15];
            var c = new int[15];
        
            for (int i = 0; i < a.Length; i++)
            {
                System.Console.WriteLine($"Digite um número:");
                a[i] = int.Parse(Console.ReadLine());
                
                System.Console.WriteLine($"Digite um número:");
                b[i] = int.Parse(Console.ReadLine());
                
                c[i] = a[i] - b[i];
                
                System.Console.WriteLine($"A subtração de {a[i]} com {b[i]} é: {c[i]}");
            }
        }
        static void Exercise2()
		{
            // 2-Ler um array com 10 inteiros 
            // e mostrar os números na ordem direta e inversa a que foram lidos.
        
            var a = new int[10];
            
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < a.Length; i++)
            {
                System.Console.WriteLine($"igual foi digitado:{a[i]}");    
                
            }
                for (int b = 9; b > -1; b--)
                {
                    System.Console.WriteLine($"Reversodo do digitado: {a[b]}");    
                }
        }
        static void Exercise3()
		{
            // 3-Leia 10 elementos e armazene em um array A. 
        // Em seguida, solicite pelo teclado um número qualquer e pesquise no array se o número existe. 
        // Caso, seja verdade imprima a mensagem: “O número existe no array”, caso contrário “Número inexistente”.
        
        var arrayLenght = 10;
        var a = new double[arrayLenght];
        var existe = false;

        for (int i = 0; i < arrayLenght; i++)
        {
            System.Console.WriteLine("Digite um número;");
                a[i] = double.Parse(Console.ReadLine());   
        }
        System.Console.WriteLine("\nDigite um número para verificarmos se o mesmo já foi digitado posteriormente");        
            var result = double.Parse(Console.ReadLine());
        
        foreach (var item in a)
        {
            if(item == result)
            {
                existe = true;
                break;
            }
        }
        var message = existe ? "O número existe no array" : "Número inexistente";
        System.Console.WriteLine(message);
        }
        static void Exercise4()
		{
            // 4-Leia dois arrays A e B com 10 elementos.  
            // Em seguida, compare os arrays e verifique se os mesmos são iguais ou diferentes.
            const int arrayLenght = 10;
            
            var a = new double?[arrayLenght];
            var b = new double[arrayLenght];
            var saoIguais = false;
            var arraySaoIguais = true;

            for (int i = 0; i < a.Length; i++)
            {
                System.Console.WriteLine($"Digite um número para a posição {i + 1}");
                    a[i] = double.Parse(Console.ReadLine());
            }

            for (int x = 0; x < b.Length; x++)
            {
            System.Console.WriteLine($"Digite um segundo número para a posição {x + 2}");
                var result = double.Parse(Console.ReadLine());
                b[x] = result;
                    
                for (int j = 0; j < a.Length; j++)
                {
                    if(a[j] == result) 
                    {
                        saoIguais = true;
                        a[j] = null;
                        break;
                    }
                }
                        
            }
            
            if(!saoIguais)
            {
                arraySaoIguais = false;
            }
            
            var message = arraySaoIguais ? "São iguais" : "Não são iguais";
            System.Console.WriteLine(message);
        }

        static void Main(string[] args)
        {
            Exercise1();
        }         
    }            
}            