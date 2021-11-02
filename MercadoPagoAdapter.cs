using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdapter
{
    class MercadoPagoAdapter : IPayPalPayment
    {
        private MercadoPago mercadoPago;

        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            this.mercadoPago = mercadoPago;
            Console.WriteLine("Realizando Adaptação de Mercado Pago para os métodos do PayPal");
        }

        public Token AutToken()
        {
            return this.mercadoPago.AuthToken();
        }

        public void PayPalPayment()
        {
            this.mercadoPago.CreatePayment();
        }

        public void PayPalReceive()
        {
            this.mercadoPago.GetPayment();
        }
    }
}
