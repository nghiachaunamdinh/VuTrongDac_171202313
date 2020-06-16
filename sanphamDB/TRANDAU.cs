namespace sanphamDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TRANDAU")]
    public partial class TRANDAU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TRANDAU()
        {
            TRANDAU_CAUTHU = new HashSet<TRANDAU_CAUTHU>();
            TRANDAU_GHIBAN = new HashSet<TRANDAU_GHIBAN>();
        }

        [StringLength(20)]
        public string TranDauID { get; set; }

        public DateTime? NgayThiDau { get; set; }

        [StringLength(20)]
        public string CLBKhach { get; set; }

        [StringLength(20)]
        public string CLBNha { get; set; }

        [StringLength(20)]
        public string SanVanDongID { get; set; }

        public int? Vong { get; set; }

        public DateTime? HiepPhu { get; set; }

        [StringLength(30)]
        public string KetQua { get; set; }

        public bool? TrangThai { get; set; }

        public virtual CAULACBO CAULACBO { get; set; }

        public virtual CAULACBO CAULACBO1 { get; set; }

        public virtual SANVANDONG SANVANDONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANDAU_CAUTHU> TRANDAU_CAUTHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANDAU_GHIBAN> TRANDAU_GHIBAN { get; set; }
    }
}
