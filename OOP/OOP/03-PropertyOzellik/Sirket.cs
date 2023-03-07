using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_PropertyOzellik
{
    public class Sirket
    {
        //kısa yazılmış hali
        public string Adi { get; set; }
        public string Adres { get; set; }


        //Uzun hali
        private string _PostaKodu;

        public string PostaKodu
        {
            get { return _PostaKodu; }
            set { _PostaKodu = value; }
        }



        //derleme sonrasında bu metotlar gelecek şekilde kodlar revize ediliyor.
        public string GetPostaKodu()
        {
            return _PostaKodu;
        }

        public void SetPostaKodu(string postaKodu)
        {
            _PostaKodu = postaKodu;
        }


        //field
        private decimal _Ciro;

        public decimal Ciro
        {
            get
            {
                return _Ciro;
            }
            set
            {
                if (value > 100)
                    _Ciro = 100;
                else
                    _Ciro = value;
            }
        }

    }
}
