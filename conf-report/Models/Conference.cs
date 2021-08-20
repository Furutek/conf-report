namespace conf_report.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Conference
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? date { get; set; }

        [StringLength(1000)]
        public string naiyou { get; set; }

        [StringLength(10)]
        public string device { get; set; }

        [StringLength(1000)]
        public string url { get; set; }

        [StringLength(1000)]
        public string participants { get; set; }

        public byte[] note { get; set; }
    }
}
