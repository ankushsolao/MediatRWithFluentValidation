using MediatRValidationPipeline.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MediatRValidationPipeline.WebApi.Context
{
    public class ApplicationContext : DbContext, IApplicationContext
    {
        public DbSet<CustomerOrder> CustomerOrders { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        { }
        public async Task<int> SaveChanges()
        {
            return await base.SaveChangesAsync();
        }
    }
}
