using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая.Users
{
    internal class Admin : User
    {
        public Admin(int id, string name, string surname, string patronymic, string email, string password)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Email = email;
            Password = password;
            UserIdentify = "Admin";
        }
        public void AddPath() { }
        public void UpdatePath() { }
        public void DeletePath() { } 
        protected User CreateManager(int id, string name, string surname, string patronymic, string email, string password) 
        {
            User manager = new Manager(id, name, surname, patronymic, email, password);
            return manager;
        }
        protected User CreateStudent(int id, string name, string surname, string patronymic, string email, string password)
        {
            User student = new Manager(id, name, surname, patronymic, email, password);
            return student;
        }
        protected User CreateLectuare(int id, string name, string surname, string patronymic, string email, string password)
        {
            User Lectuare = new Manager(id, name, surname, patronymic, email, password);
            return Lectuare;
        }
    }
}
