namespace ConsoleApp1
{


    internal class Program
    {

     
        
        static void Main(string[] args)
        {
            double fuel;
            double tankCapacity;
            double fuelConsumption;

            Colored.Write("Bakda ne qeder benzin var?\n", ConsoleColor.Yellow);
            fuel = double.Parse(Console.ReadLine());
            Colored.Write("Mashinin bakinin hemi ne qederdi?\n", ConsoleColor.Yellow);
            tankCapacity = double.Parse(Console.ReadLine());
            Colored.Write("Mashinin 100km-e ne qeder benzin istifade edir?\n", ConsoleColor.Yellow);
            fuelConsumption = double.Parse(Console.ReadLine());

            Car car = new Car(fuel, tankCapacity, fuelConsumption);

            while (true)
            {
                Colored.WriteLine("\nMenyu", ConsoleColor.Cyan);
                Colored.WriteLine("1. Sur", ConsoleColor.Green);
                Colored.WriteLine("2. Zapravkaya gir", ConsoleColor.Green);
                Colored.WriteLine("3. Benzini goster", ConsoleColor.Green);
                Colored.WriteLine("4. Getdiyimiz yolu goster", ConsoleColor.Green);

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Colored.Write("Nece km yol gedek?\n", ConsoleColor.Yellow);
                        double km = double.Parse(Console.ReadLine());
                        if (car.Drive(km))
                        {
                            Colored.WriteLine($"Qalan benzin: {fuel}L", ConsoleColor.Green);
                            Colored.WriteLine($"Gedilen yol: {km}km", ConsoleColor.Green);
                        }
                        else
                        {
                            Colored.WriteLine("Bu yolu getmek mumkun deyil", ConsoleColor.Red);
                        }
                        break;

                    case "2":
                        Colored.WriteLine("SOCAR-a xosh geldiniz", ConsoleColor.Cyan);
                        Colored.Write("Ne qeder dolduraq?\n", ConsoleColor.Yellow);
                        double amount = double.Parse(Console.ReadLine());
                        if (!car.Refuel(amount))
                        {
                            Colored.WriteLine("Sehv daxil elemisen", ConsoleColor.Red);
                        }
                        else
                        {
                            Colored.WriteLine($"Doldu. Benzin: {fuel}L", ConsoleColor.Green);
                        }
                        break;

                    case "3":
                        Colored.WriteLine($"Benzin: {fuel}L", ConsoleColor.Green);
                        break;

                    case "4":
                        Colored.WriteLine($"Getdiyimiz yol: {car.GetMileAge()}km", ConsoleColor.Green);
                        break;

                    default:
                        Colored.WriteLine("Duzgun secim etmediniz", ConsoleColor.Red);
                        break;

                }
            }
        }
    }
}