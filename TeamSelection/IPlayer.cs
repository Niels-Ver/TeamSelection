using System;
using System.Collections.Generic;
using System.Text;

namespace TeamSelectie
{
    public interface IPlayer
    {
        public string TypeSpeler { get; set; }
        public string Naam { get; set; }
        public int Rugnummer { get; set; }
        public List<string> Posities { get; set; }
        public int Rating { get; set; }
        public int Caps { get; set; }
    }
}
