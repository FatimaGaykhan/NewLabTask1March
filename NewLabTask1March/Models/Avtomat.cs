using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewLabTask1March.Models
{
    internal class Avtomat
    {
        public static int Daraq { get; set; }
        public static int Extra { get; set; }

        public Avtomat(int daraq, int extra)
        {
            Daraq = daraq;
            Extra = extra;
        }

        public void OneByOne()
        {
            if (Daraq != 0)
            {
                Console.WriteLine(Daraq-=1);
            }
            else
            {
                Console.WriteLine("Daraqda Gulle Bitmishdir");
            }
               
        }
        public void ShowDaraqCount()
        {
            if (Daraq == 0)
            {
                Console.WriteLine("Daraqda Gulle bitmishdir");
            }
        }

        public void All()
        {
            Console.WriteLine(Daraq-Daraq);
        }
    }
}
