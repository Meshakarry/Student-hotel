using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Studentski_hotel.Models.Recepcija
{
    public class PregledObavijesti
    {
        public int obavijestID { get; set; }
        public string ImeRecepcionera { get; set; }
        public string DatumObj { get; set; }

        public string Naslov { get; set; }
        public string Text { get; set; }

        
    }
}
