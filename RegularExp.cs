﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpression
{
    public class RegularExp
    {
        public static void EnterName(string name)
        {
            string pattern = "^[A-Z]{1}[a-z]{2,19}\\s[A-Z]{1}[a-z]{2,19}$";

            Regex regex = new(pattern);
            if (regex.IsMatch(name))
            {
                Console.WriteLine($"Your name is {name}");
            }
            else
            {
                Console.WriteLine("First name first character should be capital \nSecound name first character should be capital \nAnd both name must be more than 3 and less than 20 character long");
            }
        }

        public static void EnterEmail(string email)
        {
            string pattern = @"^([a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+(?:\.[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+)*)@(?:[a-zA-Z0-9](?:[a-zA-Z0-9-]*[a-zA-Z0-9])?\.)+[a-zA-Z]{2,}$";
            Regex regex = new(pattern);
            if (regex.IsMatch(email))
            {
                Console.WriteLine($"Your email is {email}");
            }
            else
            {
                Console.WriteLine("Invalid email formate");
            }
        }

        public static void EnterPhoneNumber(string phoneNumber)
        {
            string pattern = "^[0-9]{2}\\s[0-9]{10}$";
            Regex regex = new(pattern);
            if (regex.IsMatch(phoneNumber))
            {
                Console.WriteLine($"Your phone number is {phoneNumber}");
            }
            else
            {
                Console.WriteLine("invalid Number formate");
            }
        }

        public static void EnterPassword(string password)
        {
            // ?=.* ensures zero or more and [A-Z] ensures atlist 1 uppercase
            // using ^ am excluding all the existing pattern
            string pattern = @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,16}$";
            Regex regex = new(pattern);
            if (regex.IsMatch(password))
            {
                Console.WriteLine($"Your password is {password}");
            }
            else
            {
                Console.WriteLine("Invalid Password");
            }
        }
    }
}
