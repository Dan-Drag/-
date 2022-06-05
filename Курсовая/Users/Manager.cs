using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая.Users
{
    internal class Manager : User
    {
        public Manager(int id, string name, string surname, string patronymic, string email, string password)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Email = email;
            Password = password;
            UserIdentify = "Manager";
        }
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
        protected void ChangeName(User user, string name)
        {
            this.Name = name; 
        }
        protected void ChangeSurname(User user, string surname)
        {
            this.Surname = surname;
        }
        protected void ChangePatronymic(User user, string patronymic)
        {
            this.Patronymic = patronymic;
        }

        protected void ChangeID(User user, int id) 
        {
            this.ID = id;
        }

        protected void ChangeGroupName() { }
        protected void ChangeInfo() { }
        
    }
}
