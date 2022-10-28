using AddressBook.Model;
using AddressBook.Repository;
using System.Net;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book  \n");

            ContactDetailsRepo contactDetailsRepo = new ContactDetailsRepo();

            Boolean flag = true;


            while(flag)
            {
                Console.WriteLine("Enter 1 for Add person Details ");
                Console.WriteLine("Enter 2 for displaying person details");
                Console.WriteLine("Enter 3 for Exit");

                int userInput = int.Parse(Console.ReadLine());

                switch (userInput)
                {
                    case 1:Console.WriteLine("Please Add All the Details :");
                        Console.Write("Enter the First Name : ");
                        string first_Name = Console.ReadLine();
                        Console.Write("Enter the Last Name : ");
                        string last_Name = Console.ReadLine();
                        Console.Write("Enter the Mobile Number : ");
                        string mobile_Number = Console.ReadLine();
                        Console.Write("Enter the Email Id : ");
                        string email_Id = Console.ReadLine();
                        Console.Write("Enter the Address : ");
                        string address = Console.ReadLine();
                        Console.Write("Enter the City : ");
                        string city = Console.ReadLine();
                        Console.Write("Enter the State : ");
                        string state = Console.ReadLine();
                        Console.Write("Enter the Zip : ");
                        string zip = Console.ReadLine();
                        person person1 = new person()
                        {
                            FirstName = first_Name,
                            LastName = last_Name,
                            MobileNumber = int.Parse(mobile_Number),
                            Email = email_Id,
                            Address = address,
                            City = city,
                            State = state,
                            zip = int.Parse(zip),
                        };
                        contactDetailsRepo.AddPersonDetails(person1);

                        break;
                    case 2:contactDetailsRepo.DisplayContact();
                        break;
                    default:Console.WriteLine("Exiting the loop .");
                        flag = false;
                        break;


                }

            }
            
            

            /*     person person1 = new person()
                 {
                     FirstName = "Sanjeev",
                     LastName = "Singh",
                     MobileNumber = 8266953797,
                     Email = "sanjeevsingh.77d@gmail.com",
                     Address = "Om shanti colony 22 khaza ",
                     City = "Etawah",
                     State = "U.P",
                     zip = 2060001
                 };


                 person person2 = new person();
                 person2.FirstName = "Anubhav";
                 person2.LastName = "Singh";
                 person2.MobileNumber = 6384834910;
                 person2.Email = "anubhav123@gmail.com";
                 person2.Address = "new Ashok nagar ";
                 person2.City = "Noida";
                 person2.State = "U.P";
                 person2.zip = 2060001;     */


            //     ContactDetailsRepo contactDetailsRepo = new ContactDetailsRepo();
            //   contactDetailsRepo.AddPersonDetails(person1);
            // contactDetailsRepo.AddPersonDetails(person2);
            //contactDetailsRepo.DisplayContact();


        }
    }
}