﻿namespace MB.SimTaxi.Entities
{
    public class Car
    {
        public int Id { get; set; }
        public string PlateNumber { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }


        public int? DriverId { get; set; }
        public Driver Driver { get; set; }

        public List<Booking> Bookings { get; set; }
    }
}
