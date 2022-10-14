using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carnetVoyage
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void Inscription_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Hide();
            Login lf = new Login();
            lf.Closed += (s, args) => this.Close();
            lf.StartPosition = FormStartPosition.CenterScreen;
            lf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cin = textBox5.Text;
            string nom = textBox1.Text;
            string prenom =textBox2.Text;
            string tele = textBox3.Text;
            string email = textBox4.Text;
            string password = textBox6.Text;
            DateTime dateNaiss = this.dateTimePicker1.Value;

            Client cl = new Client(cin, nom, prenom, dateNaiss, tele, email, password);


        }
    }
}
