using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class OgrenciClass
    {
        public int id { get; set; }
        public string OgrenciAd { get; set; } = string.Empty;
        public string OgrenciSoyad { get; set; } = string.Empty;
        public string OgrenciOkulNo { get; set ; } = string.Empty;
        public string OgrenciSinif { get; set; } = string.Empty;
        public string OgrencininFirmaAdi { get; set; } = string.Empty;
        public string OgreciTelNo { get; set; } = string.Empty;
        public string OgrenciTCKimlikNo { get; set; } = string.Empty;
        public string OgrenciAlanAdi { get; set; } = string.Empty;
        public string OgrenciDalAdi { get; set; } = string.Empty;
        public string OgrenciGrup { get; set; } = string.Empty;
        public DateTime OgrenciStajaBaslangicTarihi { get; set; }
        public DateTime OgrenciStajBitistarihi { get; set; }
        public string OgrenciKoordinatorOgretmeni { get; set; } = string.Empty;
        public string OgrenciStajDonemi { get; set; }
    }
}
