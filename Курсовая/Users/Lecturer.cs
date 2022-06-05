using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая.Users
{
    internal class Lecturer : User
    {
        public Lecturer(int id, string name, string surname, string patronymic, string email, string password)
        {
            ID = id;
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Email = email;
            Password = password;
            UserIdentify = "Leacturer";
        }
        protected void AddFIles(string file, string path)
        {
            
            
        }

        protected void DeleteFile()
        {

        }
        
        protected void CheckStedentFiles()
        {

        }

        protected void EvaluateTheWork()
        {

        }

        protected void ChangeMark()
        {

        }
    }
}
