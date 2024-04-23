namespace shapeVirt
{
    internal class Program
    {
        public static void Result()
        {
            Console.WriteLine("For Triangel enter t ,for Rectangel enter r");
            string form = Console.ReadLine();
            switch (form.ToLower())
            {
                case "t":        
                    double a,b,c ;
                    do
                    {
                        Console.WriteLine("enter 1 number");
                    }
                    while (!double.TryParse(Console.ReadLine(), out a));
                    do
                    {
                        Console.WriteLine("enter 2 number");
                    }
                    while (!double.TryParse(Console.ReadLine(), out b));
                    do
                    {
                        Console.WriteLine("enter 3 number");
                    }
                    while (!double.TryParse(Console.ReadLine(), out c));
                    Triangel tri = new Triangel(a, b, c);
                    Console.WriteLine("P or S");
                    string optin = Console.ReadLine();
                    switch (optin.ToLower())
                    {
                        case "p":
                            Console.WriteLine(tri.Perimetr());
                            break;
                        case "s":
                            Console.WriteLine(tri.Area());
                            break;
                        default:
                            break;
                    }
                    break;
                case "r":
                    double length,width;
                    do
                    {
                        Console.WriteLine("enter width number");
                    }
                    while (!double.TryParse(Console.ReadLine(), out width));
                    do
                    {
                        Console.WriteLine("enter length number");
                    }
                    while (!double.TryParse(Console.ReadLine(), out length));
                    Rectangle rec = new Rectangle(width, length);
                    Console.WriteLine("P or S");
                    string optin1 = Console.ReadLine();
                    switch (optin1.ToLower())
                    {
                        case "p":
                            Console.WriteLine(rec.Perimetr());
                            break;
                        case "s":
                            Console.WriteLine(rec.Area());
                            break;
                        default:
                            break;
                    }


                    break;
                default:
                    break;
            }
        }

        static void Main(string[] args)
        {
            //Triangel a = new Triangel(3,5,4);
            //Console.WriteLine(a.Perimetr());
            //Console.WriteLine( a.Area());
            //Rectangle b = new Rectangle(1, 2);
            //Console.WriteLine(b.Perimetr());
            //Console.WriteLine(  b.Area());
            Result();
        }
    }
}
