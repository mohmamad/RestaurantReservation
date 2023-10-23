namespace RestaurantReservation.Db
{
    public class OrderItems
    {
        public int OrderItemsId { get; set; }
        public int OrdersId { get; set; }
        public int MenuItemId { get; set; }
        public int Quantity { get; set; }
    }
}