namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BaiViet")]
    public partial class BaiViet
    {
        [Key]
        public int ma { get; set; }

        [Required]
        [StringLength(255)]
        public string tieu_de { get; set; }

        [StringLength(255)]
        public string hinh_anh { get; set; }

        public string noi_dung { get; set; }

        public DateTime? ngay_tao { get; set; }

        [StringLength(255)]
        public string nguoi_tao { get; set; }

        [StringLength(255)]
        public string dia_chi { get; set; }

        [StringLength(255)]
        public string dien_tich { get; set; }

        public int? gia_ca { get; set; }

        public int? do_uu_tien { get; set; }

        public int? ma_danh_muc { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
