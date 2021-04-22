using System;
namespace HotelAlif.Models
{
    public class Score
    {
        public int Id { get; set; }
        public virtual Room Room { get; set; }
        public DateTime DepartureDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public DateTime PriceNumber { get; set; }







    }
}