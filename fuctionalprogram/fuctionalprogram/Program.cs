namespace fuctionalprogram
{
    class functionalprogrm
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for relative problem.");
            Console.WriteLine("1 for a flip coin and print percentage of Heads and  Tails");
            Console.WriteLine("2 for a leap year");
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
            }
        }
    }
}
