﻿using System;

namespace Ex14
{
    class PrintCompanyInformation
    {
        static void Main()
        {
            //A given company has name, address, phone number, fax number, web site and manager
            Console.Write("Please write your company name: ");
            string companyName = Console.ReadLine();

            Console.Write("Please write your company address: ");
            string companyAddress = Console.ReadLine();

            Console.Write("Please write your phone number: ");
            long phoneNumber = long.Parse(Console.ReadLine());

            Console.Write("Please write your fax number: ");
            long faxNumber = long.Parse(Console.ReadLine());

            Console.Write("Please write your company web site: ");
            string webSite = Console.ReadLine();

            //The manager has name, surname and phone number.
            Console.Write("Please write Manager's Name: ");
            string Name = Console.ReadLine();

            Console.Write("Please write Manager's surname: ");
            string surName = Console.ReadLine();

            Console.Write("Please write Manager's phone: ");
            long phoneManager = long.Parse(Console.ReadLine());

            Console.WriteLine("{0}", companyName);
            Console.WriteLine("Adress: {0}", companyAddress);
            Console.WriteLine("Tel. {0}", phoneNumber);
            Console.WriteLine("Fax. {0}", faxNumber);
            Console.WriteLine("Web-site: {0}", webSite);
            Console.WriteLine("Manager: {0}" + " " + "{1}" + " " + "{2}" + " " , Name, surName, phoneManager);
        }
    }
}
