using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SettingsClass
    {
        public int id { get; set; }
        public string OkulAdi{ get; set; }
        public string AlanAdlari { get; set; }
        public string AlanaAitDalAdlari { get; set; }
        public string SinifAdlari { get; set; }
        public string FirmIslemleriSayfasındaListelenecekIller { get; set; }
        public DateTime VarsayilanStajaBaslangicTarihi { get; set; }
        public DateTime VarsayilanStajBitisTarihi { get; set; }
        public bool ProgramHerAcildigindaSifreIstensinMi { get; set; }
        public string ProgramBaslatildigindaSolMenudenHangiButonOtomatikOlarakSecilsin { get; set; }
        public string ProgramBaslatildigindaUstMenudenHangiButonOtomatikOlarakSecilsin { get; set; }
        public bool ProgramBaslatildigindaSolMenudenHerhangiBirseySecilmesinBenSeceneKadarSagMenuAktifOlmasin { get; set; }
        public bool SolMenudeIsletmeSayisiVeDigerVerilerListelensinMi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string SorguOzellestirmeleriOgrenci { get; set; }
        public string SorguOzellestirmeleriOgretmen { get; set; }
        public string SorguOzellestirmeleriIsletme { get; set; }
        public string MudurYardimcisiAdi { get; set; }
        public string KoordinatorMuduryardimcisiIsmi { get; set; }
        public string okulMuduruIsmi { get; set; }
        public string EgitimOgretimYili { get; set; }
    }
}