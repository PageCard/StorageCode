namespace StorageCode.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Shop
    {
        [StringLength(50)]
        public string S_ShopId { get; set; }

        [StringLength(50)]
        public string S_ShopName { get; set; }

        [StringLength(50)]
        public string S_ShopType { get; set; }

        [StringLength(50)]
        public string S_CompanyId { get; set; }

        [StringLength(50)]
        public string S_ShopUnit { get; set; }

        public decimal? S_ShopM_price { get; set; }

        public decimal? S_ShopC_price { get; set; }

        public int? S_Shop_inventory { get; set; }

        public int? S_Shop_inventory_remaining { get; set; }

        [StringLength(50)]
        public string S_Shop_State { get; set; }

        [StringLength(50)]
        public string S_Shop_Addtime { get; set; }

        [StringLength(50)]
        public string S_Shop_Updatetime { get; set; }

        [StringLength(150)]
        public string S_Shop_Tags { get; set; }

        [Column(TypeName = "text")]
        public string S_Shop_Photo { get; set; }

        [Column(TypeName = "text")]
        public string S_Shop_Context { get; set; }
    }
}
