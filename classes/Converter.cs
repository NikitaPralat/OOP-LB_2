using System;
using System.Collections.Generic;
using System.Text;

namespace LB_2.classes
{
    class Converter
    {
        double usd;
        double eur;
        double rub;
        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public void convertFromUAH()
        {
            Console.WriteLine("количество гривен");
            double uan = Convert.ToDouble(Console.ReadLine());

            double rub = uan * this.rub;
            double eur = uan * this.eur;
            double usd = uan * this.usd;
            Console.WriteLine($"{uan} гривен = {rub} рублей, {eur} евро, {usd} долларов");
        }

        public void convertToUAH()
        {
            Console.Write(
                "С какой валюте конвертировать:\n" +
                "1.RUB\n" +
                "2.USD\n" +
                "3.EUR\n" +
                "--> ");
            int from = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("сколько");
            double num = Convert.ToDouble(Console.ReadLine());

            double uan;
            switch (from)
            {
                case 1:
                    {
                        uan = num / this.rub;
                        Console.WriteLine($"{num} рублей = {uan} гривен");
                    }
                    break;
                case 2:
                    {
                        uan = num / this.usd;
                        Console.WriteLine($"{num} долларiв = {uan} гривен");
                    }
                    break;
                case 3:
                    {
                        uan = num / this.eur;
                        Console.WriteLine($"{num} евро = {uan} гривен");
                    }
                    break;
            }
        }
    }
}
