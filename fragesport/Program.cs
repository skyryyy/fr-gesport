using System;

namespace fragesport
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Questionare!");

            Console.WriteLine("Please tell me your name!");

            string name;

            name = Console.ReadLine();

            Console.WriteLine("Player 1 will be... " + name + "!");

            Console.WriteLine("First question! Is a car a mode of transport?");

            Console.WriteLine("a) yes. b) no, its a banana. c) car?");

            int points = 0;

            string s = "";

            while (s != "a" && s != "b" && s != "c")
            {
                s = Console.ReadLine();
                {
                    if (s != "a" && s != "b" && s != "c")
                        Console.WriteLine("I'm not sure thats an answer.");
                    else if (s == "a")
                        points += 1;
                }
            }

            Console.WriteLine("Du har " + points + " poäng just nu");

            Console.WriteLine("Second question! Can you eat a banana?");

            Console.WriteLine("a) no, its a mode of transport. b) yes. c) No, it contains a poison so only monkeys can eat it.");

            string q = "";

            while (q != "a" && q != "b" && q != "c")
            {
                q = Console.ReadLine();
                {
                    if (q != "a" && q != "b" && q != "c")
                        Console.WriteLine("Still not an answer.");
                    else if (q == "b")
                        points += 1;
                }
            }

            Console.WriteLine("Du har " + points + " poäng just nu!");

            Console.WriteLine("Okejj, nu är det dags för sista frågan.");

            Console.WriteLine("Är denna quiz bra nog?");

            Console.WriteLine("a) Nej. b) kanske. c) Ja.");

            string e = "";

            while (e != "a" && e != "b" && e != "c")
            {
                e = Console.ReadLine();
                {
                    if (e != "a" && e != "b" && e != "c")
                        Console.WriteLine("Now youre just being stupid.");
                    else if (e == "c")
                        points += 1;
                }
            }

            if (points == 3)
                Console.WriteLine("Grattis, du fick 3 poäng och full pott.");

            else if (points <= 3)
                Console.WriteLine("Det där var inte dåligt, " + points + " poäng, men du kan bättre.");

            Console.ReadLine();






        }
    }
}
