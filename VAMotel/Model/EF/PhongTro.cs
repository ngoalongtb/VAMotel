namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhongTro")]
    public partial class PhongTro
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PhongTro()
        {
            LichSuThueNhas = new HashSet<LichSuThueNha>();
        }

        [Key]
        public int ma { get; set; }

        public bool? da_xoa { get; set; }

        public int? so_phong { get; set; }

        public int? ma_khu_tro { get; set; }

        [StringLength(255)]
        public string nguoi_thue { get; set; }

        public virtual KhuTro KhuTro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichSuThueNha> LichSuThueNhas { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
