using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore;
using Microsoft.Extensions.Configuration;

namespace ConfigurationLibrary
{
    public static class CorsConfig
    {
        public static void ConfigureCors(IApplicationBuilder app, IConfiguration config)
        {

            app.UseCors(a =>
            {
                a.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();


            });

        }

    }
}
