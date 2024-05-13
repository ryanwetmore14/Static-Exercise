namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celcius = TempCoverter.FahrenheitToCelsius(68);

            var fahrenheit = TempCoverter.CelciusToFahrenheit(20);

            Console.WriteLine("After Conversion:");
            Console.WriteLine($"celcius {celcius}");
            Console.WriteLine($"fahrenheit {fahrenheit}");

        }
    }
}
