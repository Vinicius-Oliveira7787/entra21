using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Exercises2
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(new double[15]{24, 48, 20, 50,12,5,69,345,47,69,70,363,1651,152,1216}, new double[15]{12, 24, 10, 25, 6,25,54,25,95,248,154,125,384,1684,134}, new double[15]{12,24,10,25,6,-20,15,320,-48,-179,-84,238,1267,-1532,1082})]
        public void ExerciseArrays1Q1(double[] arrayA, double[] arrayB, double[] expected)
        {

            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            List<double> returnedValues = exercises.ExerciseArrays1Q1(arrayA.ToList(), arrayB.ToList());

            // Deve / Asserções
            Assert.Equal(expected, returnedValues);
        }
        
        public static TheoryData<(List<double>, List<(double,double)>)> questionThereeTest()
        {
            return new TheoryData<(List<double>, List<(double, double)>)>
            {
                (new List<double>{12, 24, 10, 25, 6, 25, 54, 25, 95, 248}
                    , new List<(double,double)>{(12,248), (24,95), (10,25), (25,54),
                    (6,25), (25,6), (54,25), (25,10), (95,24), (248,12)}),

                (new List<double>{-15, 22.5, 524, 123, 6}
                    , new List<(double,double)>{(-15,6), (22.5,123), (524,524), (123,22.5), (6,-15)})
            };
        }

        [Theory]
        [MemberData(nameof(questionThereeTest))]
        public void ExerciseArrays1Q2((List<double>, List<(double,double)>) myList)
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            var returnedValues = exercises.Exercise2(myList.Item1);

            // Deve / Asserções
            Assert.Equal(myList.Item2, returnedValues);
        }    
        
        [Theory]
        [InlineData(25, new double[10]{12, 24, 10, 25, 6, 25, 54, 25, 95, 248}, "O número existe no array")]
        [InlineData(26, new double[10]{12, 24, 10, 25, 6, 25, 54, 25, 95, 248}, "Número inexistente")]
        public void ExerciseArrays1Q3(double search, double[] array, string expected)
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            var returnedAnswer = exercises.Exercise3(search, array.ToList());

            // Deve / Asserções
            Assert.Equal(expected, returnedAnswer);
        }    
        
        [Theory]
        [InlineData(new double[10]{0, 2, 3, 1, 4, 25, 7, 8, 9, 15}, new double[10]{45, 5, 10, 12, 5, 10, 578, 29, 51, 54}, "Não são iguais")]
        public void ExerciseArrays1Q4(double[] firstArray, double[] secondArray, string expected)
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            string returnedAnswerFalse = exercises.Exercise4(firstArray.ToList(), secondArray.ToList());

            // Deve / Asserções
            Assert.Equal(expected, returnedAnswerFalse);
        } 
        
        [Theory]
        [InlineData(new double[4]{2,4,6,8}, "2, 0, 2")]
        [InlineData(new double[4]{12, -4, 20, -25}, "2, 0, 2")] 
        [InlineData(new double[4]{5.65, 2.5, 2.99, -2}, "3, 0, 1")] 
        [InlineData(new double[2]{2.99, 3}, "1, 0, 1")] 
        [InlineData(new double[2]{1, 1}, "0, 2, 0")] 
        [InlineData(new double[7]{0, -1, 2.1, 5, 90, 2.59, 03}, "1, 0, 6")] 
        public void ExerciseArrays1Q5(double[] myList, string expected)
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            string returnedAnswer = exercises.ExerciseArrays1Q5(myList.ToList());

            // Deve / Asserções
            Assert.Equal(expected, returnedAnswer);
        }
    }
}