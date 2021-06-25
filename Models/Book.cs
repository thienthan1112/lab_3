namespace lab_3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Book")]
    public partial class Book
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Column("Tiêu đề")]
        [Required(ErrorMessage = "Tiêu đề không được để trống")]
        [StringLength(100, ErrorMessage = "Tiêu đề không được vượt quá 100 ký tự")]
        [Display(Name = "Tiêu đề")]
        public string Title { get; set; }

        [Column("Nội dung")]
        [Required]
        [StringLength(255)]
        [Display(Name = "Nội dung")]
        public string Description { get; set; }


        [Column("Tác giả")]
        [Required(ErrorMessage = "Tên tác giả không được để trống")]
        [StringLength(30, ErrorMessage = "Tên tác giả không được vượt quá 30 ký tự")]
        [Display(Name = "Tác giả")]
        public string Author { get; set; }

        [Column("Ảnh")]
        [Required]
        [StringLength(255)]
        [Display(Name = "Ảnh")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Giá không được để trống")]
        [Range(1000,1000000,ErrorMessage ="Giá chỉ từ 1000 đến 1.000.000")]
        [Column("Giá")]
        [Display(Name = "Giá")]
        public int? Price { get; set; }
    }
}
