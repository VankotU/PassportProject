using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPassports
{
    public abstract class Information:IPrint
    {
        private string name;
        private int age;
        private int egn;
        private int numberPassport;
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int NumberPassport
        {
            get { return numberPassport; }
            set { numberPassport = value; }
        }
        public int Egn
        {
            get { return egn; }
            set { egn = value; }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Insert name!");
                }
                name = value;
            }
        }
        public Information(string name, int age, int egn, int numberPassport)
        {
            this.Name = name;
            this.Age = age;
            this.Egn = egn;
            this.NumberPassport = numberPassport;
        }
        public virtual void Print()
        {
            Console.WriteLine($"Name - {this.name}\nAge - {this.age}\nEGN - {this.egn}\nPassport Number - {this.numberPassport}"); 
        }
    }
}
