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
        [Required]
        [StringLength(10)]
        public string DueDay { get; set; }

        [Required]
        [StringLength(2)]
        public string DueHour { get; set; }

        [Required]
        [StringLength(2)]
        public string DueMin { get; set; }

        [Key]
        [StringLength(150)]
        public string TaskName { get; set; }

        [Required]
        [StringLength(50)]
        public string ClassName { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Desc { get; set; }
    }
}
