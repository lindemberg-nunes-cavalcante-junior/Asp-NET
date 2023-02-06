using Microsoft.AspNet.Identity.EntityFramework;
using WebApplication2.Areas.Seguranca.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.DAL
{
    public class IdentityDbContextAplicacao : IdentityDbContext<Usuario>
    {
        public IdentityDbContextAplicacao() : base("IdentityDb")
        { }
        static IdentityDbContextAplicacao()
        {
            Database.SetInitializer<IdentityDbContextAplicacao>(new IdentityDbInit());
        }
        public static IdentityDbContextAplicacao Create()
        {
            return new IdentityDbContextAplicacao();
        }
        public class IdentityDbInit :DropCreateDatabaseIfModelChanges<IdentityDbContextAplicacao>
        {

        }
        public static void Delete(IdentityRole a)
        {
            IdentityDbContextAplicacao.Delete(a);
        }
        public System.Data.Entity.DbSet<WebApplication2.Areas.Seguranca.Models.UsuarioViewModel> UsuarioViewModels { get; set; }

        public System.Data.Entity.DbSet<WebApplication2.Areas.Seguranca.Models.Papel> IdentityRoles { get; set; }
    }
}

