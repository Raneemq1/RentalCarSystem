namespace RentalCarSystem.Models
{
    public class Reservation
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string CarId { get; set; }
        public DateTime RentDate { get; set; }
    }
}
