using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CodLib.Renk
{
    public class Renk
    {
        private static List<bool> AralikDisiMiARGB(Color argb, double degisimYuzdesi)
        {
            List<bool> ret = new List<bool>();
            double a = Mat.YuzdeArttir(255, argb.A, degisimYuzdesi);
            double r = Mat.YuzdeArttir(255, argb.R, degisimYuzdesi), g = Mat.YuzdeArttir(255, argb.G, degisimYuzdesi), b = Mat.YuzdeArttir(255, argb.B, degisimYuzdesi);

            if (a > 0 && a <= 255)
            {
                ret.Add(false);
            }
            else
            {
                ret.Add(true);
            }

            if (r > 0 && r <= 255)
            {
                ret.Add(false);
            }
            else
            {
                ret.Add(true);
            }

            if (g > 0 && g <= 255)
            {
                ret.Add(false);
            }
            else
            {
                ret.Add(true);
            }

            if (b > 0 && b <= 255)
            {
                ret.Add(false);
            }
            else
            {
                ret.Add(true);
            }

            return ret;
        }
        /// <summary>
        /// Gönderilen rengin tonunu degistirip geri gönderir.
        /// </summary>
        /// <param name="renk"></param>
        /// <param name="tonYuzdesi"></param>
        /// <returns></returns>
        public static Color RenkTonunuDegistir(Color renk, double tonYuzdesi)
        {
            Color ret = renk;
            List<bool> argbBool = AralikDisiMiARGB(renk, tonYuzdesi);
            List<int> argb = new List<int>();
            argb.Add(renk.A);
            argb.Add(renk.R);
            argb.Add(renk.G);
            argb.Add(renk.B);

            for (int i = 0; i < argbBool.Count; i++)
            {
                if (!argbBool[i])
                {
                    argb[i] = Convert.ToInt32(Mat.YuzdeArttir(255, argb[i], tonYuzdesi));
                }
                else
                {
                    argb[i] = Convert.ToInt32(Mat.YuzdeArttir(255, argb[i], -tonYuzdesi));
                }
            }

            ret = Color.FromArgb(argb[0], argb[1], argb[2], argb[0]);

            return ret;
        }
        /// <summary>
        /// Renk çemberinden renk seçmeye yarar.
        /// </summary>
        /// <param name="alpha">0-255</param>
        /// <param name="derece">0-360</param>
        /// <param name="contrast">0-255</param>
        /// <returns></returns>
        public static Color RenkCemberi(int alpha, double derece, int contrast)
        {
            Color ret;
            double aciDegeri = (2 * Math.PI * contrast) / 360;
            int r = 0, g = 0, b = 0;

            if (derece >= 120 && derece < 240 )
            {
                r = Convert.ToInt32(Mat.YuzdeArttir(255, contrast, -((aciDegeri * derece) / (aciDegeri * 360 / 100))));
                g = Convert.ToInt32(Mat.YuzdeArttir(255, 0, (aciDegeri * derece) / (aciDegeri * 360 / 100)));
                b = 0;
            }
            else if (derece >= 240 && derece <= 360)
            {
                r = 0;
                g = Convert.ToInt32(Mat.YuzdeArttir(255, contrast, -((aciDegeri * derece) / (aciDegeri * 360 / 100))));
                b = Convert.ToInt32(Mat.YuzdeArttir(255, 0, (aciDegeri * derece) / (aciDegeri * 360 / 100)));
            }
            else if (derece >= 0 && derece < 120)
            {
                r = Convert.ToInt32(Mat.YuzdeArttir(255, 0, (aciDegeri * derece) / (aciDegeri * 360 / 100)));
                g = 0;
                b = Convert.ToInt32(Mat.YuzdeArttir(255, contrast, -((aciDegeri*derece)/(aciDegeri*360/100))));
            }

            ret = Color.FromArgb(alpha, r, g, b);

            return ret;
        }
    }
}
