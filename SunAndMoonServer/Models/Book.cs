using System.ComponentModel.DataAnnotations;


namespace SunAndMoonServer.Models
{
    public class Book
    {
        public long Id { get; set; }
        [Required(ErrorMessage = "Title is required")]
        [StringLength(50, ErrorMessage = "Title cannot exceed 50 characters")]
        public string Title { get; set; }
        public int? ChapterCount { get; set; }
        // if null, auto complete to 0. Can be included as a not on the creation part
        public bool? Completed { get; set; }
        // if null, assume its not completed
        [Required(ErrorMessage = "An author/alias is required")]
        [StringLength(50, ErrorMessage = "Authors name/alias cannot exceed 50 characters")]
        public string Author { get; set; }
        public string? Description { get; set; }
        // if null, can replace standard description with text along the lines of "no description provided"
    }
}
