using System.Globalization;
using System.Text;

namespace PaymentSystem
{
    public class CreditCardPayment:Payment
    {
        public string CardNumber{get; set;}
        public override string MakePayment()
        {
            StringBuilder sb = new StringBuilder();
            if (this.Amount > 0 && this.CardNumber.Length >= 12 && this.CardNumber.Length <= 19)
            {
                sb.Append(this.CustomerName + " just paid ");
                sb.Append(this.Amount.ToString("C", CultureInfo.CurrentCulture) + " via credit card.");
            }
            else
            {
                sb.Append("Invalid amount or CC number. No payment made.");
            }
            return sb.ToString();
        }
    }
}