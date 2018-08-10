namespace StorageCode.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Unit
    {
        [Key]
        [StringLength(50)]
        public string M_UnitId { get; set; }

        [StringLength(50)]
        public string M_Name { get; set; }

        [StringLength(50)]
        public string M_companyId { get; set; }
    }
}
