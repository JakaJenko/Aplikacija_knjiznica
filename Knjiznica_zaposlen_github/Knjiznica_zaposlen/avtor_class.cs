using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica_zaposlen
{
    class avtor_class
    {
        public string ImeInPriimek;
        public string Id;

        public avtor_class(string _ImeInPriimek, string _Id)
        {
            ImeInPriimek = _ImeInPriimek;
            Id = _Id;
        }
    }
}
