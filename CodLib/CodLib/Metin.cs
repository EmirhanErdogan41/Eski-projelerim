using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodLib
{
    public class Metin
    {
        /// <summary>
        /// Gönderilen listenin elemanlarının yerlerini random şekilde değiştirir ve listeyi geri yollar;
        /// </summary>
        /// <param name="siralanacakListe"></param>
        /// <returns></returns>
        public List<string> ListeyiRandomSirala (List<string> siralanacakListe)
        {
            List<string> ret = siralanacakListe;
            ret.Clear();
            Random rnd = new Random();

            for (int i = 0; i < siralanacakListe.Count;)
            {
                int sonrakiRndDeger = rnd.Next(0, siralanacakListe.Count);

                ret.Add(siralanacakListe[sonrakiRndDeger]);
                siralanacakListe.RemoveAt(sonrakiRndDeger);
            }

            return ret;
        }
        /// <summary>
        /// Gönderilen metnin içinde parantez var mı diye bakar.
        /// </summary>
        /// <param name="gStr"></param>
        /// <returns></returns>
        public static bool ParantrzVarMi(string gStr)
        {
            bool ret = false;

            for (int i = 0; i < gStr.Length; i++)
            {
                if (gStr[i] == '(' || gStr[i] == '{' || gStr[i] == '[')
                {
                    ret = true;
                    break;
                }
            }
            return ret;
        }
        /// <summary>
        /// Gönderilen metindeki parantezlerin içini listeye aktarır. (İç içe olan parantezler ayrılmaz)
        /// </summary>
        /// <param name="gStr"></param>
        /// <returns></returns>
        public static List<string> ParantezAl(string gStr)
        {
            List<string> ret = new List<string>();
            string flag = "";
            int acilanParantez = 0;
            char parantezTuru = ' ';
            char parantezEsTuru = ' ';
            bool parantezIci = false;

            for (int i = 0; i < gStr.Length; i++)
            {
                if (parantezTuru == ' ' && (gStr[i] == '(' || gStr[i] == '{' || gStr[i] == '['))
                {
                    parantezTuru = gStr[i];
                    if (parantezTuru == '(')
                    {
                        parantezEsTuru = ')';
                    }
                    else if (parantezTuru == '{')
                    {
                        parantezEsTuru = '}';
                    }
                    else if (parantezTuru == '[')
                    {
                        parantezEsTuru = ']';
                    }
                }


                if (gStr[i] == parantezTuru)
                {
                    acilanParantez++;
                    parantezIci = true;
                }
                else if (gStr[i] == parantezEsTuru)
                {
                    acilanParantez--;
                    if (acilanParantez == 0)
                    {
                        ret.Add(BosluklariSil(flag));
                        flag = "";
                        parantezIci = false;
                        parantezTuru = ' ';
                    }
                }


                if (parantezIci && (gStr[i] != '(' && gStr[i] != '{' && gStr[i] == '['))
                {
                    flag += gStr[i];
                }
            }

            return ret;
        }
        /// <summary>
        /// Gönderilen metindeki parantezlerin içini listeye aktarır. (İç içe olan parantezler ayrılmaz)
        /// </summary>
        /// <param name="gStr"></param>
        /// <param name="parantezDahilMi">(parantezleri string'e dahil eder)</param>
        /// <returns></returns>
        public static List<string> ParantezAl(string gStr, bool parantezDahilMi)
        {
            List<string> ret = new List<string>();
            string flag = "";
            int acilanParantez = 0;
            char parantezTuru = ' ';
            char parantezEsTuru = ' ';
            bool parantezIci = false;

            for (int i = 0; i < gStr.Length; i++)
            {
                if (gStr[i] == '(' || gStr[i] == '{' || gStr[i] == '[')
                {
                    acilanParantez++;
                    parantezIci = true;

                    if (parantezTuru == ' ' && (gStr[i] == '(' || gStr[i] == '{' || gStr[i] == '['))
                    {
                        parantezTuru = gStr[i];
                        if (parantezTuru == '(')
                        {
                            parantezEsTuru = ')';
                        }
                        else if (parantezTuru == '{')
                        {
                            parantezEsTuru = '}';
                        }
                        else if (parantezTuru == '[')
                        {
                            parantezEsTuru = ']';
                        }

                        if (parantezDahilMi)
                        {
                            flag += gStr[i];
                        }

                        continue;
                    }
                }
                else if (gStr[i] == parantezEsTuru)
                {
                    acilanParantez--;
                    if (acilanParantez == 0)
                    {
                        if (parantezDahilMi)
                        {
                            flag += gStr[i];
                        }
                        ret.Add(BosluklariSil(flag));
                        flag = "";
                        parantezIci = false;
                        parantezTuru = ' ';
                        continue;
                    }
                }


                if (parantezIci)
                {
                    flag += gStr[i];
                }
            }

            return ret;
        }
        /// <summary>
        /// Gönderilen metnin içindeki tüm boşlukları siler.
        /// </summary>
        /// <param name="gStr">gStr != null</param>
        /// <returns></returns>
        public static string BosluklariSil(string gStr)
        {
            string ret = "";

            for (int i = 0; i < gStr.Length; i++)
            {
                if (gStr[i] != ' ')
                {
                    ret += gStr[i];
                }
            }
            return ret;
        }
        /// <summary>
        /// Kodun çalıştığı makinedeki ondalık ayracı ne ise onu döndürür.
        /// </summary>
        /// <returns>'.' or ','</returns>
        public static char OndalikAyraci()
        {
            return Convert.ToString(1.1)[1];
        }
        /// <summary>
        /// Basitce şifrelenen mesajları çözer
        /// </summary>
        /// <param name="metin">"String"</param>
        /// <returns>Merhaba</returns>
        public string sifreKaldir(string metin)
        {
            string ret = "";

            for (int i = 0; i < metin.Length; i++)
            {
                ret += Convert.ToChar((metin[i] - 10) * 2);
            }
            return ret;
        }
        /// <summary>
        /// Metni basit bir şekilde şifreler
        /// </summary>
        /// <param name="metin">"string"</param>
        /// <returns>"/&SFA/()&F/AS("</returns>
        public string sifrele(string metin)
        {
            string ret = "";

            for (int i = 0; i < metin.Length; i++)
            {
                ret += Convert.ToChar(ret[i] / 2 + 10);
            }
            return ret;
        }
        /// <summary>
        /// Metindeki tüm sayıları bir listeye toplar
        /// </summary>
        /// <param name="metin">"int"</param>
        /// <returns>Liste</returns>
        public static List<string> SayiBul(string metin)
        {
            List<string> ret = new List<string>();
            string aD = "";

            for (int i = 0; i < metin.Length; i++)
            {
                if ((metin[i] == '.' || metin[i] == ',') && i != metin.Length - 1 && i != 0 && aD != "" && char.IsNumber(metin[i + 1]))
                {
                    aD += OndalikAyraci();
                }
                else if (char.IsNumber(metin[i]))
                {
                    aD += metin;
                }
                else
                {
                    if (aD != "")
                    {
                        ret.Add(aD);
                        aD = "";
                    }
                }
            }
            return ret;
        }
        /// <summary>
        /// Verilen index aralığına göre metindeki sayıları listeye toplar
        /// </summary>
        /// <param name="metin">"int"</param>
        /// <param name="minIndex">0</param>
        /// <param name="maxIndex">1</param>
        /// <returns>Liste</returns>
        public static List<string> SayiBul(string metin, int maxIndex, int minIndex = 0)
        {
            List<string> ret = new List<string>();
            string aD = "";

            for (; minIndex < maxIndex; minIndex++)
            {
                if ((metin[minIndex] == '.' || metin[minIndex] == ',') && minIndex != metin.Length - 1 && minIndex != 0 && aD != "" && char.IsNumber(metin[minIndex + 1]))
                {
                    aD += OndalikAyraci();
                }
                else if (char.IsNumber(metin[minIndex]))
                {
                    aD += metin;
                }
                else
                {
                    if (aD != "")
                    {
                        ret.Add(aD);
                        aD = "";
                    }
                }
            }
            return ret;
        }
        /// <summary>
        /// Metin sayıya dönüştürülebilir mi diye kontrol eder
        /// </summary>
        /// <param name="metin">"int"</param>
        /// <returns>True or False</returns>
        public static bool SayiMi(string metin)
        {
            bool sonuc = true;

            for (int i = 0; i < metin.Length; i++)
            {
                if ((metin[i] == '.' || metin[i] == ',') && i != metin.Length - 1 && i != 0 && char.IsNumber(metin[i + 1]))
                {
                }
                else if (!char.IsNumber(metin[i]))
                {
                    sonuc = false;
                    break;
                }
            }
            return sonuc;
        }
        /// <summary>
        /// Gönderilen metni ve sayıyı birbirinden ayırır
        /// </summary>
        /// <param name="metin">"String"</param>
        /// <returns>Liste</returns>
        public static List<string> MSAyirici(string metin)
        {
            List<string> ret = new List<string>();
            string aD = "";
            int sayi = 0;

            for (int i = 0; i < metin.Length; i++)
            {
                if (metin[i] >= 48 && metin[i] <= 57)
                {
                    if ((metin[i] == '.' || metin[i] == ',') && i != metin.Length - 1 && i != 0 && aD != "" && char.IsNumber(metin[i + 1]))
                    {
                        aD += OndalikAyraci();
                    }
                    else if (sayi % 2 == 0 && aD != "")
                    {
                        ret.Add(aD.Trim());
                        aD = "";
                        sayi++;
                    }

                    aD += metin[i];
                }
                else
                {
                    if (sayi % 2 == 1 && aD != "")
                    {
                        ret.Add(aD.Trim());
                        aD = "";
                        sayi++;
                    }

                    aD += metin[i];
                }
            }

            return ret;
        }
    }
}
