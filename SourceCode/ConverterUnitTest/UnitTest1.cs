using TestAssignment1.Converters;
using Xunit;
namespace ConverterUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public static void ConvertBetweenFahrenAndCelcius_Should_Return_Celcius_When_Feeding_Fahrenheit()
        {
            // Arrange
            var fahrenheit = 10f;
            var expected = -12.2;

            // Act
            var fahrenheitToCelcius = Converter.ConvertBetweenFahrenAndCelcius(fahrenheit, Converter.MeasurementUnits.Fahrenheit);

            // Assert
            Assert.Equal(expected, fahrenheitToCelcius);
        }

        [Fact]
        public void ConvertBetweenFahrenAndCelcius_Should_Return_Fahrenheit_When_Feeding_Celcius()
        {

            // Arrange
            var celcius = 25.4f;
            var expected = 77.7;

            // Act
            var fahrenheitToCelcius = Converter.ConvertBetweenFahrenAndCelcius(celcius, Converter.MeasurementUnits.Celcius);

            // Assert
            Assert.Equal(expected, fahrenheitToCelcius);
        }

        [Fact]
        public void ArabicToRomanNumerals_Should_ReturnRomanNumerals_When_ArabicNum_Specified()
        {
            // Arrange
            var arabicNum = 1234;
            var expected = "MCCXXXIV";

            // Act
            var romanLiterals = Converter.ArabicToRomanNumerals(arabicNum);

            // Assert
            Assert.Equal(expected, romanLiterals);
        }
    }
}