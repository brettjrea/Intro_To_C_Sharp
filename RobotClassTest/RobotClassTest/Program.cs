public class Robot
{
    // Company property
    public string Company { get; set; }
    // Sector property
    public string Sector { get; set; }
    // Model property
    public string Model { get; set; }
    // Arms property
    public int Arms { get; set; }
    // Mobility property
    public string Mobility { get; set; }
    // Legs property
    public string Legs { get; set; }
    // Vision property
    public string Vision { get; set; }
    // Hearing property
    public string Hearing { get; set; }
    // Intelligence property
    public string Intelligence { get; set; }
    // Specialty property
    public string Specialty { get; set; }
    // Price property
    public decimal Price { get; set; }
    // Arms property
    public int Quantity { get; set; }
    public Robot(string company, string sector, string model, int arms, string mobility, string legs, string vision, string hearing, string intelligence, string specialty, decimal price, int quantity)
    {
        Company = company;
        Sector = sector;
        Model = model;
        Arms = arms;
        Mobility = mobility;
        Legs = legs;
        Vision = vision;
        Hearing = hearing;
        Intelligence = intelligence;
        Specialty = specialty;
        Price = price;
        Quantity = quantity;
    }
}

class Program
{
    static void Main()
    {
        Robot robot1 = new Robot("Honda", "Medical", "G500", 5, "Mobile", "Wheels", "LiDAR", "Microphone", "A.I", "Surgery", 500, 5);

        Console.WriteLine("robot1 Company = {0}\n Sector = {1}\n Model = {2}\n Arms = {3}\n Mobility = {4}\n Legs = {5}\n Vision = {6}\n Hearing = {7}\n Intelligence = {8}\n Specialty = {9}\n Price = {10}\n Quantity = {11}", robot1.Company, robot1.Sector, robot1.Model, robot1.Arms, robot1.Mobility, robot1.Legs, robot1.Vision, robot1.Hearing, robot1.Intelligence, robot1.Specialty, robot1.Price, robot1.Quantity);

        Console.WriteLine(" ");

       Robot robot2 = new Robot("Honda", "Medical", "G500", 5, "Mobile", "Wheels", "LiDAR", "Microphone", "A.I", "Surgery", 500, 5);

        Console.WriteLine("robot2 Company = {0}\n Sector = {1}\n Model = {2}\n Arms = {3}\n Mobility = {4}\n Legs = {5}\n Vision = {6}\n Hearing = {7}\n Intelligence = {8}\n Specialty = {9}\n Price = {10}\n Quantity = {11}", robot2.Company, robot2.Sector, robot2.Model, robot2.Arms, robot2.Mobility, robot2.Legs, robot2.Vision, robot2.Hearing, robot2.Intelligence, robot2.Specialty, robot2.Price, robot2.Quantity);
    }
}