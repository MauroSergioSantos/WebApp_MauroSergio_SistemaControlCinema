﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApp_MauroSergio_SistemaControlCinema.Startup))]
namespace WebApp_MauroSergio_SistemaControlCinema
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
