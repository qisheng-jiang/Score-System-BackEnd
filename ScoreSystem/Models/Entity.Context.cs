﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ScoreSystem.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sorce_systemEntities : DbContext
    {
        public sorce_systemEntities()
            : base("name=sorce_systemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<are_population_record> are_population_record { get; set; }
        public virtual DbSet<area_admin> area_admin { get; set; }
        public virtual DbSet<criminal> criminals { get; set; }
        public virtual DbSet<exam_record> exam_record { get; set; }
        public virtual DbSet<group_admin> group_admin { get; set; }
        public virtual DbSet<prison_score> prison_score { get; set; }
        public virtual DbSet<root_admin> root_admin { get; set; }
        public virtual DbSet<rule> rules { get; set; }
        public virtual DbSet<work> works { get; set; }
    }
}
