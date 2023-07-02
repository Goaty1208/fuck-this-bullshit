// See https://aka.ms/new-console-template for more information
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "batshit";

            Console.WriteLine("Type a funny joke");
            string joke = Console.ReadLine();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("'" + joke + "'" +"\nReally. This was the best you could do?\nHow old even are you for fuck's sake?");

            int age;

            age = Convert.ToInt16( Console.ReadLine() );

            Console.WriteLine(age + ".\nYour stupidity is tragic. Is this true?");

            bool stupidity = Convert.ToBoolean( Console.ReadLine() );
            if( stupidity == true){
                Console.WriteLine("Well, at least you ain't THAT bad.\nPerhaps your retardation is only minor, or maybe it isn't.");
                if(age <= 14){
                    Console.WriteLine("Although since you are " + age + " it kinda explains the whole thing.");
                } else
                {
                    Console.WriteLine("You should be mature by now.\nBut no, you chose to be a retarded kid.");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Let's see, maybe I can help you.\nI'll tell you whether you are totally retarded or not\nbased on a simple question.");

                    string answer;
                    bool isRetard;

                    Console.WriteLine("Are you dumb as shit? Dumber than a fucking retarded ass donkey?");
                    answer = Console.ReadLine().ToLower();
                    if ( answer == "yes")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        isRetard = true;
                        Console.WriteLine("Ah well, congrats. You are officially retarded.\nPress any key to leave...");
                        Console.ReadKey(true);
                        Environment.Exit(0);
                    }

                }
            }

            Console.WriteLine("\nI am fucking done with you. \nPress any key to fuck off...");
            Console.ReadKey(true);
        }
    }
}
