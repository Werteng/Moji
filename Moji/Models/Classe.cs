using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moji.Entities
{
    public class Classe
    {
        public int Id { get; set; }

        public string Libelle { get; set; }
        public float MultiMana { get; set; }
        public float MultiSante { get; set; }
        public List<Sort> Sorts { get; set; }
        public List<Arme> Armes { get; set; }
        public List<Personnage> Personnages { get; set; }
    }
}
