namespace PiedraPapelTijera
{
    public partial class PiedraPapelTijera : Form
    {
        public PiedraPapelTijera()
        {
            InitializeComponent();
        }

        private void PiedraPapelTijera_Load(object sender, EventArgs e)
        {

        }
        private string GetRandomOption()
        {
            string[] options = { "Piedra", "Papel", "Tijera" };
            Random random = new Random();
            return options[random.Next(0, 3)];
        }
        private void btnPiedra_Click(object sender, EventArgs e)
        {
            lblMaquinaEligio.Text = "La máquina eligió:";
            string randomOption = GetRandomOption();
            string userOption = "Piedra";
            if (randomOption == userOption)
            {
                lblMaquinaEligio.Text += " Piedra. Es un empate";
            }
            else if (randomOption == "Papel")
            {
                lblMaquinaEligio.Text += " Papel. Perdiste";
            }
            else
            {
                lblMaquinaEligio.Text += " Tijera. Ganaste";
            }
        }
        private void btnPapel_Click(object sender, EventArgs e)
        {
            lblMaquinaEligio.Text = "La máquina eligió:";
            string randomOption = GetRandomOption();
            string userOption = "Papel";
            if (randomOption == userOption)
            {
                lblMaquinaEligio.Text += " Papel. Es un empate";
            }
            else if (randomOption == "Tijera")
            {
                lblMaquinaEligio.Text += " Tijera. Perdiste";
            }
            else
            {
                lblMaquinaEligio.Text += " Piedra. Ganaste";
            }
        }
        private void btnTijera_Click(object sender, EventArgs e)
        {
            lblMaquinaEligio.Text = "La máquina eligió:";
            string randomOption = GetRandomOption();
            string userOption = "Tijera";
            if (randomOption == userOption)
            {
                lblMaquinaEligio.Text += " Tijera. Es un empate";
            }
            else if (randomOption == "Piedra")
            {
                lblMaquinaEligio.Text += " Piedra. Perdiste";
            }
            else
            {
                lblMaquinaEligio.Text += " Papel. Ganaste";
            }
        }
    }
}
