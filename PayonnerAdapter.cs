using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdapter
{
    class PayonnerAdapter : IPayPalPayment
    {
        private Payonner payonner;
        public PayonnerAdapter(Payonner payonner)
        {
            this.payonner = payonner;
            Console.WriteLine("Realizando Adaptação de Payonner para os métodos do PayPal.");
        }

        public Token AutToken()
        {
            return this.payonner.AuthToken();
        }

        public void PayPalPayment()
        {
            this.payonner.ReceivePayment();
        }

        public void PayPalReceive()
        {
            this.payonner.SendPayment();
        }
    }
}
