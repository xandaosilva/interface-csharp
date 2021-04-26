using System;
using System.Collections.Generic;
using System.Text;

namespace Aluguel_de_carros.Services
{
    interface ITaxService
    {
        double Tax(double amount);
    }
}
