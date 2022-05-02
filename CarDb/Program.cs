using CarDb.DAL;
using CarDb.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

namespace CarDb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var entityDal = new Dal();
            var c = new Car();
            var cu = new Customer();
            var cd = new CarDetail();
            var b = new Brand();
            int a = 0;
            while (a != 10)
            {
                Console.WriteLine("1-Cars \n2-Customers \n3-Brands \n4-Car Details \nWhich List you want to operate? : ");
                a = Convert.ToInt32(Console.ReadLine());
                if (a == 1)
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Select the Operation you want to do:\n1-Add Car \n2-Delete Car \n3-Update Car \n4-Show Cars \n5-Others \n10-Exit :");
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a == 1)
                    {
                        entityDal.GetAllBrands();
                        Console.Write("Enter Brand Id: ");
                        c.BrandId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter new Car Model Name: ");
                        c.ModelName = Console.ReadLine();
                        Console.Write("Enter new Car Price: ");
                        c.Price = Convert.ToInt32(Console.ReadLine());
                        entityDal.AddCars(c);
                    }
                    else if (a == 2)
                    {
                        entityDal.GetAllCars();
                        Console.Write("Enter Car ID: ");
                        c.CarId = Convert.ToInt32(Console.ReadLine());
                        entityDal.DeleteCars(c);
                    }
                    else if (a == 3)
                    {
                        entityDal.GetAllCars();
                        Console.Write("Enter Car ID: ");
                        c.CarId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Updated Car Model Name: ");
                        c.ModelName = Console.ReadLine();
                        Console.Write("Enter Updated Car Price: ");
                       c.Price= Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Updated Brand Id: ");
                        c.BrandId= Convert.ToInt32(Console.ReadLine());
                        entityDal.UpdateCars(c);
                    }
                    else if (a == 4)
                    {
                        entityDal.GetAllCars();
                    }
                    else if (a == 5)
                    {
                        Console.WriteLine("Select the Operation you want to do:\n1-Show Cars with Left Join \n2-Show Cars with Right Join \n10-Exit: ");
                        a = Convert.ToInt32(Console.ReadLine());
                        if (a == 1)
                        {
                            entityDal.gettAllWithLeftJoin();
                        }
                        else if (a ==2)
                        {
                            entityDal.GetAllWithRightJoin();
                        }
                    }

                }
                else if (a == 2)
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Select the Operation you want to do:\n1-Add Customer \n2-Delete Customer \n3-Update Customer \n4-Show Customers \n10-Exit");
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a == 1)
                    {

                        Console.Write("Enter new Customer First Name: ");
                        cu.FirstName=Console.ReadLine();
                        Console.Write("Enter new Customer Last Name: ");
                        cu.LastName = Console.ReadLine();
                        
                        entityDal.AddCustomers(cu);
                    }
                    else if (a == 2)
                    {
                        entityDal.GetAllCustomers();
                        Console.Write("Enter Customer Id: ");
                        cu.CustomerId = Convert.ToInt32(Console.ReadLine());
                        entityDal.DeleteCustomers(cu);
                    }
                    else if (a == 3)
                    {
                        entityDal.GetAllCustomers();
                        Console.Write("Enter Customer Id: ");
                        cu.CustomerId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Updated Customer First Name: ");
                       cu.FirstName = Console.ReadLine();
                        Console.Write("Enter Updated Customer Last Name: ");
                        cu.LastName = Console.ReadLine();
                        
                        entityDal.UpdateCustomers(cu);
                    }
                    else if (a == 4)
                    {
                        entityDal.GetAllCustomers();
                    }
                }
                else if (a == 3)
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Select the Operation you want to do:\n1-Add Brand \n2-Delete Brand \n3-Update Brand \n4-Show Categories \n10-Exit");
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a == 1)
                    {

                        Console.Write("Enter new Brand Name: ");
                        b.BrandName = Console.ReadLine();
                        Console.Write("Enter new Brand Country: ");
                        b.Country = Console.ReadLine();
                        entityDal.AddBrands(b);
                    }
                    else if (a == 2)
                    {
                        entityDal.GetAllBrands();
                        Console.Write("Enter Brand ID: ");
                       b.BrandId = Convert.ToInt32(Console.ReadLine());
                        entityDal.DeleteBrands(b);
                    }
                    else if (a == 3)
                    {
                        entityDal.GetAllBrands();
                        Console.Write("Enter Brand ID: ");
                        b.BrandId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Updated Brand Name: ");
                        b.BrandName = Console.ReadLine();
                        Console.Write("Enter Updated Country: ");
                        b.Country = Console.ReadLine();
                        entityDal.UpdateBrands(b);
                    }
                    else if (a == 4)
                    {
                        entityDal.GetAllBrands();
                    }
                }
                else if (a == 4)
                {
                    Console.WriteLine("----------------------------------------------------------------------------------------------------------");
                    Console.WriteLine("Select the Operation you want to do:\n1-Add Car Details \n2-Delete Car Details \n3-Update Car Details \n4-Show Car Details \n10-Exit");
                    a = Convert.ToInt32(Console.ReadLine());
                    if (a == 1)
                    {
                        entityDal.GetAllCars();
                        Console.Write("Enter  Car Id: ");
                        cd.CarId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter  Fuel: ");
                        cd.Fuel = Console.ReadLine();
                        Console.Write("Enter Year: ");
                        cd.Year = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Engine Size: ");
                        cd.EngineSize = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Enter Transmission Type: ");
                        cd.Transmission = Console.ReadLine();
                        entityDal.AddCarDetails(cd);
                    }
                    else if (a == 2)
                    {
                        entityDal.GetAllCarDetails();
                        Console.Write("Enter Car Detail ID: ");
                       cd.CarDetailId = Convert.ToInt32(Console.ReadLine());
                        entityDal.DeleteCarDetails(cd);
                    }
                    else if (a == 3)
                    {
                        entityDal.GetAllCarDetails();
                        Console.Write("Enter Car Detail Id: ");
                       cd.CarDetailId = Convert.ToInt32(Console.ReadLine());
                        entityDal.GetAllCars();
                        Console.Write("Enter Updated Car Id: ");
                        cd.CarId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Updated Fuel: ");
                        cd.Fuel = Console.ReadLine();
                        Console.Write("Enter Updated Year: ");
                        cd.Year = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Updated Engine Size: ");
                        cd.EngineSize = Convert.ToDecimal(Console.ReadLine());
                        Console.Write("Enter Updated Transmission Type: ");
                        cd.Transmission = Console.ReadLine();
                        entityDal.UpdateCarDetails(cd);
                    }
                    else if (a == 4)
                    {
                        entityDal.GetAllCarDetails();
                    }
                }
            }
        }

       
    }

}
