using Xunit;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace prova
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2, 24, 12, "029")]
        [InlineData(3, 30, 100, "350")]
        [InlineData(2.5, 30.5, 100.99, "304")]
        public void calculate_the_money_earned_per_day(double hours, double minutes, double serviceHour, string expected)
        {
            // Dado / Setup
            var exercises = new Program();
                            
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
            var exercises = new Program();
                            
            // Quando / Ação
            string returnedValue = exercises.Exercise2(leters.ToList());

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }

        [Theory]
        [InlineData(new string[5]{"eu","você","nós","nozes","pai"}, new string[5]{"não","não","não","não","não"}, new string[1]{"Sem usuários solteiros"})]
        [InlineData(new string[5]{"Noeh","Noah","Dean","Shaun","Justin"}, new string[5]{"sim","não","sim","sim","não"}, new string[3]{"Noeh","Dean","Shaun"})]
        [InlineData(new string[5]{"Noeh","Noah","Dean","Shaun","Justin"}, new string[5]{"sim","sim","sim","sim","sim"}, new string[5]{"Noeh","Noah","Dean","Shaun","Justin"})]
        public void show_the_names_of_the_ones_that_are_single(string[] names, string[] answers, string[] expected)
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            List<string> returnedValue = exercises.Exercise3(names.ToList(), answers.ToList());

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }

        [Theory]
        [InlineData(new int[1]{2003}, new string[1]{"Usuário menor de idade"})]
        [InlineData(new int[1]{2002}, new string[1]{"Usuário maior de idade"})]
        [InlineData(new int[2]{2010, 2004}, new string[2]{"Usuário menor de idade", "Usuário menor de idade"})]
        [InlineData(new int[3]{2002, 2001, 2000}, new string[3]{"Usuário maior de idade", "Usuário maior de idade", "Usuário maior de idade"})]
        public void should_say_if_the_user_is_under_age_or_above_age(int[] birthday, string[] expected)
        {
            // Dado / Setup
            var exercises = new Program();
                            
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
            var exercises = new Program();
            var validNumbers = new double[0];
                            
            // Quando / Ação
            List<double> returnedValue = exercises.Exercise5(numbers.ToList(), validNumbers.ToList());

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        } 
       
        [Theory]
        [InlineData(new string[5]{"11","12","-1","13","calcular"}, 12)]
        [InlineData(new string[8]{"-6","53","543,99","abc","1","12,99","calcular","12"}, 152.745)]
        [InlineData(new string[8]{"-15","24","135,20","calcular","-564","74,068","calcular","01"}, 79.6)]
        public void should_calculate_the_salary_of_the_employees(string[] salary, double expected)
        {
            // Dado / Setup
            var exercises = new Program();
                            
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
            var exercises = new Program();
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

        [Theory]
        [InlineData(new string[5]{"Vinicius", "Ruan", "Rodrigo", "Bolsonaro","Trump"}, new string[5]{"Isabelle","juliana","Gabriele","Patricia","Tatiane"}, new string[1]{"todos os alunos estudam em meio período"})]
        [InlineData(new string[8]{"Simlar", "Leo <3", "Guilherme", "Iago", "marcos", "Max", "Thiago", "Matheus"}, new string[8]{"Simlar", "Leo <3", "Guilherme", "Iago", "marcos", "Max", "Thiago", "Matheus"}, new string[8]{"Simlar", "Leo <3", "Guilherme", "Iago", "marcos", "Max", "Thiago", "Matheus"})]
        [InlineData(new string[2]{"Shaun", "Jesus"}, new string[2]{"Shaun", "C#"}, new string[1]{"Shaun"})]
        public void abc(string[] morningClass, string[] afternoonClass, string[] expected)
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            List<string> returnedValue = exercises.Exercise8(morningClass.ToList(), afternoonClass.ToList());

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        } 
    }
}