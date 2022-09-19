using System;

// test

namespace Program
{
    class Program
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