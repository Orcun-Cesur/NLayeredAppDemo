using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Entities.Concrete
{
    public class Products
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Yil { get; set; }
        public decimal Fiyat { get; set; }
        public string KullaniciAdi { get; set; }
        public char TelefonNo { get; set; }
        public DateTime BirakmaTarihi { get; set; }
    }
}
