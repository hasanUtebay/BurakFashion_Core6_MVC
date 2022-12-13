namespace Entities.Dtos.Product
{
    public class UpdateProductDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
    }
}
