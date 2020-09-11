using System;
using System.Collections.Generic;
using Xunit;

namespace Exercises3
{
    public class UnitTest1
    {
        [Fact]
        public void ExerciseArrays2Q1()
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            List<double> returnedAnswer = exercises.ExerciseArrays2Q1();

            var expectedOutput = new List<double>(){0.5, 2, 4.5, 8, 12.5, 18, 24.5, 32};

            Assert.Equal(expectedOutput, returnedAnswer);
        }
        [Fact]
        public void ExerciseArrays2Q2()
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            bool returnedAnswer = exercises.ExerciseArrays2Q2();

            var expectedOutput = true;

            Assert.Equal(expectedOutput, returnedAnswer);
        }
        [Fact]
        public void ExerciseArrays2Q3ReturnYesOrNo()
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            string returnedAnswer = exercises.ExerciseArrays2Q3YesOrNo();
            string returnedGenderAnswers = exercises.ExerciseArrays2Q3PercentageMenDislikedWomenLiked();

            var expectedOutput = "4 pessoas gostaram, 6 pessoas não gostaram";
var expectedOutputPercentageMenDislikedWomenLiked = "30% dos homens não gostaram, 20% das mulheres gostaram";

            Assert.Equal(expectedOutput, returnedAnswer);
            Assert.Equal(expectedOutputPercentageMenDislikedWomenLiked, returnedGenderAnswers);
        }
        [Fact]
        public void ExerciseArrays2Q4()
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            double returnedAnswer = exercises.ExerciseArrays2Q4();

            var expectedOutput = 19.45;

            Assert.Equal(expectedOutput, returnedAnswer);
        }
        [Fact]
        public void ExerciseArrays2Q5()
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            double returnedAnswer = exercises.ExerciseArrays2Q5();

            var expectedOutput = 7;

            Assert.Equal(expectedOutput, returnedAnswer);
        }
        [Fact]
        public void ExerciseArrays2Q6()
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            string returnedAnswer = exercises.ExerciseArrays2Q6();

            var expectedOutput = $"Maior número: 2184, Posição do index: 8";

            Assert.Equal(expectedOutput, returnedAnswer);
        }
        [Fact]
        public void ExerciseArrays2Q7()
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            double returnedAnswer = exercises.ExerciseArrays2Q7();

            var expectedOutput = 2;

            Assert.Equal(expectedOutput, returnedAnswer);
        }
        [Fact]
        public void ExerciseArrays2Q8()
        {
            // Dado / Setup
            var exercises = new Program();
            var letters = new List<string>(){"a", "b", "c", "d", "e", "f", "g", "h", "i", "j"};
                            
            // Quando / Ação
            double returnedAnswer = exercises.ExerciseArrays2Q8(letters);

            var expectedOutput = 3;

            Assert.Equal(expectedOutput, returnedAnswer);
        }
        [Fact]
        public void ExerciseArrays2Q9()
        {
            // Dado / Setup
            var exercises = new Program();
            var letters = new List<string>(){"H", "b", "U", "d", "N", "f", "T", "h", "E", "j", "R"};
                            
            // Quando / Ação
            string returnedAnswer = exercises.ExerciseArrays2Q9(letters);

            var expectedOutput = "HUNTER";

            Assert.Equal(expectedOutput, returnedAnswer);
        }
    }
}
