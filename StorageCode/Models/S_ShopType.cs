namespace StorageCode.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_ShopType
    {
        [StringLength(50)]
        public string S_ShoptypeId { get; set; }

        [StringLength(50)]
        public string S_ShopTypeName { get; set; }

        [StringLength(50)]
        public string S_ShopeTypeParent { get; set; }

        [StringLength(50)]
        public string S_CompanyId { get; set; }
    }
}
