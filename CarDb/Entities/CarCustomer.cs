namespace CarDb.Entities
{
    public class CarCustomer
    {
        public int CarCustomerId { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
       
    }
}
