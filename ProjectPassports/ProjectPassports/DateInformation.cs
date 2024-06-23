using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPassports
{
    public class DateInformation:Information, IPrint
    {
        private string dateOfCreation;
        private string dateOfExpiring;
        public string DateOfExpiring
        {
            get { return dateOfExpiring; }
            set { dateOfExpiring = value; }
        }
        public string DateOfCreation
        {
            get { return dateOfCreation; }
            set { dateOfCreation = value; }
        }
        public DateInformation(string name, int age, int egn, int numberPassport, string dateOfCreation, string dateOfExpiring) : base(name, age, egn, numberPassport)
        {
            this.DateOfCreation = dateOfCreation;
            this.DateOfExpiring = dateOfExpiring;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Date of creation - {this.DateOfCreation}:\nDate of expiring - {this.DateOfExpiring}:");
        }
    }
}
