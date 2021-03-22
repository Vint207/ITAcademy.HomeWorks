namespace HW11
{
    class Admin
    {
        public IMotorcycleRepository db;   

        public Admin() { db = new MotorcycleRepository(); }
    }
}
