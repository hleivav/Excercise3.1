using System;

namespace Excercise3
{
    internal class Program
    { 
        static void Main(string[] args)
        {  
            PersonHandler pershndl = new PersonHandler();
            List<Person> ListPerson = new List<Person>();

            //Person person = new Person(58, "Hernan", "Leiva"); 

            try
            {
                Person person = pershndl.CreatePerson(58, "Hernan", "Leiva", 1.65, 80);
                ListPerson.Add(person);
            }
            catch (ArgumentException e)
            {

                Console.WriteLine(e.Message);
            }




            foreach (Person p in ListPerson)
            {
                Console.WriteLine(p.FName + " " + p.LName);
            }

           // Console.WriteLine(person.ToString());

           // pershndl.SetAge(person, 0);
           //// pershndl.SetAge(person, 2);
           // person.FName = "C"; 

           // Console.WriteLine(person.ToString());

        }
    }
}
   