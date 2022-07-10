using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Issue
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public Priority Priority { get; set; }
        public IsuueType IsuueType { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Completed { get; set; }
    }

    
        public enum Priority
        {
            low,medium,high 
        }
    public  enum IsuueType
    {
        Feauter,Bug, Documentation
    }
}
