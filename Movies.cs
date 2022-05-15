using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotiFlix
{
    internal class Movies : Parent
    {
        public virtual Genre Genre { get; set; }

        public string GetTime()
        {
            int hours = LengthInSeconds / 3600;
            //We take the rest after dividing with 3600 and divide with 60 to get minutes
            int minutes = LengthInSeconds % 3600 / 60;
            return $"{hours}H:{minutes}M";
        }
        public void Show()
        {
            Console.WriteLine($"{Title} {Genre} {GetTime()}");
        }
    }
}
