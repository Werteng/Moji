using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moji.Entities
{
    public class Sort
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public int Cout { get; set; }
        public string Description { get; set; }
        public int Degat { get; set; }
        public int IdClasse{ get; set; }
        public Classe Classe { get; set; }

    }
}
