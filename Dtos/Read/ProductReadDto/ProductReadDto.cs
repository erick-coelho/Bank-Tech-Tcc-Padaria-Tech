using PadariaTech.Enum;
using System.ComponentModel.DataAnnotations;

namespace PadariaTech.Dtos.Read
{
    public class ProductReadDto
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public decimal Price { get; set; }     

        public int StockQuantity { get; set; }
     
        public ProductTypes ProductType { get; set; }
    }

}