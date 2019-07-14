using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class Room
    {
        //Data Type
        public string RoomName { get; set; }
        public decimal Rate { get; set; }
        public int Bed { get; set; }

        public void HotelInfo()
        {
            Console.Write("Hello Po!");
            Console.ReadKey();
        }

        public decimal HotelRate()
        {
            Rate = 2000.50m;
            return Rate;
        }

        public string SayMyName(string name)
        {
            return name;
        }
    }
}
