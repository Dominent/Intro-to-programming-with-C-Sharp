using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirmWriteInfoCSharp
{
    class FirmWriteInfoCSharp
    {
        static void Main(string[] args)
        {
            string name, address, websiteAddress, managerFirstName, managerFamilyName;
            int phoneNumber, faxNumber, managerPhoneNumber;

            Console.WriteLine("Enter Firm Name: ");
                name = Console.ReadLine();
            Console.WriteLine("Enter Firm Address: ");
                address = Console.ReadLine();
            Console.WriteLine("Enter Firm Webiste Address: ");
                websiteAddress = Console.ReadLine();
            Console.WriteLine("Enter Managers First Name: ");
                managerFirstName = Console.ReadLine();
            Console.WriteLine("Enter Managers Family Name: ");
                managerFamilyName = Console.ReadLine();
            Console.WriteLine("Enter Firm Phone Number: ");
                phoneNumber =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Firm Fax Number: ");
                faxNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Managers Phone Number: ");
                managerPhoneNumber = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine("Firm Name: {0}", name);
                    Console.WriteLine("Firm Address: {0}", address);
                    Console.WriteLine("Firm Website Address: {0}", websiteAddress);
                    Console.WriteLine("Firm Managers First Name:: {0}", managerFirstName);
                    Console.WriteLine("Firm Managers Family Name: {0}", managerFamilyName);
                    Console.WriteLine("Firm Phone Number: {0}", phoneNumber);
                    Console.WriteLine("Firm Fax Number: {0}", faxNumber);
                    Console.WriteLine("Firm Managers Phone Number: {0}", managerPhoneNumber);


        }
    }
}
