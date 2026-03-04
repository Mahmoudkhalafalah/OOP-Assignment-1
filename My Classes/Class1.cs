namespace My_Classes
{
    public enum TicketType
    {
        Standard,
        VIP,
        IMAX
    }
    public struct Location
    {
        int number;
        char row;

        public Location(int number, char row)
        {
            this.number = number;
            this.row = row;
        }
        public override string ToString()
        {
            return ($"{row}{number}");
        }
    }
    public class Ticket
    {
        public string movieName;
        public TicketType type;
        public Location seat;
        private double price;
        public Ticket(string movieName, TicketType type, Location seat, double price)
        {
            this.movieName = movieName;
            this.type = type;
            this.price = price;
            this.seat = seat;
        }
        public Ticket(string movieName)
        {
            this.movieName = movieName;
            this.type = TicketType.Standard;
            this.price = 50;
            this.seat = new Location(1, 'A');
            ;

        }
        public double CalcTotal(double taxPercent)
        {
            return (1 + taxPercent) * this.price;
        }
        public void ApplyDiscount(ref double discountAmount)
        {
            if (discountAmount > 0 && discountAmount <= this.price)
            {
                this.price -= discountAmount;
                discountAmount = 0;
            }
        }

        public void PrintTicket()
        {
            Console.WriteLine($"Movie   : {this.movieName}");
            Console.WriteLine($"Type    : {this.type}");
            Console.WriteLine($"Seat    : {this.seat}");
            Console.WriteLine($"Price   : {this.price:F2}");
        }
    }
}
