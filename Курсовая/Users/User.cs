using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсовая.Users
{
    internal abstract class User
    {
        protected int ID;
        protected string Name;
        protected string Surname;
        protected string Patronymic;
        protected string Email;
        protected string Password;
        protected string UserIdentify;
    }
}
