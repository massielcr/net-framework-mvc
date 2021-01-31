using Books.Web.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Books.Web.DataContexts {
    public class IdentityDB : IdentityDbContext<ApplicationUser> {
        public IdentityDB()
            : base("DefaultConnection", throwIfV1Schema: false) {
        }

        public static IdentityDB Create() {
            return new IdentityDB();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.HasDefaultSchema("identity");
            base.OnModelCreating(modelBuilder);
        }
    }
}