using lab1_MDK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_MDK
{
   

    public  class Employee : Person

    {
        
        public decimal Summa { get; set; }
        public Employee(string surname, string name, string patronymic, decimal sum ) : base(surname, name, patronymic)
        { 
            this.Summa = sum;
        }
         public Employee(string surname, string name, string patronymic) : base(surname, name, patronymic)
        {string Surname = surname;
            string Name = name; 
            string Patronymic = patronymic;
           
        }

        public override decimal InCome()
        {
            return Summa * 12;             
        }
        public override decimal Balance()
        {
            return  Summa*13/100;
        }

    }
}