using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OO_FulbolOyunu
{
    class Oyunucu
    {

        public string ad;
        public byte no;
        public string takim;
       
        //constructer

        public Oyunucu()
        {

        }

        public Oyunucu(string adi, byte formatNo, string takimi)
        {
            this.ad = adi;
            this.no = formatNo;
            this.takim = takimi;
        }



        public string Bilgiver()
        {
            return this.ad + "\nNumarası:" + this.no + "\nTakımı:" + this.takim;
        }


        public override string ToString()
        {
            return this.ad;
        }

    }
}
