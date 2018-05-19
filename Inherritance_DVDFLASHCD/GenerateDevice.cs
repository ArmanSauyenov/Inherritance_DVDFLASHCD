using Inherritance_DVDFLASHCD.DAL.Module;
using System;
using System.Collections.Generic;

namespace Inherritance_DVDFLASHCD
{
    public class GenerateDevice
    {
        public GenerateDevice()
        {
            hd = new List<HDD>();
            dv = new List<DVD>();
            fl = new List<Flesh>();
        }
        public List<HDD> hd;
        public List<DVD> dv;
        public List<Flesh> fl;

        private Random rand = new Random();
        public void GenerateFlash()
        {
            for (int i = 0; i < rand.Next(1, 20); i++)
            {
                Flesh f = new Flesh(string.Format("Model #{0}", rand.Next()));
                f.MemoryFlash = rand.Next(2000, 128000);
                f.typeDevice = (TypeDevice)rand.Next(0, 1);
                fl.Add(f);
            }
        }
    }
}
