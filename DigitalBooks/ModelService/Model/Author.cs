using System.ComponentModel.DataAnnotations;

namespace ModelService.Model
{
    public class Author
    {
        [Key]
        public long AuthorId { get; set; }
        public string? AuthorName { get; set; }
        public string? Password { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
