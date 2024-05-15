using PinPadLibraryBP;
using PinPadLibraryBP.Models;

namespace Demo_DNU
{

    public partial class Form1 : Form
    {
        PinpadPayment payment = new PinpadPayment();
        StatusConnection sc;
        public Form1()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal amount = 0;
            int months = 0;
            if (sc.estatus == "Conectado")
            {
                amount = decimal.Parse(txt_months.Text);
                MyPaymentResult response = payment.process(amount);
                Console.WriteLine("respuesta: {0}, {1}, {2}, {3}, {4}, {5}, {6}, {7},{8}", response.Code, response.Description, response.Auth, response.Card, response.Cardholder, response.CardType, response.ARQC, response.AID, response.License);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            sc = payment.PinpadConnection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            payment.generateOrRenewLicense();
        }

     
    }
}
