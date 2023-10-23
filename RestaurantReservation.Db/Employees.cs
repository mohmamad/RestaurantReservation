namespace RestaurantReservation.Db
{
    public class Employees
    {
        public int EmployeesId { get; set; }
        public int RestaurantsId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public List<Orders> Orders { get; set; }
    }
}