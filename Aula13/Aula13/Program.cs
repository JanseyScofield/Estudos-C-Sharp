using Aula12_2;
using System;
using System.Formats.Asn1;
using System.IO;
Triangulo x, y;

x = new Triangulo();
y = new Triangulo();

Console.WriteLine("Entre com os lados do triângulo 1: ");
Console.WriteLine("Lado 1:");
x.A = double.Parse(Console.ReadLine());
Console.WriteLine("Lado 2:");
x.B = double.Parse(Console.ReadLine());
Console.WriteLine("Lado 3:");
x.C = double.Parse(Console.ReadLine());

Console.WriteLine("Entre com os lados do triângulo 2: ");
Console.WriteLine("Lado 1:");
y.A = double.Parse(Console.ReadLine());
Console.WriteLine("Lado 2:");
y.B = double.Parse(Console.ReadLine());
Console.WriteLine("Lado 3:");
y.C = double.Parse(Console.ReadLine());

double areax = x.Area();
double areay = y.Area();

Console.WriteLine($"A área do triângulo 1 é igual a {areax:F4} m².");
Console.WriteLine($"A área do triângulo 2 é igual a {areay:F4} m².");