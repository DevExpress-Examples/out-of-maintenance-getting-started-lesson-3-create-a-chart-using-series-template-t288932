namespace ChartLesson3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GSP")]
    public partial class GSP
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Region { get; set; }

        public int? Year { get; set; }

        [Column("GSP")]
        public double? GSP1 { get; set; }

        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] SSMA_TimeStamp { get; set; }
    }
}
