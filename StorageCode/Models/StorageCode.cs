namespace StorageCode.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StorageCode : DbContext
    {
        public StorageCode()
            : base("name=StorageCode")
        {
        }

        public virtual DbSet<S_Company> S_Company { get; set; }
        public virtual DbSet<S_Menu> S_Menu { get; set; }
        public virtual DbSet<S_Order> S_Order { get; set; }
        public virtual DbSet<S_Place> S_Place { get; set; }
        public virtual DbSet<S_Role> S_Role { get; set; }
        public virtual DbSet<S_Shop> S_Shop { get; set; }
        public virtual DbSet<S_ShopType> S_ShopType { get; set; }
        public virtual DbSet<S_Unit> S_Unit { get; set; }
        public virtual DbSet<S_User> S_User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<S_Menu>()
                .Property(e => e.M_remark)
                .IsUnicode(false);

            modelBuilder.Entity<S_Place>()
                .Property(e => e.M_placeremaek)
                .IsUnicode(false);

            modelBuilder.Entity<S_Role>()
                .Property(e => e.M_RoleMenu)
                .IsUnicode(false);

            modelBuilder.Entity<S_Role>()
                .Property(e => e.M_remark)
                .IsUnicode(false);

            modelBuilder.Entity<S_Shop>()
                .Property(e => e.S_Shop_Photo)
                .IsUnicode(false);

            modelBuilder.Entity<S_Shop>()
                .Property(e => e.S_Shop_Context)
                .IsUnicode(false);

            modelBuilder.Entity<S_User>()
                .Property(e => e.M_UserRemake)
                .IsUnicode(false);
        }
    }
}
