using OOPAssignment.Encapsulation;
using OOPAssignment.Abstraction;
using OOPAssignment.Inheritance;
using OOPAssignment.Polymorphism;
class Program
{
    static void Main()
    {
        //ENCAPULATION
        Console.WriteLine("ENCAPUSLATION BANK ");
        try
        {
            // Create account
            BankAccount account = new BankAccount(
                "Itumeleng",
                "1239",
                500//Initial amount
            );

            Console.WriteLine(" ACCOUNT DETAILS ");
            Console.WriteLine($"Owner: {account.Owner}");
            Console.WriteLine($"Balance R: {account.Balance}");

            Console.WriteLine();

            // Validate PINs
            Console.WriteLine("=== PIN VALIDATION ===");

            Console.WriteLine(
                $"Correct PIN: {account.ValidatePin("1239")}"
            );

            //Console.WriteLine(
            //    $"Wrong PIN: {account.ValidatePin("5432")}"
            //);

            

            // Deposit
            Console.WriteLine("=== DEPOSIT ===");
            account.Deposit(200);
         //   account.Balance();
            Console.WriteLine();

            // Withdraw
            Console.WriteLine("=== WITHDRAW ===");
            account.Withdraw(700);

          //  Invalid deposit

           //Console.WriteLine("=== INVALID DEPOSIT ===");
           // account.Deposit(-50);

            //Checking balance without witdraw 
            Console.WriteLine("=== Your Current  Balance ===");
            Console.WriteLine(account.Balance);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"ERROR: {ex.Message}");
        }

        Console.WriteLine();

       
        //ABSTRACTION

        Console.WriteLine("\n=== ABSTRACTION ===");

        INotificationService emailService =
            new EmailNotificationService();

        OrderService orderService1 =
            new OrderService(emailService);

        orderService1.PlaceOrder("alice@email.com");

        INotificationService smsService =
            new SmsNotificationService();

        OrderService orderService2 =
            new OrderService(smsService);

        orderService2.PlaceOrder("0821234567");


        //IHERITANCE

        Console.WriteLine("\n=== INHERITANCE ===");

        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("Toyota", "Corolla", 2020, 4),
            new Truck("Ford", "F-150", 2022, 3),
            new ElectricCar("Tesla", "Model 3", 2024, 4, 550)
        };

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine(vehicle.GetDescription());
        }

        //POLYMORPHISM

        Console.WriteLine("\n=== POLYMORPHISM ===");

        List<Shape> shapes = new List<Shape>
        {
            new Circle(9),
            new Rectangle(4, 6),
            new Triangle(8, 3)
        };

        PrintReport(shapes);
        //find the fir 
        var largestShape = shapes
            .OrderByDescending(s => s.Area())
            .First();

        Console.WriteLine(
            $"\nLargest Shape: {largestShape.Describe()}"
        );
    }

    static void PrintReport(List<Shape> shapes)
    {
        foreach (var shape in shapes)
        {
            Console.WriteLine(shape.Describe());
        }
    }
}