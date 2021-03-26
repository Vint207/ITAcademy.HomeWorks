using Serilog;
using System;
using System.Collections.Generic;

namespace HW11
{
    class MotorcycleRepository : IMotorcycleRepository
    {

        public void CreateMotorcycle(Motorcycle obj)
        {
            MotorcycleContext.Motorcycles.Add(obj);
            Log.Information("The motorcycle object has been created.");
        }

        public List<Motorcycle> GetMotorcycle()
        {
            Log.Information("All motorcycle objects have been taken.");
            return MotorcycleContext.Motorcycles;
        }

        public Motorcycle GetMotorcycle(long id)
        {
            Motorcycle item = MotorcycleContext.Motorcycles?.Find(obj => obj.Id == id);

            if (item != null)
            {
                Log.Information("Motorcycle object has been taken.");
                return item;
            }
            Log.Warning("Motorcycle object has not been found or taken.");
            return item;
        }

        public void UpdateMotorcycle(long id)
        {
            try
            {
                Motorcycle item = MotorcycleContext.Motorcycles.Find(obj => obj.Id == id);

                if (item != null)
                {
                    Console.WriteLine("Inpun new id:");
                    item.Id = long.Parse(Console.ReadLine());

                    Console.WriteLine("Inpun new Model");
                    item.Model = Console.ReadLine();

                    Console.WriteLine("Inpun new Year");
                    item.Year = int.Parse(Console.ReadLine());

                    Log.Information("Motorcycle object has been updated.");
                    return;
                }
                Log.Warning("Motorcycle object has not been found or updated.");
            }
            catch (Exception ex) { Log.Fatal($"Exeption occured: {ex.Message}"); }
        }

        public void DeleteMotorcycle(long id)
        {
            Motorcycle item = MotorcycleContext.Motorcycles.Find(obj => obj.Id == id);

            if (item != null)
            {
                MotorcycleContext.Motorcycles.Remove(item);
                Log.Information("Motorcycle object has been deleted.");
                return;
            }
            Log.Warning("Motorcycle object has not been found or deleted.");
        }
    }
}
