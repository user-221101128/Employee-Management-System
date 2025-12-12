using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementSystem.Data
{
	public class EmployeeManagementContext : DbContext
	{
		public EmployeeManagementContext()
		{
			Database.EnsureCreated();
		}

		public DbSet<Employee> Employees { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(
					@"Server=DESKTOP-QLQHHLM\SQLEXPRESS;
                      Database=EmployeeManagement;
                      Trusted_Connection=True;
                      TrustServerCertificate=True;");
			}
		}
	}
}
