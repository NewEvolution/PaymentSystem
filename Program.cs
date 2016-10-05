using System;

namespace PaymentSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string response = "Invalid input. No payment made.";

            if (args.Length == 4)
            {
                PayPalPayment payment = new PayPalPayment
                {
                    CustomerName = args[0],
                    Amount = Convert.ToDecimal(args[1]),
                    Email = args[2],
                    Password = args[3]
                };
                response = payment.MakePayment();
            }
            else if (args.Length == 3)
            {
                CreditCardPayment payment = new CreditCardPayment
                {
                    CustomerName = args[0],
                    Amount = Convert.ToDecimal(args[1]),
                    CardNumber = args[2]
                };
                response = payment.MakePayment();
            }
            else if (args.Length == 2)
            {
                Payment payment = new Payment
                {
                    CustomerName = args[0],
                    Amount = Convert.ToDecimal(args[1])
                };
                response = payment.MakePayment();
            }

            Console.WriteLine(response);
        }
    }
}