﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Testing_1.Startup))]
namespace Testing_1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
