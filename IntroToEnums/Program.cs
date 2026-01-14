namespace IntroToEnums
{
    internal class Program
    {
        enum CardValue
        {
            Two = 2,
            Three, Four, Five, Six, Seven, Eight, Nine, Ten,
            Jack, Queen, King, Ace
        }

        enum Suit
        {
            Heart, Diamond, Club, Spade
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
