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
        [Display(Name = "Mã")]
        public int ma { get; set; }

        [StringLength(255)]
        [Display(Name = "Địa chỉ")]
        public string dia_chi { get; set; }

        [StringLength(255)]
        [Display(Name = "Chủ trọ")]
        public string chu_tro { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhongTro> PhongTroes { get; set; }
    }
}
