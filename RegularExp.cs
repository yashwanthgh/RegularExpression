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
            string pattern = "^[A-Z]{1}[a-z]{2,19}\\s[A-Z]{1}[a-z]{2,19}$";
            
            Regex regex = new(pattern);
            if(regex.IsMatch(name))
            {
                Console.WriteLine($"Your name is {name}");
            } else
            {
                Console.WriteLine("First name first character should be capital \nSecound name first character should be capital \nAnd both name must be more than 3 and less than 20 character long");
            }
        }
    }
}
