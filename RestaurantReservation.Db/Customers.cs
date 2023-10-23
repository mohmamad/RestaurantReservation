namespace RestaurantReservation.Db
{
    public class Customers
    {
        public int CustomersId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<Reservations> Reservations { get; set; }
    }
}
