namespace AppAdapter
{
    interface IMercadoPagoPayment
    {
        Token AuthToken();
        void CreatePayment();
        void GetPayment();
    }
}
