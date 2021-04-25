using HW09.Task1.Interfaces;
using System;
using System.Collections.Generic;

namespace HW09.Task1
{
    class UserBase : ICRUD<User>
    {

        static List<User> _userList = new();
        event BaseChanged<User> _baseChangedEvent;

        public UserBase(BaseChanged<User> del) { _baseChangedEvent = del; }

        public void AddItem(User user)
        {
            _userList.Add(user);
            _baseChangedEvent?.Invoke(user);
        }

        public void DeleteItem(User user)
        {
            _userList.Remove(_userList.Find(item => item.Name == user.Name && item.Password == user.Password));
            _baseChangedEvent?.Invoke(user);
        }

        public User GetItem(User user)
        {
            _baseChangedEvent?.Invoke(user);
            return _userList.Find(item => item.Name == user.Name && item.Password == user.Password);
        }
    }
}
