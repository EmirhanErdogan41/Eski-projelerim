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
                if (a[i] == '0' || a[i] == '1' || a[i] == '2' || a[i] == '3' || a[i] == '4' || a[i] == '5' || a[i] == '6' || a[i] == '7' || a[i] == '8' || a[i] == '9')
                {
                    ayir += a[i];
                }
                else if (a[i] == '+' || a[i] == '-' || a[i] == '*' || a[i] == '/')
                {
                    ayir += a[i];
                }
                else if (a[i] == '(')
                {
                    if (i != 0)
                    {
                        denklemAyir.Add(ayir.Trim());
                    }
                    ayir = "(";
                }
                else if (a[i] == ')')
                {
                    ayir += ")";
                    denklemAyir.Add(ayir.Trim());
                    ayir = "";
                }
                
            }
            if (ayir != "")
            {
                denklemAyir.Add(ayir.Trim());
            }

            return denklemAyir;
        }
        private List<string> ParantezYok(string a)
        {
            List<string> denklemAyir = new List<string>();
            string ayir = "";

            for (int i = 0; i < a.Length; i++)
            {


                if (a[i] == '0' || a[i] == '1' || a[i] == '2' || a[i] == '3' || a[i] == '4' || a[i] == '5' || a[i] == '6' || a[i] == '7' || a[i] == '8' || a[i] == '9')
                {
                    ayir += a[i];
                }
                else if (a[i] == '+' || a[i] == '-' || a[i] == '*' || a[i] == '/' || a[i] == '%')
                {
                    if (i != 0)
                    {
                        denklemAyir.Add(ayir.Trim());
                    }
                    denklemAyir.Add(Convert.ToString(a[i]));
                    ayir = "";
                }
                else if (a[i] == ',')
                {
                    ayir += a[i];
                }
                
            }
            if (ayir != "")
            {
                denklemAyir.Add(ayir.Trim());
            }

            return denklemAyir;
        }
        private double Islem(List<string> a)
        {
            //Parantezsiz bir işlemi, işlem önceliğine göre çözen metod.


            double sonuc = 0;
            double elde = 1;
            char son = '+';


            if (a.Count >= 3)
            {
                for (int i = 1; i < a.Count; i++)
                {
                    if (a[i] == "+")
                    {
                        if (i == 1)
                        {
                            if (a.Count == 3 || a[i + 2] == "+" || a[i + 2] == "-")
                            {
                                sonuc = Convert.ToDouble(a[0]) + Convert.ToDouble(a[2]);
                            }
                            else
                            {
                                sonuc = Convert.ToDouble(a[0]);
                                son = '+';
                            }
                        }
                        else if (i > 1 && i < a.Count - 2)
                        {
                            if (a[i + 2] != "+" && a[i + 2] != "-")
                            {
                                son = '+';
                            }
                            else
                            {
                                sonuc += Convert.ToDouble(a[i + 1]);
                            }
                        }
                        else if (i == a.Count - 2)
                        {
                            sonuc += Convert.ToDouble(a[i + 1]);
                        }
                    }
                    else if (a[i] == "-")
                    {
                        if (i == 1)
                        {
                            if (a.Count == 3 || a[i + 2] == "+" || a[i + 2] == "-")
                            {
                                sonuc = Convert.ToDouble(a[0]) - Convert.ToDouble(a[2]);
                            }
                            else
                            {
                                sonuc -= Convert.ToDouble(a[0]);
                                son = '-';
                            }
                        }
                        else if (i > 1 && i < a.Count - 2)
                        {
                            if (a[i + 2] != "+" && a[i + 2] != "-")
                            {
                                son = '-';
                            }
                            else
                            {
                                sonuc -= Convert.ToDouble(a[i + 1]);
                            }
                        }
                        else if (i == a.Count - 2)
                        {
                            sonuc += Convert.ToDouble(a[i + 1]);
                        }
                    }
                    else if (a[i] == "*")
                    {
                        if (i == 1)
                        {
                            if (a.Count == 3 || a[i + 2] == "+" || a[i + 2] == "-")
                            {
                                sonuc = Convert.ToDouble(a[0]) * Convert.ToDouble(a[2]);
                            }
                            else
                            {
                                elde = Convert.ToDouble(a[0]) * Convert.ToDouble(a[2]);
                            }

                        }
                        else if (i > 1 && i < a.Count - 2)
                        {
                            if (a[i - 2] == "+" || a[i - 2] == "-")
                            {
                                elde = Convert.ToDouble(a[i - 1]) * Convert.ToDouble(a[i + 1]);
                            }
                            else if (a[i - 2] != "+" && a[i - 2] != "-")
                            {
                                elde *= Convert.ToDouble(a[i + 1]);
                            }
                            if (a[i + 2] == "+" || a[i + 2] == "-")
                            {
                                if (son == '+')
                                {
                                    sonuc += elde;
                                }
                                else if (son == '-')
                                {
                                    sonuc -= elde;
                                }
                            }
                        }
                        else if (i == a.Count - 2)
                        {
                            if (a[i - 2] == "+" || a[i - 2] == "-")
                            {
                                if (son == '+')
                                {
                                    sonuc += Convert.ToDouble(a[i - 1]) * Convert.ToDouble(a[i + 1]);
                                }
                                else if (son == '-')
                                {
                                    sonuc -= Convert.ToDouble(a[i - 1]) * Convert.ToDouble(a[i + 1]);
                                }
                            }
                            else
                            {
                                elde *= Convert.ToDouble(a[i + 1]);

                                if (son == '+')
                                {
                                    sonuc += elde;
                                }
                                else if (son == '-')
                                {
                                    sonuc -= elde;
                                }
                            }
                        }
                    }
                    else if (a[i] == "/")
                    {
                        if (i == 1)
                        {
                            if (a.Count == 3 || a[i + 2] == "+" || a[i + 2] == "-")
                            {
                                sonuc = Convert.ToDouble(a[0]) / Convert.ToDouble(a[2]);
                            }
                            else
                            {
                                elde = Convert.ToDouble(a[0]) / Convert.ToDouble(a[2]);
                            }
                        }
                        else if (i > 1 && i < a.Count - 2)
                        {
                            if (a[i - 2] == "+" || a[i - 2] == "-")
                            {
                                elde = Convert.ToDouble(a[i - 1]) / Convert.ToDouble(a[i + 1]);
                            }
                            else if (a[i - 2] != "+" && a[i - 2] != "-")
                            {
                                elde /= Convert.ToDouble(a[i + 1]);
                            }
                            if (a[i + 2] == "+" || a[i + 2] == "-")
                            {
                                if (son == '+')
                                {
                                    sonuc += elde;
                                }
                                else if (son == '-')
                                {
                                    sonuc -= elde;
                                }
                            }
                        }
                        else if (i == a.Count - 2)
                        {
                            if (a[i - 2] == "+" || a[i - 2] == "-")
                            {
                                if (son == '+')
                                {
                                    sonuc += Convert.ToDouble(a[i - 1]) / Convert.ToDouble(a[i + 1]);
                                }
                                else if (son == '-')
                                {
                                    sonuc -= Convert.ToDouble(a[i - 1]) / Convert.ToDouble(a[i + 1]);
                                }
                            }
                            else
                            {
                                elde /= Convert.ToDouble(a[i + 1]);

                                if (son == '+')
                                {
                                    sonuc += elde;
                                }
                                else if (son == '-')
                                {
                                    sonuc -= elde;
                                }
                            }
                        }
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
                    List<string> kontrol = new List<string>();
                    kontrol = ParantezYok(denklem[i]);

                    if (kontrol.Count < 3)
                    {
                    }
                    else
                    {
                        denklemBolum.Add(Convert.ToString(Islem(kontrol)));
                    }
                }

                for(int i = 0; i < denklem.Count; i++)
                {
                    if (denklem[i][denklem[i].Length-1] == '+' && i != denklemBolum.Count-1)
                    {
                        denklemBolum[i] += '+';
                    }
                    else if (denklem[i][denklem[i].Length - 1] == '-' && i != denklemBolum.Count - 1)
                    {
                        denklemBolum[i] += '-';
                    }
                    else if (denklem[i][denklem[i].Length - 1] == '*' && i != denklemBolum.Count - 1)
                    {
                        denklemBolum[i] += '*';
                    }
                    else if (denklem[i][denklem[i].Length - 1] == '/' && i != denklemBolum.Count - 1)
                    {
                        denklemBolum[i] += '/';
                    }                    
                    else if (denklem[i][denklem[i].Length - 1] == ')' && i != denklemBolum.Count - 1)
                    {
                        if (i != denklem.Count-1)
                        {
                            denklemBolum[i] += '*';
                        }
                    }
                }
                string birlestir = string.Join("", denklemBolum);

                sonuc = Islem(ParantezYok(birlestir.Trim()));
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
