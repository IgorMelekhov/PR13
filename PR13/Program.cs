using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PR13
{
    internal class Program { 
    public struct Notebook
    {
        string surname;
        string name;
        ulong phoneNumber;
        ulong dateOfBirthsday;
    }
    public Notebook (ulong phoneNumber)
    {
        this.phoneNumber = phoneNumber;
        surname = null;
        name = null;
        dateOfBirth = null;
        InfoAboutObjStruct();
    }
    void InfoAboutObjStruct()
    {
        try
        {
            Console.Write("\nФамилия:");
            surname = Console.ReadLine();
            Console.Write("Имя:");
            name = Console.ReadLine();
            Console.Write("Дата рождения:");
            dateOfBirth= Console.ReadLine();
            Console.Write("Телефонный номер:");
            phoneNumber = Console.ReadLine();
        }catch(FormatException fe)
        {
           Console.ForegroundColor= ConsoleColor.Red;
                Console.WriteLine(fe.Message);
                Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
        void
    
        static void Main(string[] args)
        {
        }
    }
}
