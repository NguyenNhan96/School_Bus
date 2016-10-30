using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace SchoolBus
{
    class DistanceBus
    {
        string[,] kc = new string[42, 42];
        string[,] tg = new string[42, 42];

        public void DocFileDistance()
        {
            string[] tam;
            int t = 0;
            string[] file = File.ReadAllLines(@"E:\MyDocumentsSTUDY\1.STUDY\Pt-tk-Giaithuat\baitap\SchoolBus\SchoolBus\input\distance.txt");
            for (int i = 0; i < 42; i++)
            {
                for (int j = 0; j < 42; j++)
                {
                    tam = file[t].Split(' ', '\t');
                    kc[i, j] = tam[0];
                    tg[i, j] = tam[1];

                    t++;

                    //Console.WriteLine(kc[i, j]);
                }
            }

            foreach (string o in kc)
            {
                Console.WriteLine(o);
            }
        }
    }
}
