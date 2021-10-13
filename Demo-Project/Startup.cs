using DemoProject.Web.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Reflection;
using Demo_Project.Services.Interfaces;
using Demo_Project.Services;


namespace Demo_Project
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGrpc();
            //need reflection to discover from the grpcui
            services.AddGrpcReflection();
            
            //var serviceProvider = services.BuildServiceProvider();

            //services.AddGrpc(options =>
            //{
            //    options.EnableMessageValidation();
            //    options.Interceptors.Add<LoggerInterceptor>();
            //});

            //services.AddCors(o =>
            //{
            //    o.AddPolicy("MyPolicy", builder =>
            //    {
            //        builder.AllowAnyOrigin();
            //        builder.AllowAnyMethod();
            //        builder.AllowAnyHeader();
            //        builder.WithExposedHeaders("Grpc-Status", "Grpc-Message");
            //    });
            //});

            //services.AddValidator<CountryCreateRequestValidator>();

            //services.AddGrpcValidation();

            services.AddAutoMapper(Assembly.Load("DemoProject.Web"));

            services.AddScoped<IProjectService, ProjectService>();
            //services.AddScoped<IProjectTaskService, ProjectTaskService>();
            services.AddScoped<ILocationService, LocationService>();
            services.AddScoped<ITripService, TripService>();
            services.AddScoped<ICustomerService, CustomerService>();
            services.AddScoped<IDestinationService, DestinationService>();
            services.AddScoped<IFundService, FundService>();
            services.AddScoped<IGradeService, GradeService>();
            //services.AddScoped<IProjectService, ProjectService>();
            //services.AddScoped<ICountryRepository, EFCountryRepository>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.MapGrpcService<GreeterService>();
                endpoints.MapGrpcService<ProjectGrpService>();
                endpoints.MapGrpcService<LocationGrpService>();
                endpoints.MapGrpcService<TripGrpService>();
                endpoints.MapGrpcService<CustomerGrpcService>();
                endpoints.MapGrpcService<DestinationGrpcService>();
                endpoints.MapGrpcService<FundGrpcService>();
                endpoints.MapGrpcService<GradeGrpcService>();

                //if (env.IsDevelopment())
                //{
                endpoints.MapGrpcReflectionService();
                //}
                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");
                });
            });
        }
    }
}
