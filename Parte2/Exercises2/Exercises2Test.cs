using System.Collections.Generic;
using Xunit;

namespace Exercises2
{
    public class UnitTest1
    {
        [Fact]
        public void ExerciseArrays1Q1()
        {

            // Dado / Setup
            var exercises = new Program();
            var arrayA = new List<double>(){24, 48, 20, 50,12,5,69,345,47,69,70,363,1651,152,1216};
            var arrayB = new List<double>(){12, 24, 10, 25, 6,25,54,25,95,248,154,125,384,1684,134};
                            
            // Quando / Ação
            List<double> returnedValues = exercises.ExerciseArrays1Q1(arrayA, arrayB);

            var expectedOutput = new List<double>(){12,24,10,25,6,-20,15,320,-48,-179,-84,238,1267,-1532,1082};

            Assert.Equal(expectedOutput, returnedValues);
        }
        [Fact]
        public void ExerciseArrays1Q2()
        {
            // Dado / Setup
            var exercises = new Program();
            var arrayA = new List<double>(){12, 24, 10, 25, 6, 25, 54, 25, 95, 248};
                            
            // Quando / Ação
            List<double> returnedValuesDireto = exercises.ExerciseArrays1Q2Direto(arrayA);
            List<double> returnedValuesInverso = exercises.ExerciseArrays1Q2Inverso(arrayA);

            var ordemDireta = new List<double>(){12, 24, 10, 25, 6, 25, 54, 25, 95, 248};
            var ordemInversa = new List<double>(){248, 95, 25, 54, 25, 6, 25, 10, 24, 12};

            Assert.Equal(ordemDireta, returnedValuesDireto);
            Assert.Equal(ordemInversa, returnedValuesInverso);
        }   
        [Fact]
        public void ExerciseArrays1Q3()
        {
            // Dado / Setup
            var exercises = new Program();
            var arrayA = new List<double>(){12, 24, 10, 25, 6, 25, 54, 25, 95, 248};
                            
            // Quando / Ação
            string returnedAnswerTrue = exercises.ExerciseArrays1Q3True(arrayA);
            string returnedAnswerFalse = exercises.ExerciseArrays1Q3False(arrayA);

            string expectedOutputTrue = "O número existe no array";
            string expectedOutputFalse = "Número inexistente";

            Assert.Equal(expectedOutputTrue, returnedAnswerTrue);
            Assert.Equal(expectedOutputFalse, returnedAnswerFalse);
        }    
        [Fact]
        public void ExerciseArrays1Q4()
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            string returnedAnswerTrue = exercises.ExerciseArrays1Q4True();
            string returnedAnswerFalse = exercises.ExerciseArrays1Q4False();

            string expectedOutputTrue = "São iguais";
            string expectedOutputFalse = "Não são iguais";

            Assert.Equal(expectedOutputTrue, returnedAnswerTrue);
            Assert.Equal(expectedOutputFalse, returnedAnswerFalse);
        } 
        [Fact]
        public void ExerciseArrays1Q5()
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            string returnedAnswer = exercises.ExerciseArrays1Q5();

            string expectedOutput = "2, 0, 2";

            Assert.Equal(expectedOutput, returnedAnswer);
        }
    }
}