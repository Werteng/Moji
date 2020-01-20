using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Moji.Entities
{
    public class Personnage
    {
        public Personnage()
        {
            this.ManaActuel = 20;
            this.ManaMax = 120;
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string AvatarUrl { get; set; }
        public float Or { get; set; }
        public float SanteActuel { get; set; }
        public float SanteMax { get; set; }
        public float ManaActuel { get; set; }
        public float ManaMax { get; set; }
        public float Xp { get; set; }
        public int Niveau { get; set; }
        public string Genre { get; set; }
        public int IdRace  { get; set; }
        public Race Race { get; set; }
        public int IdClasse { get; set; }
        public Classe Classe { get; set; }
    }
}
