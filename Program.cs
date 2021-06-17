using _2021_06_17_Experimentente_Partial_Views.Models;
//using _2021_06_17_Experimentente_Partial_Views.Controllers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _2021_06_17_Experimentente_Partial_Views
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        //Document document = new Document()
        //{
        //    ID = 42,
        //    Name = "Sepp"
        //};
        
        //Document document2 = new Document()
        //{
        //    ID = 43,
        //    Name = "Josef"
        //};


        // Random random = new Random();

        //List<Document> documents = new List<Document>() 
        //{
        //    new Document () {ID = 42, Name="Sepp"},
        //    new Document () {ID = 43, Name="Franz"},


        //};




    }
}
