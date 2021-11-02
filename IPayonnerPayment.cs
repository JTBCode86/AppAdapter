namespace AppAdapter
{
    interface IPayonnerPayment
    {
        Token AuthToken();
        void SendPayment();
        void ReceivePayment();

    }
}
