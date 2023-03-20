using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankaKartiOrnegi
{
    public interface IHavale
    {
        void HavaleGonder(string iban, decimal tutar);
    }

    public interface IPuan
    {
        public decimal KazanilanPuan { get; set; }
    }

    public interface IDiger
    {
        public bool EkKartMi { get; set; }

        public DateTime SonKullanimTarihi { get; set; }

        void BorcOde();
    }

    public interface IEft
    {
        void EftGonder(string iban, decimal tutar);
    }

    public interface ITaksit
    {
        void TaksitYap(decimal tutar, int taksitSayisi);
    }

}
