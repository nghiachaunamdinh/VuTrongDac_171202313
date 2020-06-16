namespace sanphamDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CAULACBO")]
    public partial class CAULACBO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAULACBO()
        {
            CAUTHUs = new HashSet<CAUTHU>();
            TRANDAUs = new HashSet<TRANDAU>();
            TRANDAUs1 = new HashSet<TRANDAU>();
            TRANDAU_GHIBAN = new HashSet<TRANDAU_GHIBAN>();
        }

        [StringLength(20)]
        public string CauLacBoID { get; set; }

        [StringLength(80)]
        public string TenCLB { get; set; }

        [StringLength(10)]
        public string TenGoi { get; set; }

        [StringLength(20)]
        public string SanVanDongID { get; set; }

        [StringLength(20)]
        public string HuanLuyenVienID { get; set; }

        public virtual HUANLUYENVIEN HUANLUYENVIEN { get; set; }

        public virtual SANVANDONG SANVANDONG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAUTHU> CAUTHUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANDAU> TRANDAUs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANDAU> TRANDAUs1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANDAU_GHIBAN> TRANDAU_GHIBAN { get; set; }
    }
}
