namespace StorageCode.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Role
    {
        [Key]
        [StringLength(50)]
        public string M_Roleid { get; set; }

        [StringLength(50)]
        public string M_RoleName { get; set; }

        [Column(TypeName = "text")]
        public string M_RoleMenu { get; set; }

        [StringLength(50)]
        public string M_companyId { get; set; }

        [Column(TypeName = "text")]
        public string M_Role { get; set; }
        [Column(TypeName = "text")]
        public string M_remark { get; set; }
    }
}
