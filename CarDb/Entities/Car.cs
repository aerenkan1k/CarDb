using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDb.Entities
{
    public class Car
    {
        public Car()
        {
        }

        public Car(int carId, int price, string modelName, int brandId)
        {
            CarId = carId;
            Price = price;
            ModelName = modelName;
            BrandId = brandId;
        }

        public int CarId { get; set; }
        public int Price { get; set; }
        public string ModelName { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public CarDetail CarDetail { get; set; }
        public ICollection<CarCustomer> CarCustomers { get; set; }
        public override string ToString()
        {
            return $"CarId={CarId,-5}  ModelName={ModelName,-20}  BrandId={BrandId,-5}  Price={Price}";
        }
    }
}
