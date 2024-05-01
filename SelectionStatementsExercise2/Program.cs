namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Which one of the following classes are your favorite?");

            string favClass = Console.ReadLine();

            switch (favClass.ToLower())
            {
                case "math":
                case "mathmatics"
:                    Console.WriteLine("Thats crazy math is way to hard!!!");
                    break;
                case "science":
                    Console.WriteLine("I always thought science was pretty cool too!!!");
                    break;
                case "gym":
                case "p.e":
                    Console.WriteLine("I think we would get along!!!");
                    break;
                case "art":
                    Console.WriteLine("Feel free to paint something for me then Picasso!!");
                    break;
                case "coding":
                    Console.WriteLine("NERD!!!!!!!!!");
                    break;
                default:
                        Console.Write("that was fun too");
                    break;
            }
        }
    }
}