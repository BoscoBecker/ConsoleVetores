﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleVetores.Vetor
{
    class VetorArray
    {
        private double[] vet;
        private double sum;

        public void AdicionarQuantidadeVetor(int quantidade)
        {
            vet = new double[quantidade];

            for (int i = 0; i < quantidade; i++)
            {
                vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                sum += vet[i];
            }
            Console.WriteLine("A média é: " + this.Avg(sum, quantidade));

        }
        private double Avg(double soma, double quantidade)
        {
            return (soma / quantidade);

        }

    }
}
