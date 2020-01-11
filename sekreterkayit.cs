namespace HastahaneRandevuProje
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("sekreterkayit")]
    public partial class sekreterkayit
    {
        public int id { get; set; }

        [StringLength(50)]
        public string ad { get; set; }

        [StringLength(50)]
        public string soyad { get; set; }

        [StringLength(50)]
        public string kullaniciad { get; set; }

        [StringLength(50)]
        public string sifre { get; set; }

        //[StringLength(50)]

    }

}
