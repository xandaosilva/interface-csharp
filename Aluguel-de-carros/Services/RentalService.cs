using System;
using System.Collections.Generic;
using System.Text;

namespace Aluguel_de_carros.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        public RentalService()
        {
        }

        public RentalService(double pricePerHour, double pricePerDay)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
        }
    }
}
