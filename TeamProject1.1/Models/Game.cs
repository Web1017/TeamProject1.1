namespace TeamProject1._1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Game")]
    public partial class Game
    {
        [Key]
        [Column("GAME")]
        [StringLength(10)]
        public string GAME { get; set; }

        [Required]
        [StringLength(10)]
        public string WEEK_NUMBER { get; set; }

        [Column("TEAM_1_ID")]
        [Required]
        [StringLength(10)]
        public string TEAM_1_ID { get; set; }

        [Column("TEAM_2_ID")]
        [Required]
        [StringLength(10)]
        public string TEAM_2_ID { get; set; }
    }
}
