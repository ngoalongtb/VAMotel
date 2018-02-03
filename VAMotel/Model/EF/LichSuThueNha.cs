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
        public int ma { get; set; }

        public int? ma_phong { get; set; }

        [StringLength(255)]
        public string nguoi_thue { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay_thue { get; set; }

        public virtual PhongTro PhongTro { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
