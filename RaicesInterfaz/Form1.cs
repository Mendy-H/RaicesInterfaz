namespace RaicesInterfaz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtA.Text, out int a) ||
    !int.TryParse(txtB.Text, out int b) ||
    !int.TryParse(txtC.Text, out int c))
            {
                MessageBox.Show("Ingresa números enteros en A, B y C.");
                return;
            }

            if (a == 0)
            {
                MessageBox.Show("A no puede ser 0.");
                return;
            }

            Raices raices = new Raices(a, b, c);
            raices.CalcularRaices();

            lblTipo.Text = raices.Tipo;
            txtX1.Text = raices.X1;
            txtX2.Text = raices.X2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
