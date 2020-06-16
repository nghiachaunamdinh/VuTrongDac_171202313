namespace sanphamDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRANDAU_GHIBAN
    {
        [Key]
        [StringLength(20)]
        public string GhiBanID { get; set; }

        [StringLength(20)]
        public string TranDauID { get; set; }

        [StringLength(20)]
        public string CauLacBoID { get; set; }

        public int? ThoiDiemGhiBan { get; set; }

        [StringLength(20)]
        public string CauThuID { get; set; }

        public int? VaoLuoiNha { get; set; }

        public virtual CAULACBO CAULACBO { get; set; }

        public virtual CAUTHU CAUTHU { get; set; }

        public virtual TRANDAU TRANDAU { get; set; }
    }
}
