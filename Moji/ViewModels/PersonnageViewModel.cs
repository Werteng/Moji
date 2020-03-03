using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Moji.ViewModels
{
    public class PersonnageViewModel 
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int IdRace { get; set; }
        public List<SelectListItem> RaceItems { get; set; }
        public int IdClasse { get; set; }
        public int Id { get; set; }

        public List<SelectListItem> ClassItems { get; set; }

    }
}
