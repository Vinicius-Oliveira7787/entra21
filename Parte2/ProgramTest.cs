using System.Collections.Generic;
using Xunit;

namespace Entra21_2
{
    public class ProgramTest
    {
        [Fact]
        public void exercise1A_should_return_an_array_from_1_to_10()
        {
            var exercicio1 = new Program();
            var result = exercicio1.Exercise1A();

            var resultadoEsperado = new int[10] 
            {1,2,3,4,5,6,7,8,9,10};

            for (int i = 0; i < resultadoEsperado.Length; i++)
            {
            Assert.Equal(resultadoEsperado[i], result[i]);
            }
        }
        [Fact]
        public void exercise1B_should_return_an_array_from_10_to_1()
        {
            var exercicio1 = new Program();
            var result = exercicio1.Exercise1B();

            var resultadoEsperado = new int[10] 
            {10,9,8,7,6,5,4,3,2,1};

            for (int i = 0; i < result.Length; i++)
            {
            Assert.Equal(resultadoEsperado[i], result[i]);
            }
        }
        [Fact]
        public void exercise1C_should_return_an_array_from_1_to_10_only_pairs()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1c,
            // então a aplicação deverá retornar os números de 1 a 10, mas somente os pares

            // Dado / Setup
            var exercises = new Program();

            // Quando / Ação
            int[] returnedValues = exercises.Exercise1C();

            // Deve / Asserções
            var expectedOutput = new int[5]
            {
                2,4,6,8,10
            };
            //var expectedOutput = new int[]
            //{
            //1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47
            //49, 51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73, 75, 77, 79, 81, 83, 85,87,89,91,93,95,97,99,101,103,105,
            //107,109,111,113,115,117,119,121,123,125,127,129,131,133,135,137,139,141,143,145,147,149,151,153,155,157,
            //159,161,163,165,167,169,171,173,175,177,179,181,183,185,187,189,191,193,195,197,199
            //}

            Assert.Equal(5, returnedValues.Length);

            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], returnedValues[i]);
            }
        }
        [Fact]
        public void exercise2_should_return_5050_the_final_result_from_the_sum_between_1_to_100()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1c,
            // então a aplicação deverá retornar os números de 1 a 10, mas somente os pares

            // Dado / Setup
            var exercises = new Program();

            // Quando / Ação
            int returnedValues = exercises.Exercise2();

            // Deve / Asserções
           int expectedOutput = 5050;
           
           Assert.Equal(expectedOutput, returnedValues);
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
            var expectedOutput = new int[]
            {
            1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21, 23, 25, 27, 29, 31, 33, 35, 37, 39, 41, 43, 45, 47,
            49, 51, 53, 55, 57, 59, 61, 63, 65, 67, 69, 71, 73, 75, 77, 79, 81, 83, 85,87,89,91,93,95,97,99,101,103,105,
            107,109,111,113,115,117,119,121,123,125,127,129,131,133,135,137,139,141,143,145,147,149,151,153,155,157,
            159,161,163,165,167,169,171,173,175,177,179,181,183,185,187,189,191,193,195,197,199
            };

            Assert.Equal(199, returnedValues.Length);

            for (int i = 0; i < expectedOutput.Length; i++)
            {
                Assert.Equal(expectedOutput[i], returnedValues[i]);
            }
        }
        [Fact]
        public void exercise4_should_calculate_the_average_of_the_class_and_stop_when_the_user_digit_equal_0()
        {
            // Dado que a aplicação está preparada. Quando o usuário chamar o exercício 1c,
            // então a aplicação deverá retornar os números de 1 a 10, mas somente os pares

            // Dado / Setup
            var exercises = new Program();
            
            // Criando uma lista com o número 5 na primeira posição e o número 9 na segunda
            var myList = new List<int>() {5, 9} ;

            // Quando / Ação
            double returnedValues = exercises.Exercise4(myList);

            // Deve / Asserções
            var expectedOutput = 7;

            Assert.Equal(expectedOutput, returnedValues);
        }
        [Fact]
        public void exercise5_should_60_percent_when_passed_18_23_and_24()
        {
            // Dado / Setup
            var exercises = new Program();
            
            var myList = new List<int>() {18, 23, 17, 36, 24};

            // Quando / Ação
            double returnedValues = exercises.Exercise5(myList);

            // Deve / Asserções
            var expectedOutput = 60;

            Assert.Equal(expectedOutput, returnedValues);
        }
        [Fact]
        public void exercise6()
        {
            // Dado / Setup
            var exercises = new Program();
            
            var candidates = new List<string>() {"Superman", "Batman"};

            // Quando / Ação
            string returnedPassword = exercises.Exercise6Cadastro();
            string returnedVotes = exercises.Exercise6Votos(candidates);
            string returnedVotesSecondTurn = exercises.Exercise6SecondTurn(candidates);

            // Deve / Asserções
            var expectedOutput = "Pa$$w0rd";
            var espectedWinner = "Superman";
            //var espectedWinner = "Batman";
            var espectedSecondTurn = "SEGUNDO TURNO";

            Assert.Equal(expectedOutput, returnedPassword);
            Assert.Equal(espectedWinner, returnedVotes);
            Assert.Equal(espectedSecondTurn, returnedVotesSecondTurn);
        }
        [Fact]
        public void exercise7_should_return_11753()
        {
            // Dado / Setup
            var exercises = new Program();
            
            // Quando / Ação
            double returnedExercise = exercises.Exercise7();

            // Deve / Asserções
            var expectedOutput = 11753;

            Assert.Equal(expectedOutput, returnedExercise);
        }
        [Fact]
        public void exercise8_read_two_numbers_X_Y_and_show_the_message_if_X_is_multiple_of_Y()
        {
            // Dado / Setup
            var exercises = new Program();

            // Quando / Ação
            string returnedValuesTrue = exercises.Exercise8True();
            string returnedValuesFalse = exercises.Exercise8False();

            // Deve / Asserções
            var expectedOutputTrue = "multiplo";
            var expectedOutputFalse = "não é multiplo";

            Assert.Equal(expectedOutputTrue, returnedValuesTrue);
            Assert.Equal(expectedOutputFalse, returnedValuesFalse);
        }
        [Fact]
        public void exercise9_read_three_numbers_and_check_if_the_firstNumber_is_bigger_then_the_sum_of_the_other_ones()
        {
            // Dado / Setup
            var exercises = new Program();

            // Quando / Ação
            string returnedValuesTrue = exercises.Exercise9True();
            string returnedValuesFalse = exercises.Exercise9False();
            string returnedValuesEqual = exercises.Exercise9Equal();
            

            // Deve / Asserções
            var expectedOutputTrue = "is bigger";
            var expectedOutputFalse = "isn't bigger";
            var expectedOutputEqual = "equal";

            Assert.Equal(expectedOutputTrue, returnedValuesTrue);
            Assert.Equal(expectedOutputFalse, returnedValuesFalse);
            Assert.Equal(expectedOutputEqual, returnedValuesEqual);
        }
        [Fact]
        public void exercise10_compare_two_numbers_and_check_who_is_the_bigger_one_or_if_they_are_equal()
        {
            //10)Ler 02 números reais do teclado (A e B), verificar e imprimir qual deles é maior, 
            //ou a mensagem "A = B" caso sejam iguais.
            // Dado / Setup
            var exercises = new Program();

            // Quando / Ação
            string returnedValueFirstNumberBigger = exercises.Exercise10FirstNumberBigger();
            string returnedValueSecondNumberBigger = exercises.Exercise10SecondNumberBigger();
            string returnedValueTheyAreEqual = exercises.Exercise10Equal();

            string expectedOutputFirstNumberBigger = "FirstNumber is bigger";
            string expectedOutputSecondNumberBigger = "SecondNumber is bigger";
            string expectedOutputTheyAreEqual = "They are equal";
            
            Assert.Equal(expectedOutputFirstNumberBigger, returnedValueFirstNumberBigger);
            Assert.Equal(expectedOutputSecondNumberBigger, returnedValueSecondNumberBigger);
            Assert.Equal(expectedOutputTheyAreEqual, returnedValueTheyAreEqual);
        }
        [Fact]
        public void exercise11()
        {
            // Dado / Setup
            var exercises = new Program();

            // Quando / Ação
            double returnedValue = exercises.Exercise11();
            string returnedValueDivisionByZero = exercises.Exercise11ButIsDivisionByZero();

            double expectedOutput = 2;
            string expectedOutputDivisionByZero = "DIVISÃO POR ZERP";
            
            Assert.Equal(expectedOutput, returnedValue);
            Assert.Equal(expectedOutputDivisionByZero, expectedOutputDivisionByZero);
        }   
        [Fact]
        public void exercise12()
        {
            // Dado / Setup
            var exercises = new Program();

            // Quando / Ação
            double returnedValue = exercises.Exercise12();

            double expectedOutput = 6;
            
            Assert.Equal(expectedOutput, returnedValue);
        }   
        [Fact]
        public void exercise13()
        {
            // Dado / Setup
            var exercises = new Program();

            // Quando / Ação
            double returnedValue = exercises.Exercise13();

            double expectedOutput = 10;
            
            Assert.Equal(expectedOutput, returnedValue);
        }   
        [Fact]
        public void exercise14()
        {
            // Dado / Setup
            var exercises = new Program();
            double firstNumber = 28;
            double secondNumber = 1;
            double thridNumber = 17;

            // Quando / Ação
            string returnedValue = exercises.Exercise14(firstNumber, secondNumber, thridNumber);

            string expectedOutput = "1,17,28";
            
            Assert.Equal(expectedOutput, returnedValue);
        }   
        [Fact]
        public void exercise15()
        {
            // Dado / Setup
            var exercises = new Program();
            var numbers = new List<double>(10){5, 9.99, 18, 10, 9, 69, 6, 24, 9, 39};
                            
            // Quando / Ação
            string returnedValue = exercises.Exercise15(numbers);

            string expectedOutput = "7,2";
            
            Assert.Equal(expectedOutput, returnedValue);
        }
        [Fact]
        public void exercise16()
        {
            // Dado / Setup
            var exercises = new Program();
            var salary = new List<double>(){600, 975, 1400, 5000};
                            
            // Quando / Ação
            string returnedValue = exercises.Exercise16(salary);

            string expectedOutput = "ISENTO, 20%, 25%, 30%";
            
            Assert.Equal(expectedOutput, returnedValue);
        }   
        [Fact]
        public void exercise17()
        {
                //     Assert.Collection(
                // returnedValues,
                // item1 => { Assert.Equal(tabuada[i] * i, item1); },
                // item2 => { Assert.Equal(tabuada[i] * i, item2); },
                // item3 => { Assert.Equal(tabuada[i] * i, item3); },
                // item4 => { Assert.Equal(tabuada[i] * i, item4); },
                // item5 => { Assert.Equal(tabuada[i] * i, item5); },
                // item6 => { Assert.Equal(tabuada[i] * i, item6); },
                // item7 => { Assert.Equal(tabuada[i] * i, item7); },
                // item8 => { Assert.Equal(tabuada[i] * i, item8); },
                // item9 => { Assert.Equal(tabuada[i] * i, item9); },
                // item10 => { Assert.Equal(tabuada[i] * i, item10); });
            // Dado / Setup
            var exercises = new Program();
            var tabuada = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
                            
            // Quando / Ação
            List<double> returnedValues = exercises.Exercise17(tabuada);

            var expectedOutput = new List<double>()
            {
                1,2,3,4,5,6,7,8,9,10,2,4,6,8,10,12,14,16,18,20,3,6,9,12,15,18,21,24,27,30,4,8,12,16,20,24,28,32,36,40,5,10,15,20,25,30,35,40,45,50,6,12,18,24,30,36,42,48,54,60,7,14,21,28,35,42,49,56,63,70,8,16,24,32,40,48,56,64,72,80,9,18,27,36,45,54,63,72,81,90,10,20,30,40,50,60,70,80,90,100
            };
           
            Assert.Equal(expectedOutput, returnedValues);
        }
                [Fact]
        public void exercise18()
        {

            // Dado / Setup
            var exercises = new Program();
            var appleList = new List<double>(){12, 24, 10};
                            
            // Quando / Ação
            List<string> returnedValues = exercises.Exercise18(appleList);

            var expectedOutput = new List<string>(){"R$12", "R$24", "R$13"};

            Assert.Equal(expectedOutput, returnedValues);
        }
        // [Fact]
        // public void exercise27()
        // {
        //     // Dado / Setup
        //     var exercises = new Program();
        //     var salary = new List<double>(){600, 975, 1400, 5000};
                            
        //     // Quando / Ação
        //     string returnedValue = exercises.Exercise27();

        //     //string expectedOutput = "ISENTO, 20%, 25%, 30%";
            
        //     //Assert.Equal(expectedOutput, returnedValue);
        // }      
    }
}