﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Encodings;

namespace Dolgozo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dolgozo> dolgozok = new List<Dolgozo>();
            StreamReader sr = new StreamReader(
                path: @"..\..\..\src\Dolgozok.txt",
                encoding: System.Text.Encoding.UTF8
                );
            while (!sr.EndOfStream) dolgozok.Add(new Dolgozo(sr.ReadLine()));

            Console.WriteLine("8. feladat:");
            int kor = 0;
            foreach (var d in dolgozok)
            {
                kor += d.Age;
            }
            Console.WriteLine($"\tA dolgozók átlag életkora: {kor / dolgozok.Count}");
        }
    }
}
