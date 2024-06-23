using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPassports
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Insert number - ");
                int n = int.Parse(Console.ReadLine());

                List<DateInformation> list = new List<DateInformation>();

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Insert data for the passport - ");
                    var data = Console.ReadLine().Split();
                    DateInformation d1 = new DateInformation(data[0], int.Parse(data[1]), int.Parse(data[2]),int.Parse(data[3]),data[4],data[5]);
                    list.Add(d1);
                }

                foreach (var d in list)
                {
                    d.Print();
                }
                AgeComparator comparator = new AgeComparator();
                list.Sort(comparator);
                Console.WriteLine(string.Join(Environment.NewLine, list.Select(x => x.Age).ToList()));
                Console.WriteLine($"Name - {string.Join(Environment.NewLine, list.Select(x => x.Name).ToList())}:");
                Console.WriteLine($"EGN - {string.Join(Environment.NewLine, list.Select(x => x.Egn).ToList())}:");
                Console.WriteLine($"Number of pass - {string.Join(Environment.NewLine, list.Select(x => x.NumberPassport).ToList())}:");
                Console.WriteLine($"Date of creation - {string.Join(Environment.NewLine, list.Select(x => x.DateOfCreation).ToList())}:");
                Console.WriteLine($"Date of expiring - {string.Join(Environment.NewLine, list.Select(x => x.DateOfExpiring).ToList())}:");
                StreamWriter writer = new StreamWriter("Passports",true);
                using (writer)
                {
                    foreach (var pass in list)
                    {
                        writer.WriteLine($"Age - {pass.Age}:, Name - {pass.Name}:, EGN - {pass.Egn}:, Number of the passport - {pass.NumberPassport}:, Date of creation - {pass.DateOfCreation}:, Date of expiring - {pass.DateOfExpiring}:");
                    }

                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
