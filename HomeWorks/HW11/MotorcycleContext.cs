using System.Collections.Generic;

namespace HW11
{
    class MotorcycleContext
    {
        public static List<Motorcycle> Motorcycles { get; set; }

        static MotorcycleContext() { Motorcycles = new(); }
    }
}
