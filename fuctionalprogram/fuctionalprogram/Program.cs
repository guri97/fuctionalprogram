namespace fuctionalprogram
{
    class functionalprogrm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for relative problem.");
            Console.WriteLine("1 for a flip coin and print percentage of Heads and  Tails");
            Console.WriteLine("2 for a leap year");
            Console.WriteLine("3 for a power of 2");
            Console.WriteLine("4 for a harmonic number");
            Console.WriteLine("5 for a factors");
            Console.WriteLine("6 for a Quotient and Remainder");
            Console.WriteLine("7 for a Swap Number ");
            Console.WriteLine("8 for a even and odd number ");
            int function = Convert.ToInt32(Console.ReadLine());



            switch (function)
            {
                case 1:
                    Flipcoin flipCoin = new Flipcoin();
                    flipCoin.FlipCoin_Percentage();
                    break;

                case 2:
                    Leapyear leapYear = new Leapyear();
                    leapYear.Leap_year();
                    break;

                case 3:
                    Power_of_2 Power = new Power_of_2();
                    Power.PowerOfTwo();
                    break;

                case 4:
                    Harmonic_Number harmonic = new Harmonic_Number();
                    harmonic.Harmonic();
                    break;

                case 5:
                    Factors factor = new Factors();
                    factor.PrimeFactors();
                    break;

                case 6:
                    QuotientAndRemainder QuotientRemain = new QuotientAndRemainder();
                    QuotientRemain.CompQuotient();
                    break;

                case 7:
                    Swaping_Two_Numbers Swap = new Swaping_Two_Numbers();
                    Swap.SwapTwoNumber();
                    break;

                case 8:
                    EvenOdd even = new EvenOdd();
                    even.evenOdd();
                    break;
            }
        }
    }
}
