using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
static void Main(string[] args)
{
    // Realizar un programa de computadora que haga el cálculo
    // del área y perímetro de un rectangulo

    // Variables
    double altura, ancho, area, perimetro;

    // Pedimos la altura y convertimos a tipo double
    Console.Write("Dame la altura: ");
    altura = Convert.ToDouble(Console.ReadLine());

    // Pedimos la ancho y convertimos a tipo double
    Console.Write("Dame la base: ");
    ancho = Convert.ToDouble(Console.ReadLine());

    // Calculamos el área
    area = altura * ancho;

    // Calculamos el perímetro
    perimetro = 2 * (altura + ancho);

    // Mostramos los resultados en pantalla
    Console.WriteLine("El área es: {0}", area);
    Console.WriteLine("El perímetro es: {0}", perimetro);
}
    }
}
