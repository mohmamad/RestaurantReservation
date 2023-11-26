﻿namespace RestaurantReservation.Db.Models
{
    public class MenuItem
    {
        public int ItemId { get; set; }
        public int RestaurantId { get; set; }
        public int OrderItemId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Restaurant Restaurant { get; set; }  
        public List<OrderItem> OrderItems { get; set; }
    }
}