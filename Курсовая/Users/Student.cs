using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая.Users
{
    internal class Student : User
    {
        public Student(int id, string name, string surname, string patronymic, string email, string password)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Email = email;
            Password = password;
            UserIdentify = "Student";
        }
        protected int Group { get; set; }
        protected void AddFIles()
        {

        }

        protected void DeleteFile()
        {

        }

        
    }
}
