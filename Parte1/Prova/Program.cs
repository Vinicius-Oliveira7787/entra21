using System;
using System.Text;

namespace Prova
{
    class Program
    {
        static void Q1()
        {
        // Solicite ao usuário que informe quantas horas e minutos ele trabalha por dia
        // e qual o valor/hora de seu serviço. Imprima quanto dinheiro ele ganha ao longo de um dia trabalhado.
        // A mensagem impressa ao usuário deve ter, no máximo, duas casas após a vírgula. (1p)

        System.Console.WriteLine("Quantas horas você trabalha por dia?");
        var result = double.Parse(Console.ReadLine()); 
        
        System.Console.WriteLine("Quantos minutos você trabalha por dia?");
        var result1 = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Qual o valor/hora de seu serviço?");
        var horaServico = int.Parse(Console.ReadLine());

        var totalHoras = result + (result1 / 60);
        var total = (totalHoras * horaServico).ToString("0,00");
        System.Console.WriteLine($"você ganha ao longo de um dia trabalhado o total de: {total}");
        }
        static void Q2()
        {
            // Solicite ao usuário que informe uma palavra qualquer, 
            // porém ele deve digitar uma letra por vez. Quando o usuário informar a palavra “Finalizar”, 
            // a aplicação deve apresentar a palavra inteira. (1p)
            
            // var a = new string[46];
            // System.Console.WriteLine("informe uma palavra qualquer:");
            // System.Console.WriteLine("porém você deve digitar uma letra por vez, digite um . quando terminar a palavra");
            // for (int i = 0; i < a.Length; i++)
            // {
            //     a[i] = Console.ReadLine();
            //     if (a[i] == ".")
            //     {
            //         break;
            //     }
            // }
            // for (int i = 0; i < a.Length; i++)
            // {
            //     System.Console.Write(a[i]);
            //     if (a[i] == ".")
            //     {
            //         break;
            //     }
            // }

            var word = "";
            while (true)
            {
                Console.WriteLine("Digite uma letra");
                var letter = Console.ReadLine();
                if (letter == "Finalizar")
                {
                    break;
                }
                word += letter;
            }

            System.Console.WriteLine($"A palavra é: {word}");
        }
        static void Q3()
        {
        //     Solicite para 5 usuários que informem seus nomes e se são solteiros. 
        //     Ao final apresente o nome de todos os usuários solteiros. (1p)
        
        // var a = new (string nomes, string solteiro)[5];
        // for (int i = 0; i < a.Length; i++)
        // {
        //     System.Console.WriteLine("Digite seu nome;");
        //     a[i].nomes = Console.ReadLine();
        //     System.Console.WriteLine("Você é solteiro?");
        //     a[i].solteiro = Console.ReadLine();
        // }
        // for (int i = 0; i <  a.Length; i++)
        // {
        //     if (a[i].solteiro == "sim")
        //     {
        //         System.Console.WriteLine($"O usuario: {a[i].nomes} é solteiro");
        //     }
        // }

        var singleMen = new StringBuilder();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Digite seu nome");
                var name = Console.ReadLine();
                Console.WriteLine("Você é solteiro?");
                var isSingle = Console.ReadLine();
                if (isSingle == "sim")
                {
                    singleMen.Append($"{name}, ");
                }
            }

            singleMen.Remove(singleMen.Length - 2, 2);
            Console.WriteLine($"Todos os solteiros: {singleMen}");
        }
        static void Q4()
        {
            // Solicite ao usuário seu ano de nascimento e imprima se ele é ou não maior de idade. 
            // Caso o usuário digite um valor inválido, a aplicação deve pedir que ele digite novamente. (1p)
            var result = 0;
            System.Console.WriteLine("Digite o ano de seu nascimento:");
            while (true)
            {
                try
                {
                    result = int.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine("Número inválido, Digite novamente");
                }
            }
            var maiorDeIdade = 2020 - result;
            if (maiorDeIdade > 17)
            {
                System.Console.WriteLine("Você é maior de idade.");
            }
            else if (maiorDeIdade < 18)
            {
                System.Console.WriteLine("Você é menor de idade.");
            }
        }
        static void Q5()
        {
            // Solicite ao usuário que informe 5 números e armazene em um array. 
            // Toda vez que o usuário digitar um valor inválido, a aplicação deverá armazenas “null” 
            // no índice correspondente. Ao final, imprimir apenas os números válidos.(1p)

            var a = new double?[5];
            for (int i = 0; i < a.Length; i++)
            {
                System.Console.WriteLine("Digite um número:");
                try
                {
                    a[i] = double.Parse(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    a[i] = null;
                }
            }
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != null)
                {
                System.Console.WriteLine($"{a[i]}");
                }
            }
        }
        static void Q6()
        {
            // Calcule e apresente a média salarial dos funcionários de uma empresa qualquer. 
            // A aplicação será encerrada quando o usuário digitar a palavra "calcular". 
            // Caso o usuário digite um valor negativo então a aplicação deve pedir seu salário novamente.
            
            for (int i = 0; true; i++)
            {
                System.Console.WriteLine("Salário:");
                var result = Console.ReadLine();
                var salario = double.Parse(result); 
                
                if (salario < 0)
                {
                    System.Console.WriteLine("Invalido! tente novamente.");
                    continue;
                }
                
                var total = salario / i;
                if (result == "calcular")
                {
                    System.Console.WriteLine(total.ToString("0,00"));
                    break;
                }
            }
        }
        static void Q7()
        {
            // Pergunte para 5 usuários a UF que representa o estado onde ele nasceu. 
            // A aplicação deverá mostrar uma lista com todas as opções para o usuário, 
            // e cada uma deve conter um ID numérico, o usuário digitará o número que representa sua UF. 
            // Ao final a aplicação deverá mostrar a porcentagem de usuários que nasceram em Santa Catarina.

            var sc = 0;
            for (int i = 0; i < 5; i++)
            {
                
                System.Console.WriteLine("Qual a UF do estado que você nasceu?");
                System.Console.WriteLine("Lista de opções:");
                System.Console.WriteLine("11 RO, 12, AC, 13 AM, 14 RR, 15 PA, 16 AP, 17 TO, 21 MA, 22 PI, 23 CE,");
                System.Console.WriteLine("24 RN, 25 PB, 26 PE, 27 AL, 28 SE, 29 BA, 31 MG, 32 ES, 33 RJ, 35 SP, 41 PR");
                System.Console.WriteLine("42 SC, 43 RS, 50 MS, 51 MT, 52 GO E 53 DF.");
                var result = Console.ReadLine();
                
                if (result == "42")
                {
                    sc++;
                }
            }
            var total = (sc * 100) / 5;
            System.Console.WriteLine($"porcentagem de usuários que nasceram em Santa Catarina: {total}%");
        }
        static void Q8()
        {
            // Solicite ao usuário que digite o nome dos alunos das turmas Matutino e Vespertino. 
            // Cada turma possui 5 alunos. Armazene os nomes em dois arrays distintos de forma alternada, 
            // ou seja, o primeiro nome deve ser armazenado no array da Matutino, 
            // o segundo nome deve ser armazenado no array da Turma Vespertino, assim por diante. 
            // Ao final imprima apenas os nomes dos alunos que estão estudando em período integral. 
            // Caso nenhum aluno esteja cadastrado em ambas as turmas, 
            // imprimir a mensagem “todos os alunos estudam em meio período”. (2p)
            
            // var matutino = new string[5];
            // var vespertino = new string[5];
            // var periodoIntegral = new StringBuilder();
            // var meioPeriodoEIntegral = false;
            
            // for (int i = 0; i < matutino.Length; i++)
            // {
            //     System.Console.WriteLine("Digite um de cade vez os nomes dos alunos que estudam no período matutino.");
            //     matutino[i] = Console.ReadLine();
                
            //     System.Console.WriteLine("estuda em periodo integral?");
            //     var result = Console.ReadLine();
                
            //     if (result == "sim")
            //     {
            //         periodoIntegral.Append($"{matutino[i]}, ");
            //     }
            // }
            // for (int i = 0; i < vespertino.Length; i++)
            // {
            //     System.Console.WriteLine("Digite um de cade vez os nomes dos alunos que estudam no período vespertino.");
            //     var result1 = Console.ReadLine();
            //     vespertino[i] = result1;
                
            //     System.Console.WriteLine("estuda em periodo integral?");
            //     var result = Console.ReadLine();
            //     if (result == "sim")
            //     {
            //         periodoIntegral.Append($"{vespertino[i]}, ");
            //     }
                
            //     for (int k = 0; k < matutino.Length; k++)
            //     {
            //         if (matutino[k] == result1)
            //         {
            //          meioPeriodoEIntegral = true;
            //          matutino[k] = null;
            //          break; 
            //         }
            //     }
            // }
            
            // periodoIntegral.Remove(periodoIntegral.Length - 2, 2);
            // var message = meioPeriodoEIntegral ? $"Alunos que estudam em período integral: {periodoIntegral}" : "todos os alunos estudam em meio período";
            // System.Console.WriteLine(message);

            var studentsPerClass = 5;
            var morningClass = new string[studentsPerClass];
            var afternoonClass = new string[studentsPerClass];
            
            for (int i = 0; i < studentsPerClass; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    System.Console.WriteLine("Digite um nome");
                    var input = Console.ReadLine();
                    
                    var currentClass = j == 0 ? morningClass : afternoonClass;
                    currentClass[i] = input;
                }
            }

            var onlyHalfPeriodStudents = true;

            System.Console.WriteLine("Pesquisando por alunos de período integral...");
            foreach (var morningStudent in morningClass)
            {
                foreach (var afternoonStudent in afternoonClass)
                {
                    if (morningStudent == afternoonStudent)
                    {
                        System.Console.WriteLine(morningStudent);
                        onlyHalfPeriodStudents = false;
                    }
                }
            }

            if (onlyHalfPeriodStudents)
            {
                System.Console.WriteLine("todos os alunos estudam em meio período");
            }
        }
        static void Main(string[] args)
        {
            Q8();
        }
    }
}