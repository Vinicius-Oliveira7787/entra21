using Xunit;
using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Tests
{
    public class ProvaTest
    {
        [Theory]
        [InlineData(2, 24, 12, "029")]
        [InlineData(3, 30, 100, "350")]
        [InlineData(2.5, 30.5, 100.99, "304")]
        public void calculate_the_money_earned_per_day(double hours, double minutes, double serviceHour, string expected)
        {
            // Dado / Setup
            var exercises = new Prova();
                            
            // Quando / Ação
            string returnedValue = exercises.Exercise1(hours, minutes, serviceHour);

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }

        [Theory]
        [InlineData(new string[11]{"i","A","M"," ","H","U","N","T","E","R","Finalizar"}, "iAM HUNTER")]
        [InlineData(new string[18]{"I","s"," ","C","y","b","e","r"," ","C","r","i","m","i","n","a","l","Finalizar"}, "Is Cyber Criminal")]
        [InlineData(new string[37]{"W","a","y"," ","B","a","c","k"," ","H","o","m","e"," ","i","s"," ","a"," ","r","e","a","l","l","y"," ","g","o","o","d"," ","m","u","s","i","c","Finalizar"}, "Way Back Home is a really good music")]
        public void one_leter_per_time_and_should_stop_when_digit_equal_finalizar(string[] leters, string expected)
        {
            // Dado / Setup
            var exercises = new Prova();
                            
            // Quando / Ação
            string returnedValue = exercises.Exercise2(leters.ToList());

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }

        public static TheoryData<(List<(string,string)>, List<string>)> testThirdQuestion()
        {
            return new TheoryData<(List<(string, string)>, List<string>)>
            {
                (new List<(string,string)>{("eu","Casado"), ("você","Casado"), ("nós","Casado"), ("nozes","Casado"), ("pai","Casado")}, 
                new List<string>{"Sem usuários solteiros"}),

                (new List<(string,string)>{("Noeh","Solteiro"), ("Noah","Casado"), ("Dean","Solteiro"), ("Shaun","Solteiro"), ("Justin","Casado")}
                ,new List<string>{"Noeh", "Dean", "Shaun"}),

                (new List<(string,string)>{("Noeh","Solteiro"), ("Noah","Solteiro"), ("Dean","Solteiro"), ("Shaun","Solteiro"), ("Justin","Solteiro")}
                ,new List<string>{"Noeh", "Noah", "Dean", "Shaun", "Justin"})
            };
        }
        
        [Theory]
        [MemberData(nameof(testThirdQuestion))]
        public void show_the_names_of_the_ones_that_are_single((List<(string, string)>, List<string>) people)
        {
            // Dado / Setup
            var exercises = new Prova();
                            
            // Quando / Ação
            var returnedValue = exercises.Exercise3(people.Item1);

            // Deve / Asserções
            Assert.Equal(people.Item2, returnedValue);
        }

        [Theory]
        [InlineData(new int[1]{2003}, new string[1]{"Usuário menor de idade"})]
        [InlineData(new int[1]{2002}, new string[1]{"Usuário maior de idade"})]
        [InlineData(new int[2]{2010, 2004}, new string[2]{"Usuário menor de idade", "Usuário menor de idade"})]
        [InlineData(new int[3]{2002, 2001, 2000}, new string[3]{"Usuário maior de idade", "Usuário maior de idade", "Usuário maior de idade"})]
        public void should_say_if_the_user_is_under_age_or_above_age(int[] birthday, string[] expected)
        {
            // Dado / Setup
            var exercises = new Prova();
                            
            // Quando / Ação
            var returnedValue = exercises.Exercise4(birthday.ToList());

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }

        [Theory]
        [InlineData(new string[5]{"eu","12","17,5","abc","6"}, new double[]{12, 17.5, 6})]
        [InlineData(new string[5]{"-6","-53","-543,99","abc","0"}, new double[]{-6, -53, -543.99, 0})]
        public void should_show_only_valid_numbers(string[] numbers, double[] expected)
        {
            // Dado / Setup
            var exercises = new Prova();
                            
            // Quando / Ação
            List<double> returnedValue = exercises.Exercise5(numbers.ToList());

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        } 
       
        [Theory]
        [InlineData(new string[5]{"11","12","-1","13","calcular"}, 12)]
        [InlineData(new string[8]{"-6","53","543,99","abc","1","12,99","calcular","12"}, 152.745)] // 610,98
        [InlineData(new string[8]{"-15","24","135,20","calcular","-564","74,068","calcular","01"}, 79.6)]
        public void should_calculate_the_salary_of_the_employees(string[] salary, double expected)
        {
            // Dado / Setup
            var exercises = new Prova();
                            
            // Quando / Ação
            double returnedValue = exercises.Exercise6(salary.ToList());

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        } 
       
        [Theory]
        [InlineData(new string[5]{"42 SC","50 MS","42 SC","29 BA","21 MA"}, "40%")]
        [InlineData(new string[8]{"13 AM","15 PA","51 MT","50 MS","52 GO","22 PI","53 DF","32 ES"}, "0%")]
        [InlineData(new string[8]{"42 SC","42 SC","42 SC","42 SC","42 SC","42 SC","42 SC","42 SC"}, "100%")]
        public void should_calculate_the_percentage_of_people_born_in_SC(string[] users, string expected)
        {
            // Dado / Setup
            var exercises = new Prova();
            var uf = new List<string>()
            {
            "11 RO", "12 AC", "13 AM", "14 RR", "15 PA", "16 AP", "17 TO", "21 MA", "22 PI", 
            "23 CE", "24 RN", "25 PB", "26 PE", "27 AL", "28 SE", "29 BA", "31 MG", "32 ES", 
            "33 RJ", "35 SP", "41 PR", "42 SC", "43 RS", "50 MS", "51 MT", "52 GO", "53 DF"
            }; //desnecessário
                            
            // Quando / Ação
            string returnedValue = exercises.Exercise7(users.ToList());

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        } 

        public static TheoryData<(List<(string,string)>, List<string>)> testQuestionEight()
        {
            return new TheoryData<(List<(string, string)>, List<string>)>
            {
                (new List<(string,string)>{("Vinicius","Isabelle"),("Ruan","Gabriele"),("Rodrigo","Patricia"),("Bolsonaro","juliana"),("Trump","Tatiane")}, 
                new List<string>{"todos os alunos estudam em meio período"}),
                (new List<(string,string)>{("Simlar","Simlar"),("Leo <3","Leo <3"),("Guilherme","Guilherme"),("Iago","Iago"),("marcos","marcos"),("Max","Max"),("Thiago","Thiago"),("Matheus","Matheus")}, 
                new List<string>{"Simlar", "Leo <3", "Guilherme", "Iago", "marcos", "Max", "Thiago", "Matheus"}),
                (new List<(string,string)>{("Shaun","Shaun"),("Jesus","C#")}, 
                new List<string>{"Shaun"})
            };
        }

        [Theory]
        [MemberData(nameof(testQuestionEight))]
        public void abc((List<(string morningClass, string afternoonClass)>, List<string>) students)
        {
            // Dado / Setup
            var exercises = new Prova();
                            
            // Quando / Ação
            List<string> returnedValue = exercises.Exercise8(students.Item1);

            // Deve / Asserções
            Assert.Equal(students.Item2, returnedValue);
        } 

        [Fact]
        public void huann()
        {
            var exercises = new Prova();
                            
            exercises.Huann();
        }
    }
}