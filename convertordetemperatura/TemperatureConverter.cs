using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace convertordetemperatura
{
   public static class TemperatureConverter
{
public static double CelsiusToFahrenheit(string temperatureCelsius)
{
// conversia argumentului din string în double
double celsius = Convert.ToDouble(temperatureCelsius);
// conversia din grade Celsius în grade Fahrenheit
double fahrenheit = (celsius * 9 / 5) + 32;
return fahrenheit;
}
public static double FahrenheitToCelsius(string temperatureFahrenheit)
{
double fahrenheit = Convert.ToDouble(temperatureFahrenheit);
double celsius = (fahrenheit - 32) * 5 / 9;
return celsius;
}
}
}
