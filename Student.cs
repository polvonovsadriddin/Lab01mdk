using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab1_MDK
{
    class Student : Person
    {
        decimal Summa;
        public Student(string surname, string name, string patronymic, decimal sum) : base(surname, name, patronymic)
        {
            this.Summa = sum;
        }
        public Student(string surname, string name, string patronymic ):base(surname, name,patronymic)
        {
          Surname = surname;
            Name = name;
            Patronymic= patronymic;
        }

      

        public override decimal InCome()
        {
            return Summa*12;
        }
        public override decimal Balance()
        {
            return (Summa/100*0);
        }
    }
}
