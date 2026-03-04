using My_Classes;
namespace OOP_Assignment_1
{

    class test
    {
        private int a = 0;
        public int b = 1;
        public int incrementA()
        {
            return a++;
        }
    }

    struct test1
    {
        int value;
        int value1;
        public void print()
        {
            Console.WriteLine($"{value}, {value1}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01
            #region Question 1
            // Class
            // Refeere Type Stored in heap / copies refernce / used for complex data
            // Struct 
            // value type Stored in stack / cpies data / use for simple data


            #endregion

            #region Question 2
            test testobj = new test();
            // private 
            // cannot be accessed outside class
            // testobj.a // not valid
            // public 
            // can be accessed from anywhere
            testobj.b = 2;
            Console.WriteLine(testobj.b);


            #endregion

            #region Question 3
            // file > New > project > class library
            // write class code > right click solution > Add > Existing project > build
            // right click dependencies > add project reference > choose library name
            // add using library name at the top of the project
            #endregion

            #region Question 4
            // A Class Library is a separate project that contains reusable classes,
            // but has no Main method and cannot run on its own. It compiles into a .dll file (Dynamic Link Library).
            // usage
            // Reusability — write once, use in many projects
            // Organization — Separate concerns into different assemblies
            // Teamwork — different developers work on different libraries
            // Maintenance — fix a bug once, all projects benefit

            #endregion
            #endregion
            Console.Write("Enter Movie Name: ");
            string name = Console.ReadLine() ?? "Unknown";

            Console.Write("Enter Ticket Type (0 = Standard, 1 = VIP, 2 = IMAX): ");
            TicketType type;
            Enum.TryParse(Console.ReadLine(), out type);


            Console.Write("Enter Seat Row (A, B, C...): ");
            char row;
            char.TryParse(Console.ReadLine()?.ToUpper(), out row);

            Console.Write("Enter Seat Number: ");
            int num;
            int.TryParse(Console.ReadLine(),out num);

            Console.Write("Enter Price: ");
            double price;
            double.TryParse(Console.ReadLine(), out price);

            Console.Write("Enter Discount Amount: ");
            double discount;
            double.TryParse(Console.ReadLine(), out discount);

            Ticket myTicket = new Ticket(name, type, new Location(num, row), price);

            Console.WriteLine("\n===== Ticket Info =====");
            myTicket.PrintTicket();
            Console.WriteLine($"Total (14% tax) : {myTicket.CalcTotal(0.14):F2}");

            Console.WriteLine("\n===== After Discount =====");
            Console.WriteLine($"Discount Before : {discount:F2}");

            myTicket.ApplyDiscount(ref discount);

            Console.WriteLine($"Discount After  : {discount:F2}");
            myTicket.PrintTicket();
            Console.WriteLine($"Total (14% tax) : {myTicket.CalcTotal(0.14):F2}");

            Console.ReadLine(); 
        
        #region Part 2
        #endregion
    }
    }
}
