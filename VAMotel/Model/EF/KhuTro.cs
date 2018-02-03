namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhuTro")]
    public partial class KhuTro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KhuTro()
        {
            PhongTroes = new HashSet<PhongTro>();
        }

        [Key]
        public int ma { get; set; }

        public bool? da_xoa { get; set; }

        [StringLength(255)]
        public string dia_chi { get; set; }

        [StringLength(255)]
        public string chu_tro { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhongTro> PhongTroes { get; set; }
    }
}
