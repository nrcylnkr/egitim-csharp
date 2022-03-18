using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44_Array_List
{
    class Program
    {
        static void Main(string[] args)
        {

            //Array List nedir...

            /* string[] names = { "Nur", "Ceylan", "Enes" };  //ilkel dizi yöntemi- Array list ile bunları yapmamıza gerek kalmayacak.
             foreach (string name in names)
             {
                 Console.WriteLine(name);*/

            /* ArrayList koleksiyon = new ArrayList();   // bu classtır.

             koleksiyon.Add("Nur Ceylan");  // Add içine bir tane string eklenir
             koleksiyon.Add("Enes");
             koleksiyon.Add("Özdemir");
             koleksiyon.Add("21.10.2020");*/

            //koleksiyon.Remove("Özdemir");  //o satırı yazdırmaz
            //int count = koleksiyon.Count;    // Dizinin eleman sayısını gösterir.
            //koleksiyon.Clear(); // Araylist dizisinin içindeki tüm elemanları temizler yani yazdırmaz.
            //bool kontrol = koleksiyon.Contains("Enes");  //Dizinin içinde var mı diye aratabiliriz varsa True yoksa False
            //int index = koleksiyon.IndexOf("Enes");  // içinde yazdırdığımız kaçıncı indeksi onu gösterir
            //koleksiyon.Insert(3, "Evlendi");   //belirttiğimiz diziye eleman ekleyebiliriz
            //koleksiyon.Reverse(); // Ters çevirme- aşağıdan yukarı okuma

            /* foreach (var a in koleksiyon) 
            {
                Console.WriteLine(a);
            }*/

            //Console.WriteLine("Dizinin Elaman Sayısı : "+ count);
            //Console.WriteLine("Enes Var mı?"+kontrol);
            //Console.WriteLine("Index No: " + index);


            //-------------------------------------------------------------------------

            /*ArrayList rakamlar = new ArrayList();
            rakamlar.Add(5);
            rakamlar.Add(3);
            rakamlar.Add(1);
            rakamlar.Add(100);
            rakamlar.Add(24);


            rakamlar.Sort();  // diziyi küçükten büyüğe sıralar
           



            foreach (int b in rakamlar)
            {
                Console.WriteLine(b);
            }*/


            //---------------------------------------------------------------------------------


            int x = 10;
            string y = x.ToString();  //bir değeri string veri tipine dönüştürür







            Console.ReadLine();
            
        }
    }
}
