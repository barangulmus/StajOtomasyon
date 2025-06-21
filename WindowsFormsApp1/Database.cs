using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace WindowsFormsApp1
{
    public class Database : DbContext
    {
        public Database() : base("connect")
        {

        }
        public DbSet<OgrenciClass> OgrenciTablo { get; set; }
        public DbSet<OgretmenClass> OgretmenTablo { get; set; }
        public DbSet<IsletmeClass> IsletmeTablo { get; set; }
        public DbSet<SettingsClass> SettingsTablo { get; set; }
        public DbSet<QRClass> QRTablo { get; set; }

        public bool DatabaseExists()
        {
            try
            {
                // Veritabanının varlığını kontrol et
                return this.Database.Exists();
            }
            catch
            {
                return false;
            }
        }

        public void CreateDatabase()
        {
            // Veritabanını oluştur
            this.Database.CreateIfNotExists();
        }
    }
}