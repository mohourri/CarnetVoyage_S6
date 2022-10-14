using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carnetVoyage
{
    internal class Reservation
    {
        int ID;
        List<Activite> activites;
        Client client;
        DateTime dateDebut;
        DateTime dateFin;

        public Reservation( List<Activite> activites, Client client, DateTime dateDebut, DateTime dateFin)
        {

            this.activites = activites;
            this.client = client;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
        }

        public int ID1 { get => ID; }
        public DateTime DateDebut { get => dateDebut; set => dateDebut = value; }
        public DateTime DateFin { get => dateFin; set => dateFin = value; }
        internal List<Activite> Activites { get => activites; set => activites = value; }
        internal Client Client { get => client; set => client = value; }

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
