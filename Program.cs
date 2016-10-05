using System;

namespace PaymentSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string response = "Invalid input. No payment made.";
            Payment payment = null;

            // Four arguments for PayPal payments
            if (args.Length == 4)
            {
                payment = new PayPalPayment
                {
                    CustomerName = args[0],
                    Amount = Convert.ToDecimal(args[1]),
                    Email = args[2],
                    Password = args[3]
                };
                response = payment.MakePayment();
            }
            // Three arguments for credit card payments
            else if (args.Length == 3)
            {
                payment = new CreditCardPayment
                {
                    CustomerName = args[0],
                    Amount = Convert.ToDecimal(args[1]),
                    CardNumber = args[2]
                };
                response = payment.MakePayment();
            }
            // Two arguments for credit card payments
            else if (args.Length == 2)
            {
                payment = new Payment
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