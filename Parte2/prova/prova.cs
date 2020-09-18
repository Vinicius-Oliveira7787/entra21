using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prova
{
    class Program
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
            
            foreach (var item in letters)
            {
                if (item == "Finalizar")
                {
                    break;
                }
                word += item;
            }
            
            return word;
        }

        public List<string> Exercise3(List<string> names, List<string> answers)
        {
            //Solicite para 5 usuários que informem seus nomes e se são solteiros. 
            //Ao final apresente o nome de todos os usuários solteiros.

            var returnedNames = new List<string>();
            var solteiros = false;

            for (int k = 0; k < answers.Count; k++)
            {
                if (answers[k] == "sim")
                {
                    returnedNames.Add(names[k]);
                    solteiros = true;
                }
            }
            if (!solteiros)
            {
                var temporary = new List<string>(){"Sem usuários solteiros"};
                return temporary;
            }
            else
            {
            return returnedNames;
            }
        }
       
        public string Exercise4(int birthday)
        {
            // Solicite ao usuário seu ano de nascimento e imprima se ele é ou não maior de idade.
            //Caso o usuário digite um valor inválido, a aplicação deve pedir que ele digite novamente.

            birthday = 2020 - birthday;
            return birthday > 17 ? "Usuário maior de idade" : "Usuário menor de idade";
        }
        
        public List<double> Exercise5(List<string> numbers, List<double> validNumbers)
        {
            // Solicite ao usuário que informe 5 números e armazene em um array. 
            // Toda vez que o usuário digitar um valor inválido, a aplicação 
            // deverá armazenas “null” no índice correspondente. Ao final, imprimir apenas os números válidos.

            for (int i = 0; i < numbers.Count; i++)
            {
                var counter = 0.0;
                try
                {
                    counter = double.Parse(numbers[i]);
                }
                catch (System.Exception)
                {
                    numbers[i] = null;
                }
                
                if (numbers[i] != null)
                {
                    validNumbers.Add(counter);
                }
            }
            
            return validNumbers;
        }
        
        public double Exercise6(List<string> salary)
        {
            //Calcule e apresente a média salarial dos funcionários de uma empresa qualquer. 
            //A aplicação será encerrada quando o usuário digitar a palavra "calcular". Caso o usuário 
            //digite um valor negativo então a aplicação deve pedir seu salário novamente.

            (double sum, double index) numbers = (0, 0);

            for (var i = 0; i < salary.Count; i++)
            {    
                if (salary[i] == "calcular")
                {
                    break;
                }
                
                var temporary = 0.0;
                try
                {
                    temporary = Double.Parse(salary[i]);
                }
                catch (System.Exception)
                {
                    salary[i] = null;
                    continue;
                }
        
                if (temporary < 0)
                {
                    salary[i] = null;
                    continue;
                }
                
                else if (temporary > 0)
                {
                    numbers.sum += temporary;
                    numbers.index++;
                }
            }
            return numbers.sum / numbers.index;
        }
        
        public string Exercise7(List<string> users)
        {
            // Pergunte para 5 usuários a UF que representa o estado onde ele nasceu. 
            // A aplicação deverá mostrar uma lista com todas as opções para o usuário, 
            // e cada uma deve conter um ID numérico, o usuário digitará o número que representa sua UF. 
            // Ao final a aplicação deverá mostrar a porcentagem de usuários que nasceram em Santa Catarina.

            var count = users.Where(item => item == "42 SC").Count();
            var total = (count * 100) / users.Count;
            return $"{total}%";
        }

        public List<string> Exercise8(List<string> morningClass, List<string> afternoonClass)
        {
            // Solicite ao usuário que digite o nome dos alunos das turmas Matutino e Vespertino. 
            // Cada turma possui 5 alunos. Armazene os nomes em dois arrays distintos de forma alternada, 
            // ou seja, o primeiro nome deve ser armazenado no array da Matutino, o segundo nome deve
            // ser armazenado no array da Turma Vespertino, assim por diante. Ao final imprima apenas 
            //os nomes dos alunos que estão estudando em período integral. Caso nenhum aluno esteja 
            //cadastrado em ambas as turmas, imprimir a mensagem “todos os alunos estudam em meio período”.

            var students = new List<string>();
            var onlyHalfPeriodStudents = true;

            foreach (var morningStudent in morningClass)
            {
                foreach (var afternoonStudent in afternoonClass)
                {
                    if (morningStudent == afternoonStudent)
                    {
                        students.Add(morningStudent);
                        onlyHalfPeriodStudents = false;
                    }
                }
            }

            if (onlyHalfPeriodStudents)
            {
                students.Add("todos os alunos estudam em meio período");
                return students;
            }
            else
            {
                return students;
            }
        }
    }
}