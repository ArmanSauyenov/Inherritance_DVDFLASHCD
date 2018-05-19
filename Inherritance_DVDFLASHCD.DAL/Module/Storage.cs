﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherritance_DVDFLASHCD.DAL.Module
{

    public abstract class Storage
    {
        public Storage() : this("")
        {
        }
        public Storage(string Name) : this(Name, "")
        {
        }
        public Storage(string Name, string Model)
        {
            this.Name = Name;
            this.Model = Model;
        }

        public static int Time { get; set; }
        protected string Name { get; set; }
        public string Model { get; protected set; }
        public int Count { get; set; }

        public abstract double getMemory();

        public abstract void Copy();
        public virtual void PrintInfo()
        {
            Console.WriteLine("{0} ({1})", Name, Model);
        }
        public static void PrintTime()
        {
            Console.WriteLine("{0}", Time);
        }
    }

}
