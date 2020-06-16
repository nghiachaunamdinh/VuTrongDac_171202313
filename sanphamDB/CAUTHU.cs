namespace sanphamDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CAUTHU")]
    public partial class CAUTHU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAUTHU()
        {
            TRANDAU_CAUTHU = new HashSet<TRANDAU_CAUTHU>();
            TRANDAU_GHIBAN = new HashSet<TRANDAU_GHIBAN>();
        }

        [StringLength(20)]
        public string CauThuID { get; set; }

        [StringLength(40)]
        public string HoVaTen { get; set; }

        [StringLength(20)]
        public string CauLacBoID { get; set; }

        public DateTime? NGAYSINH { get; set; }

        [StringLength(40)]
        public string ViTri { get; set; }

        [StringLength(40)]
        public string QuocTich { get; set; }

        [StringLength(10)]
        public string SoAo { get; set; }

        public virtual CAULACBO CAULACBO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANDAU_CAUTHU> TRANDAU_CAUTHU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANDAU_GHIBAN> TRANDAU_GHIBAN { get; set; }
    }
}
