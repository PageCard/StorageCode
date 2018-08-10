namespace StorageCode.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Place
    {
        [Key]
        [StringLength(50)]
        public string M_placeId { get; set; }

        [StringLength(250)]
        public string M_placeAdress { get; set; }

        [StringLength(50)]
        public string M_placeName { get; set; }

        [StringLength(50)]
        public string M_placeAdminUser { get; set; }

        [StringLength(50)]
        public string M_placeAdminTel { get; set; }

        [StringLength(50)]
        public string M_placeAddtime { get; set; }

        [Column(TypeName = "text")]
        public string M_placeremaek { get; set; }

        [StringLength(50)]
        public string M_CompanyId { get; set; }
    }
}
