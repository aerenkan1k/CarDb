using System;

namespace CarDb.Entities
{
    public class CarDetail
    {
        public CarDetail()
        {
        }

        public CarDetail(int carDetailId, int carId, string fuel, int year, decimal engineSize, string transmission)
        {
            CarDetailId = carDetailId;
            CarId = carId;
            Fuel = fuel;
            Year = year;
            EngineSize = engineSize;
            Transmission = transmission;
        }

        public int CarDetailId { get; set; }
        public int CarId { get; set; }
       
        public string Fuel { get; set; }
        public int Year { get; set; }
        public decimal EngineSize { get; set; }
        public string Transmission { get; set; }
        public Car Car { get; set; }

        public override string ToString()
        {
            return $"Car Detail Id={CarDetailId,-5} Car Id={CarId,-5}  Fuel={Fuel,-10}  Year={Year,-5}  Engine Size={EngineSize,-10} Transmission={Transmission,-15}";
        }
    }
}
