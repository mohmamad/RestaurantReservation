namespace RestaurantReservation.Db
{
    public class MenuItem
    {
        public int ItemId { get; set; }
        public int RestaurantsId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public List<OrderItems> OrderItems { get; set; }
    }
}