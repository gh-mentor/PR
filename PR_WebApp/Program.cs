using PR_WebApp.Services;

namespace PR_WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // Register EmployeeService
            builder.Services.AddScoped<EmployeeService>();

            // Register DepartmentService
            builder.Services.AddScoped<DepartmentService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

             name: Security Scan
            
            on:
              push:
                branches:
                  - main
              pull_request:
                branches:
                  - main
              workflow_dispatch:
            
            jobs:
              security-scan:
                runs-on: windows-latest
            
                steps:
                  - name: Checkout repository
                    uses: actions/checkout@v2
            
                  - name: Setup .NET
                    uses: actions/setup-dotnet@v2
                    with:
                      dotnet-version: '6.0.x'
            
                  - name: Install dependencies
                    run: dotnet restore
            
                  - name: Run SecurityCodeScan
                    run: dotnet build --no-restore /p:SecurityCodeScanConfigFile=SecurityCodeScan.config /p:RunAnalyzersDuringBuild=true /warnaserror /p:CodeAnalysisLogFile=security-scan.sarif
            
                  - name: Upload SARIF report
                    uses: github/codeql-action/upload-sarif@v1
                    with:
                      sarif_file: security-scan.sarif
        }
    }
}
