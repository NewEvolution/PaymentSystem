using System.Globalization;

namespace PaymentSystem
{
    public class Payment
    {
        public string CustomerName{get; set;}
        public decimal Amount{get; set;}

        public virtual string MakePayment()
        {
            //TODO hit the payment processing API
            return $"{this.CustomerName} paid {this.Amount.ToString("C", CultureInfo.CurrentCulture)} in cash.";
        }

        public string SendConfirmation(string email)
        {
            return "You have purchased several nice items";
        }

        public string SendConfirmation(string email, bool digitalDownload)
        {
            return "Check your email for a dowload link.";
        }
    }
}