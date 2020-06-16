namespace sanphamDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HUANLUYENVIEN")]
    public partial class HUANLUYENVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HUANLUYENVIEN()
        {
            CAULACBOes = new HashSet<CAULACBO>();
        }

        [StringLength(20)]
        public string HuanLuyenVienID { get; set; }

        [StringLength(40)]
        public string TenHLV { get; set; }

        public int? NamSinh { get; set; }

        [StringLength(40)]
        public string QuocTich { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAULACBO> CAULACBOes { get; set; }
    }
}
