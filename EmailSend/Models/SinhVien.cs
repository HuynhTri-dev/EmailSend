namespace EmailSend.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [Key]
        [StringLength(11)]
        public string MSSV { get; set; }

        [Required]
        [StringLength(255)]
        public string HoTen { get; set; }

        public double? Diem { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Khoa { get; set; }
    }
}
