using System;

// test

namespace QEProIO
{
    class QEProIOMaster
    {
        static void Main(string[] args)
        {
            int numberOfSpectrometers;
            //int spectrometerIndex;
            OmniDriver.NETWrapper wrapper = new OmniDriver.NETWrapper();
            numberOfSpectrometers = wrapper.openAllSpectrometers();
            Console.WriteLine($"number = {numberOfSpectrometers}");
            return;
        }
    }   
}