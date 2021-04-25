namespace HW09.Task1.Interfaces
{
    interface ICRUD<T>
    {
        void AddItem(T item);

        void DeleteItem(T item);

        T GetItem(T item);
    }
}
