namespace RestaurantReservation.Db
{
    public class Restaurants
    {
        public int RestaurantsId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime OpeningHour { get; set; }
        public List<Reservations> Reservations { get; set; }
        public List<Tables> Tables { get; set; }
        public List<Employees> Employees { get; set; }
        public List<MenuItem> menuItems { get; set; }
    }
}