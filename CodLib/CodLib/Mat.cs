using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodLib
{
    public class Mat
    {
        public static double YuzdeArttir(double maxDeger, double gDeger, double arttirmaOrani)
        {
            double ret;
            double yuzdeBir = maxDeger / 100;
            double oran = gDeger / yuzdeBir;

            ret = yuzdeBir * (oran + arttirmaOrani);

            return ret;
        }
    }
}
