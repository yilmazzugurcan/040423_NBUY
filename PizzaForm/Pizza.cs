using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaForm
{
    internal class Pizza
    {
        public string  Adi { get; set; }
        public decimal Fiyat { get; set; }
        public Ebat Ebati { get; set; }
        public KenarTip KenarTipi { get; set; }

        public List<string> Malzemeler { get; set; }
        public decimal tutar { 
            get 
            {
                decimal tutar = 0;
                tutar = Fiyat * (decimal)Ebati.Carpan;
                tutar += KenarTipi.ekFiyat;
                return tutar; 
            } 
        }
        public override string ToString()
        {
            return Adi;
        }





    }
}
