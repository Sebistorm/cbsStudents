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
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime StartDate { get; set; }

        [Required]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime EndDate { get; set; }

        [Required]
        public string StartTime { get; set; }

        [Required]
        public string EndTime { get; set; }

        [Required]
        [MinLength(10)]
        public string Description { get; set; }


    }
}

