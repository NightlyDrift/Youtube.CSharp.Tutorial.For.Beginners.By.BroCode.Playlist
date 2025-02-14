using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStringMethodsByBroCode50._11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) ToUpper/Lower:
            String fullName = "Bro Code";
            String fullNameUpperCase;
            String fullNameLowerCase;

            fullNameUpperCase = fullName.ToUpper(); //ToUpper capitalizes all characters in a given string
            fullNameLowerCase = fullName.ToLower(); //ToLower displays all characters in a string as lower case

            Console.WriteLine(fullName);
            Console.WriteLine(fullNameUpperCase);
            Console.WriteLine(fullNameLowerCase);


            //2) Replace:
            String phoneNumber = "123-456-7890";
            String phoneNumberReplaceEX;

            phoneNumberReplaceEX = phoneNumber.Replace("-","/");
            //Replace command replaces the first character with the second one.
            //This can also be used to delete certain characters by leaving the second character blank

            Console.WriteLine(phoneNumberReplaceEX);


            //3) Insert:
            String userName = fullName.Insert(0,"@");
            //Insert will insert a character in the place in which you specify.
            //Placement comes first and the character is specified last. With 0 being the first place.

            Console.WriteLine(userName);


            //4) Length
            //String fullNameLength;
            //fullNameLength = fullName.Length(); This line of code doesn't work as a method
            Console.WriteLine(fullName.Length); //One potential use case for this command is limiting the characters for an online username



            //5) SubString
            //This will take a slice from an existing string of text by specifying where to start and finish.
            //With the start value on the left and finish value on the right
            String firstName = fullName.Substring(0,3);
            String lastName = fullName.Substring(4,4);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);



            //6) Etc
            //You can find other more advance string methods by using a string variable. ...
            //fullName.

        }
    }
}
