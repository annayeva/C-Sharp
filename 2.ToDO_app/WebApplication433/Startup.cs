﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApplication433.Startup))]
namespace WebApplication433
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
