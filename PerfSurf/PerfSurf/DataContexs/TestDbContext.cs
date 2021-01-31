using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PerfSurf.DataContexs {
    public class TestDbContext : DbContext {

        public TestDbContext() : base("DefaultConnection") {

        }

        public System.Data.Entity.DbSet<PerfSurf.Models.TestModel> TestModels { get; set; }
    }
}