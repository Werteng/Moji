using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moji.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string email { get; set; }
        public string motDePasse { get; set; }

        public List<Personnage> Personnages { get; set; }
    }
}
