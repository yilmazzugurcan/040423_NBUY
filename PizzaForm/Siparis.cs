using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaForm
{
    internal class Siparis
    {
        public Pizza Pizza { get; set; }
        public int adet { get; set; }
        public decimal toplamtutar { get; set; }

        public override string ToString()
        {
            //string spr = "";
            //spr += Pizza.Ebati.Adi + ",";
            //spr += Pizza.Adi + ",";
            //spr += Pizza.KenarTipi.Adi + ",";
            //foreach (string mlz in Pizza.Malzemeler)
            //{
            //    spr += string.Format("{0},", mlz);
            //}
            //spr += string.Format("{0}x{1}={2}");

           return string.Format("Pizza Adı: {0}, Ebatı: {1}, Kenar Tipi: {2} Malzemeler: {3}, Fiyatı: {4}", Pizza.Adi,Pizza.Ebati.Adi,Pizza.KenarTipi.Adi,Pizza.Malzemeler.Count,Pizza.tutar);
        }
    }
}
