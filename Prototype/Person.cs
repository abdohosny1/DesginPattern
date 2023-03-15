using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
   public class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public IdInfo idInfo { get; set; }


        public Person ShallowCop()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCop()
        {
            Person person = new Person();
            person = (Person)this.MemberwiseClone();
            person.idInfo = new IdInfo { Id = 100 };
            person.Name = String.Copy(Name);
            return person;
        }

        public override string ToString()
        {
            return $@"name : {this.Name}
                      Age : {this.Age}
                      IdInfo : {this.idInfo.Id}";
        }


    }

  public  class IdInfo
    {
        public int Id { get; set; }
    }
}
