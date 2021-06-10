namespace PaymentContext.Domain.Commands
{
    public class CreatePayPalSubscriptionCommand
    {

        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public string Number { get; private set; }
        public string Address { get; private set; }

    }
}