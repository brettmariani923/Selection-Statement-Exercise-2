using System.Text;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();

            



            switch (favoriteSubject)
            {
                case "Math":
                    Console.WriteLine("Math is really cool! You must be let brained. You'll make a ton of money someday!");
                break;
                case "Social Studies":
                    Console.WriteLine("Social studies is fun! Its great to know about people.");
                break;
                case "English":
                    Console.WriteLine("Engish is good to know because we all speak it! Its the foundation for everything else we do!");
                break;
                case "Science":
                    Console.WriteLine("Science is great because teaches us about the nature of things in the physical world! Always good to know as much about science as we can!");
                break;   
                case "Coding":
                    Console.WriteLine("Well, coding is the best subject of all! I hear they have great teachers over there at truecoders. If you're lucky, someday you can learn from them too!");
                 break;   
                default:
                     Console.WriteLine("Interesting choice! Thats a less common choice, still awesome though!");
                break;
                
            }
        }
    }
}