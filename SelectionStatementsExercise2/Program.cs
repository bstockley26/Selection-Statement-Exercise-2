namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Which one of the following classes are your favorite?" +
                " Math, Science, Gym, Art, or Coding");

            string favClass = Console.ReadLine();

            switch (favClass.ToLower())
            {
                case "math":
                    Console.WriteLine("Thats crazy math is way to hard!!!");
                    break;
                case "science":
                    Console.WriteLine("I always thought science was pretty cool too!!!");
                    break;
                case "gym":
                    Console.WriteLine("I think we would get along!!!");
                    break;
                case "art":
                    Console.WriteLine("Feel free to paint something for me then Picasso!!");
                    break;
                case "coding":
                    Console.WriteLine("NERD!!!!!!!!!");
                    break;
            }
        }
    }
}