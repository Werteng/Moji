using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moji.Entities
{
    public class Race
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public List<Personnage> Personnages { get; set; }

    }
}
