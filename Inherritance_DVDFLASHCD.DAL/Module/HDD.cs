using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Inherritance_DVDFLASHCD.DAL.Module
{
    public class HDD : Storage
    {
        public HDD() : this(0) { }
        public HDD(int SpeedHDD) : this(SpeedHDD, TypeDevice.USB2) { }
        public HDD(int SpeedHDD, TypeDevice typeDevice) : base()
        {
            this.SpeedHDD = SpeedHDD;
            this.typeDevice = typeDevice;
        }
        public int SpeedHDD { get; set; }
        public TypeDevice typeDevice { get; set; }
        public int Cluster { get; set; }
        public int ClusterMemory { get; set; }

        public override double getMemory()
        {
            return ClusterMemory;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();

            Console.WriteLine("speedHDD= {0}", SpeedHDD);
            Console.WriteLine("typeDevice={0}", typeDevice);
            Console.WriteLine("Cluster ={0}", Cluster);
            Console.WriteLine("ClusterMemory ={0}", ClusterMemory);

        }
        public override void Copy()
        {
            int summ = ClusterMemory / SpeedHDD;
            for (int i = 0; i < summ; i++)
            {
                Console.WriteLine(".");
                Thread.Sleep(500);
            }
        }
    }
}
