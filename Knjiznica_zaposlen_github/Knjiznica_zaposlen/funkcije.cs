using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knjiznica_zaposlen
{
    class funkcije
    {
        public static string and(string query, bool dodaj)
        {
            if (dodaj == true)
            {
                query = query + " AND ";
            }
            return query;
        }

        public static string date_time()
        {
            string datumInCas="";

            datumInCas = DateTime.Now.Year.ToString() + "_" + DateTime.Now.Month.ToString() + "_" + DateTime.Now.Day.ToString();

            return datumInCas;
        }
    }
}
