namespace RestaurantReservation.Db
{
    public class Reservations
    {
        public int ReservationId { get; set; }
        public int CustomersId { get; set; }
        public int RestaurantsId { get; set; }
        public int TablesId { get; set; }
        public DateTime ReservationDate { get; set; }
        public int PartySize { get; set; }
        public List<Orders> Orders { get; set; }
    }
}