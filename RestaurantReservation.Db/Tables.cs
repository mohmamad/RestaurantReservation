namespace RestaurantReservation.Db
{
    public class Tables
    {
        public int TablesId { get; set; }
        public int RestaurantsID { get; set; }
        public int Capacity { get; set; }
        public List<Reservations> Reservations { get; set; }
    }
}