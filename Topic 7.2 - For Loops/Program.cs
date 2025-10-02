namespace Topic_7._2___For_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //FavFood();
            //Clear();

            //Counter();
            //Clear();

            //CountingMachine();
            //Clear();

            //Assigments

            //BlastOff();
            //Clear();

            //XYCount();
            //Clear();

            TenNames();
            Clear();

        }

        public static void Clear()
        {
            Console.WriteLine();
            Console.WriteLine("press ENTER to continue");
            Console.ReadLine();
            Console.Clear();
        }

        public static void FavFood()
        {
            string favFood;

            Console.WriteLine("Enter your favourite food, and I'll display it ten times.");
            Console.Write("Favourite Food: ");
            favFood = Console.ReadLine();
            for (int i = 1; i <= 10; i = i + 1)
                Console.WriteLine(i + ". " + favFood + " is delicious.");

            Console.ReadLine();
        }

        public static void Counter()
        {
            int total;

            Console.WriteLine("How high would you like to count? ");
            int.TryParse(Console.ReadLine(), out total);

            for (int i = 1; i <= total; i = i + 1)
                Console.Write(" " + i);
        }

        public static void CountingMachine()
        {
            int min, max, multiplier;

            Console.Write("Count from : ");

            while (!int.TryParse(Console.ReadLine(), out min))
                Console.Write("Count from : ");

            Console.Write("Count to : ");

            while (!int.TryParse(Console.ReadLine(), out max))
                Console.Write("Count to : ");

            Console.Write("Count by : ");

            while (!int.TryParse(Console.ReadLine(), out multiplier))
                Console.Write("Count by : ");

            for (int i = min; i <= max; i = i + multiplier)
                Console.WriteLine(i);


        }

        //ASSIGNMENTS
        public static void BlastOff()
        {
            for (int i = 10; i >= 0; i = i - 1)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("BLAST OFF!");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static void XYCount()
        {
            Console.WriteLine("X \t Y ");
            Console.WriteLine("-----------");
            for (int i = -10; i <= 10; i = i + 2)
            {
                Console.WriteLine(i + "\t" + (i * i));
            }
        }

        public static void TenNames()
        {
            int max = 10;
            string name;
            
            Console.Write("What is your name? ");
            name = Console.ReadLine();
            
            if (name.ToLower() == "aldworth")
                max = 5;

            for (int i = 1; i <= max; i += 1)
                Console.WriteLine(i + ". " + name);
            

        }
    }

}
