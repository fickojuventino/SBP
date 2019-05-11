using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MotornaVozila.Entiteti
{
    public class Kupac
    {
        public virtual int id { get; protected set; }
        public virtual string ime { get; set; }
        public virtual string prezime { get; set; }
        public virtual long telefon { get; set; }
        public virtual string tipLica { get; set; }
        public virtual long pib { get; protected set; }
        public virtual long maticniBroj { get; protected set; }

        public virtual IList<Vozilo> vozila { get; set; }
        
        public Kupac()
        {
            vozila = new List<Vozilo>();
        }
    }
}
