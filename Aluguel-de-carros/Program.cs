using Aluguel_de_carros.Entities;
using Aluguel_de_carros.Services;
using System;
using System.Globalization;
namespace Aluguel_de_carros
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");
            string model = Console.ReadLine();
            Console.Write("Pickup(dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CI);
            Console.Write("Return(dd/MM/yyyy hh:mm): ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CI);
            Console.Write("Enter price per hour: ");
            double hour = double.Parse(Console.ReadLine(), CI);
            Console.Write("Enter price per day: ");
            double day = double.Parse(Console.ReadLine(), CI);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());
            rentalService.ProcessInvoice(carRental);

            Console.WriteLine("INVOICE:");
            Console.WriteLine(carRental.Invoice);
        }
    }
}
