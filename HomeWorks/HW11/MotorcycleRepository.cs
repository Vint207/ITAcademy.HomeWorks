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
            Log.Information("The motorcycle object has been created.");
            db.Motorcycles.Add(obj); 
        }

        public List<Motorcycle> GetMotorcycle() 
        {
            Log.Information("All motorcycle objects was taken.");
            return db.Motorcycles; 
        }

        public Motorcycle GetMotorcycle(long id)
        {
            Log.Information("Motorcycle object has been taken.");
            foreach (Motorcycle item in db.Motorcycles)
            {
                if (item.Id == id) { return item; }
            }
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
                Log.Information("Motorcycle object has not been updated.");
            }
            catch (Exception) { Log.Fatal("Wrong input string format"); }
        }

        public void DeleteMotorcycle(Motorcycle obj) 
        {
            Log.Information("Motorcycle object has been deleted.");
            db.Motorcycles.Remove(obj); 
        }
    }
}
