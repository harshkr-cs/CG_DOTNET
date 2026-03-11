namespace StudentHostelAPI_CodeFirstEF.Models
{
    public class Hostel
    {
        public int HostelId { get; set; }

        public int RoomNumber { get; set; }

        public int StudentId { get; set; }

        public Student Student { get; set; }
    }
}
