using System.Collections.Generic;
using Xunit;
using System.Linq;

namespace Exercises1
{
    public class Exercises1Test
    {
        [Theory]
        [InlineData(new int[10]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, new int[10]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10})]
        public void exercise1A_should_return_an_array_from_1_to_10(int[] numbers, int[] expected)
        {
            var exercicio1 = new Program();
            var result = exercicio1.Exercise1A(numbers.ToList());

            Assert.Equal(expected, numbers);
        }
        [Theory]
        [InlineData(new int[10]{10, 9, 8, 7, 6, 5, 4, 3, 2, 1}, new int[10]{10, 9, 8, 7, 6, 5, 4, 3, 2, 1})]
        public void exercise1B_should_return_an_array_from_10_to_1(int[] numbers, int[] expected)
        {
            var exercicio1 = new Program();
            var result = exercicio1.Exercise1B(numbers.ToList());

            Assert.Equal(expected, result);
        }
        
        [Theory]
        [InlineData(new int[5]{2,4,6,8,10})]
        public void exercise1C_should_return_an_array_from_1_to_10_only_pairs(int[] expected)
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1c,
            // então a aplicação deverá retornar os números de 1 a 10, mas somente os pares

            // Dado / Setup
            var exercises = new Program();

            // Quando / Ação
            int[] returnedValues = exercises.Exercise1C();

            // Deve / Asserções
            Assert.Equal(5, returnedValues.Length);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], returnedValues[i]);
            }
        }
        
        [Theory]
        [InlineData(5050)]
        public void exercise2(double expected)
        {
            // Dado / Setup
            var exercises = new Program();

            // Quando / Ação
            int returnedValues = exercises.Exercise2();

            // Deve / Asserções
           Assert.Equal(expected, returnedValues);
        }
        
        [Fact]
        public void exercise3_should_return_an_array_from_1_to_200_only_odd()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1c,
            // então a aplicação deverá retornar os números de 1 a 10, mas somente os pares

            // Dado / Setup
            var exercises = new Program();

            // Quando / Ação
            int[] returnedValues = exercises.Exercise3();

            // Deve / Asserções
            var expectedOutput = new int[100]
            {
            1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47,
            49, 51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73, 75, 77, 79, 81, 83, 85,87,89,91,93,95,97,99,101,103,105,
            107,109,111,113,115,117,119,121,123,125,127,129,131,133,135,137,139,141,143,145,147,149,151,153,155,157,
            159,161,163,165,167,169,171,173,175,177,179,181,183,185,187,189,191,193,195,197,199
            };

            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], returnedValues[i]);
            }
        }
        
        [Theory]
        [InlineData(new int[3]{4, 6, 8}, 6)]
        [InlineData(new int[2]{4, 6}, 5)]
        [InlineData(new int[4]{1, 2, 3, 4}, 2.5)]
        [InlineData(new int[2]{-15, -15}, -15)]
        //[InlineData(new int[4]{1, 2, 0, 4}, 1.5)]
        public void exercise4(int[] ages, double expected)
        {
            // Dado / Setup
            var exercises = new Program();
            
            // Quando / Ação
            double returnedValues = exercises.Exercise4(ages.ToList());
            
            //deve / asserções
            Assert.Equal(expected, returnedValues);
        }
        
        [Theory]
        [InlineData(new int[3]{18, 23, 24}, 100)]
        [InlineData(new int[5]{17, 22, 91, 32, 35}, 60)]
        [InlineData(new int[4]{1, 2, 3, 4}, 0)]
        [InlineData(new int[2]{18, 17}, 50)]
        public void exercise5(int[] ages, double expected)
        {
            // Dado / Setup
            var exercises = new Program();
            
            // Quando / Ação
            double returnedValues = exercises.Exercise5(ages.ToList());

            // Deve / Asserções
            Assert.Equal(expected, returnedValues);
        }
       
        [Theory]
        [InlineData(new string[2]{"Batman", "Superman"}, new int[2]{2, 1}, "Vencedor é: Batman, com 2 votos")]
        [InlineData(new string[2]{"Batman", "Superman"}, new int[2]{2, 2}, "SEGUNDO TURNO")]
        [InlineData(new string[2]{"Dragon", "Hunter"}, new int[2]{2, 8}, "Vencedor é: Hunter, com 8 votos")]
        [InlineData(new string[4]{"Dragon", "Hunter", "Knight", "Vecktor"}, new int[4]{0, 5, 9, 3}, "Vencedor é: Knight, com 9 votos")]
        public void exercise6(string[] candidates, int[] votes, string expected)
        {
            // Dado / Setup
            var exercises = new Program();
            
            // Quando / Ação
            string returned = exercises.Exercise6(candidates.ToList(), votes.ToList());

            // Deve / Asserções
            Assert.Equal(expected, returned);
        }

        [Theory]
        [InlineData(1, 3, 3.99, 4369.05)]
        [InlineData(2, 7, 2.30, 11753)]
        [InlineData(1, 1, 12.00, 4380)]
        [InlineData(2, 2.5, 1.30, 2372.5)]
        public void exercise7(int years, double perDay, double price, double expected)
        {
            // Dado / Setup
            var exercises = new Program();
            
            // Quando / Ação
            double returnedExercise = exercises.Exercise7(years, perDay, price);

            // Deve / Asserções
            Assert.Equal(expected, returnedExercise);
        }
        [Theory]
        [InlineData(6, 3, "multiple")]
        [InlineData(-6, -3, "multiple")]
        [InlineData(3, 6, "not multiple")]
        [InlineData(1, 1, "multiple")]
        [InlineData(1.30, 2.30, "not multiple")]
        public void exercise8(int firstNumber, int secondNumber, string expected)
        {
            // Dado / Setup
            var exercises = new Program();

            // Quando / Ação
            string returnedValues = exercises.Exercise8(firstNumber, secondNumber);

            // Deve / Asserções
            Assert.Equal(expected, returnedValues);
        }
       
        [Theory]
        [InlineData(10, 8, 1, "is bigger")]
        [InlineData(10, 8, 3, "isn't bigger")]
        [InlineData(10, 8, 2, "equal")]
        [InlineData(2.30, 1.30, 0.50,"is bigger")]
        [InlineData(-1.30, -2.30, -0.50,"is bigger")]
        public void exercise9(double firstNumber, double secondNumber, double thridNumber, string expected)
        {
            // Dado / Setup
            var exercises = new Program();

            // Quando / Ação
            string returnedValues = exercises.Exercise9(firstNumber, secondNumber, thridNumber);

            // Deve / Asserções
            Assert.Equal(expected, returnedValues);
        }
        
        [Theory]
        [InlineData(4646, 3410, "FirstNumber is bigger")]
        [InlineData(-12, -8, "SecondNumber is bigger")]
        [InlineData(10.30, 10.30, "They are equal")]
        public void exercise10(double firstNumber, double secondNumber, string expected)
        {
//10)Ler 02 números reais do teclado (A e B), verificar e imprimir qual deles é maior, 
//ou a mensagem "A = B" caso sejam iguais.
            
            // Dado / Setup
            var exercises = new Program();

            // Quando / Ação
            string returnedValue = exercises.Exercise10(firstNumber, secondNumber);

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }
        [Theory]
        [InlineData(10, 5, "2")]
        [InlineData(-10, -5, "2")]
        [InlineData(12, 0, "DIVISÃO POR ZERO")]
        [InlineData(12.5, 8.5, "1,4705882352941178")]
        public void exercise11(double firstNumber, double secondNumber, string expected)
        {
            // Dado / Setup
            var exercises = new Program();

            // Quando / Ação
            string returnedValue = exercises.Exercise11(firstNumber, secondNumber);

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }   
       
        [Theory]
        [InlineData(new int[4]{1, 2, 3, 4}, 6)]
        [InlineData(new int[3]{18, 23, 24}, 42)]
        [InlineData(new int[5]{17, 22, 91, 32, 35}, 54)]
        [InlineData(new int[2]{18, 17}, 18)]
        public void exercise12(int[] numbers, double expected)
        {
            // Dado / Setup
            var exercises = new Program();

            // Quando / Ação
            double returnedValue = exercises.Exercise12(numbers.ToList());
            
            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }  

        [Theory]
        [InlineData(new double[10]{1,2,3,4,5,6,7,8,9,10}, 10)]
        [InlineData(new double[3]{18, 23, 24}, 24)]
        [InlineData(new double[5]{17, 22, 91, 91.1, 35}, 91.1)]
        [InlineData(new double[2]{-18, -17}, -17)]
        public void exercise13(double[] numbers, double expected)
        {
            // Dado / Setup
            var exercises = new Program();

            // Quando / Ação
            double returnedValue = exercises.Exercise13(numbers.ToList());

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }   
       
        [Theory]
        [InlineData(28, 1, 17, "1,17,28")]
        [InlineData(-32, -13, -24, "-32,-24,-13")]
        [InlineData(9.99, 5.65, -17, "-17,5,65,9,99")]
        public void exercise14(double firstNumber, double secondNumber, double thridNumber, string expected)
        {
            // Dado / Setup
            var exercises = new Program();

            // Quando / Ação
            string returnedValue = exercises.Exercise14(firstNumber, secondNumber, thridNumber);

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }   
       
        [Theory]
        [InlineData(new double[10]{5, 9.99, 18, 10, 9, 69, 6, 24, 9, 39}, "7,2")]
        [InlineData(new double[5]{18, 23, -24, -25, -50}, "2,2")]
        [InlineData(new double[3]{17.5, 22.35, 12.50}, "0,0")]
        public void exercise15(double[] numbers, string expected)
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            string returnedValue = exercises.Exercise15(numbers.ToList());

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }
       
        [Theory]
        [InlineData(560, "ISENTO")]
        [InlineData(700, "20% = 560")]
        [InlineData(1800, "25% = 1350")]
        [InlineData(10000, "30% = 7000")]
        public void exercise16(double salary, string expected)
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            string returnedValue = exercises.Exercise16(salary);

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }   
        
        [Theory]
        [InlineData(1, new int[10]{1,2,3,4,5,6,7,8,9,10})]
        [InlineData(2, new int[10]{2,4,6,8,10,12,14,16,18,20})]
        [InlineData(3, new int[10]{3,6,9,12,15,18,21,24,27,30})]
        [InlineData(4, new int[10]{4,8,12,16,20,24,28,32,36,40})]
        [InlineData(5, new int[10]{5,10,15,20,25,30,35,40,45,50})]
        [InlineData(6, new int[10]{6,12,18,24,30,36,42,48,54,60})]
        [InlineData(7, new int[10]{7,14,21,28,35,42,49,56,63,70})]
        [InlineData(8, new int[10]{8,16,24,32,40,48,56,64,72,80})]
        [InlineData(9, new int[10]{9,18,27,36,45,54,63,72,81,90})]
        [InlineData(10, new int[10]{10,20,30,40,50,60,70,80,90,100})]
        public void exercise17(int tabuada, int[] expected)
        {
        
            // Dado / Setup
            var exercises = new Program();
            //var tabuada = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
                            
            // Quando / Ação
            int[] returnedValues = exercises.Exercise17(tabuada);
            
            // Deve / Asserções
            Assert.Equal(expected, returnedValues);
        }
       
        [Theory]
        [InlineData(12, "R$12")]
        [InlineData(11, "R$14,3")]
        [InlineData(-1, "número de maçãs inválido!")]
        public void exercise18(int apples, string expected)
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            string returnedValues = exercises.Exercise18(apples);

            // Deve / Asserções
            Assert.Equal(expected, returnedValues);
        }
    }
}