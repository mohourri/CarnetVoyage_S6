using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carnetVoyage
{
    internal class Activite
    {
        int ID;
        string nomAct;
        int nbPersonnes;
        float prix;
        DateTime dateHeur;
        CategorieAct categorie;

        public Activite( string nomAct, int nbPersonnes, float prix, DateTime dateHeur, CategorieAct categorie)
        {
            this.nomAct = nomAct;
            this.nbPersonnes = nbPersonnes;
            this.prix = prix;
            this.dateHeur = dateHeur;
            this.categorie = categorie;
        }

        public int ID1 { get => ID;}
        public string NomAct { get => nomAct; set => nomAct = value; }
        public int NbPersonnes { get => nbPersonnes; set => nbPersonnes = value; }
        public float Prix { get => prix; set => prix = value; }
        public DateTime DateHeur { get => dateHeur; set => dateHeur = value; }
        internal CategorieAct Categorie { get => categorie; set => categorie = value; }

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
