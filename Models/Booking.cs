using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaxiBooking.Models
{
    public class Booking
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime BookingDate { get; set; }
        public string PickupPoint { get; set; }
        public string Destination { get; set; }
        public decimal CurrentLocationLatitude { get; set; }
        public decimal CurrentLocationLongitude { get; set; }
    }
}
