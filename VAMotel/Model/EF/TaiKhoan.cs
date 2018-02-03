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
            LichSuThueNhas = new HashSet<LichSuThueNha>();
            PhongTroes = new HashSet<PhongTro>();
        }

        [Key]
        [StringLength(255)]
        public string tai_khoan { get; set; }

        [StringLength(255)]
        public string mat_khau { get; set; }

        [StringLength(255)]
        public string ten_hien_thi { get; set; }

        [StringLength(255)]
        public string hinh_anh { get; set; }

        public int? loai_tai_khoan { get; set; }

        [StringLength(255)]
        public string ten { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay_sinh { get; set; }

        [StringLength(20)]
        public string so_dien_thoai { get; set; }

        [StringLength(255)]
        public string email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaiViet> BaiViets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KhuTro> KhuTroes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichSuThueNha> LichSuThueNhas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PhongTro> PhongTroes { get; set; }
    }
}
