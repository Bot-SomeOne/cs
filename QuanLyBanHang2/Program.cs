using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using QuanLyBanHang.Data;
using QuanLyBanHang.Models;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                Application.Run(serviceProvider.GetRequiredService<DangNhap>());
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<QuanlybanhangContext>(options =>
                options.UseSqlServer("Data Source='192.168.50.31, 1435';Initial Catalog=QUANLYBANHANG;Persist Security Info=True;User ID=sa;Password=P@ss12345;Trust Server Certificate=True"));

            // Register your forms
            services.AddTransient<DangNhap>();
            services.AddTransient<HoaDon>();
        }
    }
}