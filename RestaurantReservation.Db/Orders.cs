namespace RestaurantReservation.Db
{
    public class Orders
    {
        public int OrdersId { get; set; }
        public int ReservationsId { get; set; }
        public int EmployeesId { get; set; }
        public DateTime OrderDate { get; set; }
        public float TotalAmount { get; set; }
        public List<OrderItems> OrderItems { get; set; }
    }
}