namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichSuThueNha")]
    public partial class LichSuThueNha
    {
        [Key]
        [Display(Name = "Mã")]
        public int ma { get; set; }

        [Display(Name = "Mã phòng")]
        public int? ma_phong { get; set; }

        [StringLength(255)]
        [Display(Name = "Người thuê")]
        public string nguoi_thue { get; set; }

        [StringLength(20)]
        [Display(Name = "CMTND")]
        public string cmtnd { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày thuê")]
        public DateTime? ngay_thue { get; set; }

        public virtual PhongTro PhongTro { get; set; }
    }
}
