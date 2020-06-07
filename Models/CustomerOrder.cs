using System.ComponentModel.DataAnnotations.Schema;

namespace MediatRValidationPipeline.WebApi.Models
{
    public class CustomerOrder  
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public string OrderDetails { get; set; }
        public bool IsActive { get; set; } = true;
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }
    }
}
