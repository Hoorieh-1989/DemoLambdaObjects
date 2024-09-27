using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLambdaObjects.Classes
{
    public class Person


    {

        public string Name { get; set; }    
        public DateTime BornDate { get; set; }  

        public int ShoeSize{ get; set; }

        public PersonType Type { get; set; }

        public Person(string name, DateTime bornDate, int shoeSize, PersonType type)
        {
            Name = name;
            BornDate = bornDate;
            ShoeSize = shoeSize;
            Type = type;
        }
    }
}
