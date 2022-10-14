using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carnetVoyage
{
    internal class CategorieAct
    {
        int ID;
        string categorie;

        public CategorieAct(string categorie)
        {
            this.categorie = categorie;
        }

        public int ID1 { get => ID;  }
        public string Categorie { get => categorie; set => categorie = value; }

        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
