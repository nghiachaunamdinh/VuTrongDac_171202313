namespace sanphamDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRANDAU_CAUTHU
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(20)]
        public string TranDauID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(20)]
        public string CauThuID { get; set; }

        public int? ThoiGianBatDau { get; set; }

        public int? ThoiGianKetThuc { get; set; }

        [StringLength(1)]
        public string PhamLoi { get; set; }

        public virtual CAUTHU CAUTHU { get; set; }

        public virtual TRANDAU TRANDAU { get; set; }
    }
}
