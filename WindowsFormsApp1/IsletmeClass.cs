using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class IsletmeClass
    {
        public int id { get; set; }
        public string IsletmeAd { get; set; }
        public string IsletmeAdresIl { get; set; }
        public string IsletmeAdresIlce { get; set; }
        public string IsletmeTamAdres { get; set; } = string.Empty;
        public string IsletmeYetkilisi { get; set; } = string.Empty;
        public string IsletmeSicilNo { get; set; } = string.Empty;
        public string IsletmeIbanNo { get; set; } = string.Empty;
        public string IsletmeUstaOgreticiAdi { get; set; } = string.Empty;
        public string IsletmeUstaOgreticiSoyadi { get; set; } = string.Empty;
        public string IsletmeUstaOgreticiTcNo { get; set; } = string.Empty;
        public DateTime IsletmeUstaOgreticiDogumTarihi { get; set; }
        public string IsletmeTelNo { get; set; } = string.Empty;
        public string IsletmeUstaOgreticilikVarmiYokmu { get; set; } = string.Empty;
        public string IsletmeBolum { get; set; } = string.Empty;
        public string IsletmeDal { get; set; } = string.Empty;
    }
}