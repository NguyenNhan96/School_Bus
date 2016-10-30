using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SchoolBus
{
    class Bus
    {
        List<string> idBus = new List<string>();
        List<string> slGhe = new List<string>();
        string[] tam;
        public List<string> IdBus
        {
            get { return idBus; }
            set { idBus = value; }
        }
        public List<string> SlGhe
        {
            get { return slGhe; }
            set { slGhe = value; }
        }

        public void DocFileBuses()
        {
            string[] file = File.ReadAllLines(@"E:\MyDocumentsSTUDY\1.STUDY\Pt-tk-Giaithuat\baitap\SchoolBus\SchoolBus\input\buses.txt");
            for (int i = 0; i < file.Length; i++)
            {
                tam = file[i].Split( ' ', '\t');
                idBus.Add(tam[0]); slGhe.Add(tam[1]);

            }
            foreach (string o in slGhe)
            {
                Console.WriteLine(o);
            }
        }
    }
}
