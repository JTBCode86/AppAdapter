using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppAdapter
{
    interface IPayPalPayment
    {
        Token AutToken();
        void PayPalPayment();
        void PayPalReceive();

    }
}
