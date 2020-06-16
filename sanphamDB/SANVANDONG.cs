namespace sanphamDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANVANDONG")]
    public partial class SANVANDONG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANVANDONG()
        {
            CAULACBOes = new HashSet<CAULACBO>();
            TRANDAUs = new HashSet<TRANDAU>();
        }

        [StringLength(20)]
        public string SanVanDongID { get; set; }

        [StringLength(60)]
        public string TenSan { get; set; }

        [StringLength(30)]
        public string ThanhPho { get; set; }

        public int? NamBatDau { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAULACBO> CAULACBOes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TRANDAU> TRANDAUs { get; set; }
    }
}
