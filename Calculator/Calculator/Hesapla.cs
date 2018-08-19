using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Hesapla
    {
        public Form1 frm1;

        public int topla(int gelendeger2)
        {
            int sonuc = frm1.ilkdeger + gelendeger2;
            return sonuc;
        }
        public int cikar(int gelendeger2)
        {
            int sonuc = frm1.ilkdeger - gelendeger2;
            return sonuc;
        }
        public int carp(int gelendeger2)
        {
            int sonuc = frm1.ilkdeger * gelendeger2;
            return sonuc;
        }
        public int bol(int gelendeger2)
        {
            int sonuc = frm1.ilkdeger / gelendeger2;
            return sonuc;
        }
    }
}
