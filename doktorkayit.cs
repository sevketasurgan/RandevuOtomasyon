namespace HastahaneRandevuProje
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("doktorkayit")]
    public partial class doktorkayit
    {
        public int id { get; set; }

        [StringLength(50)]
        public string fullname { get; set; }

        [StringLength(50)]
        public string sifre { get; set; }

        [StringLength(50)]
        public string kullaniciad { get; set; }

        [StringLength(50)]
        public string bolum { get; set; }

        //[StringLength(50)]

    }

}
