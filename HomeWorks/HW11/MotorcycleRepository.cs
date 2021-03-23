using Serilog;
using System;
using System.Collections.Generic;

namespace HW11
{
    class MotorcycleRepository : IMotorcycleRepository
    {
        MotorcycleContext db;

        public MotorcycleRepository() { db = new(); }

        public void CreateMotorcycle(Motorcycle obj) 
        {
            db.Motorcycles.Add(obj);
            Log.Information("The motorcycle object has been created.");
        }

        public List<Motorcycle> GetMotorcycle() 
        {
            Log.Information("All motorcycle objects have been taken.");
            return db.Motorcycles;
        }

        public Motorcycle GetMotorcycle(long id)
        {         
            foreach (Motorcycle item in db.Motorcycles)
            {
                if (item.Id == id) 
                {                  
                    Log.Information("Motorcycle object has been taken.");
                    return item;
                }
            }
            Log.Warning("Motorcycle object has not been found or taken.");
            return null;
        }

        public void UpdateMotorcycle(long id)
        {
            try
            {
                foreach (Motorcycle item in db.Motorcycles)
                {
                    if (item.Id == id) 
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
                }
                Log.Warning("Motorcycle object has not been found or updated.");
            }
            catch (Exception) { Log.Fatal("Wrong input string format"); }
        }

        public void DeleteMotorcycle(long id) 
        {
            foreach (Motorcycle item in db.Motorcycles)
            {
                if (item.Id == id) 
                { 
                    db.Motorcycles.Remove(item);
                    Log.Information("Motorcycle object has been deleted.");
                    return;
                }
            }
            Log.Warning("Motorcycle object has not been found or deleted.");
        }
    }
}
