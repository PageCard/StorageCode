namespace StorageCode.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_User
    {
        [Key]
        [StringLength(50)]
        public string M_UserId { get; set; }

        [StringLength(50)]
        public string M_UserParentId { get; set; }

        [StringLength(50)]
        public string M_Roleid { get; set; }

        [StringLength(50)]
        public string M_User { get; set; }

        [StringLength(50)]
        public string M_UserPass { get; set; }

        [StringLength(50)]
        public string M_UserName { get; set; }

        [StringLength(50)]
        public string M_UserTel { get; set; }

        [StringLength(50)]
        public string M_UserSex { get; set; }

        [StringLength(50)]
        public string M_UserAdress { get; set; }

        [StringLength(50)]
        public string M_UserEmail { get; set; }

        [StringLength(50)]
        public string M_UserChuanz { get; set; }

        [StringLength(50)]
        public string M_time { get; set; }

        [StringLength(50)]
        public string M_companyId { get; set; }

        [Column(TypeName = "text")]
        public string M_UserRemake { get; set; }
    }
}
