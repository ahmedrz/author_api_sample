using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ProductAPI.DAL
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        [Required]
        public DateTime IssueDate { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

    }
}
