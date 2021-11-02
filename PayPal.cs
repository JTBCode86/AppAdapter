using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdapter
{
    class PayPal : IPayPalPayment
    {
        private Token token;

        public Token AutToken()
        {
            return new Token();
        }

        public void PayPalPayment()
        {
            token = AutToken();
            Console.WriteLine("Enviando pagamento com PayPal.");
        }

        public void PayPalReceive()
        {
            Console.WriteLine("Recebendo pagamento com PayPal.");
        }
    }
}
