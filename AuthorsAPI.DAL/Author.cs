using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProductAPI.DAL
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        [Required]
        public DateTime BOD { get; set; }
        [Required]
        [MaxLength(25)]
        public string Country { get; set; }
        public ICollection<Book> Books { get; set; }


    }
}
