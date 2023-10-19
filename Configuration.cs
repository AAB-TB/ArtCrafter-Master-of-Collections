using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtCrafter.MasterofCollections
{
    public class Configuration
    {
        public static string GetConnectionString()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory()) // Or the path to your JSON file
                .AddJsonFile("appsettings.json");

            IConfiguration configuration = builder.Build();

            string connectionString = configuration.GetConnectionString("MyDatabase");

            return connectionString;
        }
    }
}
