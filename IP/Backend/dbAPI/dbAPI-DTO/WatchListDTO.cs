using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace dbAPI_DTO
{
    public class WatchListDTO
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("AccountId")]
        public int AccountId { get; set; }

        [Required]
        public int imdbId { get; set; }

        [Required]
        [MaxLength(155)]
        public string Title { get; set; }

        public bool Watched { get; set; }
    }
}
