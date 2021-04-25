using HW09.Task1.Interfaces;
using System.Collections.Generic;

namespace HW09.Task1
{
    class UserBase : ICRUD<User>
    {

        static List<User> _userList = new();

        public delegate void UserBaseChanged(User user);
        public event UserBaseChanged baseChangedEvent;

        public void AddItem(User user)
        {
            _userList.Add(user);
            baseChangedEvent?.Invoke(user);
        }

        public void DeleteItem(User user)
        {
            _userList.Remove(_userList.Find(item => item.Name == user.Name && item.Password == user.Password));
            baseChangedEvent?.Invoke(user);
        }

        public User GetItem(User user)
        {
            baseChangedEvent?.Invoke(user);
            return _userList.Find(item => item.Name == user.Name && item.Password == user.Password);
        }
    }
}
