namespace StorageCode.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class S_Order
    {
        [StringLength(50)]
        public string S_OrderId { get; set; }

        [StringLength(50)]
        public string S_Order_Name { get; set; }

        [StringLength(50)]
        public string S_Order_type { get; set; }

        [StringLength(50)]
        public string S_ShopId { get; set; }

        [StringLength(50)]
        public string S_Order_Number { get; set; }

        [StringLength(50)]
        public string S_Order_Price { get; set; }

        [StringLength(50)]
        public string S_Order_Remark { get; set; }

        [StringLength(50)]
        public string S_Order_Tags { get; set; }

        [StringLength(50)]
        public string S_Order_State { get; set; }

        [StringLength(50)]
        public string S_Order_approval_Price { get; set; }

        [StringLength(50)]
        public string S_CompanyId { get; set; }

        [StringLength(50)]
        public string S_Userid { get; set; }

        [StringLength(50)]
        public string S_Order_CreateTime { get; set; }

        [StringLength(50)]
        public string S_Order_Log { get; set; }

        [StringLength(50)]
        public string S_Order_Handle_Person { get; set; }
    }
}
