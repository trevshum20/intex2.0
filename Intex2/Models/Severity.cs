using System;
using System.ComponentModel.DataAnnotations;

namespace Intex2.Models
{
    public class Severity
    {
        [Key]
        [Required]
        public int SeverityId { get; set; }

        public string Name { get; set; }
    }
}
