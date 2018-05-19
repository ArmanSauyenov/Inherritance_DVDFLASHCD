using Inherritance_DVDFLASHCD.DAL.Module;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Inherritance_DVDFLASHCD
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите объем данных");
            double temp = Double.Parse(Console.ReadLine());

            GenerateDevice gener = new GenerateDevice();
            gener.GenerateFlash();

            Service serv = new Service();
            double totalMemory = serv.CalculateTotalMemory(new List<HDD>(), gener.fl, new List<DVD>());
            Console.WriteLine("общий объем флешек ={0} ({1})", totalMemory, gener.fl.Count);

            TimeSpan time = serv.CalculateTotalTime(gener.fl);
            Console.WriteLine(time.TotalMinutes);

            serv.getCounter(ref gener.fl, temp);
            foreach (Flesh item in gener.fl)
            {
                item.PrintInfo();
            }
        }
    }
}
