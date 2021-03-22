using System.Collections.Generic;

namespace HW11
{
    class MotorcycleContext
    {
        public List<Motorcycle> Motorcycles { get; set; }

        public MotorcycleContext() { Motorcycles = new(); }
    }
}
