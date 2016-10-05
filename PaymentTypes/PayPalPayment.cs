using System.Globalization;
using System.Text;

namespace PaymentSystem
{
    public class PayPalPayment:Payment
    {
        public string Password{get; set;}
        public string Email{get; set;}
        public override string MakePayment()
        {
            StringBuilder sb = new StringBuilder();
            if (this.Amount > 0 && !System.String.IsNullOrWhiteSpace(this.Password))
            {
                sb.Append(this.CustomerName + " (" + this.Email + ") just paid ");
                sb.Append(this.Amount.ToString("C", CultureInfo.CurrentCulture) + " via PayPal.");
            }
            else
            {
                sb.Append("Invalid amount or password. No payment made.");
            }
            return sb.ToString();
        }
    }
}