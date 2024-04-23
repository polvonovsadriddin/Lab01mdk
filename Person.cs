using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_MDK
{
   public abstract class  Person
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
       

        protected Person(string surname, string name, string patronymic)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            
        }

        public String Print()
        {
            string res = String.Empty;
            return res;
        }
        public abstract decimal InCome();
        public abstract decimal Balance();

    }
}
