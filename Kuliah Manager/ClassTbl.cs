namespace Kuliah_Manager
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ClassTbl")]
    public partial class ClassTbl
    {
        [Key]
        [StringLength(30)]
        public string ClassName { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string MeetingLink { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string AttendanceLink { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string DriveLink { get; set; }

        [Required]
        [StringLength(7)]
        public string Day { get; set; }

        [Required]
        [StringLength(3)]
        public string Hour { get; set; }

        [Required]
        [StringLength(3)]
        public string Min { get; set; }
    }
}
