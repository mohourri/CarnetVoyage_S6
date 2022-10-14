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
    public partial class AdminMain : Form
    {
        public AdminMain()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Activites af = new Activites();
            af.StartPosition = FormStartPosition.CenterScreen;
            af.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reservations rf = new Reservations();
            rf.StartPosition = FormStartPosition.CenterScreen;
            rf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clients cf = new Clients();
            cf.StartPosition = FormStartPosition.CenterScreen;
            cf.Show();
        }
    }
}
