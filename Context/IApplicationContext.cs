using MediatRValidationPipeline.WebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace MediatRValidationPipeline.WebApi.Context
{
    public interface IApplicationContext
    {
        DbSet<CustomerOrder> CustomerOrders { get; set; }

        Task<int> SaveChanges();
    }
}