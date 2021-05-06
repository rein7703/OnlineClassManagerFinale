namespace Kuliah_Manager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaskTbl")]
    public partial class TaskTbl
    {
        public int DueDay { get; set; }

        [Required]
        [StringLength(2)]
        public string DueHour { get; set; }

        [Required]
        [StringLength(2)]
        public string DueMin { get; set; }

        [Key]
        [MaxLength(100)]
        public byte[] TaskName { get; set; }

        [Required]
        [StringLength(50)]
        public string ClassName { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Desc { get; set; }
    }
}
