using System;

namespace Strings1
{
    class Program
    {
        static void Main(string[] args)
        {
            // a string (or my name)
            var fullname = "Kaloyan Stoyanov    ";
            
            // Trim method. Removes Spaces from the beggining or the end
            Console.WriteLine("Trim: '{0}'", fullname.Trim());
            
            // ToUpper. Makes the string with uppercases
            Console.WriteLine("ToUpper: '{0}'", fullname.Trim().ToUpper());
            
            // Split a full name into a first and last name. Method One
            var index = fullname.IndexOf(" ");
            var firstname = fullname.Substring(0, index);
            var lastname = fullname.Substring(index + 1);
            Console.WriteLine($"First Name: {firstname}");
            Console.WriteLine($"Last Name: {lastname}");
            
            // Seperate the first and second method
            Console.WriteLine();
            
            // Split a full name into a first and last name. Method Two
            var names = fullname.Split(" ");
            Console.WriteLine($"First Name: {names[0]}");
            Console.WriteLine($"Last Name: {names[1]}");
            
            // Replace a word with another word
            var newname = fullname.Replace("Kaloyan", "Kalata");
            Console.WriteLine(newname);
            
            // Check if there is user input
            if(String.IsNullOrWhiteSpace(fullname))
                Console.WriteLine("Invalid");
            
            // Convert string to number
            var age = "25";
            var convertedage = Convert.ToInt32(age);
            Console.WriteLine(convertedage);
            
            // Convert number to string
            float price = 29.95f;
            Console.WriteLine(price.ToString("C0")); // Represent the price as a currency
        }
    }
}