using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLambdaObjects.Classes
{
    public static class Repository
    {

        public static List<Person> GetPersonList()
        {
            PersonType type1 = new PersonType("Student");
            PersonType type2 = new PersonType("Vuxen");
            PersonType type3 = new PersonType("Pensionär");

            //Lista med objekt och subselect
            List<Person> persons = new List<Person>
            {
                new Person("Kalle",Convert.ToDateTime("1992-10-10"), 42, type1 ),
                new Person("Lisa", Convert.ToDateTime("1993-10-10"), 38, type1),
                new Person("Kevin",Convert.ToDateTime("1994-10-10"), 43, type1 ),
                new Person("Ann", Convert.ToDateTime("1988-10-10"), 40, type2),
                new Person("Stina", Convert.ToDateTime("1978-10-10"), 41, type2),
                new Person("Peter", Convert.ToDateTime("1982-10-10"), 40, type2),
                new Person("Hanna", Convert.ToDateTime("1989-10-10"), 36, type2),
                new Person("Rolf", Convert.ToDateTime("1956-10-10"), 41, type3),
                new Person("Bengt", Convert.ToDateTime("1948-10-10"), 41, type3),
                new Person("Birgitta", Convert.ToDateTime("1960-10-10"), 38, type3),
                new Person("Nils", Convert.ToDateTime("1952-10-10"), 41, type3),
                new Person("Margareta", Convert.ToDateTime("1957-10-10"), 39, type3)
             };

            return persons;
        }


    }
}