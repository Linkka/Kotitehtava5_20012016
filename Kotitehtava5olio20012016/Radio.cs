using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kotitehtava5olio20012016
{
    class Radio
    {
        private readonly double MinFrequency = 2000.0;
        private readonly double MaxFrequency = 26000.0;
        private readonly int MinVolume = 0;
        private readonly int MaxVolume = 9;
        public bool OnOff { get; set; }

        private double frequency;
        private int volume;
        public double Frequency
        {
            get
            {
                return frequency;
            }
            set
            {
                if (value <= MaxFrequency && value >= MinFrequency) frequency = value;
                else
                {
                    Console.WriteLine("Frequency too high or low. Choose one between 2000.0 and 26000.0 - set to minimum!");
                    frequency = MinFrequency;
                }
            }
        }
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                if (value <= MaxVolume && value >= MinVolume) volume = value;
                else
                {
                    Console.WriteLine("Volume too high or low. Choose one between 0 and 9 - set to minimum!");
                    volume = MinVolume;
                }
            }
        }
        public void PrintData()
        {
            Console.WriteLine("Radio data : ");
            Console.WriteLine("- onoff : " + OnOff);
            Console.WriteLine("- frequency : " + Frequency);
            Console.WriteLine("- volume : " + Volume);
        }
        public void Change()
        {
            Frequency += 10000.0;
            Volume += 4;
        }
    }
}
