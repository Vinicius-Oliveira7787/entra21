using System;
using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class Prova
    {
        public string Exercise1(double hours, double minutes, double serviceHour)
        {
            // Solicite ao usuário que informe quantas horas e minutos ele trabalha por dia 
            // e qual o valor/hora de seu serviço. Imprima quanto dinheiro 
            //ele ganha ao longo de um dia trabalhado. 
            // A mensagem impressa ao usuário deve ter, no máximo, duas casas após a vírgula.

            double returnedValue = (hours + (minutes / 60)) * serviceHour;
            return $"{returnedValue.ToString("0,00")}";
        }
        
        public string Exercise2(List<string> letters)
        {
            // Solicite ao usuário que informe uma palavra qualquer, porém ele deve digitar uma letra por vez.
            // Quando o usuário informar a palavra “Finalizar”, a aplicação deve apresentar a palavra inteira.
        
            var word = "";
            var indexBreak = letters.IndexOf("Finalizar");
            
            for (int i = 0; i < indexBreak ; i++)
            {
                word+=letters[i];
            }
            
            return word;
        }

        public List<string> Exercise3(List<(string name, string civil)> users)
        {
            //Solicite para 5 usuários que informem seus nomes e se são solteiros. 
            //Ao final apresente o nome de todos os usuários solteiros.
            
            var usersSingle = users
                .Where(item => item.civil == "Solteiro")
                .Select(item => item.name)
                .ToList();
            
            return usersSingle.Count < 1
            ? new List<string>(){"Sem usuários solteiros"}
            : usersSingle;
        }
       
        public List<string> Exercise4(List<int> usersBirthday)
        {
            // Solicite ao usuário seu ano de nascimento e imprima se ele é ou não maior de idade.
            //Caso o usuário digite um valor inválido, a aplicação deve pedir que ele digite novamente.

            return usersBirthday.Select(item => {
                return 2020-item > 17
                    ? "Usuário maior de idade"
                    : "Usuário menor de idade";
            }).ToList();
        }
        
        public List<double> Exercise5(List<string> numbers)
        {
            // Solicite ao usuário que informe 5 números e armazene em um array. 
            // Toda vez que o usuário digitar um valor inválido, a aplicação 
            // deverá armazenas “null” no índice correspondente. Ao final, imprimir apenas os números válidos.

            var validNumbers = new List<double>();

            numbers.ForEach(item => {
                try
                {
                    var counter = double.Parse(item);
                    validNumbers.Add(counter);
                }
                    
                catch(System.Exception)
                {
                    item = null;
                }
            });
            
            return validNumbers;
        }
        
        public double Exercise6(List<string> salary)
        {
            // Calcule e apresente a média salarial dos funcionários de uma empresa qualquer. 
            // A aplicação será encerrada quando o usuário digitar a palavra "calcular". Caso o usuário 
            // digite um valor negativo então a aplicação deve pedir seu salário novamente.

            var temporary = new List<double>();
            var indexBreaker = salary.IndexOf("calcular");

            for (int i = 0; i < indexBreaker; i++)
            {
                try
                {
                    var abc = double.Parse(salary[i]);
                    if (abc > -1)
                    {
                        temporary.Add(abc);
                    }
                }
                catch (System.Exception){}             
            }

            return temporary.Sum() / temporary.Count();
        }
        
        public string Exercise7(List<string> users)
        {
            // Pergunte para 5 usuários a UF que representa o estado onde ele nasceu. 
            // A aplicação deverá mostrar uma lista com todas as opções para o usuário, 
            // e cada uma deve conter um ID numérico, o usuário digitará o número que representa sua UF. 
            // Ao final a aplicação deverá mostrar a porcentagem de usuários que nasceram em Santa Catarina.

            var count = users.Where(item => item == "42 SC").Count();
            return $"{(count * 100) / users.Count}%";
        }

        public List<string> Exercise8(List<(string morningClass, string afternoonClass)> students)
        {
            // Solicite ao usuário que digite o nome dos alunos das turmas Matutino e Vespertino. 
            // Cada turma possui 5 alunos. Armazene os nomes em dois arrays distintos de forma alternada, 
            // ou seja, o primeiro nome deve ser armazenado no array da Matutino, o segundo nome deve
            // ser armazenado no array da Turma Vespertino, assim por diante. Ao final imprima apenas 
            //os nomes dos alunos que estão estudando em período integral. Caso nenhum aluno esteja 
            //cadastrado em ambas as turmas, imprimir a mensagem “todos os alunos estudam em meio período”.

            var returnedStudents = students
                .Where(item => item.morningClass == item.afternoonClass)
                .Select(item => item.morningClass)
                .ToList();

            return returnedStudents.Count < 1
            ? new List<string>(){"todos os alunos estudam em meio período"}
            : returnedStudents;
        }

        public void Huann()
        {
            // System.Console.WriteLine("Digite o dia de nascimento.");
            // var diaNascimento = int.Parse(Console.ReadLine());
            var diaNascimento = 23;

            // System.Console.WriteLine("Digite o mês de nascimento.");
            // var mesNascimento = int.Parse(Console.ReadLine());
            var mesNascimento = 5;

            // System.Console.WriteLine("Digite o ano de nascimento.");
            // var anoNascimento = int.Parse(Console.ReadLine());
            var anoNascimento = 2004;
 
            var anoAtual = DateTime.Now.Year;
            
            var totalDiasNascimento = 0;
            for (int mes = mesNascimento; mes < 13; mes++)
            {
                totalDiasNascimento += DateTime.DaysInMonth(anoNascimento, mes);
            }
            anoNascimento++;

            var diasAteHoje = 0;
            for (int ano = anoNascimento; ano < anoAtual + 1; ano++)
            {
                if (ano == anoAtual)
                {
                    for (int mes = 1; mes < DateTime.Now.Month; mes++)
                    {
                        diasAteHoje += DateTime.DaysInMonth(anoNascimento, mes);
                    }

                    diasAteHoje += DateTime.Now.Day;
                    break;
                }

                for (int mes = 1; mes < 13; mes++)
                {
                    diasAteHoje += DateTime.DaysInMonth(anoNascimento, mes);
                }
                anoNascimento++;
            }

            var final = diasAteHoje + (totalDiasNascimento - diaNascimento);
            // 21.900 = 60 anos
            var mensagem = final > 21900 ? "você é idoso" : "você é jovem";
            System.Console.WriteLine(mensagem);
        }
    }
}