using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace NameValidator
{
    class Program
    {
        static void NameIsValid(string nameInput)
        {
            int wordCount = 0, index = 0;

            while (index < nameInput.Length && char.IsWhiteSpace(nameInput[index]))
                index++;

            while (index < nameInput.Length)
            {
                while (index < nameInput.Length && !char.IsWhiteSpace(nameInput[index]))
                    index++;

                wordCount++;

                while (index < nameInput.Length && char.IsWhiteSpace(nameInput[index]))
                    index++;
            }

            if (wordCount == 1)
                Console.WriteLine(false);
            else if (wordCount == 2 && Char.IsUpper(nameInput.Split(' ')[0], 0) && Char.IsUpper(nameInput.Split(' ')[1], 0) && nameInput.Split(' ')[0].EndsWith(".") || wordCount == 3 && Char.IsUpper(nameInput.Split(' ')[0], 0) && Char.IsUpper(nameInput.Split(' ')[1], 0) && Char.IsUpper(nameInput.Split(' ')[2], 0) && nameInput.Split(' ')[0].EndsWith(".") && nameInput.Split(' ')[1].EndsWith(".") || wordCount == 3 && Char.IsUpper(nameInput.Split(' ')[0], 0) && Char.IsUpper(nameInput.Split(' ')[1], 0) && Char.IsUpper(nameInput.Split(' ')[2], 0) && nameInput.Split(' ')[1].EndsWith("."))
                Console.WriteLine(true);
            else
                Console.WriteLine(false);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenidos a Name Validator.\n");
            Console.WriteLine("A continuación, por favor ingrese el nombre a ser validado.\n");

            string name = Console.ReadLine();

            NameIsValid(name);
        }
    }
}
