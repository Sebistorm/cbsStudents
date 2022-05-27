using System.ComponentModel.DataAnnotations;

namespace cbsStudents.Models.Entities

{
    public class Event
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please fill out title")]
        [MinLength(3, ErrorMessage = "Minimum 3 characters")]
        public string Title { get; set; }

        [Required]
        public DateOnly StartDate { get; set; }

        [Required]
        public DateOnly EndDate { get; set; }

        [Required]
        public TimeOnly StartTime { get; set; }

        [Required]
        public TimeOnly EndTime { get; set; }

        [Required]
        [MinLength(10)]
        public string Description { get; set; }


    }
}

