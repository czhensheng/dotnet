using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo01
{
    public class Context : DbContext
    {
        public Context() : base("name=base") { }
        public virtual IDbSet<Donator> Donators { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //公约
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            //关联到配置方法  
            AddEntityMapping(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        /// <summary>  
        /// 制定类对类对象进行配置  
        /// </summary>  
        /// <param name="modelBuilder"></param>  
        private void AddEntityMapping(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DonatorMapping());
        }
    }

    /// <summary>
    /// 对类对象进行构造 
    /// </summary>
    public class DonatorMapping : EntityTypeConfiguration<Donator>
    {
        public DonatorMapping()
        {
            this.ToTable("Donator");
            this.HasKey(x => x.DonatorId);
            this.Property(x => x.Name).HasMaxLength(20);
        }
    }
}
