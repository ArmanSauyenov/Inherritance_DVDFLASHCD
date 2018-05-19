using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Inherritance_DVDFLASHCD.DAL.Module
{
    public enum TypeDevice { USB2, USB3 }
    public class Flesh : Storage
    {
        public Flesh(string model) : base("", model) { }
        public Flesh() : this(0) { }
        public Flesh(int SpeedFlash) : this(SpeedFlash, 0) { }
        public Flesh(int SpeedFlash, double MemoryFlash) : base()
        {
            this.SpeedFlash = SpeedFlash;
            this.MemoryFlash = MemoryFlash;
        }
        public int SpeedFlash { get; private set; }
        public double MemoryFlash { get; set; }
        private TypeDevice typeDevice_;
        public TypeDevice typeDevice
        {
            get
            {
                return typeDevice_;
            }
            set
            {
                typeDevice_ = value;

                if (TypeDevice.USB2 == value)
                    SpeedFlash = 2000;
                else
                    SpeedFlash = 3000;

            }
        }

        public override double getMemory()
        {
            return MemoryFlash;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();

            Console.WriteLine("SpeedFlash= {0}", SpeedFlash);
            Console.WriteLine("MemoryFlash={0}", MemoryFlash);
            Console.WriteLine("typeDevice ={0}", typeDevice);

        }
        public override void Copy()
        {
            int summ = (int)MemoryFlash / SpeedFlash;
            for (int i = 0; i < summ; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(500);
            }
        }
    }
}
