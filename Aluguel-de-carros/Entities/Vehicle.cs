using System;
using System.Collections.Generic;
using System.Text;

namespace Aluguel_de_carros.Entities
{
    class Vehicle
    {
        public string Model { get; set; }

        public Vehicle()
        {
        }

        public Vehicle(string model)
        {
            Model = model;
        }
    }
}
