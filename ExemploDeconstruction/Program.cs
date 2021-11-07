static (double tempFahrenheit, double tempCelsius, double tempKelvin)
    ConverterTemperaturas(double valorFahrenheit)
{
    double retCelsius = Math.Round((valorFahrenheit - 32) / 1.8, 2);
    double retKelvin = retCelsius + +273.15;

    return (valorFahrenheit, retCelsius, retKelvin);
}


Console.WriteLine("..... Melhorias no uso de Tuplas | C# 10 + .NET 6 .....");
Console.WriteLine("Conversão de temperaturas");

// Exemplo simples
var resultado1 = ConverterTemperaturas(86);
Console.WriteLine($"Fahrenheit = {resultado1.tempFahrenheit} - " +
                    $"Celsius = {resultado1.tempCelsius} - " +
                    $"Kelvin = {resultado1.tempKelvin}");

// Exemplo 1 - Desconstrução
(double resFahrenheit2, double resCelsius2, double resKelvin2) =
    ConverterTemperaturas(32);
Console.WriteLine($"Fahrenheit = {resFahrenheit2} - " +
                  $"Celsius = {resCelsius2} - " +
                  $"Kelvin = {resKelvin2}");

// Exemplo 2 - Desconstrução
double valorFahrenheit3 = 212;
(_, double resCelsius3, double resKelvin3) =
    ConverterTemperaturas(valorFahrenheit3);
Console.WriteLine($"Fahrenheit = {valorFahrenheit3} - " +
                  $"Celsius = {resCelsius3} - " +
                  $"Kelvin = {resKelvin3}");

// Exemplo 3 - Desconstrução
double resFahrenheit4;
double resCelsius4;
double resKelvin4;
(resFahrenheit4, resCelsius4, resKelvin4) =
    ConverterTemperaturas(86);
Console.WriteLine($"Fahrenheit = {resFahrenheit4} - " +
                  $"Celsius = {resCelsius4} - " +
                  $"Kelvin = {resKelvin4}");

// Exemplo 4 - Desconstrução - Novidade do C# 10
double resFahrenheit5;
double resCelsius5;
(resFahrenheit5, resCelsius5, double resKelvin5) =
    ConverterTemperaturas(71.6);
Console.WriteLine($"Fahrenheit = {resFahrenheit5} - " +
                  $"Celsius = {resCelsius5} - " +
                  $"Kelvin = {resKelvin5}");

Console.WriteLine("Testes concluídos!");