using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdapter
{
    class MercadoPago : IMercadoPagoPayment
    {
        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void CreatePayment()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento com Mercado Pago.");
        }

        public void GetPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com Mercado Pago.");
        }
    }
}
