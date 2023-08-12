using System;

namespace Homework
{
    internal class Money
    {
        private int integral;
        private int unintegral;
        private string currency;
        public Money()
        {
            integral = 0;
            unintegral = 0;
        }
        public Money(int integral, int unintegral, string currency)
        {
            this.integral = integral;
            this.unintegral = unintegral;
            this.currency = currency;
        }
        public int Integral
        {
            get => integral; 
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Integral part of the sum caanot be negative");
                }
                integral = value; 
            }
        }
        public int Unintegral
        {
            get => unintegral; 
            set
            {
                if (value < 0 || value > 99)
                {
                    throw new ArgumentException("Unintegral part of the sum cannot be negative or greater than 99");
                }
                unintegral = value;
            }
        }
        public string Currency
        {
            get => currency; set => currency = value;
        }
        public void Edit(int new_integral)
        {
            integral = new_integral;
        }
        public void Edit(int new_integral, int new_unintegral)
        {
            integral = new_integral;
            unintegral = new_unintegral;
        }
        public override string ToString()
        {
            return $"Sum: {integral}.{unintegral:d2} {currency}";
        }
    }
    internal class Product : Money
    {

    }
}
