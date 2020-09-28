using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Exercises3
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new double[4]{1, 2, 3, 4}, new double[4]{5, 6, 7, 8}, new double[8]{0.5, 2, 4.5, 8, 12.5, 18, 24.5, 32})]
        public void Exercise1(double[] firstList, double[] secondList, double[] expected)
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            List<double> returnedAnswer = exercises.Exercise1(firstList.ToList(), secondList.ToList());

            // Deve / Asserções
            Assert.Equal(expected, returnedAnswer);
        }
       
        [Theory]
        [InlineData(new double[10]{1, 165, 21, 13, 541, 48, 416, 151, 25, 25}, true)]
        [InlineData(new double[10]{1, 2, 3, 4, 5, 6, 7, 8, 9, 10}, false)]
        public void Exercise2(double[] numbers, bool expected)
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            var returnedAnswer = exercises.Exercise2(numbers.ToList());

            // Deve / Asserções
            Assert.Equal(expected, returnedAnswer);
        }
       
        [Fact]
        public void Exercise3()
        {
            // Dado / Setup
            var exercises = new Program();
            (string gender, string genderAnswers) firstInterview = ("man", "not");
            (string gender, string genderAnswers) secondInterview = ("woman", "yes");
            (string gender, string genderAnswers) thirdInterview = ("woman", "not");
            var peopleInterviewed = new List<(string gender, string genderAnswers)>(){firstInterview, secondInterview, thirdInterview};

            // Quando / Ação
            var returnedGenderAnswers = exercises.Exercise3(peopleInterviewed);
         
            // Esperado
            (string percentageWomen, string percentageMen, int liked, int disliked) expected = ("50%", "100%", 2, 1);

            // Deve / Asserções
            Assert.Equal(expected, returnedGenderAnswers);
        }
       
        [Theory]
        [InlineData(new double[5]{1.5, 2.75, 4, 4, 15.2,}, 19.45)]
        [InlineData(new double[5]{0.1, 0.1, 4, 4, 0.1,}, 0.30000000000000004)]
        public void Exercise4(double[] numbers, double expected)
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            var returnedAnswer = exercises.ExerciseArrays2Q4(numbers.ToList());

            // Deve / Asserções
            Assert.Equal(expected, returnedAnswer);
        }
        
        [Theory]
        [InlineData(new double[12]{-1, 1.5, -6541, 12, 468, -654, -218, -41684, 2184, 11, 354, 15}, 7)]
        [InlineData(new double[12]{-1, 0.1, -6541, -12, -468, -654, -218, -41684, -2184, -11, -354, -15}, 1)]
        [InlineData(new double[12]{-1, -0.1, -6541, -12, -468, -654, -218, -41684, -2184, -11, -354, -15}, 0)]
        public void Exercise5(double[] List, double expected)
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            var returnedAnswer = exercises.ExerciseArrays2Q5(List.ToList());

            // Deve / Asserções
            Assert.Equal(expected, returnedAnswer);
        }
        
        [Theory]
        [InlineData(new double[12]{-1, 1.5, -6541, 12, 468, -654, -218, -41684, 2184, 11, 354, 15}, "Maior número: 2184, Posição do index: 8")]
        [InlineData(new double[12]{-1, -1.5, -6541, -12, -468, -654, -218, -41684, -2184, -11, -354, 0}, "Maior número: 0, Posição do index: 11")]
        [InlineData(new double[11]{-2, -1.5, -6541, -12, -468, -654, -218, -41684, -2184, -11, -354}, "Maior número: -1,5, Posição do index: 1")]
        public void Exercise6(double[] List, string expected)
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            var returnedAnswer = exercises.ExerciseArrays2Q6(List);

            // Deve / Asserções
            Assert.Equal(expected, returnedAnswer);
        }
        
        [Theory]
        [InlineData(new double[12]{0, 1, -6541, 12, 468, -654, -218, -41684, 2184, 11, 354, 15}, 2)]
        [InlineData(new double[4]{0, 1, 2, 3}, 4)]
        [InlineData(new double[1]{1}, 0)]
        public void Exercise7(double[] numbers, double expected)
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            double returnedAnswer = exercises.ExerciseArrays2Q7(numbers.ToList());

            // Deve / Asserções
            Assert.Equal(expected, returnedAnswer);
        }
        
        [Theory]
        [InlineData(new string[10]{"a", "b", "c", "d", "e", "f", "g", "h", "i", "j"}, 3)]
        [InlineData(new string[10]{"a", "a", "e", "e", "i", "i", "o", "o", "u", "u"}, 10)]
        [InlineData(new string[10]{"s", "b", "c", "d", "v", "f", "g", "h", "g", "j"}, 0)]
        public void Exercise8(string[] letters, int expected)
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            double returnedAnswer = exercises.ExerciseArrays2Q8(letters.ToList());

            // Deve / Asserções
            Assert.Equal(expected, returnedAnswer);
        }
        
        [Theory]
        [InlineData(new string[11]{"H", "b", "U", "d", "N", "f", "T", "h", "E", "j", "R"}, "HUNTER")]
        [InlineData(new string[11]{"K", "b", "N", "d", "I", "f", "G", "h", "H", "j", "T"}, "KNIGHT")]
        [InlineData(new string[11]{"D", "b", "R", "d", "A", "f", "G", "h", "O", "j", "N"}, "DRAGON")]
        public void Exercise9(string[] letters, string expected)
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            var returnedAnswer = exercises.ExerciseArrays2Q9(letters.ToList());

            // Deve / Asserções
            Assert.Equal(expected, returnedAnswer);
        }
    }
}
