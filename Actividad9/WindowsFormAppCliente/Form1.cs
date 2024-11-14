using System.Security.Policy;

namespace WindowsFormAppCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tipo = 1;
            string dni = textBox1.Text;

            using var cliente = new HttpClient();

            string url = $"https://localhost:7124/api/Comercio/AgregarTicket?tipo={1}1&dni={dni}&nroCC=0";

            HttpRequestMessage consulta = new HttpRequestMessage();
            consulta.Method = HttpMethod.Get;
            consulta.RequestUri = new Uri(url);

            HttpResponseMessage respuesta =  cliente.Send(consulta);

            if (respuesta.IsSuccessStatusCode)
            {
                MessageBox.Show("Ok");
            }
            else
            {
                MessageBox.Show("No ok");
            }
        }
    }
}
