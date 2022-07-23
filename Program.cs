using System;

namespace rekurisfVeExtensionMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // Normalde bir sayının karesini almak istiyorsak for döngüsü ile şöyle bir yönteme başvurulabilinir:

            int sonuc = 1;

            for (int i = 1; i < 3; i++)
                sonuc *= 5;

            Console.WriteLine(sonuc);

            dersMetotları metot1 = new();
            Console.WriteLine(metot1.Expo(5, 2));

            string isim = "Furkan Yılmaz";
            Console.WriteLine(Extensions.CheckSpaces(isim));

            Console.WriteLine(isim);
            Console.WriteLine(Extensions.RemoveWhiteSpaces(isim));
            Console.WriteLine(Extensions.MakeUpperCase(isim));
            Console.WriteLine(Extensions.MakeLowerCase(isim));

            int[] dizi = { 1, 2, 3, 6, 3, 8, 1, 0, 4, 3 };

            Extensions.ArraySort(dizi);
            Extensions.EkranaYazdir(dizi);

            int yas = 26;

            Console.WriteLine(Extensions.IsEvenNumber(yas));

            Console.WriteLine(Extensions.GetFirstCharacter(isim));
        }
    }

    class dersMetotları
    {
        public int Expo(int sayi, int üs)
        {
            if (üs < 2)
                return sayi;
            return Expo(sayi, üs - 1) * sayi;

            // 4, 3
            // (4,2) * 4
            // (4,1) * 4 * 4
            // 4 * 4 * 4
        }
    }

    public static class Extensions
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("*", dizi);
        }

        public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

        public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] ArraySort(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (int item in param)
                Console.WriteLine(item);
        }

        public static bool IsEvenNumber(this int param)
        {
            return param % 2 == 0;
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0, 1);
        }
    }
}