namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TaiKhoan()
        {
            BaiViets = new HashSet<BaiViet>();
            KhuTroes = new HashSet<KhuTro>();
        }

        [Key]
        [StringLength(255)]
        [Display(Name = "Tài khoản")]
        public string tai_khoan { get; set; }

        [StringLength(255)]
        [Display(Name = "Mật khẩu")]
        public string mat_khau { get; set; }

        [StringLength(255)]
        [Display(Name = "Tên hiển thị")]
        public string ten_hien_thi { get; set; }

        [StringLength(255)]
        [Display(Name = "Hình ảnh")]
        public string hinh_anh { get; set; }

        [Display(Name = "Loại tài khoản")]
        public int? loai_tai_khoan { get; set; }

        [StringLength(255)]
        [Display(Name = "Tên")]
        public string ten { get; set; }

        [Column(TypeName = "date")]
        [Display(Name = "Ngày sinh")]
        public DateTime? ngay_sinh { get; set; }

        [StringLength(20)]
        [Display(Name = "Số điện thoại")]
        public string so_dien_thoai { get; set; }

        [StringLength(255)]
        [Display(Name = "Email")]
        public string email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaiViet> BaiViets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhuTro> KhuTroes { get; set; }
    }
}
