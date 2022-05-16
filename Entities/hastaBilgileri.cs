using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisHekimiUygulamasi.Entities
{
    class hastaBilgileri
    {
        public int hastaBilgileriId { get; set; }
        public string hastaAdi { get; set; }
        public string hastaSoyadi { get; set; }
        public int hastaTc { get; set; }
        public int hastaNumarasi { get; set; }
        public int hastaYasi { get; set; }
        public string Cinsiyet { get; set; }
    }
}
