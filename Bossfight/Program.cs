namespace Bossfight
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome, hero! Press C) to let the battle commence");
            string input = Console.ReadLine();
            if (input == "C")
            {
                GameCharacter.Fight(100, 40, 400, 10);
            }
            
            
        }
    }
}
