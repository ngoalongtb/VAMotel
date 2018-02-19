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
        [Display(Name = "Tiêu đề")]
        public string tieu_de { get; set; }

        [StringLength(255)]
        [Display(Name = "Hình ảnh")]
        public string hinh_anh { get; set; }

        [Display(Name = "Nội dung")]
        public string noi_dung { get; set; }

        [Display(Name = "Ngày tạo")]
        public DateTime? ngay_tao { get; set; }

        [StringLength(255)]
        [Display(Name = "Người tạo")]
        public string nguoi_tao { get; set; }

        [StringLength(255)]
        [Display(Name = "Địa chỉ")]
        public string dia_chi { get; set; }

        [StringLength(255)]
        [Display(Name = "Diện tích")]
        public string dien_tich { get; set; }

        [Display(Name = "Giá cả")]
        public int? gia_ca { get; set; }

        [Display(Name = "Độ ưu tiên")]
        public int? do_uu_tien { get; set; }

        [Display(Name = "Mã danh mục")]
        public int? ma_danh_muc { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
