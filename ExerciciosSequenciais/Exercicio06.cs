using System;

namespace ExerciciosSequenciais
{
    class Exercicio06
    {
        public static void Main(string[] args)
        {
           //Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. 
           //Em seguida, calcule e mostre: 
           //a) a área do triângulo retângulo que tem A por base e C por altura. 
            //b) a área do círculo de raio C. (pi = 3.14159) 
            //c) a área do trapézio que tem A e B por bases e C por altura. 
            //d) a área do quadrado que tem lado B. 
           //e) a área do retângulo que tem lados A e B.
           double a,b,c,areaTriangulo,areaCirculo,areaTrapezio,areaQuadrado,areaRetangulo;
           double pi=3.14159;

           string[] valores=Console.ReadLine().Split(' ');
           a=double.Parse(valores[0]);
           b=double.Parse(valores[1]);
           c=double.Parse(valores[2]);
           areaTriangulo=a*c/2;
           areaCirculo=pi*Math.Pow(c,2.0);
           areaTrapezio=(a+b)*c/2;
           areaQuadrado=Math.Pow(b,2.0);
           areaRetangulo=a*b;

           Console.WriteLine($"Triangulo: {areaTriangulo:F3}");
           Console.WriteLine($"Circulo: {areaCirculo:F3}");
           Console.WriteLine($"Trapezio: {areaTrapezio:F3}");
           Console.WriteLine($"Quadrado: {areaQuadrado:F3}");
           Console.WriteLine($"Retangulo: {areaRetangulo:F3}");
        }
    }
}