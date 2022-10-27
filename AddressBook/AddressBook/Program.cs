using AddressBook.Model;
using AddressBook.Repository;
using System.Net;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");

            /*  person person1 = new person()
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
              person2.zip = 2060001;


              ContactDetailsRepo contactDetailsRepo = new ContactDetailsRepo();
              contactDetailsRepo.AddPersonDetails(person1);
              contactDetailsRepo.AddPersonDetails(person2);
              contactDetailsRepo.DisplayContact();
            */

            person obj = new person();
            obj.FirstName = "sanjv";
            Console.WriteLine(obj.FirstName);

        }
    }
}