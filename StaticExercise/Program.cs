namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(32);
            Console.WriteLine($"98 Fahrenheit is {celsius} degrees Celsius.");

            var fahrenheit = TempConverter.CelsiusToFahrenheit(celsius);
            Console.WriteLine($"It is {fahrenheit} converted back to Fahrenheit.");

        }
    }
}
