namespace UniversityApp.Data.Models
{
    public class Room
    {
        public int RoomId { get; set; }
        public char Building { get; set; }
        public int RoomNumber { get; set; }
        public int RoomCapacity { get; set; }
        public RoomType RoomType { get; set; }
    }

    public enum RoomType
    {
        LectureHall = 0,
        Classroom = 1,
        Office = 2,
        Others = 3
    }
}