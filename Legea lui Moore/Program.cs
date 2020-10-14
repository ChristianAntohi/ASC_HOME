﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Legea_lui_Moore
{
    class Program
    {
        static void Main(string[] args)
        {
            //Demonstrarea solutiei legii lui Moore
            //La fiecare 1.5 ani (18 luni) puterea de calcul al procesoarelor creste de 2x ori
            //Pentru e demonstra aceasta vom folosi log in baza 2 pentru a afla in cati ani va creste puterea de calcul de n ori
            Console.WriteLine("Legea lui Moore spune ca puterea de calcul se dubleaza la fiecare 18 luni");
            Console.WriteLine("Programul respectiv va permite afisarea timpului ramas pana cand puterea de calcul va creste de n ori");
            Console.Write("Introdu de cate ori va creste puterea de calcul n=");
            
            
                int n = int.Parse(Console.ReadLine());
                int luni = Convert.ToInt32(Math.Log(n, 2) * 18);
                int ani = luni / 12;

                luni = luni % 12;
                Console.Write($"Solutia: Puterea de calcul va fi de {n} ori mai mare in {ani} ani si {luni} luni ");
            
            {
                Console.ReadKey();
            }
        } 
    }
}

