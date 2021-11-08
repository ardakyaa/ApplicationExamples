using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace StringExtensionMethods.Extensions
{
    public static class StringExtensions
    {
        public static bool ContainsMethod(this string metin1,string aranilacakIfade,bool result)
        {
            int sayac = 0;
            for (int i = 0, j=0; i < metin1.Length; i++)
            {
                if (metin1[i]==aranilacakIfade[j])
                {
                    sayac++;
                    j++;
                }
                else
                {
                    sayac = 0;
                    j = 0;
                    i--;
                }

            }
            if (sayac == aranilacakIfade.Length)
            {
                result = true;
                MessageBox.Show("Aradığınız ifade metinde geçmektedir.");
            }
            else
            {
                result = false;
                MessageBox.Show("Aradığınız ifade metinde geçmemektedir.");
            }
            return result;
        }
        public static bool StartsWithMethod(this string metin1, string baslangicIfadesi, bool result)
        {
            int sayac = 0;
            for (int i = 0, j = 0; i < baslangicIfadesi.Length; i++, j++)
            {
                if (metin1[j] == baslangicIfadesi[i])
                {
                    sayac++;

                }
                if (baslangicIfadesi.Length>metin1.Length)
                {
                    MessageBox.Show("Hata!Girdiğiniz ifade, metnin uzunluğundan fazladır.");
                    break;
                }

            }

            if (sayac == baslangicIfadesi.Length)
            {
                result = true;
                MessageBox.Show($"Metin {baslangicIfadesi} ile başlamaktadır.");
            }
            else
            {
                MessageBox.Show($"Metin {baslangicIfadesi} ile başlamamaktadır.");
            }
            return result;

        }

        public static int CompareToMethod(this string kelime1, string kelime2)
        {
           
            for (char letter = 'A'; letter < 'Z'; letter++)
            {
                string[] alphabet = { letter.ToString().ToLower() };
                for (int i = 0; i < alphabet.Length; i++)
                {
                    for (int j = 0,h=0; j < kelime1.Length; j++,h++)
                    {
                        if (alphabet[i]==kelime1[j].ToString().ToLower())
                        {

                        }
                    }
                }
            }

            return 0;
        }
        public static int IndexOfMethod(this string kelime, char harf)
        {
            for (int i=0;i<kelime.Length;i++)
            {
                if (kelime[i]==harf)
                {
                    MessageBox.Show($"Aradığınız harf kelimenin {i}. indexinde bulunmaktadır.");
                    return i;
                }
               
            }
            MessageBox.Show("Aradığınız harf kelimede bulunmamaktadır.");
            return -1;
        }
        public static int LastIndexOfMethod(this string kelime, char harf)
        {

            for (int i = kelime.Length - 1; i >= 0; i--)
            {
                if (kelime[i] == harf)
                {
                    MessageBox.Show($"Aradığınız harf kelimenin {i}. indexinde bulunmaktadır.");
                    return 1;
                }

            }
            MessageBox.Show("Aradığınız harf kelimede bulunmamaktadır.");
            return -1;

        }
        public static int RemoveMethod(this string metin, int index)
        {
            string[] metin2 = new string[0];
            for (int i = 0; i < index; i++)
            {
                Array.Resize(ref metin2, metin2.Length+1);
                metin2[metin2.Length - 1] = metin[i].ToString();

            }
            MessageBox.Show(string.Concat(metin2));
            return 1;
        }

        public static int ReplaceMethod(this string metin, string ifade, string yeniIfade)
        {

            return 0;
        }
        public static int SplitMethod(this string metin, char ifade)
        {
            for (int i = 0; i < metin.Length; i++)
            {
                if (ifade==metin[i])
                {

                }
            }
            return 0;
        }

        public static string InsertMethod(this string metin, string ifade, int index)
        {
            string[] metin2 = new string[0];

            for (int i =0; i < metin.Length; i++)
            {
                Array.Resize(ref metin2, metin2.Length + 1);
                metin2[metin2.Length - 1] = metin[i].ToString();

                if (index==i)
                {
                    for (int j = 0; j < ifade.Length; j++)
                    {
                        Array.Resize(ref metin2, metin2.Length + 1);
                        metin2[metin2.Length - 1] = ifade[j].ToString();

                    }

                }

            }
            MessageBox.Show(string.Concat(metin2));
            return metin;
        }
        public static int SubStringMethod(this string metin, int index)
        {
            string[] metin2 = new string[0];
            for (int i = index; i < metin.Length; i++)
            {
                Array.Resize(ref metin2, metin2.Length + 1);
                metin2[metin2.Length - 1] = metin[i].ToString();

            }
            MessageBox.Show(string.Concat(metin2));
            return 1;
        }
        public static int ToCharArrayMethod(this string metin)
        {
            char[] dizi = new char[0];
            for (int i = 0; i < metin.Length; i++)
            {
                Array.Resize(ref dizi, dizi.Length + 1);
                dizi[dizi.Length - 1] = metin[i];
                MessageBox.Show(dizi[i].ToString());
            }
            return 0;
        }
        public static bool EndWithMethod(this string metin1, string sonIfade, bool result)
        {
            int sayac = 0;
            for (int i = 0, j =0; i <sonIfade.Length; i++, j++)
            {
                if (sonIfade.Length > metin1.Length)
                {
                    MessageBox.Show("Hata!Girdiğiniz ifade, metnin uzunluğundan fazladır.");
                    break;
                }
                if (metin1[i+metin1.Length-sonIfade.Length] == sonIfade[j])
                {
                    sayac++;

                }


            }

            if (sayac == sonIfade.Length)
            {
                result = true;
                MessageBox.Show($"Metin {sonIfade} ile bitmektedir.");
            }
            else
            {
                MessageBox.Show($"Metin {sonIfade} ile bitmemektedir.");
            }
            return result;

        }
    }

}
