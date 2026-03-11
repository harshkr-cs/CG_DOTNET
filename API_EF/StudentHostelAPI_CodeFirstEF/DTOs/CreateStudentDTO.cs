namespace StudentHostelAPI_CodeFirstEF.DTOs
{
    public class CreateStudentDTO
    {
        public string StudentName { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public string Course { get; set; }

        public int RoomNumber { get; set; }
    }
}
