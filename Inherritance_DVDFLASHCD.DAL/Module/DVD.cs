using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Inherritance_DVDFLASHCD.DAL.Module
{
    public enum TypeDVD { OneSide, TwoSide }
    public class DVD : Storage
    {
        public DVD() : this(0) { }
        public DVD(int SpeedWrite) : this(SpeedWrite, TypeDVD.OneSide) { }
        public DVD(int SpeedWrite, TypeDVD typeDVD):base()
        {
            this.SpeedWrite = SpeedWrite;
            this.typeDVD = typeDVD;
        }
        public DVD(string name)
        {
            base.Name = name;
            base.Model = "fdsadf";
        }
        public int SpeedWrite { get; set; }
        public int SpeedRead { get; set; }
        public TypeDVD typeDVD { get; set; }
        public override double getMemory()
        {
            if (TypeDVD.OneSide == typeDVD)
                return 4.7;
            else
                return 9.4;
        }
        public override void PrintInfo()
        {
            base.PrintInfo();

            Console.WriteLine("SpeedWrite= {0}", SpeedWrite);
            Console.WriteLine("MemoryFlash={0}", SpeedRead);
            Console.WriteLine("typeDevice ={0}", typeDVD);

        }
        public sealed override void Copy()
        {
            int summ = (int)getMemory() / SpeedWrite;
            for (int i = 0; i < summ; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(500);
            }
        }
    }
}
