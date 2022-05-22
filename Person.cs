using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3
{
  

    internal class Person
    {
        public Person(int age, string fname, string lname, double height = 1.65, double weight = 80.2)
         {
            Age = age;
            FName = fname;  
            LName = lname;
            Height = height;
            Weight = weight;
        }

        public int Age
        {
            get { return Age; }
            set 
            {
                if (value > 1) 
                { 
                    Age = value; 
                }
                else
                {
                    throw new ArgumentException("Inga bebisar tillåtna. Ange ett värde större än 0.");
                }
                
            }
        }
        private string fName;

        public string FName
        {
            get { return fName; }
            set {
                try { if (value.Length > 2 || value.Length < 10) { fName = value; };  } catch { Console.WriteLine("Förnamnet ska bestå av minst två bokstäver och max 10 bokstäver."); }
                }
        }
        private string lName;

        public string LName
        {
            get { return lName; }
            set {
                try { if (value.Length > 3 || value.Length < 15) { lName = value; }; } catch { Console.WriteLine("Efternamet ska bestå av minst tre bokstäver och max 15 bokstäver. "); }
                }
        }
        private double height;
         
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        private double weight;

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }


        public override string ToString()
        {
            return $"{FName} {LName}, {Age} years old, {Height} cm tall, weighs {Weight} kg.";
        }

    }
}
