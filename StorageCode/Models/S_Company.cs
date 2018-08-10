namespace StorageCode.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Company
    {
        [Key]
        [StringLength(50)]
        public string M_companyId { get; set; }

        [StringLength(50)]
        public string M_companyName { get; set; }

        [StringLength(50)]
        public string M_companyAdress { get; set; }

        [StringLength(50)]
        public string M_companyEmail { get; set; }

        [StringLength(50)]
        public string M_companyUser { get; set; }

        [StringLength(50)]
        public string M_companyTel { get; set; }
    }
}
