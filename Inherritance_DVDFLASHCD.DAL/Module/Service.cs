using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///●	расчет общего количества памяти всех устройств;
///●	копирование информации на устройства;
///●	расчет времени необходимого для копирования;
///●	расчет необходимого количества носителей информации представленных типов для переноса информации.
/// </summary>
/// 
namespace Inherritance_DVDFLASHCD.DAL.Module
{
    public class Service
    {
        public double CalculateTotalMemory(List<HDD> hdds, List<Flesh> flashs, List<DVD> dvds)
        {
            double result = 0;

            foreach (HDD item in hdds)
                result += item.getMemory();

            foreach (Flesh item in flashs)
                result += item.getMemory();

            foreach (DVD item in dvds)
                result += item.getMemory();

            return result;
        }
        public TimeSpan CalculateTotalTime(List<HDD> hdds)
        {
            double sum = 0;

            foreach (HDD item in hdds)
                sum += item.ClusterMemory / item.SpeedHDD;

            return TimeSpan.FromMilliseconds(sum);
        }

        public TimeSpan CalculateTotalTime(List<Flesh> flashs)
        {
            double sum = 0;

            foreach (Flesh item in flashs)
                sum += item.MemoryFlash / item.SpeedFlash;

            return TimeSpan.FromMilliseconds(sum);
        }

        public TimeSpan CalculateTotalTime(List<DVD> DVD)
        {
            double sum = 0;

            foreach (DVD item in DVD)
                sum += item.getMemory() / item.SpeedWrite;

            return TimeSpan.FromMilliseconds(sum);
        }



        //private void DeviceCounter(Flesh flesh, double MemoryData, out int count)
        //{
        //    count= Int32.Parse(
        //        Math.Ceiling((MemoryData / flesh.MemoryFlash))
        //            .ToString()
        //        );
        //}



        private int DeviceCounter(Flesh flesh, double MemoryData)
        {
            return Int32.Parse(
                Math.Ceiling((MemoryData / flesh.MemoryFlash))
                    .ToString()
                );
        }
        private int DeviceCounter(DVD dvd, double MemoryData)
        {
            return
                Int32.Parse(
                Math.Ceiling((MemoryData / dvd.getMemory()))
                    .ToString()
                );
        }
        private int DeviceCounter(HDD hdd, double MemoryData)
        {
            return
                Int32.Parse(
                Math.Ceiling((MemoryData / hdd.getMemory()))
                    .ToString()
                );
        }



        public void getCounter(ref List<Flesh> flashs, double MemoryData)
        {
            foreach (Flesh item in flashs)
            {
                item.Count = DeviceCounter(item, MemoryData);
            }
        }
        public void getCounter(ref List<HDD> hdds, double MemoryData)
        {
            foreach (HDD item in hdds)
            {
                item.Count = DeviceCounter(item, MemoryData);
            }
        }
        public void getCounter(ref List<DVD> dvds, double MemoryData)
        {
            foreach (DVD item in dvds)
            {
                item.Count = DeviceCounter(item, MemoryData);
            }
        }
    }
}