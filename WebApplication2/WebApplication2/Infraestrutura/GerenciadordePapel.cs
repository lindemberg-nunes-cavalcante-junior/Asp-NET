﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Areas.Seguranca.Models;
using WebApplication2.DAL;

namespace WebApplication2.Infraestrutura
{
    public class GerenciadorPapel : RoleManager<Papel>, IDisposable
    {
        public GerenciadorPapel(RoleStore<Papel> store) : base(store)
        {
        }
        public static GerenciadorPapel Create(IdentityFactoryOptions
        <GerenciadorPapel> options, IOwinContext context)
        {
            return new GerenciadorPapel(new RoleStore<Papel>
            (context.Get<IdentityDbContextAplicacao>()));
        }

    }
}