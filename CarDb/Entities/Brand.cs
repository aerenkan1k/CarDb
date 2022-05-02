using System.Collections.Generic;

namespace CarDb.Entities
{
    public class Brand
    {
        public Brand()
        {
        }

        public Brand(int brandId, string brandName, string country)
        {
            BrandId = brandId;
            BrandName = brandName;
            Country = country;
        }

        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string Country { get; set; }
        public override string ToString()
        {
            return $"Brand Id={BrandId,-5}  Brand Name={BrandName,-20}  Country={Country,-20}";
        }

        public ICollection<Car> Cars { get; set; }
    }
}
