using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SchoolBus
{
    class StationBus
    {
        List<string> idTram = new List<string>(); 
        List<string> lat = new List<string>();
        List<string> lon = new List<string>();
        List<string> sohs = new List<string>();
        public List<string> IdTram
        {
            get { return idTram; }
            set { idTram = value; }
        }
        public List<string> Lat
        {
            get { return lat; }
            set { lat = value; }
        }
        public List<string> Lon
        {
            get { return lon; }
            set { lon = value; }
        }
        public List<string> Sohs
        {
            get { return sohs; }
            set { sohs = value; }
        }
        public void DocfileStation()
        {
            
            string[] file = File.ReadAllLines(@"E:\MyDocumentsSTUDY\1.STUDY\Pt-tk-Giaithuat\baitap\SchoolBus\SchoolBus\input\station.txt");
            for (int i = 1; i <file.Length; i++)
            {
                string[] tam = file[i].Split(' ', '\t');
                idTram.Add(tam[0]); lat.Add(tam[1]); lon.Add(tam[2]); sohs.Add(tam[3]);
            }
            foreach (string o in idTram)
            {
                Console.WriteLine(o);
            }
        }
    }
}
