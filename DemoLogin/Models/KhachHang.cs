namespace DemoLogin.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KhachHang")]
    public partial class KhachHang
    {
        [Required]
        [StringLength(20)]
        public string NameLogin { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }

        [Key]
        [StringLength(10)]
        public string cmnd { get; set; }

        [StringLength(20)]
        public string Ho { get; set; }

        [StringLength(10)]
        public string Ten { get; set; }

        [StringLength(10)]
        public string Tuoi { get; set; }

        [StringLength(10)]
        public string SDT { get; set; }
    }
}
