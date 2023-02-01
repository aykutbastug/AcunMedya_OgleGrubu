using MFramework.Services.FakeData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace WebApplication1.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MusteriController : ControllerBase
    {
        [HttpGet("TumMusteriler")]
        public List<Musteri> TumMusteriler()
        {
            List<Musteri> musteriler = new List<Musteri>();
            for (int i = 0; i < 5; i++)
            {
                musteriler.Add(new Musteri { 
                    AdiSoyadi = NameData.GetFullName(),
                    Departman = NameData.GetDepartmentName(),
                    Id= i,
                    KayitTarihi = DateTimeData.GetDatetime(),
                    ToplamBorc = NumberData.GetDouble()
                });
            }

            return musteriler;

        }

        [HttpPost("MusteriOlustur")]
        public ActionResult MusteriOlustur(Musteri musteri)
        {

            //return Ok(musteri);
            return BadRequest();
        }


        [HttpGet("MusteriFiltrele/{musteriId}")]
        public List<Musteri> MusteriFiltrele(int musteriId)
        {
            List<Musteri> musteriler = new List<Musteri>();
            for (int i = 0; i < 5; i++)
            {
                musteriler.Add(new Musteri
                {
                    AdiSoyadi = NameData.GetFullName(),
                    Departman = NameData.GetDepartmentName(),
                    Id = i,
                    KayitTarihi = DateTimeData.GetDatetime(),
                    ToplamBorc = NumberData.GetDouble()
                });
            }

            return musteriler.Where(x => x.Id > musteriId).ToList();

        }

    }
}
