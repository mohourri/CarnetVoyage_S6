using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carnetVoyage
{
    internal class Client
    {
        string CIN;
        String nom;
        string prenom;
        DateTime dateNaiss;
        string tele;
        string email;
        string password;

        public Client() { }
        public Client(string cin,string nom, string prenom, DateTime dateNaiss, string tele, string email, string password)
        {
            this.CIN = cin;
            this.nom = nom;
            this.prenom = prenom;
            this.tele = tele;
            this.email = email;
            this.password = password;
            this.dateNaiss = dateNaiss;
        }

        public string CIN1 { get => CIN; set => CIN = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Tele { get => tele; set => tele = value; }
        public string Email { get => email; set => email = value; }
        public string Password { get => password; set => password = value; }
        public DateTime DateNaiss { get => dateNaiss; set => dateNaiss = value; }

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
            return "CIN: " + this.CIN + " nom: " + this.nom + " prenom:"
                + this.prenom + " date de naissance: " + this.dateNaiss +
                " telephone: " + this.tele + " email:" + this.email + 
                " mot de pass:" + this.Password;
        }
    }
}
