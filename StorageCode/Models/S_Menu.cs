namespace StorageCode.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Menu
    {
        [Key]
        [StringLength(50)]
        public string M_id { get; set; }

        [StringLength(50)]
        public string M_Name { get; set; }

        [StringLength(50)]
        public string M_ParentId { get; set; }

        [StringLength(100)]
        public string M_url { get; set; }

        [StringLength(50)]
        public string M_icon { get; set; }

        [StringLength(50)]
        public string M_open { get; set; }

        [StringLength(50)]
        public string M_time { get; set; }

        [StringLength(50)]
        public string M_addpersen { get; set; }

        [Column(TypeName = "text")]
        public string M_remark { get; set; }
    }
}
