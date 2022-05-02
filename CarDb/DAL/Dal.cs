using CarDb.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDb.DAL
{
    public class Dal
    {
        public  void gettAllWithLeftJoin()
        {
            var list = new ArrayList();
            var cmd = new SqlCommand("select * from Cars left join CarDetails on Cars.CarId = CarDetails.CarId");
            var fuel = "";
            var transmission = "";
            var ds = RDMS.SqlReader(cmd);
            foreach (DataRow item in ds.Tables[0].Rows)
            {

                var carId = int.Parse(item[0].ToString());
                var price = int.Parse(item[1].ToString());
                var modelName = item[2].ToString();
                fuel = item[6].ToString();
                transmission = item[9].ToString();
                list.Add(carId);
                list.Add(modelName);
                list.Add(price);
                list.Add(fuel);
                list.Add(transmission);
            }
            for (int i = 0; i < list.Count; i++)
            {


                Console.WriteLine(list[i]);

            }
        }
        public  void GetAllWithRightJoin()
        {
            var list = new ArrayList();
            var cmd = new SqlCommand("select * from Cars right join CarDetails on Cars.CarId = CarDetails.CarId");

            var ds = RDMS.SqlReader(cmd);
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                var carId = int.Parse(item[0].ToString());
                var price = int.Parse(item[1].ToString());
                var modelName = item[2].ToString();
                var fuel = item[6].ToString();
                var year = double.Parse(item[7].ToString());
                var transmission = item[9].ToString();

                list.Add(carId);
                list.Add(modelName);
                list.Add(price);
                list.Add(fuel);
                list.Add(year);
                list.Add(transmission);
            }
            for (int i = 0; i < list.Count; i++)
            {


                Console.WriteLine(list[i]);

            }
        }

        

        public  void UpdateCars(Car car)
        {
            var cmd = new SqlCommand("UPDATE Cars SET ModelName =@ModelName, Price =@Price, BrandId =@BrandId WHERE CarId =@CarId");
            cmd.Parameters.AddWithValue("CarId", car.CarId);
            cmd.Parameters.AddWithValue("Price", car.Price);
            cmd.Parameters.AddWithValue("ModelName", car.ModelName);
            cmd.Parameters.AddWithValue("BrandId", car.BrandId);


            var s = RDMS.SqlNonQuery(cmd);
            if (s == 1)
            {
                Console.WriteLine("Güncellendi");
            }
            else
            {
                Console.WriteLine("Hata");
            }
        }
        public  void UpdateBrands(Brand brand)
        {
            var cmd = new SqlCommand("UPDATE Brands SET BrandName =@BrandName, Country =@Country WHERE BrandId =@BrandId");
            cmd.Parameters.AddWithValue("CarId", brand.BrandId);
            cmd.Parameters.AddWithValue("Price", brand.BrandName);
            cmd.Parameters.AddWithValue("ModelName", brand.Country);
           


            var s = RDMS.SqlNonQuery(cmd);
            if (s == 1)
            {
                Console.WriteLine("Güncellendi");
            }
            else
            {
                Console.WriteLine("Hata");
            }
        }
        public  void UpdateCustomers(Customer customer)
        {
            var cmd = new SqlCommand("UPDATE Customers SET FirstName =@FirstName, LastName =@LastName WHERE CustomerId =@CustomerId");
            cmd.Parameters.AddWithValue("CustomerId", customer.CustomerId);
            cmd.Parameters.AddWithValue("FirstName", customer.FirstName);
            cmd.Parameters.AddWithValue("LastName", customer.LastName);



            var s = RDMS.SqlNonQuery(cmd);
            if (s == 1)
            {
                Console.WriteLine("Güncellendi");
            }
            else
            {
                Console.WriteLine("Hata");
            }
        }
        public  void UpdateCarDetails(CarDetail carDetail)
        {
            var cmd = new SqlCommand("UPDATE CarDetails SET CarId =@CarId, Fuel =@Fuel, Year =@Year, EngineSize =@EngineSize, Transmission=@Transmission WHERE CarDetailId =@CarDetailId");
            cmd.Parameters.AddWithValue("CarId", carDetail.CarId);
            cmd.Parameters.AddWithValue("Fuel", carDetail.Fuel);
            cmd.Parameters.AddWithValue("Year", carDetail.Year);
            cmd.Parameters.AddWithValue("EngineSize", carDetail.EngineSize);
            cmd.Parameters.AddWithValue("Transmission", carDetail.Transmission);
            cmd.Parameters.AddWithValue("CarDetailId", carDetail.CarDetailId);

            var s = RDMS.SqlNonQuery(cmd);
            if (s == 1)
            {
                Console.WriteLine("Güncellendi");
            }
            else
            {
                Console.WriteLine("Hata");
            }
        }



        public  void DeleteCars(Car car)
        {
            var cmd = new SqlCommand("DELETE FROM Cars WHERE CarId=@CarId");
            cmd.Parameters.AddWithValue("CarId", car.CarId);
            var s = RDMS.SqlNonQuery(cmd);
            if (s == 1)
            {
                Console.WriteLine("Silindi");
            }
            else
            {
                Console.WriteLine("Hata");
            }
        }
        public  void DeleteBrands(Brand brand)
        {
            var cmd = new SqlCommand("DELETE FROM Brands WHERE BrandId=@BrandId");
            cmd.Parameters.AddWithValue("BrandId", brand.BrandId);
            var s = RDMS.SqlNonQuery(cmd);
            if (s == 1)
            {
                Console.WriteLine("Silindi");
            }
            else
            {
                Console.WriteLine("Hata");
            }
        }
        public  void DeleteCustomers(Customer customer)
        {
            var cmd = new SqlCommand("DELETE FROM Customers WHERE CustomerId=@CustomerId");
            cmd.Parameters.AddWithValue("CustomerId", customer.CustomerId);
            var s = RDMS.SqlNonQuery(cmd);
            if (s == 1)
            {
                Console.WriteLine("Silindi");
            }
            else
            {
                Console.WriteLine("Hata");
            }
        }
        public  void DeleteCarDetails(CarDetail carDetail) 
        { 
            var cmd = new SqlCommand("DELETE FROM CarDetails WHERE CarDetailId=@CarDetailId");
            cmd.Parameters.AddWithValue("CarDetailId", carDetail.CarDetailId);
            var s = RDMS.SqlNonQuery(cmd);
            if (s == 1)
            {
                Console.WriteLine("Silindi");
            }
            else
            {
                Console.WriteLine("Hata");
            }
        }



        public  void AddCars(Car car)
        {
            var cmd = new SqlCommand("INSERT INTO Cars(Price, ModelName,BrandId)VALUES(@Price,@ModelName,@BrandId)");
            cmd.Parameters.AddWithValue("Price", car.Price);
            cmd.Parameters.AddWithValue("ModelName", car.ModelName);
            cmd.Parameters.AddWithValue("BrandId", car.BrandId);


            var s = RDMS.SqlNonQuery(cmd);
            if (s == 1)
            {
                Console.WriteLine("Eklendi");
            }
            else
            {
                Console.WriteLine("Hata");
            }
        }
        public  void AddBrands(Brand brand)
        {
            var cmd = new SqlCommand("INSERT INTO Brands(BrandName, Country)VALUES(@BrandName,@Country)");
            cmd.Parameters.AddWithValue("BrandName", brand.BrandName);
            cmd.Parameters.AddWithValue("Country", brand.Country);
        
            var s = RDMS.SqlNonQuery(cmd);
            if (s == 1)
            {
                Console.WriteLine("Eklendi");
            }
            else
            {
                Console.WriteLine("Hata");
            }
        }
        public  void AddCustomers(Customer customer)
        {
            var cmd = new SqlCommand("INSERT INTO Customers(FirstName, LastName)VALUES(@FirstName,@LastName)");
            cmd.Parameters.AddWithValue("FirstName", customer.FirstName);
            cmd.Parameters.AddWithValue("LastName", customer.LastName);

            var s = RDMS.SqlNonQuery(cmd);
            if (s == 1)
            {
                Console.WriteLine("Eklendi");
            }
            else
            {
                Console.WriteLine("Hata");
            }
        }
        public  void AddCarDetails(CarDetail carDetail)
        {
            
            var cmd = new SqlCommand("INSERT INTO CarDetails(CarId, Fuel, Year, EngineSize, Transmission)VALUES(@CarId, @Fuel, @Year, @EngineSize, @Transmission)");
            cmd.Parameters.AddWithValue("CarId", carDetail.CarId);
            cmd.Parameters.AddWithValue("Fuel", carDetail.Fuel);
            cmd.Parameters.AddWithValue("Year", carDetail.Year);
            cmd.Parameters.AddWithValue("EngineSize", carDetail.EngineSize);
            cmd.Parameters.AddWithValue("Transmission", carDetail.Transmission);


            var s = RDMS.SqlNonQuery(cmd);
            if (s == 1)
            {
                Console.WriteLine("Eklendi");
            }
            else
            {
                Console.WriteLine("Hata");
            }
        }

        public List<Car> GetAllCars()
        {
            List<Car> _list = new List<Car>();

            var cmd = new SqlCommand("SELECT * FROM Cars");

            var ds = RDMS.SqlReader(cmd);
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                _list.Add(new Car(int.Parse(item[0].ToString()),
                    int.Parse(item[1].ToString()),
                    item[2].ToString(),
                    int.Parse(item[3].ToString())));

            }
            foreach (var item in _list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            return _list;
        }
        public List<Brand> GetAllBrands()
        {
            List<Brand> _list = new List<Brand>();

            var cmd = new SqlCommand("SELECT * FROM Brands");

            var ds = RDMS.SqlReader(cmd);
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                _list.Add(new Brand(int.Parse(item[0].ToString()),
                    item[1].ToString(),
                    item[2].ToString()));

            }
            foreach (var item in _list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            return _list;
        }
        public List<Customer> GetAllCustomers()
        {
            List<Customer> _list = new List<Customer>();

            var cmd = new SqlCommand("SELECT * FROM Customers");

            var ds = RDMS.SqlReader(cmd);
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                _list.Add(new Customer(int.Parse(item[0].ToString()),
                    item[1].ToString(),
                    item[2].ToString()));

            }
            foreach (var item in _list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            return _list;
        }
        public List<CarDetail> GetAllCarDetails()
        {
            List<CarDetail> _list = new List<CarDetail>();

            var cmd = new SqlCommand("SELECT * FROM CarDetails");

            var ds = RDMS.SqlReader(cmd);
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                _list.Add(new CarDetail(int.Parse(item[0].ToString()),
                    int.Parse(item[1].ToString()),
                    item[2].ToString(),
                    int.Parse(item[3].ToString()),
                    decimal.Parse(item[4].ToString()),
                    item[5].ToString()));

            }
            foreach (var item in _list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n");
            return _list;
        }
    }
}
