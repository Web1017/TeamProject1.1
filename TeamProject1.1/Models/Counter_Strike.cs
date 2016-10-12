namespace TeamProject1._1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Counter Strike")]
    public partial class Counter_Strike
    {
        [Key]
        [Column("Counter Strike")]
        [StringLength(10)]
        public string Counter_Strike1 { get; set; }

        [Column("Week 20 ")]
        [Required]
        [StringLength(10)]
        public string Week_20_ { get; set; }

        [Column("Team 1")]
        [Required]
        [StringLength(10)]
        public string Team_1 { get; set; }

        [Column("Team 2")]
        [Required]
        [StringLength(10)]
        public string Team_2 { get; set; }
    }
}
