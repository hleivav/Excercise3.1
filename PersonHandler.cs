using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3
{
     internal class PersonHandler
    {
        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            Person person = new Person(age, fname, lname);
            return person;
        }
        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }
        public string GetAge(Person pers)
        {
            return pers.Age.ToString();
        }
        public void ChangeFName(Person pers, string fName)
        {
            pers.FName = fName; 
        }
        public string GetFName(Person pers, string fName)
        {
            return pers.FName; 
        }
        public void ChangeLName(Person pers, string lName)
        {
            pers.LName = lName;
        }
        public string GetLName(Person pers, string lName)
        {
            return pers.LName;
        }
        public void SetHeight(Person pers, double height)
        {
            pers.Height = height;
        }
        public double GetHeight(Person pers, double weight)
        {
            return weight;
        }
        public void SetWeight(Person pers, double height)
        {
            pers.Height = height;  
        }
    }
}
