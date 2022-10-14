namespace carnetVoyage
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inscription insf = new Inscription();
            insf.Closed += (s, args) => this.Close();
            insf.StartPosition = FormStartPosition.CenterScreen;
            insf.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Hide();
            AdminMain am = new AdminMain();
            am.Closed += (s, args) => this.Close();
            am.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            label1.BackColor = System.Drawing.Color.Transparent;
            label2.BackColor = System.Drawing.Color.Transparent;
            label3.BackColor = System.Drawing.Color.Transparent;
            label4.BackColor = System.Drawing.Color.Transparent;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}