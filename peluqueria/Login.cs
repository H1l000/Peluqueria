namespace peluqueria
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inicio nuevaVentana = new Inicio(); 
            nuevaVentana.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
