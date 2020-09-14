using Xunit;
using System.Collections.Generic;
using System.Linq;

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
        [InlineData(new string[12]{}, "029")]
        [InlineData(3, 30, 100, "350")]
        [InlineData(2.5, 30.5, 100.99, "304")]
        public void one_leter_per_time_and_should_stop_when_digit_equal_finalizar(string[] leters, string expected)
        {
            // Dado / Setup
            var exercises = new Program();
                            
            // Quando / Ação
            string returnedValue = exercises.Exercise2(leters.ToList);

            // Deve / Asserções
            Assert.Equal(expected, returnedValue);
        }
    }
}