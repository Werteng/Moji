using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moji.Entities
{
    public class Arme
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public int Degat { get; set; }
        public string Description { get; set; }
        public int IdClasse { get; set; }
        public Classe Classe { get; set; }
    }
}
