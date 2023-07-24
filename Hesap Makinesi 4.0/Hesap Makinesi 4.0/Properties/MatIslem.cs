using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesap_Makinesi_4._0
{
    class MatIslem
    {
        private List<string> ParantezVar(string a)
        {
            List<string> denklemAyir = new List<string>();
            string ayir = "";

            for (int i = 0; i < a.Length; i++)
            {
                try
                {
                    short sayi = Convert.ToInt16(a[i]);
                    ayir += a[i];
                }
                catch
                {
                    if (a[i] == '+' || a[i] == '-' || a[i] == '*' || a[i] == '/' || a[i] == '%')
                    {
                        ayir += a[i];
                    }
                    else if (a[i] == '(')
                    {
                        denklemAyir.Add(ayir.Trim());
                        ayir = "(";
                    }
                    else if (a[i] == ')')
                    {
                        ayir += ")";
                        denklemAyir.Add(ayir.Trim());
                        ayir = "";
                    }
                }
            }
            return denklemAyir;
        }
        private List<string> ParantezYok(string a)
        {
            List<string> denklemAyır = new List<string>();
            string ayir = "";

            for (int i = 0; i < a.Length; i++)
            {
                try
                {
                    short test = Convert.ToInt16(a[i]);
                    ayir += a[i];
                }
                catch
                {
                    if (a[i] == '+' || a[i] == '-' || a[i] == '*' || a[i] == '/' || a[i] == '%')
                    {
                        denklemAyır.Add(ayir.Trim());
                        denklemAyır.Add(Convert.ToString(a[i]));
                        ayir = "";
                    }
                    else if (a[i] == '.')
                    {
                        ayir += a[i];
                    }
                }
            }
            return denklemAyır;
        }
        private double Islem(List<string> a)
        {
            //Parantezsiz bir işlemi, işlem önceliğine göre çözen metod.


            double sonuc = 0;
            double elde = 1;
            char son = '+';

            if (a[1] == "+" || a[1] == "-")
            {
                sonuc = Convert.ToDouble(a[0]);
            }

            for (int i = 1; i < a.Count; i++)
            {
                if (a[i] == "+")
                {
                    if (a[i + 2] == "+" || a[i + 2] == "-")
                    {
                        sonuc += Convert.ToDouble(a[i + 1]);
                    }
                }
                else if (a[i] == "-")
                {
                    if (a[i + 2] == "+" || a[i + 2] == "-")
                    {
                        sonuc -= Convert.ToDouble(a[i + 1]);
                    }
                }
                else if (a[i] == "*")
                {
                    if (a[i - 2] == "+")
                    {
                        son = '+';
                    }
                    else if (a[i - 2] == "-")
                    {
                        son = '-';
                    }
                    if (a[i + 2] == "+" || a[i + 2] == "-")
                    {
                        if (elde == 1)
                        {
                            if (a[i - 2] == "+")
                            {
                                sonuc += Convert.ToDouble(a[i - 1]) * Convert.ToDouble(a[i + 1]);
                            }
                            else if (a[i - 2] == "-")
                            {
                                sonuc -= Convert.ToDouble(a[i - 1]) * Convert.ToDouble(a[i + 1]);
                            }
                        }
                        else
                        {
                            if (son == '+')
                            {
                                sonuc += elde * Convert.ToDouble(a[i + 1]);
                            }
                            else
                            {
                                sonuc -= elde * Convert.ToDouble(a[i + 1]);
                            }
                        }
                    }
                    else
                    {                        
                        elde *= Convert.ToDouble(a[i + 1]);
                    }
                }
                else if (a[i] == "/")
                {
                    if (a[i - 2] == "+")
                    {
                        son = '+';
                    }
                    else if (a[i - 2] == "-")
                    {
                        son = '-';
                    }
                    if (a[i + 2] == "+" || a[i + 2] == "-")
                    {
                        if (elde == 1)
                        {
                            if (a[i - 2] == "+")
                            {
                                sonuc += Convert.ToDouble(a[i - 1]) / Convert.ToDouble(a[i + 1]);
                            }
                            else if (a[i - 2] == "-")
                            {
                                sonuc -= Convert.ToDouble(a[i - 1]) / Convert.ToDouble(a[i + 1]);
                            }
                        }
                        else
                        {
                            if (son == '+')
                            {
                                sonuc += elde / Convert.ToDouble(a[i + 1]);
                            }
                            else
                            {
                                sonuc -= elde / Convert.ToDouble(a[i + 1]);
                            }
                        }
                    }
                    else
                    {
                        elde /= Convert.ToDouble(a[i + 1]);
                    }
                }
                else if (a[i] == "%")
                {
                    if (a[i - 2] == "+")
                    {
                        son = '+';
                    }
                    else if (a[i - 2] == "-")
                    {
                        son = '-';
                    }
                    if (a[i + 2] == "+" || a[i + 2] == "-")
                    {
                        if (elde == 1)
                        {
                            if (a[i - 2] == "+")
                            {
                                sonuc += Convert.ToDouble(a[i - 1]) % Convert.ToDouble(a[i + 1]);
                            }
                            else if (a[i - 2] == "-")
                            {
                                sonuc -= Convert.ToDouble(a[i - 1]) % Convert.ToDouble(a[i + 1]);
                            }
                        }
                        else
                        {
                            if (son == '+')
                            {
                                sonuc += elde % Convert.ToDouble(a[i + 1]);
                            }
                            else
                            {
                                sonuc -= elde % Convert.ToDouble(a[i + 1]);
                            }
                        }
                    }
                    else
                    {
                        elde = elde % Convert.ToDouble(a[i + 1]);
                    }
                }
            }
            return sonuc;
        }




        public double Cevap(string a)
        {
            bool parantezVarMi = false;
            double sonuc;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '(')
                {
                    parantezVarMi = true;
                    break;
                }
            }



            if (parantezVarMi)
            {
                //True
                List<string> denklem = ParantezVar(a);
                List<string> denklemBolum = new List<string>();                

                for(int i = 0; i < denklem.Count; i++)
                {
                    denklemBolum.Add(Convert.ToString(Islem(ParantezYok(denklem[i]))));
                }

                for(int i = 0; i < denklem.Count; i++)
                {
                    if (denklem[i][denklem[i].Length-1] == '+')
                    {
                        denklemBolum[i] += '+';
                    }
                    else if (denklem[i][denklem[i].Length - 1] == '-')
                    {
                        denklemBolum[i] += '-';
                    }
                    else if (denklem[i][denklem[i].Length - 1] == '*')
                    {
                        denklemBolum[i] += '*';
                    }
                    else if (denklem[i][denklem[i].Length - 1] == '/')
                    {
                        denklemBolum[i] += '/';
                    }
                    else if (denklem[i][denklem[i].Length - 1] == '%')
                    {
                        denklemBolum[i] += '%';
                    }
                    else if (denklem[i][denklem[i].Length - 1] != ')')
                    {
                        denklemBolum[i] += '*';
                    }
                }

                sonuc = Islem(denklemBolum);

            }
            else
            {
                //False
                List<string> denklem = ParantezYok(a);
                sonuc = Islem(denklem);                
            }
            return sonuc;
        }
    }
}
