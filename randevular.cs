namespace HastahaneRandevuProje
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("randevular")]
    public partial class randevular
    {
        public int id { get; set; }

        [StringLength(50)]
        public string isim { get; set; }

        [StringLength(50)]
        public string soyisim { get; set; }

        [StringLength(50)]
        public string bolum { get; set; }

        [StringLength(50)]
        public string tarih { get; set; }

        [StringLength(50)]
        public string saat { get; set; }

        [StringLength(50)]
        public string vki { get; set; }

        [StringLength(50)]
        public string doktorisim { get; set; }

        [StringLength(50)]
        public string kilo { get; set; }

        [StringLength(50)]
        public string boy { get; set; }

        [StringLength(50)]
        public string yas { get; set; }

        [StringLength(50)]
        public string cinsiyet { get; set; }
        [StringLength(50)]
        public string value { get; set; }
    }
}
