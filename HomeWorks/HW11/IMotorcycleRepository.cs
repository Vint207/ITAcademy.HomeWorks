using System;
using System.Collections.Generic;
using System.Text;

namespace HW11
{
    interface IMotorcycleRepository
    {
        void CreateMotorcycle(Motorcycle obj);

        List<Motorcycle> GetMotorcycle();

        Motorcycle GetMotorcycle(long id);

        void UpdateMotorcycle(long id);

        void DeleteMotorcycle(long id);
    }
}
