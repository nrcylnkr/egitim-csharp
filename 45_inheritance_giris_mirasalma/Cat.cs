using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45_inheritance_giris_mirasalma
{
    public class Cat : Animal
    {
        //: üst üste koyarak Animal classından miras alıyoruz
        //buraya hiç birşey yazılmayacak. içi bol olmalı.


        public string cat_eyes_color;

        public void CatMethod()
        {
            Console.WriteLine("Kedi Miyavlıyor...");
        }

    }
}
