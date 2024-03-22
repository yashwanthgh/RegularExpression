using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    public class RegularExp
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter yout name: ");
            string? name = Console.ReadLine();
            if(name != null ) 
            {
                EnterName(name);
            }
        }
        public static void EnterName(string name)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,19}$";
            
            Regex regex = new(pattern);
            if(regex.IsMatch(name))
            {
                Console.WriteLine($"Your name is {name}");
            } else
            {
                Console.WriteLine("Name should contain First letter as Capital and must be more than 3 characters long and less than 20 characters");
            }
        }
    }
}
