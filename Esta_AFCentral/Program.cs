using System;
using DataAccess;
using Esta_AFCentral.Models;
 
namespace Esta_AFCentral
{  
    public class Program
    {
        static void Main(string[] args)
        {
            string terminate = "";
            do
            {
                terminate = Entry();
            }while (terminate != "N");
        }

        public static string Entry()
        {
            AFCentralAccess connection = new(Globals.cn);
            MemberModel model = new();

            Console.WriteLine("Enter your name: ");
            model.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your surname: ");
            model.LastName = Console.ReadLine();
            Console.WriteLine("Enter your position (Facilitator/Intern): ");
            model.Position = Console.ReadLine();
            Console.WriteLine("Enter your email");
            model.Email = Console.ReadLine(); 
            Console.WriteLine("Enter your phone number");
            model.Phone = Console.ReadLine();
            Console.WriteLine("Enter the programme name: ");
            model.Name = Console.ReadLine();
            Console.WriteLine("Enter the programme duration: ");
            model.Duration = Console.ReadLine();

            connection.insert(model.FirstName, model.LastName, model.Position, model.Email, model.Phone, model.Name, model.Duration);
            Console.WriteLine("Would you like to make another entry (Y/N): ");
            string anotherEntry = Console.ReadLine();

            return anotherEntry.ToUpper();
        }
    }
}