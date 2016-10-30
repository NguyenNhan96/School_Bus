using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SchoolBus
{
    class Program
    {
        static void Main(string[] args)
        {
            //StationBus stationbus=new StationBus();
            //stationbus.DocfileStation();


            //Bus bus = new Bus();
            //bus.DocFileBuses();

            DistanceBus distancebus = new DistanceBus();
            distancebus.DocFileDistance();

            Console.ReadKey();
        }
    }
}
