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
        [Display(Name = "Mã")]
        public int ma { get; set; }

        [Display(Name = "Số phòng")]
        public int? so_phong { get; set; }

        [Display(Name = "Mã khu trọ")]
        public int? ma_khu_tro { get; set; }

        [StringLength(255)]
        [Display(Name = "Người thuê")]
        public string nguoi_thue { get; set; }

        [StringLength(20)]
        [Display(Name = "CMTND")]
        public string cmtnd { get; set; }

        public virtual KhuTro KhuTro { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichSuThueNha> LichSuThueNhas { get; set; }
    }
}
