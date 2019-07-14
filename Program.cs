using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate
            Room room = new Room();
            room.HotelInfo();
            decimal rate = room.HotelRate();
            Console.Write("Room rate: " + rate.ToString());
            Console.ReadKey();
        }
        

    }
}
