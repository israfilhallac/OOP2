using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            İndividualCustomer individualCustomer1 = new İndividualCustomer();
            individualCustomer1.Id = 1;
            individualCustomer1.CustomerNo = "4";
            individualCustomer1.CitizenshipNumber = "1234564";
            individualCustomer1.Name = "İsrafil";
            individualCustomer1.SurName = "Hallaç";

            CoorporateCustomer coorporateCustomer1 = new CoorporateCustomer();
            coorporateCustomer1.Id = 2;
            coorporateCustomer1.CustomerNo = "12354";
            coorporateCustomer1.CompanyName = "BTK";
            coorporateCustomer1.TaxNumber = "25687";

            Console.WriteLine("Müsteri Adı : " +individualCustomer1.Name);
            Console.ReadLine();



        }
    }
}
