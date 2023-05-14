/*using System;

namespace ExerciciosSequenciais
{
    class Exercicio05
    {
        public static void Main(string[] args)
        {
           //Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, 
           //o código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. 
           //Calcule e mostre o valor a ser pago.
            int codigo1,codigo2,qtd1,qtd2;
            double valor1,valor2;
            double valorFinal=0.0;

            string[] valores=Console.ReadLine().Split(' ');
            codigo1=int.Parse(valores[0]);
            qtd1=int.Parse(valores[1]);
            valor1=double.Parse(valores[2]);
            valorFinal+=qtd1*valor1;

            string [] valores2=Console.ReadLine().Split(' ');
            codigo2=int.Parse(valores2[0]);
            qtd2=int.Parse(valores2[1]);
            valor2=double.Parse(valores2[2]);

            valorFinal+=qtd2*valor2;

            Console.WriteLine($"Valor a pagar: R$ {valorFinal:F2}");
        }
    }
}*/