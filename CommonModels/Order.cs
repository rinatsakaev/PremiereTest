﻿namespace CommonModels
{
    public class Order
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int SessionId { get; set; }
        public Session Session { get; set; }
    }
}
