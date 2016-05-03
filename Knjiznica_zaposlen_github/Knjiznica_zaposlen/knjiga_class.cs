using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica_zaposlen
{
    class knjiga_class
    {
        public string Id;
        public string Zalozba;
        public string Vrsta;
        public string Jezik;
        public string Avtor;
        public string Naslov;
        public string Leto;
        public string Opombe;
        public string ISBN;
        public string UKD;

        public knjiga_class(string _Id, string _Zalozba, string _Vrsta, string _Jezik, string _Avtor, string _Naslov, string _Leto, string _Opombe, string _ISBN, string _UKD)
        {
            Id = _Id;
            Zalozba = _Zalozba;
            Vrsta = _Vrsta;
            Jezik = _Jezik;
            Avtor = _Avtor;
            Naslov = _Naslov;
            Leto = _Leto;
            Opombe = _Opombe;
            ISBN = _ISBN;
            UKD = _UKD;
        }
    }
}
